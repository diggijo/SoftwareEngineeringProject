
namespace DogKennelSys
{
    partial class frmMakeBooking
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
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuHome = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.grpSelectDog = new System.Windows.Forms.GroupBox();
            this.grdPets = new System.Windows.Forms.DataGridView();
            this.grpBooking = new System.Windows.Forms.GroupBox();
            this.btnSelectDates = new System.Windows.Forms.Button();
            this.lblCheckOut = new System.Windows.Forms.Label();
            this.lblCheckIn = new System.Windows.Forms.Label();
            this.dtpCheckOut = new System.Windows.Forms.DateTimePicker();
            this.dtpCheckIn = new System.Windows.Forms.DateTimePicker();
            this.btnMakeBooking = new System.Windows.Forms.Button();
            this.grdAccounts = new System.Windows.Forms.DataGridView();
            this.grpKennels = new System.Windows.Forms.GroupBox();
            this.grdKennels = new System.Windows.Forms.DataGridView();
            this.grpSearch.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.grpSelectDog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPets)).BeginInit();
            this.grpBooking.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAccounts)).BeginInit();
            this.grpKennels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdKennels)).BeginInit();
            this.SuspendLayout();
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.lblLastName);
            this.grpSearch.Controls.Add(this.btnSearch);
            this.grpSearch.Controls.Add(this.txtName);
            this.grpSearch.Location = new System.Drawing.Point(14, 44);
            this.grpSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpSearch.Size = new System.Drawing.Size(275, 189);
            this.grpSearch.TabIndex = 20;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Search Customer";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(29, 67);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(79, 20);
            this.lblLastName.TabIndex = 21;
            this.lblLastName.Text = "Last Name";
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
            this.txtName.TabIndex = 19;
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
            this.menuStrip1.TabIndex = 21;
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
            // grpSelectDog
            // 
            this.grpSelectDog.Controls.Add(this.grdPets);
            this.grpSelectDog.Location = new System.Drawing.Point(14, 260);
            this.grpSelectDog.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpSelectDog.Name = "grpSelectDog";
            this.grpSelectDog.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpSelectDog.Size = new System.Drawing.Size(887, 167);
            this.grpSelectDog.TabIndex = 23;
            this.grpSelectDog.TabStop = false;
            this.grpSelectDog.Text = "Select Dogs";
            this.grpSelectDog.Visible = false;
            // 
            // grdPets
            // 
            this.grdPets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPets.Location = new System.Drawing.Point(9, 38);
            this.grdPets.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grdPets.Name = "grdPets";
            this.grdPets.RowHeadersWidth = 51;
            this.grdPets.RowTemplate.Height = 25;
            this.grdPets.Size = new System.Drawing.Size(872, 129);
            this.grdPets.TabIndex = 0;
            this.grdPets.Visible = false;
            this.grdPets.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdPets_CellClick);
            // 
            // grpBooking
            // 
            this.grpBooking.Controls.Add(this.btnSelectDates);
            this.grpBooking.Controls.Add(this.lblCheckOut);
            this.grpBooking.Controls.Add(this.lblCheckIn);
            this.grpBooking.Controls.Add(this.dtpCheckOut);
            this.grpBooking.Controls.Add(this.dtpCheckIn);
            this.grpBooking.Location = new System.Drawing.Point(14, 452);
            this.grpBooking.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpBooking.Name = "grpBooking";
            this.grpBooking.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpBooking.Size = new System.Drawing.Size(887, 149);
            this.grpBooking.TabIndex = 0;
            this.grpBooking.TabStop = false;
            this.grpBooking.Text = "Select Dates";
            this.grpBooking.Visible = false;
            // 
            // btnSelectDates
            // 
            this.btnSelectDates.Location = new System.Drawing.Point(381, 110);
            this.btnSelectDates.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSelectDates.Name = "btnSelectDates";
            this.btnSelectDates.Size = new System.Drawing.Size(125, 31);
            this.btnSelectDates.TabIndex = 5;
            this.btnSelectDates.Text = "Select Dates";
            this.btnSelectDates.UseVisualStyleBackColor = true;
            this.btnSelectDates.Click += new System.EventHandler(this.btnSelectDates_Click);
            // 
            // lblCheckOut
            // 
            this.lblCheckOut.AutoSize = true;
            this.lblCheckOut.Location = new System.Drawing.Point(474, 60);
            this.lblCheckOut.Name = "lblCheckOut";
            this.lblCheckOut.Size = new System.Drawing.Size(114, 20);
            this.lblCheckOut.TabIndex = 3;
            this.lblCheckOut.Text = "Check-Out Date";
            // 
            // lblCheckIn
            // 
            this.lblCheckIn.AutoSize = true;
            this.lblCheckIn.Location = new System.Drawing.Point(72, 60);
            this.lblCheckIn.Name = "lblCheckIn";
            this.lblCheckIn.Size = new System.Drawing.Size(102, 20);
            this.lblCheckIn.TabIndex = 2;
            this.lblCheckIn.Text = "Check-In Date";
            // 
            // dtpCheckOut
            // 
            this.dtpCheckOut.CustomFormat = "dd/MM/yyyy";
            this.dtpCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCheckOut.Location = new System.Drawing.Point(594, 55);
            this.dtpCheckOut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpCheckOut.MinDate = new System.DateTime(2022, 4, 4, 0, 0, 0, 0);
            this.dtpCheckOut.Name = "dtpCheckOut";
            this.dtpCheckOut.Size = new System.Drawing.Size(129, 27);
            this.dtpCheckOut.TabIndex = 1;
            this.dtpCheckOut.ValueChanged += new System.EventHandler(this.dtpCheckOut_ValueChanged);
            // 
            // dtpCheckIn
            // 
            this.dtpCheckIn.CustomFormat = "dd/MM/yyyy";
            this.dtpCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCheckIn.Location = new System.Drawing.Point(180, 55);
            this.dtpCheckIn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpCheckIn.MinDate = new System.DateTime(2022, 4, 4, 0, 0, 0, 0);
            this.dtpCheckIn.Name = "dtpCheckIn";
            this.dtpCheckIn.Size = new System.Drawing.Size(128, 27);
            this.dtpCheckIn.TabIndex = 0;
            this.dtpCheckIn.ValueChanged += new System.EventHandler(this.dtpCheckIn_ValueChanged);
            // 
            // btnMakeBooking
            // 
            this.btnMakeBooking.Location = new System.Drawing.Point(582, 59);
            this.btnMakeBooking.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMakeBooking.Name = "btnMakeBooking";
            this.btnMakeBooking.Size = new System.Drawing.Size(188, 59);
            this.btnMakeBooking.TabIndex = 4;
            this.btnMakeBooking.Text = "Make Booking";
            this.btnMakeBooking.UseVisualStyleBackColor = true;
            this.btnMakeBooking.Visible = false;
            this.btnMakeBooking.Click += new System.EventHandler(this.btnMakeBooking_Click);
            // 
            // grdAccounts
            // 
            this.grdAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAccounts.Location = new System.Drawing.Point(320, 44);
            this.grdAccounts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grdAccounts.Name = "grdAccounts";
            this.grdAccounts.RowHeadersWidth = 51;
            this.grdAccounts.RowTemplate.Height = 25;
            this.grdAccounts.Size = new System.Drawing.Size(581, 189);
            this.grdAccounts.TabIndex = 0;
            this.grdAccounts.Visible = false;
            this.grdAccounts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdAccounts_CellClick);
            // 
            // grpKennels
            // 
            this.grpKennels.Controls.Add(this.grdKennels);
            this.grpKennels.Controls.Add(this.btnMakeBooking);
            this.grpKennels.Location = new System.Drawing.Point(15, 609);
            this.grpKennels.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpKennels.Name = "grpKennels";
            this.grpKennels.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpKennels.Size = new System.Drawing.Size(887, 176);
            this.grpKennels.TabIndex = 24;
            this.grpKennels.TabStop = false;
            this.grpKennels.Text = "Select Kennel";
            this.grpKennels.Visible = false;
            // 
            // grdKennels
            // 
            this.grdKennels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdKennels.Location = new System.Drawing.Point(9, 38);
            this.grdKennels.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grdKennels.Name = "grdKennels";
            this.grdKennels.RowHeadersWidth = 51;
            this.grdKennels.RowTemplate.Height = 25;
            this.grdKennels.Size = new System.Drawing.Size(417, 107);
            this.grdKennels.TabIndex = 0;
            this.grdKennels.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdKennels_CellClick);
            // 
            // frmMakeBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 814);
            this.Controls.Add(this.grpKennels);
            this.Controls.Add(this.grdAccounts);
            this.Controls.Add(this.grpBooking);
            this.Controls.Add(this.grpSelectDog);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMakeBooking";
            this.Text = "Doggy Day Care - [Make Booking]";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMakeBooking_FormClosed);
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpSelectDog.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdPets)).EndInit();
            this.grpBooking.ResumeLayout(false);
            this.grpBooking.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAccounts)).EndInit();
            this.grpKennels.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdKennels)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuHome;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.GroupBox grpSelectDog;
        private System.Windows.Forms.GroupBox grpBooking;
        private System.Windows.Forms.Button btnMakeBooking;
        private System.Windows.Forms.Label lblCheckOut;
        private System.Windows.Forms.Label lblCheckIn;
        private System.Windows.Forms.DateTimePicker dtpCheckOut;
        private System.Windows.Forms.DateTimePicker dtpCheckIn;
        private System.Windows.Forms.DataGridView grdAccounts;
        private System.Windows.Forms.DataGridView grdPets;
        private System.Windows.Forms.Button btnSelectDates;
        private System.Windows.Forms.GroupBox grpKennels;
        private System.Windows.Forms.DataGridView grdKennels;
    }
}