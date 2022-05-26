
namespace DogKennelSys
{
    partial class frmMainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            this.picMainMenu = new System.Windows.Forms.PictureBox();
            this.mnuAccounts = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpenAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdateAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRegisterDog = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuServices = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddService = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWithdrawService = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBookings = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMakeBooking = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCancelBooking = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddBkService = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCheckIn_Out = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuYearlyRevenue = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceAnalysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.picMainMenu)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picMainMenu
            // 
            this.picMainMenu.Image = ((System.Drawing.Image)(resources.GetObject("picMainMenu.Image")));
            this.picMainMenu.Location = new System.Drawing.Point(14, 36);
            this.picMainMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picMainMenu.Name = "picMainMenu";
            this.picMainMenu.Size = new System.Drawing.Size(887, 548);
            this.picMainMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMainMenu.TabIndex = 1;
            this.picMainMenu.TabStop = false;
            // 
            // mnuAccounts
            // 
            this.mnuAccounts.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOpenAccount,
            this.mnuUpdateAccount,
            this.mnuRegisterDog});
            this.mnuAccounts.Name = "mnuAccounts";
            this.mnuAccounts.Size = new System.Drawing.Size(83, 24);
            this.mnuAccounts.Text = "Accounts";
            // 
            // mnuOpenAccount
            // 
            this.mnuOpenAccount.Name = "mnuOpenAccount";
            this.mnuOpenAccount.Size = new System.Drawing.Size(199, 26);
            this.mnuOpenAccount.Text = "Open Account";
            this.mnuOpenAccount.Click += new System.EventHandler(this.mnuOpenAccount_Click);
            // 
            // mnuUpdateAccount
            // 
            this.mnuUpdateAccount.Name = "mnuUpdateAccount";
            this.mnuUpdateAccount.Size = new System.Drawing.Size(199, 26);
            this.mnuUpdateAccount.Text = "Update Account";
            this.mnuUpdateAccount.Click += new System.EventHandler(this.mnuUpdateAccount_Click);
            // 
            // mnuRegisterDog
            // 
            this.mnuRegisterDog.Name = "mnuRegisterDog";
            this.mnuRegisterDog.Size = new System.Drawing.Size(199, 26);
            this.mnuRegisterDog.Text = "Register Dog";
            this.mnuRegisterDog.Click += new System.EventHandler(this.mnuRegisterDog_Click);
            // 
            // mnuServices
            // 
            this.mnuServices.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddService,
            this.mnuWithdrawService});
            this.mnuServices.Name = "mnuServices";
            this.mnuServices.Size = new System.Drawing.Size(76, 24);
            this.mnuServices.Text = "Services";
            // 
            // mnuAddService
            // 
            this.mnuAddService.Name = "mnuAddService";
            this.mnuAddService.Size = new System.Drawing.Size(207, 26);
            this.mnuAddService.Text = "Add Service";
            this.mnuAddService.Click += new System.EventHandler(this.mnuAddService_Click);
            // 
            // mnuWithdrawService
            // 
            this.mnuWithdrawService.Name = "mnuWithdrawService";
            this.mnuWithdrawService.Size = new System.Drawing.Size(207, 26);
            this.mnuWithdrawService.Text = "Withdraw Service";
            this.mnuWithdrawService.Click += new System.EventHandler(this.mnuWithdrawService_Click);
            // 
            // mnuBookings
            // 
            this.mnuBookings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMakeBooking,
            this.mnuCancelBooking,
            this.mnuAddBkService,
            this.mnuCheckIn_Out});
            this.mnuBookings.Name = "mnuBookings";
            this.mnuBookings.Size = new System.Drawing.Size(84, 24);
            this.mnuBookings.Text = "Bookings";
            // 
            // mnuMakeBooking
            // 
            this.mnuMakeBooking.Name = "mnuMakeBooking";
            this.mnuMakeBooking.Size = new System.Drawing.Size(230, 26);
            this.mnuMakeBooking.Text = "Make Booking";
            this.mnuMakeBooking.Click += new System.EventHandler(this.mnuMakeBooking_Click);
            // 
            // mnuCancelBooking
            // 
            this.mnuCancelBooking.Name = "mnuCancelBooking";
            this.mnuCancelBooking.Size = new System.Drawing.Size(230, 26);
            this.mnuCancelBooking.Text = "Cancel Booking";
            this.mnuCancelBooking.Click += new System.EventHandler(this.mnuCancelBooking_Click);
            // 
            // mnuAddBkService
            // 
            this.mnuAddBkService.Name = "mnuAddBkService";
            this.mnuAddBkService.Size = new System.Drawing.Size(230, 26);
            this.mnuAddBkService.Text = "Add Booking Service";
            this.mnuAddBkService.Click += new System.EventHandler(this.mnuAddBkService_Click);
            // 
            // mnuCheckIn_Out
            // 
            this.mnuCheckIn_Out.Name = "mnuCheckIn_Out";
            this.mnuCheckIn_Out.Size = new System.Drawing.Size(230, 26);
            this.mnuCheckIn_Out.Text = "Check-In/Out";
            this.mnuCheckIn_Out.Click += new System.EventHandler(this.mnuCheckIn_Out_Click);
            // 
            // mnuAdmin
            // 
            this.mnuAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuYearlyRevenue,
            this.serviceAnalysisToolStripMenuItem});
            this.mnuAdmin.Name = "mnuAdmin";
            this.mnuAdmin.Size = new System.Drawing.Size(67, 24);
            this.mnuAdmin.Text = "Admin";
            // 
            // mnuYearlyRevenue
            // 
            this.mnuYearlyRevenue.Name = "mnuYearlyRevenue";
            this.mnuYearlyRevenue.Size = new System.Drawing.Size(248, 26);
            this.mnuYearlyRevenue.Text = "Yearly Revenue Analysis";
            this.mnuYearlyRevenue.Click += new System.EventHandler(this.mnuYearlyRevenue_Click);
            // 
            // serviceAnalysisToolStripMenuItem
            // 
            this.serviceAnalysisToolStripMenuItem.Name = "serviceAnalysisToolStripMenuItem";
            this.serviceAnalysisToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.serviceAnalysisToolStripMenuItem.Text = "Service Analysis";
            this.serviceAnalysisToolStripMenuItem.Click += new System.EventHandler(this.serviceAnalysisToolStripMenuItem_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(47, 24);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAccounts,
            this.mnuServices,
            this.mnuBookings,
            this.mnuAdmin,
            this.mnuExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(914, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // frmMainMenu
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.picMainMenu);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMainMenu";
            this.Text = "Doggy Day Care - [Main Menu]";
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picMainMenu)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picMainMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuAccounts;
        private System.Windows.Forms.ToolStripMenuItem mnuOpenAccount;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdateAccount;
        private System.Windows.Forms.ToolStripMenuItem mnuRegisterDog;
        private System.Windows.Forms.ToolStripMenuItem mnuServices;
        private System.Windows.Forms.ToolStripMenuItem mnuAddService;
        private System.Windows.Forms.ToolStripMenuItem mnuWithdrawService;
        private System.Windows.Forms.ToolStripMenuItem mnuBookings;
        private System.Windows.Forms.ToolStripMenuItem mnuMakeBooking;
        private System.Windows.Forms.ToolStripMenuItem mnuCancelBooking;
        private System.Windows.Forms.ToolStripMenuItem mnuAddBkService;
        private System.Windows.Forms.ToolStripMenuItem mnuAdmin;
        private System.Windows.Forms.ToolStripMenuItem mnuYearlyRevenue;
        private System.Windows.Forms.ToolStripMenuItem serviceAnalysisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuCheckIn_Out;
    }
}

