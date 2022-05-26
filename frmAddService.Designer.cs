
namespace DogKennelSys
{
    partial class frmAddService
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
            this.txtServiceCode = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.lblServiceCode = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.btnAddService = new System.Windows.Forms.Button();
            this.grpAddService = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.grpAddService.SuspendLayout();
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
            // txtServiceCode
            // 
            this.txtServiceCode.Location = new System.Drawing.Point(368, 48);
            this.txtServiceCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtServiceCode.MaxLength = 3;
            this.txtServiceCode.Name = "txtServiceCode";
            this.txtServiceCode.Size = new System.Drawing.Size(140, 27);
            this.txtServiceCode.TabIndex = 1;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(253, 116);
            this.txtDesc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDesc.MaxLength = 50;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(381, 27);
            this.txtDesc.TabIndex = 2;
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(368, 184);
            this.txtRate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRate.MaxLength = 5;
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(140, 27);
            this.txtRate.TabIndex = 3;
            // 
            // lblServiceCode
            // 
            this.lblServiceCode.AutoSize = true;
            this.lblServiceCode.Location = new System.Drawing.Point(262, 52);
            this.lblServiceCode.Name = "lblServiceCode";
            this.lblServiceCode.Size = new System.Drawing.Size(95, 20);
            this.lblServiceCode.TabIndex = 4;
            this.lblServiceCode.Text = "Service Code";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(162, 119);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(85, 20);
            this.lblDesc.TabIndex = 5;
            this.lblDesc.Text = "Description";
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Location = new System.Drawing.Point(309, 188);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(39, 20);
            this.lblRate.TabIndex = 6;
            this.lblRate.Text = "Rate";
            // 
            // btnAddService
            // 
            this.btnAddService.Location = new System.Drawing.Point(381, 252);
            this.btnAddService.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(117, 31);
            this.btnAddService.TabIndex = 7;
            this.btnAddService.Text = "Add Service";
            this.btnAddService.UseVisualStyleBackColor = true;
            this.btnAddService.Click += new System.EventHandler(this.btnAddService_Click);
            // 
            // grpAddService
            // 
            this.grpAddService.Controls.Add(this.lblServiceCode);
            this.grpAddService.Controls.Add(this.btnAddService);
            this.grpAddService.Controls.Add(this.txtServiceCode);
            this.grpAddService.Controls.Add(this.lblRate);
            this.grpAddService.Controls.Add(this.txtDesc);
            this.grpAddService.Controls.Add(this.txtRate);
            this.grpAddService.Controls.Add(this.lblDesc);
            this.grpAddService.Location = new System.Drawing.Point(14, 51);
            this.grpAddService.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpAddService.Name = "grpAddService";
            this.grpAddService.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpAddService.Size = new System.Drawing.Size(887, 331);
            this.grpAddService.TabIndex = 8;
            this.grpAddService.TabStop = false;
            this.grpAddService.Text = "Add Service";
            // 
            // frmAddService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 397);
            this.Controls.Add(this.grpAddService);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAddService";
            this.Text = "Doggy Day Care - [Add Service]";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAddService_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpAddService.ResumeLayout(false);
            this.grpAddService.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuHome;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.TextBox txtServiceCode;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.Label lblServiceCode;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Button btnAddService;
        private System.Windows.Forms.GroupBox grpAddService;
    }
}