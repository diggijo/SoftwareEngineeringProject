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
    public partial class frmUpdateAccount : Form
    {
        frmMainMenu parent;
        public frmUpdateAccount(frmMainMenu Parent)
        {
            InitializeComponent();
            dtpDOB.MaxDate = DateTime.Today.AddYears(-16);
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
                    grpCustDetails.Visible = false;
                }
                else
                {
                    txtFirstName.Text = firstName;
                    txtLastName.Text = grdAccounts.Rows[e.RowIndex].Cells[2].Value.ToString();
                    dtpDOB.Value = DateTime.Parse(grdAccounts.Rows[e.RowIndex].Cells[3].Value.ToString());
                    txtStreet.Text = grdAccounts.Rows[e.RowIndex].Cells[4].Value.ToString();
                    txtTown.Text = grdAccounts.Rows[e.RowIndex].Cells[5].Value.ToString();
                    txtCounty.Text = grdAccounts.Rows[e.RowIndex].Cells[6].Value.ToString();
                    txtEircode.Text = grdAccounts.Rows[e.RowIndex].Cells[7].Value.ToString();
                    txtPhone.Text = grdAccounts.Rows[e.RowIndex].Cells[8].Value.ToString();
                    txtEmail.Text = grdAccounts.Rows[e.RowIndex].Cells[9].Value.ToString();
                    txtCustID.Text = grdAccounts.Rows[e.RowIndex].Cells[0].Value.ToString();
                    grpCustDetails.Visible = true;
                    txtFirstName.Focus();
                }
            }
            catch
            {
                //so program doesnt crash by a misclick;
            }

        }

        private void btnUpdateAcc_Click(object sender, EventArgs e)
        {
            // FIRST NAME VALIDATION
            if (Validation.isEmpty(txtFirstName.Text))
            {
                Validation.emptyMsg(lblFirstName.Text, txtFirstName);
                return;
            }
            else
            {
                if (!Validation.validName(txtFirstName.Text))
                {
                    Validation.invalidMsg(lblFirstName.Text, txtFirstName);
                    return;
                }
            }

            // SECOND NAME VALIDATION
            if (Validation.isEmpty(txtLastName.Text))
            {
                Validation.emptyMsg(label.Text, txtLastName);
                return;
            }
            else
            {
                if (!Validation.validName(txtLastName.Text))
                {
                    Validation.invalidMsg(label.Text, txtLastName);
                    return;
                }
            }

            // STREET VALIDATION
            if (Validation.isEmpty(txtStreet.Text))
            {
                Validation.emptyMsg(lblStreet.Text, txtStreet);
                return;
            }
            else
            {
                if (!Validation.validAddress(txtStreet.Text))
                {
                    Validation.invalidMsg(lblStreet.Text, txtStreet);
                    return;
                }
            }

            // TOWN VALIDATION
            if (Validation.isEmpty(txtTown.Text))
            {
                Validation.emptyMsg(lblTown.Text, txtTown);
                return;
            }
            else
            {
                if (!Validation.validAddress(txtTown.Text))
                {
                    Validation.invalidMsg(lblTown.Text, txtTown);
                    return;
                }
            }

            // COUNTY VALIDATION
            if (Validation.isEmpty(txtCounty.Text))
            {
                Validation.emptyMsg(lblCounty.Text, txtCounty);
                return;
            }
            else
            {
                if (!Validation.validCounty(txtCounty.Text.ToUpper()))
                {
                    Validation.invalidMsg(lblCounty.Text, txtCounty);
                    return;
                }
            }

            // EIRCODE VALIDATION
            if (Validation.isEmpty(txtEircode.Text))
            {
                Validation.emptyMsg(lblEircode.Text, txtEircode);
                return;
            }
            else
            {
                if (!Validation.validEircode(txtEircode.Text))
                {
                    Validation.invalidMsg(lblEircode.Text, txtEircode);
                    return;
                }
            }

            // PHONE VALIDATION
            if (Validation.isEmpty(txtPhone.Text))
            {
                Validation.emptyMsg(lblPhone.Text, txtPhone);
                return;
            }
            else
            {
                if (!Validation.validPhone(txtPhone.Text))
                {
                    Validation.invalidMsg(lblPhone.Text, txtPhone);
                    return;
                }
            }

            // EMAIL VERIFICATION
            if (Validation.isEmpty(txtEmail.Text))
            {
                Validation.emptyMsg(lblEmail.Text, txtEmail);
                return;
            }
            else
            {
                if (!Validation.validEmail(txtEmail.Text))
                {
                    Validation.invalidMsg(lblEmail.Text, txtEmail);
                    return;
                }
            }

            Account.updateAccount(Convert.ToInt32(txtCustID.Text), txtFirstName.Text.ToUpper(), txtLastName.Text.ToUpper(), dtpDOB.Value, txtStreet.Text.ToUpper(), txtTown.Text.ToUpper(), txtCounty.Text.ToUpper(), txtEircode.Text.ToUpper(), txtPhone.Text, txtEmail.Text.ToUpper());

            if(Account.validUpdate)
            {
                txtFirstName.Clear();
                txtLastName.Clear();
                dtpDOB.Value = dtpDOB.MaxDate;
                txtStreet.Clear();
                txtTown.Clear();
                txtCounty.Clear();
                txtEircode.Clear();
                txtPhone.Clear();
                txtEmail.Clear();
                txtName.Clear();
                grdAccounts.Visible = false;
                grpCustDetails.Visible = false;
            }

            if(Account.phoneTaken)
            {
                txtPhone.Clear();
                txtPhone.Focus();
            }

            if(Account.emailTaken)
            {
                txtEmail.Clear();
                txtEmail.Focus();
            }
        }

        private void frmUpdateAccount_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Visible = true;
        }
    }
}
