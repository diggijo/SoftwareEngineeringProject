﻿
namespace DogKennelSys
{
    partial class frmServicesAnalysis
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.grdServicesAnalysis = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.cboYears = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdServicesAnalysis)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(1114, 30);
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
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(16, 112);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1086, 64);
            this.lblTitle.TabIndex = 14;
            this.lblTitle.Visible = false;
            // 
            // grdServicesAnalysis
            // 
            this.grdServicesAnalysis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdServicesAnalysis.Location = new System.Drawing.Point(16, 190);
            this.grdServicesAnalysis.Name = "grdServicesAnalysis";
            this.grdServicesAnalysis.RowHeadersWidth = 51;
            this.grdServicesAnalysis.RowTemplate.Height = 29;
            this.grdServicesAnalysis.Size = new System.Drawing.Size(1086, 124);
            this.grdServicesAnalysis.TabIndex = 13;
            this.grdServicesAnalysis.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Select Year";
            // 
            // cboYears
            // 
            this.cboYears.FormattingEnabled = true;
            this.cboYears.Location = new System.Drawing.Point(103, 50);
            this.cboYears.Name = "cboYears";
            this.cboYears.Size = new System.Drawing.Size(151, 28);
            this.cboYears.TabIndex = 11;
            this.cboYears.SelectedIndexChanged += new System.EventHandler(this.cmboYear_SelectedIndexChanged);
            // 
            // frmServicesAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 335);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grdServicesAnalysis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboYears);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmServicesAnalysis";
            this.Text = "Doggy Day Care - [Services Analysis]";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmServicesAnalysis_FormClosed);
            this.Load += new System.EventHandler(this.frmChart_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdServicesAnalysis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuHome;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView grdServicesAnalysis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboYears;
    }
}