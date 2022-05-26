using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogKennelSys
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {

        }

        private void mnuOpenAccount_Click(object sender, EventArgs e)
        {
            frmOpenAccount nextForm = new frmOpenAccount(this);
            this.Hide();
            nextForm.Show();
        }

        private void mnuAddService_Click(object sender, EventArgs e)
        {
            frmAddService nextForm = new frmAddService(this);
            this.Hide();
            nextForm.Show();
        }

        private void mnuUpdateAccount_Click(object sender, EventArgs e)
        {
            frmUpdateAccount nextForm = new frmUpdateAccount(this);
            this.Hide();
            nextForm.Show();
        }

        private void mnuWithdrawService_Click(object sender, EventArgs e)
        {
            frmWithdrawService nextForm = new frmWithdrawService(this);
            this.Hide();
            nextForm.Show();
        }

        private void mnuRegisterDog_Click(object sender, EventArgs e)
        {
            frmRegisterDog nextForm = new frmRegisterDog(this);
            this.Hide();
            nextForm.Show();
        }

        private void mnuYearlyRevenue_Click(object sender, EventArgs e)
        {
            frmRevenueAnalysis nextForm = new frmRevenueAnalysis(this);
            this.Hide();
            nextForm.Show();
        }

        private void serviceAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmServicesAnalysis nextForm = new frmServicesAnalysis(this);
            this.Hide();
            nextForm.Show();
        }

        private void mnuMakeBooking_Click(object sender, EventArgs e)
        {
            frmMakeBooking nextForm = new frmMakeBooking(this);
            this.Hide();
            nextForm.Show();
        }

        private void mnuCancelBooking_Click(object sender, EventArgs e)
        {
            frmCancelBooking nextForm = new frmCancelBooking(this);
            this.Hide();
            nextForm.Show();
        }

        private void mnuAddBkService_Click(object sender, EventArgs e)
        {
            frmAddBookingService nextForm = new frmAddBookingService(this);
            this.Hide();
            nextForm.Show();
        }

        private void mnuCheckIn_Out_Click(object sender, EventArgs e)
        {
            frmCheckIn_Out nextForm = new frmCheckIn_Out(this);
            this.Hide();
            nextForm.Show();
        }
    }
}
