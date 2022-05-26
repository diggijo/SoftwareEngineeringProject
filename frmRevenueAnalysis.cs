using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DogKennelSys
{
    public partial class frmRevenueAnalysis : Form
    {
        frmMainMenu parent;
        public frmRevenueAnalysis(frmMainMenu Parent)
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

        private void frmChart_Load(object sender, EventArgs e)
        {
            loadYears();
            formatGrid();
        }

        public void loadYears()
        {
            int year = DateTime.Today.Year;
            cboYears.DropDownStyle = ComboBoxStyle.DropDownList;
            cboYears.Items.Clear();
            for (int i = 1; i < 5; i++)
            {
                cboYears.Items.Add(year.ToString());
                year--;
            }

            lblTitle.Font = new Font("Arial", 18, FontStyle.Bold);
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblTitle.Text = "Revenue Analysis " + cboYears.Text;
        }
        public void formatGrid()
        {
            grdYearlyRevenue.ColumnCount = 12;
            grdYearlyRevenue.RowCount = 1;

            for (int i = 0; i < 12; i++)
            {
                grdYearlyRevenue.Columns[i].Width = 90;
                grdYearlyRevenue.Columns[i].Name = getMonth(i + 1);
            }

            foreach (DataGridViewColumn col in grdYearlyRevenue.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }

            grdYearlyRevenue.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grdYearlyRevenue.RowHeadersVisible = false;
        }

        public String getMonth(int monthNo)
        {
            switch (monthNo)
            {
                case 1: return "JAN";
                case 2: return "FEB";
                case 3: return "MAR";
                case 4: return "APR";
                case 5: return "MAY";
                case 6: return "JUN";
                case 7: return "JUL";
                case 8: return "AUG";
                case 9: return "SEP";
                case 10: return "OCT";
                case 11: return "NOV";
                case 12: return "DEC";
                default: return "";
            }
        }

        private void cmboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblTitle.Text = "Revenue Analysis " + cboYears.Text;
            lblTitle.Visible = true;
            loadData();
        }

        public void loadData()
        {
            lblTitle.Visible = false;
            grdYearlyRevenue.Visible = false;

            DataSet ds = Sales.getYearlyRevenue(cboYears.Text.Substring(2, 2));

            if (ds.Tables["RA"].Rows.Count == 0)
            {
                MessageBox.Show("No data found for year " + cboYears.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboYears.Focus();
                return;
            }

            double smallest = 999.99;
            int smallestMonth = 1;
            double largest = 0;
            int largestMonth = 1;
            grdYearlyRevenue.Rows[0].Cells[1].Style.ForeColor = Color.Red;

            for (int i = 0; i < ds.Tables["RA"].Rows.Count; i++)
            {
                grdYearlyRevenue.CurrentCell = grdYearlyRevenue.Rows[0].Cells[i];
                grdYearlyRevenue.CurrentCell.Value = ds.Tables["RA"].Rows[i][1].ToString();

                if (Convert.ToDouble(ds.Tables["RA"].Rows[i][1]) < smallest)
                {
                    grdYearlyRevenue.Rows[0].Cells[smallestMonth - 1].Style.ForeColor = Color.Black;
                    smallest = Convert.ToDouble(ds.Tables["RA"].Rows[i][1]);
                    smallestMonth = i + 1;
                    grdYearlyRevenue.Rows[0].Cells[smallestMonth - 1].Style.ForeColor = Color.Red;
                }

                if (Convert.ToDouble(ds.Tables["RA"].Rows[i][1]) > largest)
                {
                    grdYearlyRevenue.Rows[0].Cells[largestMonth - 1].Style.ForeColor = Color.Black;
                    largest = Convert.ToDouble(ds.Tables["RA"].Rows[i][1]);
                    largestMonth = i + 1;
                    grdYearlyRevenue.Rows[0].Cells[largestMonth - 1].Style.ForeColor = Color.Green;
                }

            }

            lblTitle.Visible = true;
            grdYearlyRevenue.Visible = true;
        }

        private void frmRevenueAnalysis_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Visible = true;
        }
    }
}
