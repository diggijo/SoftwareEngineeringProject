
namespace DogKennelSys
{
    partial class frmRegisterDog
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
            this.mnuHme = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.grpDogDetails = new System.Windows.Forms.GroupBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.cmboNeutered = new System.Windows.Forms.ComboBox();
            this.cmboSex = new System.Windows.Forms.ComboBox();
            this.cmboSize = new System.Windows.Forms.ComboBox();
            this.lblNeutered = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCustID = new System.Windows.Forms.TextBox();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblColour = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblBreed = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnRegisterDog = new System.Windows.Forms.Button();
            this.txtColour = new System.Windows.Forms.TextBox();
            this.txtBreed = new System.Windows.Forms.TextBox();
            this.txtPetName = new System.Windows.Forms.TextBox();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.grdAccounts = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.grpDogDetails.SuspendLayout();
            this.grpSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAccounts)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHme,
            this.mnuExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(914, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
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
            // grpDogDetails
            // 
            this.grpDogDetails.Controls.Add(this.dtpDOB);
            this.grpDogDetails.Controls.Add(this.cmboNeutered);
            this.grpDogDetails.Controls.Add(this.cmboSex);
            this.grpDogDetails.Controls.Add(this.cmboSize);
            this.grpDogDetails.Controls.Add(this.lblNeutered);
            this.grpDogDetails.Controls.Add(this.label7);
            this.grpDogDetails.Controls.Add(this.txtCustID);
            this.grpDogDetails.Controls.Add(this.lblSex);
            this.grpDogDetails.Controls.Add(this.lblColour);
            this.grpDogDetails.Controls.Add(this.lblSize);
            this.grpDogDetails.Controls.Add(this.lblBreed);
            this.grpDogDetails.Controls.Add(this.lblDOB);
            this.grpDogDetails.Controls.Add(this.lblName);
            this.grpDogDetails.Controls.Add(this.btnRegisterDog);
            this.grpDogDetails.Controls.Add(this.txtColour);
            this.grpDogDetails.Controls.Add(this.txtBreed);
            this.grpDogDetails.Controls.Add(this.txtPetName);
            this.grpDogDetails.Location = new System.Drawing.Point(14, 252);
            this.grpDogDetails.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpDogDetails.Name = "grpDogDetails";
            this.grpDogDetails.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpDogDetails.Size = new System.Drawing.Size(887, 320);
            this.grpDogDetails.TabIndex = 1;
            this.grpDogDetails.TabStop = false;
            this.grpDogDetails.Text = "Enter Dog Details";
            this.grpDogDetails.Visible = false;
            // 
            // dtpDOB
            // 
            this.dtpDOB.CustomFormat = "dd/MM/yyyy";
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDOB.Location = new System.Drawing.Point(120, 97);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(131, 27);
            this.dtpDOB.TabIndex = 2;
            // 
            // cmboNeutered
            // 
            this.cmboNeutered.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboNeutered.FormattingEnabled = true;
            this.cmboNeutered.Items.AddRange(new object[] {
            "Y",
            "N"});
            this.cmboNeutered.Location = new System.Drawing.Point(590, 147);
            this.cmboNeutered.Name = "cmboNeutered";
            this.cmboNeutered.Size = new System.Drawing.Size(74, 28);
            this.cmboNeutered.TabIndex = 7;
            // 
            // cmboSex
            // 
            this.cmboSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboSex.FormattingEnabled = true;
            this.cmboSex.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cmboSex.Location = new System.Drawing.Point(590, 99);
            this.cmboSex.Name = "cmboSex";
            this.cmboSex.Size = new System.Drawing.Size(74, 28);
            this.cmboSex.TabIndex = 6;
            // 
            // cmboSize
            // 
            this.cmboSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboSize.FormattingEnabled = true;
            this.cmboSize.Items.AddRange(new object[] {
            "S",
            "M",
            "L"});
            this.cmboSize.Location = new System.Drawing.Point(120, 197);
            this.cmboSize.Name = "cmboSize";
            this.cmboSize.Size = new System.Drawing.Size(70, 28);
            this.cmboSize.TabIndex = 4;
            // 
            // lblNeutered
            // 
            this.lblNeutered.AutoSize = true;
            this.lblNeutered.Location = new System.Drawing.Point(498, 150);
            this.lblNeutered.Name = "lblNeutered";
            this.lblNeutered.Size = new System.Drawing.Size(71, 20);
            this.lblNeutered.TabIndex = 16;
            this.lblNeutered.Text = "Neutered";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(517, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "CustID";
            // 
            // txtCustID
            // 
            this.txtCustID.Location = new System.Drawing.Point(590, 197);
            this.txtCustID.Name = "txtCustID";
            this.txtCustID.ReadOnly = true;
            this.txtCustID.Size = new System.Drawing.Size(93, 27);
            this.txtCustID.TabIndex = 13;
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(537, 102);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(32, 20);
            this.lblSex.TabIndex = 12;
            this.lblSex.Text = "Sex";
            // 
            // lblColour
            // 
            this.lblColour.AutoSize = true;
            this.lblColour.Location = new System.Drawing.Point(516, 50);
            this.lblColour.Name = "lblColour";
            this.lblColour.Size = new System.Drawing.Size(53, 20);
            this.lblColour.TabIndex = 11;
            this.lblColour.Text = "Colour";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(63, 200);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(36, 20);
            this.lblSize.TabIndex = 10;
            this.lblSize.Text = "Size";
            // 
            // lblBreed
            // 
            this.lblBreed.AutoSize = true;
            this.lblBreed.Location = new System.Drawing.Point(51, 150);
            this.lblBreed.Name = "lblBreed";
            this.lblBreed.Size = new System.Drawing.Size(48, 20);
            this.lblBreed.TabIndex = 9;
            this.lblBreed.Text = "Breed";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(53, 102);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(46, 20);
            this.lblDOB.TabIndex = 8;
            this.lblDOB.Text = "D.O.B";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(50, 50);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 20);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Name";
            // 
            // btnRegisterDog
            // 
            this.btnRegisterDog.Location = new System.Drawing.Point(372, 259);
            this.btnRegisterDog.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRegisterDog.Name = "btnRegisterDog";
            this.btnRegisterDog.Size = new System.Drawing.Size(143, 31);
            this.btnRegisterDog.TabIndex = 8;
            this.btnRegisterDog.Text = "Register Dog";
            this.btnRegisterDog.UseVisualStyleBackColor = true;
            this.btnRegisterDog.Click += new System.EventHandler(this.btnRegisterDog_Click);
            // 
            // txtColour
            // 
            this.txtColour.Location = new System.Drawing.Point(590, 47);
            this.txtColour.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtColour.Name = "txtColour";
            this.txtColour.Size = new System.Drawing.Size(135, 27);
            this.txtColour.TabIndex = 5;
            // 
            // txtBreed
            // 
            this.txtBreed.Location = new System.Drawing.Point(120, 147);
            this.txtBreed.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBreed.Name = "txtBreed";
            this.txtBreed.Size = new System.Drawing.Size(227, 27);
            this.txtBreed.TabIndex = 3;
            // 
            // txtPetName
            // 
            this.txtPetName.Location = new System.Drawing.Point(120, 47);
            this.txtPetName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPetName.MaxLength = 12;
            this.txtPetName.Name = "txtPetName";
            this.txtPetName.Size = new System.Drawing.Size(197, 27);
            this.txtPetName.TabIndex = 1;
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.lblLastName);
            this.grpSearch.Controls.Add(this.btnSearch);
            this.grpSearch.Controls.Add(this.txtName);
            this.grpSearch.Location = new System.Drawing.Point(14, 55);
            this.grpSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpSearch.Size = new System.Drawing.Size(275, 189);
            this.grpSearch.TabIndex = 22;
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
            this.txtName.Location = new System.Drawing.Point(107, 63);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(146, 27);
            this.txtName.TabIndex = 19;
            // 
            // grdAccounts
            // 
            this.grdAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAccounts.Location = new System.Drawing.Point(323, 57);
            this.grdAccounts.Name = "grdAccounts";
            this.grdAccounts.RowHeadersWidth = 51;
            this.grdAccounts.RowTemplate.Height = 29;
            this.grdAccounts.Size = new System.Drawing.Size(578, 188);
            this.grdAccounts.TabIndex = 23;
            this.grdAccounts.Visible = false;
            this.grdAccounts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdAccounts_CellClick);
            // 
            // frmRegisterDog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 587);
            this.Controls.Add(this.grdAccounts);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.grpDogDetails);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmRegisterDog";
            this.Text = "Doggy Day Care - [Register Dog]";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmRegisterDog_FormClosed);
            this.Load += new System.EventHandler(this.frmRegisterDog_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpDogDetails.ResumeLayout(false);
            this.grpDogDetails.PerformLayout();
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAccounts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuHme;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.GroupBox grpDogDetails;
        private System.Windows.Forms.Button btnRegisterDog;
        private System.Windows.Forms.TextBox txtColour;
        private System.Windows.Forms.TextBox txtBreed;
        private System.Windows.Forms.TextBox txtPetName;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblColour;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblBreed;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DataGridView grdAccounts;
        private System.Windows.Forms.Label lblNeutered;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCustID;
        private System.Windows.Forms.ComboBox cmboSize;
        private System.Windows.Forms.ComboBox cmboNeutered;
        private System.Windows.Forms.ComboBox cmboSex;
        private System.Windows.Forms.DateTimePicker dtpDOB;
    }
}