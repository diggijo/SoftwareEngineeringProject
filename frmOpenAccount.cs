using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace DogKennelSys
{
    public partial class frmOpenAccount : Form
    {
        frmMainMenu parent;

        public frmOpenAccount(frmMainMenu Parent)
        {
            InitializeComponent();
            dtpDOB.MaxDate = DateTime.Today.AddYears(-16);
            dtpDOB.Value = dtpDOB.MaxDate;
            dtpDOB.CustomFormat = "dd/MM/yyyy";
            parent = Parent;
        }

        private void mnuHme_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }


        private void openAcc_Click(object sender, EventArgs e)
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
                Validation.emptyMsg(lblLastName.Text, txtLastName);
                return;
            }
            else
            {
                if (!Validation.validName(txtLastName.Text))
                {
                    Validation.invalidMsg(lblLastName.Text, txtLastName);
                    return;
                }
            }

            // STREET VALIDATION
            if(Validation.isEmpty(txtStreet.Text))
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

            int custID;

            Account anAccount = new Account(custID = Account.getNextCustID(), txtFirstName.Text.ToUpper(), txtLastName.Text.ToUpper(), dtpDOB.Value, txtStreet.Text.ToUpper(), txtTown.Text.ToUpper(), txtCounty.Text.ToUpper(), txtEircode.Text.ToUpper(), txtPhone.Text, txtEmail.Text.ToUpper());

            anAccount.addAccount();

            if(anAccount.accountValid)
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
                txtFirstName.Focus();
            }

            if(anAccount.phoneError)
            {
                txtPhone.Clear();
                txtPhone.Focus();
            }

            if(anAccount.emailError)
            {
                txtEmail.Clear();
                txtEmail.Focus();
            }
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmOpenAccount_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Visible = true;
        }
    }
}