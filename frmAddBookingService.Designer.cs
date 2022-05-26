
namespace DogKennelSys
{
    partial class frmAddBookingService
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
            this.lblLastName = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.grpBookings = new System.Windows.Forms.GroupBox();
            this.grdBookings = new System.Windows.Forms.DataGridView();
            this.grpServices = new System.Windows.Forms.GroupBox();
            this.grdServices = new System.Windows.Forms.DataGridView();
            this.grpAddBookingService = new System.Windows.Forms.GroupBox();
            this.btnAddBService = new System.Windows.Forms.Button();
            this.lblServiceCode = new System.Windows.Forms.Label();
            this.txtServiceCode = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.grpSearch.SuspendLayout();
            this.grpBookings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdBookings)).BeginInit();
            this.grpServices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdServices)).BeginInit();
            this.grpAddBookingService.SuspendLayout();
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
            this.grpSearch.Controls.Add(this.lblLastName);
            this.grpSearch.Controls.Add(this.btnSearch);
            this.grpSearch.Controls.Add(this.txtName);
            this.grpSearch.Location = new System.Drawing.Point(12, 44);
            this.grpSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpSearch.Size = new System.Drawing.Size(275, 189);
            this.grpSearch.TabIndex = 22;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Search Booking";
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
            // grpBookings
            // 
            this.grpBookings.Controls.Add(this.grdBookings);
            this.grpBookings.Location = new System.Drawing.Point(318, 44);
            this.grpBookings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpBookings.Name = "grpBookings";
            this.grpBookings.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpBookings.Size = new System.Drawing.Size(582, 189);
            this.grpBookings.TabIndex = 23;
            this.grpBookings.TabStop = false;
            this.grpBookings.Text = "Search Results";
            this.grpBookings.Visible = false;
            // 
            // grdBookings
            // 
            this.grdBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBookings.Location = new System.Drawing.Point(8, 31);
            this.grdBookings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grdBookings.Name = "grdBookings";
            this.grdBookings.RowHeadersWidth = 51;
            this.grdBookings.RowTemplate.Height = 25;
            this.grdBookings.Size = new System.Drawing.Size(568, 142);
            this.grdBookings.TabIndex = 0;
            this.grdBookings.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdBookings_CellClick);
            // 
            // grpServices
            // 
            this.grpServices.Controls.Add(this.grdServices);
            this.grpServices.Location = new System.Drawing.Point(12, 241);
            this.grpServices.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpServices.Name = "grpServices";
            this.grpServices.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpServices.Size = new System.Drawing.Size(452, 219);
            this.grpServices.TabIndex = 0;
            this.grpServices.TabStop = false;
            this.grpServices.Text = "List of Services";
            this.grpServices.Visible = false;
            // 
            // grdServices
            // 
            this.grdServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdServices.Location = new System.Drawing.Point(8, 31);
            this.grdServices.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grdServices.Name = "grdServices";
            this.grdServices.RowHeadersWidth = 51;
            this.grdServices.RowTemplate.Height = 25;
            this.grdServices.Size = new System.Drawing.Size(438, 180);
            this.grdServices.TabIndex = 0;
            this.grdServices.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdServices_CellClick);
            // 
            // grpAddBookingService
            // 
            this.grpAddBookingService.Controls.Add(this.btnAddBService);
            this.grpAddBookingService.Controls.Add(this.lblServiceCode);
            this.grpAddBookingService.Controls.Add(this.txtServiceCode);
            this.grpAddBookingService.Location = new System.Drawing.Point(470, 241);
            this.grpAddBookingService.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpAddBookingService.Name = "grpAddBookingService";
            this.grpAddBookingService.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpAddBookingService.Size = new System.Drawing.Size(430, 219);
            this.grpAddBookingService.TabIndex = 24;
            this.grpAddBookingService.TabStop = false;
            this.grpAddBookingService.Text = "Add Booking Service";
            this.grpAddBookingService.Visible = false;
            // 
            // btnAddBService
            // 
            this.btnAddBService.Location = new System.Drawing.Point(130, 120);
            this.btnAddBService.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddBService.Name = "btnAddBService";
            this.btnAddBService.Size = new System.Drawing.Size(170, 37);
            this.btnAddBService.TabIndex = 2;
            this.btnAddBService.Text = "Add Booking Service";
            this.btnAddBService.UseVisualStyleBackColor = true;
            this.btnAddBService.Click += new System.EventHandler(this.btnAddBService_Click);
            // 
            // lblServiceCode
            // 
            this.lblServiceCode.AutoSize = true;
            this.lblServiceCode.Location = new System.Drawing.Point(109, 69);
            this.lblServiceCode.Name = "lblServiceCode";
            this.lblServiceCode.Size = new System.Drawing.Size(95, 20);
            this.lblServiceCode.TabIndex = 1;
            this.lblServiceCode.Text = "Service Code";
            // 
            // txtServiceCode
            // 
            this.txtServiceCode.Location = new System.Drawing.Point(210, 66);
            this.txtServiceCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtServiceCode.Name = "txtServiceCode";
            this.txtServiceCode.ReadOnly = true;
            this.txtServiceCode.Size = new System.Drawing.Size(101, 27);
            this.txtServiceCode.TabIndex = 0;
            // 
            // frmAddBookingService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 474);
            this.Controls.Add(this.grpAddBookingService);
            this.Controls.Add(this.grpServices);
            this.Controls.Add(this.grpBookings);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAddBookingService";
            this.Text = "Doggy Day Care - [Add Booking Service]";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAddBookingService_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.grpBookings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdBookings)).EndInit();
            this.grpServices.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdServices)).EndInit();
            this.grpAddBookingService.ResumeLayout(false);
            this.grpAddBookingService.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuHome;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox grpBookings;
        private System.Windows.Forms.GroupBox grpServices;
        private System.Windows.Forms.GroupBox grpAddBookingService;
        private System.Windows.Forms.Button btnAddBService;
        private System.Windows.Forms.Label lblServiceCode;
        private System.Windows.Forms.TextBox txtServiceCode;
        private System.Windows.Forms.DataGridView grdBookings;
        private System.Windows.Forms.DataGridView grdServices;
    }
}