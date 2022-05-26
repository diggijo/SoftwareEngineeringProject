using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DogKennelSys
{
    public partial class frmMakeBooking : Form
    {
        int petID;
        int kennelNo;
        float totalCost;
        String dogSize;
        frmMainMenu parent;

        public frmMakeBooking(frmMainMenu Parent)
        {
            InitializeComponent();
            dtpCheckIn.MinDate = DateTime.Today;
            dtpCheckIn.MaxDate = DateTime.Today.AddYears(1);
            dtpCheckOut.MinDate = DateTime.Today.AddDays(1);
            dtpCheckOut.MaxDate = dtpCheckOut.MinDate.AddYears(1).AddMonths(1);
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
            grdAccounts.Visible = true;
            grdAccounts.DataSource = Account.findAccounts(txtName.Text.ToUpper()).Tables["Accounts"];
        }

        private void grdAccounts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                String firstName = grdAccounts.Rows[e.RowIndex].Cells[1].Value.ToString();

                if(firstName == "")
                {
                    MessageBox.Show("Please select a customer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    grpSelectDog.Visible = false;
                }
                else
                {
                    grpSelectDog.Visible = true;
                    grdPets.Visible = true;
                    int custID = Convert.ToInt32(grdAccounts.Rows[e.RowIndex].Cells[0].Value.ToString());
                    grdPets.DataSource = Pet.findPets(custID).Tables["Pets"];
                }

            }
            catch
            {
                //so the program doesnt crash on a misclick;
            }
        }

        private void grdPets_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                String petName = grdPets.Rows[e.RowIndex].Cells[1].Value.ToString();

                if (petName == "")
                {
                    grpBooking.Visible = false;
                    MessageBox.Show("Please select a dog", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    grpBooking.Visible = true;
                    petID = Convert.ToInt32(grdPets.Rows[e.RowIndex].Cells[0].Value.ToString());
                    dogSize = grdPets.Rows[e.RowIndex].Cells[4].Value.ToString();
                }
            }
            catch
            {
                //so the program doesnt crash on a misclick;
            }
        }

        private void btnSelectDates_Click(object sender, EventArgs e)
        {
            grpKennels.Visible = true;
        
            if(Bookings.findAvailableKennels(dogSize, String.Format("{0:dd-MMM-yy}", dtpCheckIn.Value), String.Format("{0:dd-MMM-yy}", dtpCheckOut.Value)).Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("There are no kennels available for this date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                grdKennels.DataSource = Bookings.findAvailableKennels(dogSize, String.Format("{0:dd-MMM-yy}", dtpCheckIn.Value), String.Format("{0:dd-MMM-yy}", dtpCheckOut.Value)).Tables["Kennels"];
            }
        }

        private void grdKennels_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                String kennelSize = grdKennels.Rows[e.RowIndex].Cells[1].Value.ToString();

                if(kennelSize == "")
                {
                    MessageBox.Show("Please select a dog", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnMakeBooking.Visible = false;
                }
                else
                {
                    btnMakeBooking.Visible = true;
                    kennelNo = Convert.ToInt32(grdKennels.Rows[e.RowIndex].Cells[0].Value);
                    float rate = (float)grdKennels.Rows[e.RowIndex].Cells[2].Value;
                    TimeSpan numberOfNights = dtpCheckOut.Value - dtpCheckIn.Value;
                    int TotalDays = numberOfNights.Days + 1;
                    totalCost = rate * TotalDays;
                }
            }
            catch
            {
                //so the program doesnt crash on a misclick;
            }
        }

        private void btnMakeBooking_Click(object sender, EventArgs e)
        {
            Bookings aBooking = new Bookings(Bookings.getNextBookingID(), kennelNo, dtpCheckIn.Value, dtpCheckOut.Value, totalCost, petID, 'B');

            aBooking.addBooking();

            MessageBox.Show("Booking added successfully!" + "\nCost: " + totalCost, "Booking Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);

            grpBooking.Visible = false;
            grdAccounts.Visible = false;
            grpSelectDog.Visible = false;
            grpKennels.Visible = false;
            txtName.Clear();
            dtpCheckIn.Value = dtpCheckIn.MinDate;
            dtpCheckOut.Value = dtpCheckOut.MinDate;
            grdKennels.DataSource = null;
        }

        private void dtpCheckIn_ValueChanged(object sender, EventArgs e)
        {
            grpKennels.Visible = false;
        }

        private void dtpCheckOut_ValueChanged(object sender, EventArgs e)
        {
            grpKennels.Visible = false;
        }

        private void frmMakeBooking_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Visible = true;
        }
    }
}
