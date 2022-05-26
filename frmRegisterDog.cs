using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DogKennelSys
{
    
    public partial class frmRegisterDog : Form
    {
        frmMainMenu parent;
        public frmRegisterDog(frmMainMenu Parent)
        {
            InitializeComponent();
            dtpDOB.MaxDate = DateTime.Today.AddYears(-1);
            dtpDOB.Value = dtpDOB.MaxDate;
            parent = Parent;
        }

        private void frmRegisterDog_Load(object sender, EventArgs e)
        {

        }
        private void mnuHme_Click(object sender, EventArgs e)
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


        private void btnRegisterDog_Click(object sender, EventArgs e)
        {
            //NAME VALIDATION
            if (Validation.isEmpty(txtPetName.Text))
            {
                Validation.emptyMsg(lblName.Text, txtPetName);
                return;
            }
            else
            {
                if (!Validation.validName(txtPetName.Text))
                {
                    Validation.invalidMsg(lblName.Text, txtPetName);
                    return;
                }
            }

            //BREED VALIDATION
            if (Validation.isEmpty(txtBreed.Text))
            {
                Validation.emptyMsg(lblBreed.Text, txtBreed);
                return;
            }
            else
            {
                if (!Validation.validName(txtBreed.Text))
                {
                    Validation.invalidMsg(lblBreed.Text, txtBreed);
                    return;
                }
            }

            //COLOUR VALIDATION
            if (Validation.isEmpty(txtColour.Text))
            {
                Validation.emptyMsg(lblColour.Text, txtColour);
                return;
            }
            else
            {
                if (!Validation.validColour(txtColour.Text))
                {
                    Validation.invalidMsg(lblColour.Text, txtColour);
                    return;
                }
            }

            int petID;

            Pet aPet = new Pet(petID = Pet.getNextPetID(), txtPetName.Text.ToUpper(), dtpDOB.Value, txtBreed.Text.ToUpper(), Convert.ToChar(cmboSize.Text), txtColour.Text.ToUpper(), Convert.ToChar(cmboSex.Text), Convert.ToChar(cmboNeutered.Text), Convert.ToInt32(txtCustID.Text));

            aPet.registerDog();

            MessageBox.Show(txtPetName.Text + " registered successfully! \nPetID = " + petID, "Pet Registered", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtPetName.Clear();
            dtpDOB.Value = dtpDOB.MaxDate;
            txtBreed.Clear();
            cmboSize.ResetText();
            txtColour.Clear();
            cmboSex.ResetText();
            cmboNeutered.ResetText();
            txtCustID.Clear();
            txtName.Clear();
            grdAccounts.Visible = false;
            grpDogDetails.Visible = false;
        }

        private void grdAccounts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                String custID = grdAccounts.Rows[e.RowIndex].Cells[0].Value.ToString();

                if(custID == "")
                {
                    MessageBox.Show("Please select a customer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    grpDogDetails.Visible = false;
                }
                else
                {
                    txtCustID.Text = custID;
                    grpDogDetails.Visible = true;
                    txtName.Focus();
                }
            }
            catch
            {
                //so program doesnt crash by a misclick;
            }

        }

        private void frmRegisterDog_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Visible = true;
        }
    }
}
