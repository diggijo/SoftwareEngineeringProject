using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DogKennelSys
{
    public partial class frmAddService : Form
    {
        frmMainMenu parent;

        public frmAddService(frmMainMenu Parent)
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

        private void btnAddService_Click(object sender, EventArgs e)
        {
            //Validate Service Code
            if(Validation.isEmpty(txtServiceCode.Text))
            {
                Validation.emptyMsg(lblServiceCode.Text, txtServiceCode);
                return;
            }
            else
            {
                if (!Validation.validServiceCode(txtServiceCode.Text))
                {
                    Validation.invalidMsg(lblServiceCode.Text, txtServiceCode);
                    return;
                }
            }

            //Validate Description
            if (Validation.isEmpty(txtDesc.Text))
            {
                Validation.emptyMsg(lblDesc.Text, txtDesc);
                return;
            }

            //Validate Rate
            if (Validation.isEmpty(txtRate.Text))
            {
                Validation.emptyMsg(lblRate.Text, txtRate);
                return;
            }
            else
            {
                if (!Validation.validRate(txtRate.Text))
                {
                    Validation.invalidMsg(lblRate.Text, txtRate);
                    return;
                }
            }


            Service aService = new Service(txtServiceCode.Text.ToUpper(), txtDesc.Text.ToUpper(), Convert.ToDecimal(txtRate.Text), 'A');

            aService.addService();

            txtServiceCode.Clear();
            txtDesc.Clear();
            txtRate.Text = "0.00";
            txtServiceCode.Focus();
        }

        private void frmAddService_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Visible = true;        
        }
    }
}
