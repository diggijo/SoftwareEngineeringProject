
namespace DogKennelSys
{
    partial class frmCheckIn_Out
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
            this.radIn = new System.Windows.Forms.RadioButton();
            this.radOut = new System.Windows.Forms.RadioButton();
            this.grdArv_Depts = new System.Windows.Forms.DataGridView();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdArv_Depts)).BeginInit();
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
            // radIn
            // 
            this.radIn.AutoSize = true;
            this.radIn.Location = new System.Drawing.Point(213, 75);
            this.radIn.Name = "radIn";
            this.radIn.Size = new System.Drawing.Size(120, 24);
            this.radIn.TabIndex = 1;
            this.radIn.TabStop = true;
            this.radIn.Text = "Check-In Dog";
            this.radIn.UseVisualStyleBackColor = true;
            this.radIn.CheckedChanged += new System.EventHandler(this.radIn_CheckedChanged);
            // 
            // radOut
            // 
            this.radOut.AutoSize = true;
            this.radOut.Location = new System.Drawing.Point(489, 75);
            this.radOut.Name = "radOut";
            this.radOut.Size = new System.Drawing.Size(132, 24);
            this.radOut.TabIndex = 2;
            this.radOut.TabStop = true;
            this.radOut.Text = "Check-Out Dog";
            this.radOut.UseVisualStyleBackColor = true;
            this.radOut.CheckedChanged += new System.EventHandler(this.radOut_CheckedChanged);
            // 
            // grdArv_Depts
            // 
            this.grdArv_Depts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdArv_Depts.Location = new System.Drawing.Point(12, 135);
            this.grdArv_Depts.Name = "grdArv_Depts";
            this.grdArv_Depts.RowHeadersWidth = 51;
            this.grdArv_Depts.RowTemplate.Height = 29;
            this.grdArv_Depts.Size = new System.Drawing.Size(890, 188);
            this.grdArv_Depts.TabIndex = 3;
            this.grdArv_Depts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdArv_Depts_CellClick);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(378, 359);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(94, 29);
            this.btnConfirm.TabIndex = 4;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Visible = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // frmCheckIn_Out
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 420);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.grdArv_Depts);
            this.Controls.Add(this.radOut);
            this.Controls.Add(this.radIn);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmCheckIn_Out";
            this.Text = "Doggy Day Care - [Check-In/Out Dog]";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCheckIn_Out_FormClosed);
            this.Load += new System.EventHandler(this.frmCheckIn_Out_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdArv_Depts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuHome;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.RadioButton radIn;
        private System.Windows.Forms.RadioButton radOut;
        private System.Windows.Forms.DataGridView grdArv_Depts;
        private System.Windows.Forms.Button btnConfirm;
    }
}