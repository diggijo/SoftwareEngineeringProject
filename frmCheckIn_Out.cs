using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DogKennelSys
{
    public partial class frmCheckIn_Out : Form
    {
        private int selectedBooking;
        private int kennelNo;
        private DateTime saleDate;
        frmMainMenu parent;
        public frmCheckIn_Out(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void mnuHome_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmCheckIn_Out_Load(object sender, EventArgs e)
        {
            grdArv_Depts.DataSource = Bookings.findCheckIns().Tables["Bookings"];
        }

        private void radOut_CheckedChanged(object sender, EventArgs e)
        {
            grdArv_Depts.DataSource = Bookings.findCheckOuts().Tables["Bookings"];
        }

        private void radIn_CheckedChanged(object sender, EventArgs e)
        {
            grdArv_Depts.DataSource = Bookings.findCheckIns().Tables["Bookings"];
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(radOut.Checked)
            {
                double bookingCost = Bookings.GetBookingCost(selectedBooking);
                double services = BookingService.GetServiceCosts(selectedBooking);
                double totalCost = bookingCost + services;

                totalCost = Bookings.GetBookingCost(selectedBooking) + BookingService.GetServiceCosts(selectedBooking);
                Bookings.checkOut(selectedBooking, kennelNo);
                MessageBox.Show("Check-Out Successful! \nBooking Cost: " + bookingCost + "\nServices: " + services +
                    "\nTotal Cost: " + totalCost, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                grdArv_Depts.DataSource = Bookings.findCheckOuts().Tables["Bookings"];

                Sales aSale = new Sales(Sales.getNextSaleID(), saleDate, totalCost, services);
                aSale.addSale();
                
            }

            else
            {
                Bookings.checkIn(selectedBooking, kennelNo);
                MessageBox.Show("Check-In Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                grdArv_Depts.DataSource = Bookings.findCheckIns().Tables["Bookings"];
            }
        }

        private void grdArv_Depts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                String status = grdArv_Depts.Rows[e.RowIndex].Cells[6].Value.ToString();

                if(status == "")
                {
                    MessageBox.Show("Please select a booking", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnConfirm.Visible = false;
                }
                else
                {
                    selectedBooking = Convert.ToInt32(grdArv_Depts.Rows[e.RowIndex].Cells[0].Value);
                    kennelNo = Convert.ToInt32(grdArv_Depts.Rows[e.RowIndex].Cells[1].Value);
                    saleDate = (DateTime)(grdArv_Depts.Rows[e.RowIndex].Cells[3].Value);
                    btnConfirm.Visible = true;
                }
            }
            catch
            {
                //so program doesnt crash on a misclick;
            }
        }

        private void frmCheckIn_Out_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Visible = true;
        }
    }
}
