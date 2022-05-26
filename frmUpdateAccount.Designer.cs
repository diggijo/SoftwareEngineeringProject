
namespace DogKennelSys
{
    partial class frmUpdateAccount
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuHome = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.label = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.grpCustDetails = new System.Windows.Forms.GroupBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.txtCustID = new System.Windows.Forms.TextBox();
            this.lblCustID = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.btnUpdateAcc = new System.Windows.Forms.Button();
            this.lblEircode = new System.Windows.Forms.Label();
            this.lblCounty = new System.Windows.Forms.Label();
            this.lblTown = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtCounty = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtEircode = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtTown = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.grdAccounts = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.grpSearch.SuspendLayout();
            this.grpCustDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAccounts)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHome,
            this.mnuExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(914, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuHome
            // 
            this.mnuHome.Name = "mnuHome";
            this.mnuHome.Size = new System.Drawing.Size(64, 24);
            this.mnuHome.Text = "Home";
            this.mnuHome.Click += new System.EventHandler(this.mnuHome_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(47, 24);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.label);
            this.grpSearch.Controls.Add(this.btnSearch);
            this.grpSearch.Controls.Add(this.txtName);
            this.grpSearch.Location = new System.Drawing.Point(14, 55);
            this.grpSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpSearch.Size = new System.Drawing.Size(275, 189);
            this.grpSearch.TabIndex = 23;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Search Customer";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(29, 67);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(79, 20);
            this.label.TabIndex = 21;
            this.label.Text = "Last Name";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(80, 133);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(86, 31);
            this.btnSearch.TabIndex = 20;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(114, 64);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(146, 27);
            this.txtName.TabIndex = 0;
            // 
            // grpCustDetails
            // 
            this.grpCustDetails.Controls.Add(this.dtpDOB);
            this.grpCustDetails.Controls.Add(this.txtCustID);
            this.grpCustDetails.Controls.Add(this.lblCustID);
            this.grpCustDetails.Controls.Add(this.lblDOB);
            this.grpCustDetails.Controls.Add(this.lblEmail);
            this.grpCustDetails.Controls.Add(this.lblPhone);
            this.grpCustDetails.Controls.Add(this.btnUpdateAcc);
            this.grpCustDetails.Controls.Add(this.lblEircode);
            this.grpCustDetails.Controls.Add(this.lblCounty);
            this.grpCustDetails.Controls.Add(this.lblTown);
            this.grpCustDetails.Controls.Add(this.lblStreet);
            this.grpCustDetails.Controls.Add(this.lblLastName);
            this.grpCustDetails.Controls.Add(this.lblFirstName);
            this.grpCustDetails.Controls.Add(this.txtCounty);
            this.grpCustDetails.Controls.Add(this.txtEmail);
            this.grpCustDetails.Controls.Add(this.txtEircode);
            this.grpCustDetails.Controls.Add(this.txtStreet);
            this.grpCustDetails.Controls.Add(this.txtFirstName);
            this.grpCustDetails.Controls.Add(this.txtLastName);
            this.grpCustDetails.Controls.Add(this.txtTown);
            this.grpCustDetails.Controls.Add(this.txtPhone);
            this.grpCustDetails.Location = new System.Drawing.Point(14, 252);
            this.grpCustDetails.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpCustDetails.Name = "grpCustDetails";
            this.grpCustDetails.Padding = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.grpCustDetails.Size = new System.Drawing.Size(887, 347);
            this.grpCustDetails.TabIndex = 25;
            this.grpCustDetails.TabStop = false;
            this.grpCustDetails.Text = "Update Customer Details";
            this.grpCustDetails.Visible = false;
            // 
            // dtpDOB
            // 
            this.dtpDOB.CustomFormat = "dd/MM/yyyy";
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDOB.Location = new System.Drawing.Point(96, 145);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(133, 27);
            this.dtpDOB.TabIndex = 3;
            // 
            // txtCustID
            // 
            this.txtCustID.Location = new System.Drawing.Point(503, 247);
            this.txtCustID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCustID.MaxLength = 7;
            this.txtCustID.Name = "txtCustID";
            this.txtCustID.PlaceholderText = "Enter Details to Update";
            this.txtCustID.ReadOnly = true;
            this.txtCustID.Size = new System.Drawing.Size(106, 27);
            this.txtCustID.TabIndex = 100;
            // 
            // lblCustID
            // 
            this.lblCustID.AutoSize = true;
            this.lblCustID.Location = new System.Drawing.Point(445, 250);
            this.lblCustID.Name = "lblCustID";
            this.lblCustID.Size = new System.Drawing.Size(52, 20);
            this.lblCustID.TabIndex = 19;
            this.lblCustID.Text = "CustID";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(50, 150);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(40, 20);
            this.lblDOB.TabIndex = 17;
            this.lblDOB.Text = "DOB";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(44, 250);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 20);
            this.lblEmail.TabIndex = 16;
            this.lblEmail.Text = "Email";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(40, 200);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(50, 20);
            this.lblPhone.TabIndex = 15;
            this.lblPhone.Text = "Phone";
            // 
            // btnUpdateAcc
            // 
            this.btnUpdateAcc.Location = new System.Drawing.Point(372, 300);
            this.btnUpdateAcc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdateAcc.Name = "btnUpdateAcc";
            this.btnUpdateAcc.Size = new System.Drawing.Size(143, 33);
            this.btnUpdateAcc.TabIndex = 10;
            this.btnUpdateAcc.Text = "Update Account";
            this.btnUpdateAcc.UseVisualStyleBackColor = true;
            this.btnUpdateAcc.Click += new System.EventHandler(this.btnUpdateAcc_Click);
            // 
            // lblEircode
            // 
            this.lblEircode.AutoSize = true;
            this.lblEircode.Location = new System.Drawing.Point(436, 200);
            this.lblEircode.Name = "lblEircode";
            this.lblEircode.Size = new System.Drawing.Size(61, 20);
            this.lblEircode.TabIndex = 14;
            this.lblEircode.Text = "EirCode";
            // 
            // lblCounty
            // 
            this.lblCounty.AutoSize = true;
            this.lblCounty.Location = new System.Drawing.Point(442, 150);
            this.lblCounty.Name = "lblCounty";
            this.lblCounty.Size = new System.Drawing.Size(55, 20);
            this.lblCounty.TabIndex = 13;
            this.lblCounty.Text = "County";
            // 
            // lblTown
            // 
            this.lblTown.AutoSize = true;
            this.lblTown.Location = new System.Drawing.Point(453, 100);
            this.lblTown.Name = "lblTown";
            this.lblTown.Size = new System.Drawing.Size(44, 20);
            this.lblTown.TabIndex = 12;
            this.lblTown.Text = "Town";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(449, 50);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(48, 20);
            this.lblStreet.TabIndex = 11;
            this.lblStreet.Text = "Street";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(11, 100);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(79, 20);
            this.lblLastName.TabIndex = 10;
            this.lblLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(10, 50);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(80, 20);
            this.lblFirstName.TabIndex = 9;
            this.lblFirstName.Text = "First Name";
            // 
            // txtCounty
            // 
            this.txtCounty.Location = new System.Drawing.Point(503, 145);
            this.txtCounty.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCounty.MaxLength = 10;
            this.txtCounty.Name = "txtCounty";
            this.txtCounty.PlaceholderText = "Enter Details to Update";
            this.txtCounty.Size = new System.Drawing.Size(207, 27);
            this.txtCounty.TabIndex = 8;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(96, 247);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.MaxLength = 30;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PlaceholderText = "Enter Details to Update";
            this.txtEmail.Size = new System.Drawing.Size(264, 27);
            this.txtEmail.TabIndex = 5;
            // 
            // txtEircode
            // 
            this.txtEircode.Location = new System.Drawing.Point(503, 197);
            this.txtEircode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEircode.MaxLength = 7;
            this.txtEircode.Name = "txtEircode";
            this.txtEircode.PlaceholderText = "Enter Details to Update";
            this.txtEircode.Size = new System.Drawing.Size(150, 27);
            this.txtEircode.TabIndex = 9;
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(503, 47);
            this.txtStreet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStreet.MaxLength = 20;
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.PlaceholderText = "Enter Details to Update";
            this.txtStreet.Size = new System.Drawing.Size(225, 27);
            this.txtStreet.TabIndex = 6;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(96, 47);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFirstName.MaxLength = 15;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PlaceholderText = "Enter Details to Update";
            this.txtFirstName.Size = new System.Drawing.Size(201, 27);
            this.txtFirstName.TabIndex = 1;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(96, 97);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLastName.MaxLength = 15;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.PlaceholderText = "Enter Details to Update";
            this.txtLastName.Size = new System.Drawing.Size(201, 27);
            this.txtLastName.TabIndex = 2;
            // 
            // txtTown
            // 
            this.txtTown.Location = new System.Drawing.Point(503, 97);
            this.txtTown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTown.MaxLength = 20;
            this.txtTown.Name = "txtTown";
            this.txtTown.PlaceholderText = "Enter Details to Update";
            this.txtTown.Size = new System.Drawing.Size(225, 27);
            this.txtTown.TabIndex = 7;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(96, 197);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPhone.MaxLength = 10;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PlaceholderText = "Enter Details to Update";
            this.txtPhone.Size = new System.Drawing.Size(164, 27);
            this.txtPhone.TabIndex = 4;
            // 
            // grdAccounts
            // 
            this.grdAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAccounts.Location = new System.Drawing.Point(323, 57);
            this.grdAccounts.Name = "grdAccounts";
            this.grdAccounts.RowHeadersWidth = 51;
            this.grdAccounts.RowTemplate.Height = 29;
            this.grdAccounts.Size = new System.Drawing.Size(578, 188);
            this.grdAccounts.TabIndex = 26;
            this.grdAccounts.Visible = false;
            this.grdAccounts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdAccounts_CellClick);
            // 
            // frmUpdateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 616);
            this.Controls.Add(this.grdAccounts);
            this.Controls.Add(this.grpCustDetails);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmUpdateAccount";
            this.Text = "Doggy Day Care - [Update Account]";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmUpdateAccount_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.grpCustDetails.ResumeLayout(false);
            this.grpCustDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAccounts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuHome;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox grpCustDetails;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblEircode;
        private System.Windows.Forms.Label lblCounty;
        private System.Windows.Forms.Label lblTown;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Button btnUpdateAcc;
        private System.Windows.Forms.TextBox txtCounty;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtEircode;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtTown;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.DataGridView grdAccounts;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.TextBox txtCustID;
        private System.Windows.Forms.Label lblCustID;
        private System.Windows.Forms.DateTimePicker dtpDOB;
    }
}