
namespace DogKennelSys
{
    partial class frmWithdrawService
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
            this.grpWithdrawService = new System.Windows.Forms.GroupBox();
            this.btnRemoveService = new System.Windows.Forms.Button();
            this.lblServiceCode = new System.Windows.Forms.Label();
            this.txtServiceCode = new System.Windows.Forms.TextBox();
            this.btnGetServices = new System.Windows.Forms.Button();
            this.grdServices = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.grpWithdrawService.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdServices)).BeginInit();
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
            // grpWithdrawService
            // 
            this.grpWithdrawService.Controls.Add(this.btnRemoveService);
            this.grpWithdrawService.Controls.Add(this.lblServiceCode);
            this.grpWithdrawService.Controls.Add(this.txtServiceCode);
            this.grpWithdrawService.Location = new System.Drawing.Point(113, 387);
            this.grpWithdrawService.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpWithdrawService.Name = "grpWithdrawService";
            this.grpWithdrawService.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpWithdrawService.Size = new System.Drawing.Size(688, 149);
            this.grpWithdrawService.TabIndex = 1;
            this.grpWithdrawService.TabStop = false;
            this.grpWithdrawService.Text = "Withdraw Service";
            this.grpWithdrawService.Visible = false;
            // 
            // btnRemoveService
            // 
            this.btnRemoveService.Location = new System.Drawing.Point(264, 96);
            this.btnRemoveService.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRemoveService.Name = "btnRemoveService";
            this.btnRemoveService.Size = new System.Drawing.Size(160, 31);
            this.btnRemoveService.TabIndex = 2;
            this.btnRemoveService.Text = "Withdraw Service";
            this.btnRemoveService.UseVisualStyleBackColor = true;
            this.btnRemoveService.Click += new System.EventHandler(this.btnRemoveService_Click);
            // 
            // lblServiceCode
            // 
            this.lblServiceCode.AutoSize = true;
            this.lblServiceCode.Location = new System.Drawing.Point(155, 51);
            this.lblServiceCode.Name = "lblServiceCode";
            this.lblServiceCode.Size = new System.Drawing.Size(95, 20);
            this.lblServiceCode.TabIndex = 1;
            this.lblServiceCode.Text = "Service Code";
            // 
            // txtServiceCode
            // 
            this.txtServiceCode.Location = new System.Drawing.Point(253, 48);
            this.txtServiceCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtServiceCode.MaxLength = 3;
            this.txtServiceCode.Name = "txtServiceCode";
            this.txtServiceCode.ReadOnly = true;
            this.txtServiceCode.Size = new System.Drawing.Size(182, 27);
            this.txtServiceCode.TabIndex = 2;
            // 
            // btnGetServices
            // 
            this.btnGetServices.Location = new System.Drawing.Point(377, 68);
            this.btnGetServices.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGetServices.Name = "btnGetServices";
            this.btnGetServices.Size = new System.Drawing.Size(160, 31);
            this.btnGetServices.TabIndex = 3;
            this.btnGetServices.Text = "Get Services";
            this.btnGetServices.UseVisualStyleBackColor = true;
            this.btnGetServices.Click += new System.EventHandler(this.btnGetServices_Click);
            // 
            // grdServices
            // 
            this.grdServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdServices.Location = new System.Drawing.Point(245, 125);
            this.grdServices.Name = "grdServices";
            this.grdServices.RowHeadersWidth = 51;
            this.grdServices.RowTemplate.Height = 29;
            this.grdServices.Size = new System.Drawing.Size(424, 235);
            this.grdServices.TabIndex = 27;
            this.grdServices.Visible = false;
            this.grdServices.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdServices_CellClick);
            // 
            // frmWithdrawService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.grdServices);
            this.Controls.Add(this.btnGetServices);
            this.Controls.Add(this.grpWithdrawService);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmWithdrawService";
            this.Text = "Doggy Day Care - [Withdraw Service]";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmWithdrawService_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpWithdrawService.ResumeLayout(false);
            this.grpWithdrawService.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdServices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuHome;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.GroupBox grpWithdrawService;
        private System.Windows.Forms.Button btnRemoveService;
        private System.Windows.Forms.Label lblServiceCode;
        private System.Windows.Forms.TextBox txtServiceCode;
        private System.Windows.Forms.Button btnGetServices;
        private System.Windows.Forms.DataGridView grdServices;
    }
}