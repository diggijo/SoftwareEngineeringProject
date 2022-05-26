using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DogKennelSys
{
    public partial class frmWithdrawService : Form
    {
        frmMainMenu parent;

        public frmWithdrawService(frmMainMenu Parent)
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

        private void btnRemoveService_Click(object sender, EventArgs e)
        {

            Service.withdrawService(txtServiceCode.Text);

            MessageBox.Show("Service removed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtServiceCode.Clear();
            txtServiceCode.Focus();
            grdServices.Visible = false;
            grpWithdrawService.Visible = false;
        }

        private void btnGetServices_Click(object sender, EventArgs e)
        {
            grdServices.Visible = true;
            grdServices.DataSource = Service.findServices().Tables["Services"];
        }

        private void grdServices_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                String serviceCode = grdServices.Rows[e.RowIndex].Cells[0].Value.ToString();

                if(serviceCode == "")
                {
                    MessageBox.Show("Please select a service", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    grpWithdrawService.Visible = false;
                }
                else
                {
                    grpWithdrawService.Visible = true;
                    txtServiceCode.Text = serviceCode;
                }
            }
            catch
            {
                //so program doesnt crash by a misclick;
            }

        }

        private void frmWithdrawService_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Visible = true;
        }
    }
}
