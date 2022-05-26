
namespace DogKennelSys
{
    partial class frmOpenAccount
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
            this.mnuOpenAccount = new System.Windows.Forms.MenuStrip();
            this.mnuHme = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.grpCustDetails = new System.Windows.Forms.GroupBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblEircode = new System.Windows.Forms.Label();
            this.lblCounty = new System.Windows.Forms.Label();
            this.lblTown = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.btnOpenAcc = new System.Windows.Forms.Button();
            this.txtCounty = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtEircode = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtTown = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.mnuOpenAccount.SuspendLayout();
            this.grpCustDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuOpenAccount
            // 
            this.mnuOpenAccount.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuOpenAccount.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHme,
            this.mnuExit});
            this.mnuOpenAccount.Location = new System.Drawing.Point(0, 0);
            this.mnuOpenAccount.Name = "mnuOpenAccount";
            this.mnuOpenAccount.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.mnuOpenAccount.Size = new System.Drawing.Size(914, 30);
            this.mnuOpenAccount.TabIndex = 0;
            this.mnuOpenAccount.Text = "mnuOpenAccount";
            // 
            // mnuHme
            // 
            this.mnuHme.Name = "mnuHme";
            this.mnuHme.Size = new System.Drawing.Size(64, 24);
            this.mnuHme.Text = "Home";
            this.mnuHme.Click += new System.EventHandler(this.mnuHme_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(47, 24);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // grpCustDetails
            // 
            this.grpCustDetails.Controls.Add(this.dtpDOB);
            this.grpCustDetails.Controls.Add(this.lblDOB);
            this.grpCustDetails.Controls.Add(this.lblEmail);
            this.grpCustDetails.Controls.Add(this.lblPhone);
            this.grpCustDetails.Controls.Add(this.lblEircode);
            this.grpCustDetails.Controls.Add(this.lblCounty);
            this.grpCustDetails.Controls.Add(this.lblTown);
            this.grpCustDetails.Controls.Add(this.lblStreet);
            this.grpCustDetails.Controls.Add(this.lblLastName);
            this.grpCustDetails.Controls.Add(this.lblFirstName);
            this.grpCustDetails.Controls.Add(this.btnOpenAcc);
            this.grpCustDetails.Controls.Add(this.txtCounty);
            this.grpCustDetails.Controls.Add(this.txtEmail);
            this.grpCustDetails.Controls.Add(this.txtEircode);
            this.grpCustDetails.Controls.Add(this.txtStreet);
            this.grpCustDetails.Controls.Add(this.txtFirstName);
            this.grpCustDetails.Controls.Add(this.txtLastName);
            this.grpCustDetails.Controls.Add(this.txtTown);
            this.grpCustDetails.Controls.Add(this.txtPhone);
            this.grpCustDetails.Location = new System.Drawing.Point(14, 36);
            this.grpCustDetails.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpCustDetails.Name = "grpCustDetails";
            this.grpCustDetails.Padding = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.grpCustDetails.Size = new System.Drawing.Size(887, 548);
            this.grpCustDetails.TabIndex = 1;
            this.grpCustDetails.TabStop = false;
            this.grpCustDetails.Text = "Enter Customer Details";
            // 
            // dtpDOB
            // 
            this.dtpDOB.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtpDOB.CustomFormat = "dd/MM/yyyy";
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDOB.Location = new System.Drawing.Point(311, 132);
            this.dtpDOB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(106, 27);
            this.dtpDOB.TabIndex = 3;
            this.dtpDOB.Value = new System.DateTime(1996, 2, 1, 0, 0, 0, 0);
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(238, 137);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(46, 20);
            this.lblDOB.TabIndex = 18;
            this.lblDOB.Text = "D.O.B";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(241, 460);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 20);
            this.lblEmail.TabIndex = 16;
            this.lblEmail.Text = "Email";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(233, 404);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(50, 20);
            this.lblPhone.TabIndex = 15;
            this.lblPhone.Text = "Phone";
            // 
            // lblEircode
            // 
            this.lblEircode.AutoSize = true;
            this.lblEircode.Location = new System.Drawing.Point(225, 351);
            this.lblEircode.Name = "lblEircode";
            this.lblEircode.Size = new System.Drawing.Size(61, 20);
            this.lblEircode.TabIndex = 14;
            this.lblEircode.Text = "EirCode";
            // 
            // lblCounty
            // 
            this.lblCounty.AutoSize = true;
            this.lblCounty.Location = new System.Drawing.Point(227, 297);
            this.lblCounty.Name = "lblCounty";
            this.lblCounty.Size = new System.Drawing.Size(55, 20);
            this.lblCounty.TabIndex = 13;
            this.lblCounty.Text = "County";
            // 
            // lblTown
            // 
            this.lblTown.AutoSize = true;
            this.lblTown.Location = new System.Drawing.Point(240, 244);
            this.lblTown.Name = "lblTown";
            this.lblTown.Size = new System.Drawing.Size(44, 20);
            this.lblTown.TabIndex = 12;
            this.lblTown.Text = "Town";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(238, 191);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(48, 20);
            this.lblStreet.TabIndex = 11;
            this.lblStreet.Text = "Street";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(208, 84);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(79, 20);
            this.lblLastName.TabIndex = 10;
            this.lblLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(207, 31);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(80, 20);
            this.lblFirstName.TabIndex = 9;
            this.lblFirstName.Text = "First Name";
            // 
            // btnOpenAcc
            // 
            this.btnOpenAcc.Location = new System.Drawing.Point(379, 507);
            this.btnOpenAcc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOpenAcc.Name = "btnOpenAcc";
            this.btnOpenAcc.Size = new System.Drawing.Size(143, 33);
            this.btnOpenAcc.TabIndex = 10;
            this.btnOpenAcc.Text = "Submit";
            this.btnOpenAcc.UseVisualStyleBackColor = true;
            this.btnOpenAcc.Click += new System.EventHandler(this.openAcc_Click);
            // 
            // txtCounty
            // 
            this.txtCounty.Location = new System.Drawing.Point(311, 294);
            this.txtCounty.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCounty.MaxLength = 10;
            this.txtCounty.Name = "txtCounty";
            this.txtCounty.Size = new System.Drawing.Size(117, 27);
            this.txtCounty.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(311, 453);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.MaxLength = 40;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(265, 27);
            this.txtEmail.TabIndex = 9;
            // 
            // txtEircode
            // 
            this.txtEircode.Location = new System.Drawing.Point(311, 348);
            this.txtEircode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEircode.MaxLength = 7;
            this.txtEircode.Name = "txtEircode";
            this.txtEircode.Size = new System.Drawing.Size(96, 27);
            this.txtEircode.TabIndex = 7;
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(311, 188);
            this.txtStreet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStreet.MaxLength = 20;
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(179, 27);
            this.txtStreet.TabIndex = 4;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(311, 28);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFirstName.MaxLength = 15;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(155, 27);
            this.txtFirstName.TabIndex = 1;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(311, 81);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLastName.MaxLength = 15;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(155, 27);
            this.txtLastName.TabIndex = 2;
            // 
            // txtTown
            // 
            this.txtTown.Location = new System.Drawing.Point(311, 241);
            this.txtTown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTown.MaxLength = 20;
            this.txtTown.Name = "txtTown";
            this.txtTown.Size = new System.Drawing.Size(167, 27);
            this.txtTown.TabIndex = 5;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(311, 401);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPhone.MaxLength = 10;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(117, 27);
            this.txtPhone.TabIndex = 8;
            // 
            // frmOpenAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 599);
            this.Controls.Add(this.grpCustDetails);
            this.Controls.Add(this.mnuOpenAccount);
            this.MainMenuStrip = this.mnuOpenAccount;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmOpenAccount";
            this.Text = "Doggy Day Care - [Open Account]";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmOpenAccount_FormClosed);
            this.mnuOpenAccount.ResumeLayout(false);
            this.mnuOpenAccount.PerformLayout();
            this.grpCustDetails.ResumeLayout(false);
            this.grpCustDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuOpenAccount;
        private System.Windows.Forms.ToolStripMenuItem mnuHme;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.GroupBox grpCustDetails;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblEircode;
        private System.Windows.Forms.Label lblCounty;
        private System.Windows.Forms.Label lblTown;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Button btnOpenAcc;
        private System.Windows.Forms.TextBox txtCounty;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtEircode;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtTown;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.DateTimePicker dtpDOB;
    }
}