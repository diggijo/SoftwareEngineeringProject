using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DogKennelSys
{
    public partial class frmCancelBooking : Form
    {
        private int bookingID;
        frmMainMenu parent;
        public frmCancelBooking(frmMainMenu Parent)
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
            grpResults.Visible = true;
            grdBookings.DataSource = Bookings.findBookings(txtName.Text.ToUpper()).Tables["Bookings"];
        }

        private void grdBookings_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                String firstName = grdBookings.Rows[e.RowIndex].Cells[0].Value.ToString();

                if(firstName == "")
                {
                    btnCancelBooking.Visible = false;
                    MessageBox.Show("Please select a booking", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    btnCancelBooking.Visible = true;
                    bookingID = Convert.ToInt32(grdBookings.Rows[e.RowIndex].Cells[5].Value.ToString());
                }
            }
            catch
            {
                //so program doesnt crash on a misclick;
            }
        }

        private void btnCancelBooking_Click(object sender, EventArgs e)
        {
            Bookings.cancelBooking(bookingID);
            grpResults.Visible = false;
            btnCancelBooking.Visible = false;
            txtName.Clear();
            MessageBox.Show("Booking Cancelled!", "Booking Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmCancelBooking_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Visible = true;
        }
    }
}
