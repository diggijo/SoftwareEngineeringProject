using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DogKennelSys
{
    public partial class frmAddBookingService : Form
    {
        private int bookingID;
        private String serviceCode;
        private float cost;
        frmMainMenu parent;
        DialogResult dialogResult;
        public frmAddBookingService(frmMainMenu Parent)
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            grpBookings.Visible = true;
            grdBookings.DataSource = Bookings.findBookings(txtName.Text.ToUpper()).Tables["Bookings"];
        }

        private void grdBookings_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                String firstName = grdBookings.Rows[e.RowIndex].Cells[0].Value.ToString();

                if (firstName == "")
                {
                    grpServices.Visible = false;
                    MessageBox.Show("Please select a booking", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    grpServices.Visible = true;
                    grdServices.DataSource = Service.findServices().Tables["Services"];
                    bookingID = Convert.ToInt32(grdBookings.Rows[e.RowIndex].Cells[5].Value.ToString());
                }
            }
            catch
            {
                //so program doesnt crash on a misclick;
            }
        }

        private void grdServices_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                serviceCode = grdServices.Rows[e.RowIndex].Cells[0].Value.ToString();

                if(serviceCode == "")
                {
                    grpAddBookingService.Visible = false;
                    MessageBox.Show("Please select a booking service", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    grpAddBookingService.Visible = true;
                    txtServiceCode.Text = serviceCode;
                    cost = (float)grdServices.Rows[e.RowIndex].Cells[2].Value;
                }
            }
            catch
            {
                //so program doesnt crash on a misclick
            }
        }

        private void btnAddBService_Click(object sender, EventArgs e)
        {
            BookingService aBookingService = new BookingService(bookingID, serviceCode, cost);

            aBookingService.addBookingService();

            if(aBookingService.validBookingService)
            {
                dialogResult = MessageBox.Show("Booking Service added successfully to Booking! \nWould you like to add another booking service?", "Success",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            

            if(dialogResult == DialogResult.Yes)
            {
                grpAddBookingService.Visible = false;
            }
            else
            {
                grpAddBookingService.Visible = false;
                grpBookings.Visible = false;
                grpServices.Visible = false;
                txtName.Clear();
            }

        }

        private void frmAddBookingService_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Visible = true;
        }
    }
}
