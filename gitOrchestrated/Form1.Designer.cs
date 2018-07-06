namespace gitOrchestrated
{
    partial class chbTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(chbTest));
            this.boxVDCName = new System.Windows.Forms.TextBox();
            this.boxVMName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.boxTemplateVer = new System.Windows.Forms.ComboBox();
            this.boxWinVersion = new System.Windows.Forms.ComboBox();
            this.boxWinEdition = new System.Windows.Forms.ComboBox();
            this.boxCPUno = new System.Windows.Forms.ComboBox();
            this.boxRAM = new System.Windows.Forms.ComboBox();
            this.boxADJoin = new System.Windows.Forms.ComboBox();
            this.boxOrgNetName = new System.Windows.Forms.TextBox();
            this.boxIPAdd = new System.Windows.Forms.TextBox();
            this.boxDNS1 = new System.Windows.Forms.TextBox();
            this.boxDNS2 = new System.Windows.Forms.TextBox();
            this.boxEPProtection = new System.Windows.Forms.ComboBox();
            this.lblTemplateVersion = new System.Windows.Forms.Label();
            this.lblVMName = new System.Windows.Forms.Label();
            this.lblVDCName = new System.Windows.Forms.Label();
            this.lblWinVer = new System.Windows.Forms.Label();
            this.lblWinEdition = new System.Windows.Forms.Label();
            this.lblCPUno = new System.Windows.Forms.Label();
            this.lblRAM = new System.Windows.Forms.Label();
            this.lblADJoin = new System.Windows.Forms.Label();
            this.lblOrgNetName = new System.Windows.Forms.Label();
            this.lblIPAdd = new System.Windows.Forms.Label();
            this.lblDNS1 = new System.Windows.Forms.Label();
            this.lblDNS2 = new System.Windows.Forms.Label();
            this.lblEPProtection = new System.Windows.Forms.Label();
            this.btnBuild = new System.Windows.Forms.PictureBox();
            this.btnAddPanel = new System.Windows.Forms.PictureBox();
            this.lblAddPanel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Label();
            this.checkBoxTest = new System.Windows.Forms.CheckBox();
            this.btnImport = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuild)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnImport)).BeginInit();
            this.SuspendLayout();
            // 
            // boxVDCName
            // 
            this.boxVDCName.Location = new System.Drawing.Point(0, 0);
            this.boxVDCName.Margin = new System.Windows.Forms.Padding(2);
            this.boxVDCName.Name = "boxVDCName";
            this.boxVDCName.Size = new System.Drawing.Size(129, 20);
            this.boxVDCName.TabIndex = 1;
            this.boxVDCName.Text = "TDCHCXT-VDC02";
            // 
            // boxVMName
            // 
            this.boxVMName.Location = new System.Drawing.Point(0, 26);
            this.boxVMName.Margin = new System.Windows.Forms.Padding(2);
            this.boxVMName.Name = "boxVMName";
            this.boxVMName.Size = new System.Drawing.Size(129, 20);
            this.boxVMName.TabIndex = 2;
            this.boxVMName.Text = "mape2016";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.boxVDCName);
            this.panel1.Controls.Add(this.boxVMName);
            this.panel1.Controls.Add(this.boxTemplateVer);
            this.panel1.Controls.Add(this.boxWinVersion);
            this.panel1.Controls.Add(this.boxWinEdition);
            this.panel1.Controls.Add(this.boxCPUno);
            this.panel1.Controls.Add(this.boxRAM);
            this.panel1.Controls.Add(this.boxADJoin);
            this.panel1.Controls.Add(this.boxOrgNetName);
            this.panel1.Controls.Add(this.boxIPAdd);
            this.panel1.Controls.Add(this.boxDNS1);
            this.panel1.Controls.Add(this.boxDNS2);
            this.panel1.Controls.Add(this.boxEPProtection);
            this.panel1.Location = new System.Drawing.Point(92, 50);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(129, 333);
            this.panel1.TabIndex = 4;
            // 
            // boxTemplateVer
            // 
            this.boxTemplateVer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxTemplateVer.FormattingEnabled = true;
            this.boxTemplateVer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.boxTemplateVer.Items.AddRange(new object[] {
            "Current",
            "Test",
            "Old"});
            this.boxTemplateVer.Location = new System.Drawing.Point(0, 52);
            this.boxTemplateVer.Name = "boxTemplateVer";
            this.boxTemplateVer.Size = new System.Drawing.Size(129, 21);
            this.boxTemplateVer.TabIndex = 3;
            // 
            // boxWinVersion
            // 
            this.boxWinVersion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxWinVersion.FormattingEnabled = true;
            this.boxWinVersion.Items.AddRange(new object[] {
            "Windows2008Standard",
            "Windows2008Enterprise",
            "Windows2008Datacenter",
            "Windows2008x64Standard",
            "Windows2008x64Enterprise",
            "Windows2008x64Datacenter",
            "Windows2008R2",
            "Windows2012",
            "Windows2012R2",
            "Windows2016",
            "Windows2019"});
            this.boxWinVersion.Location = new System.Drawing.Point(0, 78);
            this.boxWinVersion.Name = "boxWinVersion";
            this.boxWinVersion.Size = new System.Drawing.Size(129, 21);
            this.boxWinVersion.TabIndex = 4;
            // 
            // boxWinEdition
            // 
            this.boxWinEdition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxWinEdition.FormattingEnabled = true;
            this.boxWinEdition.Items.AddRange(new object[] {
            "Standard",
            "Datacenter",
            "Enterprise"});
            this.boxWinEdition.Location = new System.Drawing.Point(0, 104);
            this.boxWinEdition.Name = "boxWinEdition";
            this.boxWinEdition.Size = new System.Drawing.Size(129, 21);
            this.boxWinEdition.TabIndex = 5;
            // 
            // boxCPUno
            // 
            this.boxCPUno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxCPUno.FormattingEnabled = true;
            this.boxCPUno.Items.AddRange(new object[] {
            "1.0",
            "2.0",
            "3.0",
            "4.0",
            "5.0",
            "6.0",
            "7.0",
            "8.0",
            "9.0",
            "10.0",
            "11.0",
            "12.0",
            "13.0",
            "14.0",
            "15.0",
            "16.0"});
            this.boxCPUno.Location = new System.Drawing.Point(0, 130);
            this.boxCPUno.Name = "boxCPUno";
            this.boxCPUno.Size = new System.Drawing.Size(129, 21);
            this.boxCPUno.TabIndex = 6;
            // 
            // boxRAM
            // 
            this.boxRAM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxRAM.FormattingEnabled = true;
            this.boxRAM.Items.AddRange(new object[] {
            "1.0",
            "2.0",
            "3.0",
            "4.0",
            "5.0",
            "6.0",
            "7.0",
            "8.0",
            "9.0",
            "10.0",
            "11.0",
            "12.0",
            "13.0",
            "14.0",
            "15.0",
            "16.0",
            "17.0",
            "18.0",
            "19.0",
            "20.0",
            "21.0",
            "22.0",
            "23.0",
            "24.0"});
            this.boxRAM.Location = new System.Drawing.Point(0, 156);
            this.boxRAM.Name = "boxRAM";
            this.boxRAM.Size = new System.Drawing.Size(129, 21);
            this.boxRAM.TabIndex = 7;
            // 
            // boxADJoin
            // 
            this.boxADJoin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxADJoin.FormattingEnabled = true;
            this.boxADJoin.Items.AddRange(new object[] {
            "yes",
            "no"});
            this.boxADJoin.Location = new System.Drawing.Point(0, 182);
            this.boxADJoin.Name = "boxADJoin";
            this.boxADJoin.Size = new System.Drawing.Size(129, 21);
            this.boxADJoin.TabIndex = 8;
            // 
            // boxOrgNetName
            // 
            this.boxOrgNetName.Location = new System.Drawing.Point(0, 208);
            this.boxOrgNetName.Name = "boxOrgNetName";
            this.boxOrgNetName.Size = new System.Drawing.Size(129, 20);
            this.boxOrgNetName.TabIndex = 9;
            this.boxOrgNetName.Text = "TDCHCXT_PZ_IND2";
            // 
            // boxIPAdd
            // 
            this.boxIPAdd.Location = new System.Drawing.Point(0, 234);
            this.boxIPAdd.Name = "boxIPAdd";
            this.boxIPAdd.Size = new System.Drawing.Size(129, 20);
            this.boxIPAdd.TabIndex = 10;
            this.boxIPAdd.Text = "10.0.1.50";
            // 
            // boxDNS1
            // 
            this.boxDNS1.Location = new System.Drawing.Point(0, 260);
            this.boxDNS1.Name = "boxDNS1";
            this.boxDNS1.Size = new System.Drawing.Size(129, 20);
            this.boxDNS1.TabIndex = 11;
            this.boxDNS1.Text = "10.0.1.10";
            // 
            // boxDNS2
            // 
            this.boxDNS2.Location = new System.Drawing.Point(0, 286);
            this.boxDNS2.Name = "boxDNS2";
            this.boxDNS2.Size = new System.Drawing.Size(129, 20);
            this.boxDNS2.TabIndex = 12;
            this.boxDNS2.Text = "10.0.1.11";
            // 
            // boxEPProtection
            // 
            this.boxEPProtection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxEPProtection.FormattingEnabled = true;
            this.boxEPProtection.Items.AddRange(new object[] {
            "yes",
            "no"});
            this.boxEPProtection.Location = new System.Drawing.Point(0, 312);
            this.boxEPProtection.Name = "boxEPProtection";
            this.boxEPProtection.Size = new System.Drawing.Size(129, 21);
            this.boxEPProtection.TabIndex = 13;
            // 
            // lblTemplateVersion
            // 
            this.lblTemplateVersion.AutoSize = true;
            this.lblTemplateVersion.BackColor = System.Drawing.Color.Transparent;
            this.lblTemplateVersion.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTemplateVersion.Location = new System.Drawing.Point(5, 105);
            this.lblTemplateVersion.Name = "lblTemplateVersion";
            this.lblTemplateVersion.Size = new System.Drawing.Size(86, 13);
            this.lblTemplateVersion.TabIndex = 6;
            this.lblTemplateVersion.Text = "TemplateVersion";
            // 
            // lblVMName
            // 
            this.lblVMName.AutoSize = true;
            this.lblVMName.BackColor = System.Drawing.Color.Transparent;
            this.lblVMName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblVMName.Location = new System.Drawing.Point(5, 79);
            this.lblVMName.Name = "lblVMName";
            this.lblVMName.Size = new System.Drawing.Size(51, 13);
            this.lblVMName.TabIndex = 5;
            this.lblVMName.Text = "VMName";
            // 
            // lblVDCName
            // 
            this.lblVDCName.AutoSize = true;
            this.lblVDCName.BackColor = System.Drawing.Color.Transparent;
            this.lblVDCName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblVDCName.Location = new System.Drawing.Point(5, 53);
            this.lblVDCName.Name = "lblVDCName";
            this.lblVDCName.Size = new System.Drawing.Size(57, 13);
            this.lblVDCName.TabIndex = 4;
            this.lblVDCName.Text = "VDCName";
            // 
            // lblWinVer
            // 
            this.lblWinVer.AutoSize = true;
            this.lblWinVer.BackColor = System.Drawing.Color.Transparent;
            this.lblWinVer.ForeColor = System.Drawing.SystemColors.Control;
            this.lblWinVer.Location = new System.Drawing.Point(5, 131);
            this.lblWinVer.Name = "lblWinVer";
            this.lblWinVer.Size = new System.Drawing.Size(61, 13);
            this.lblWinVer.TabIndex = 7;
            this.lblWinVer.Text = "WinVersion";
            // 
            // lblWinEdition
            // 
            this.lblWinEdition.AutoSize = true;
            this.lblWinEdition.BackColor = System.Drawing.Color.Transparent;
            this.lblWinEdition.ForeColor = System.Drawing.SystemColors.Control;
            this.lblWinEdition.Location = new System.Drawing.Point(5, 158);
            this.lblWinEdition.Name = "lblWinEdition";
            this.lblWinEdition.Size = new System.Drawing.Size(58, 13);
            this.lblWinEdition.TabIndex = 8;
            this.lblWinEdition.Text = "WinEdition";
            // 
            // lblCPUno
            // 
            this.lblCPUno.AutoSize = true;
            this.lblCPUno.BackColor = System.Drawing.Color.Transparent;
            this.lblCPUno.ForeColor = System.Drawing.SystemColors.Control;
            this.lblCPUno.Location = new System.Drawing.Point(5, 183);
            this.lblCPUno.Name = "lblCPUno";
            this.lblCPUno.Size = new System.Drawing.Size(41, 13);
            this.lblCPUno.TabIndex = 9;
            this.lblCPUno.Text = "CPUno";
            // 
            // lblRAM
            // 
            this.lblRAM.AutoSize = true;
            this.lblRAM.BackColor = System.Drawing.Color.Transparent;
            this.lblRAM.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRAM.Location = new System.Drawing.Point(5, 209);
            this.lblRAM.Name = "lblRAM";
            this.lblRAM.Size = new System.Drawing.Size(31, 13);
            this.lblRAM.TabIndex = 10;
            this.lblRAM.Text = "RAM";
            // 
            // lblADJoin
            // 
            this.lblADJoin.AutoSize = true;
            this.lblADJoin.BackColor = System.Drawing.Color.Transparent;
            this.lblADJoin.ForeColor = System.Drawing.SystemColors.Control;
            this.lblADJoin.Location = new System.Drawing.Point(5, 235);
            this.lblADJoin.Name = "lblADJoin";
            this.lblADJoin.Size = new System.Drawing.Size(41, 13);
            this.lblADJoin.TabIndex = 11;
            this.lblADJoin.Text = "ADJoin";
            // 
            // lblOrgNetName
            // 
            this.lblOrgNetName.AutoSize = true;
            this.lblOrgNetName.BackColor = System.Drawing.Color.Transparent;
            this.lblOrgNetName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblOrgNetName.Location = new System.Drawing.Point(5, 261);
            this.lblOrgNetName.Name = "lblOrgNetName";
            this.lblOrgNetName.Size = new System.Drawing.Size(69, 13);
            this.lblOrgNetName.TabIndex = 12;
            this.lblOrgNetName.Text = "OrgNetName";
            // 
            // lblIPAdd
            // 
            this.lblIPAdd.AutoSize = true;
            this.lblIPAdd.BackColor = System.Drawing.Color.Transparent;
            this.lblIPAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.lblIPAdd.Location = new System.Drawing.Point(5, 287);
            this.lblIPAdd.Name = "lblIPAdd";
            this.lblIPAdd.Size = new System.Drawing.Size(36, 13);
            this.lblIPAdd.TabIndex = 13;
            this.lblIPAdd.Text = "IPAdd";
            // 
            // lblDNS1
            // 
            this.lblDNS1.AutoSize = true;
            this.lblDNS1.BackColor = System.Drawing.Color.Transparent;
            this.lblDNS1.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDNS1.Location = new System.Drawing.Point(5, 313);
            this.lblDNS1.Name = "lblDNS1";
            this.lblDNS1.Size = new System.Drawing.Size(36, 13);
            this.lblDNS1.TabIndex = 14;
            this.lblDNS1.Text = "DNS1";
            // 
            // lblDNS2
            // 
            this.lblDNS2.AutoSize = true;
            this.lblDNS2.BackColor = System.Drawing.Color.Transparent;
            this.lblDNS2.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDNS2.Location = new System.Drawing.Point(5, 339);
            this.lblDNS2.Name = "lblDNS2";
            this.lblDNS2.Size = new System.Drawing.Size(36, 13);
            this.lblDNS2.TabIndex = 15;
            this.lblDNS2.Text = "DNS2";
            // 
            // lblEPProtection
            // 
            this.lblEPProtection.AutoSize = true;
            this.lblEPProtection.BackColor = System.Drawing.Color.Transparent;
            this.lblEPProtection.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEPProtection.Location = new System.Drawing.Point(5, 365);
            this.lblEPProtection.Name = "lblEPProtection";
            this.lblEPProtection.Size = new System.Drawing.Size(69, 13);
            this.lblEPProtection.TabIndex = 16;
            this.lblEPProtection.Text = "EPProtection";
            // 
            // btnBuild
            // 
            this.btnBuild.BackColor = System.Drawing.Color.Transparent;
            this.btnBuild.Image = global::gitOrchestrated.Properties.Resources.brick;
            this.btnBuild.Location = new System.Drawing.Point(3, 397);
            this.btnBuild.Name = "btnBuild";
            this.btnBuild.Size = new System.Drawing.Size(46, 46);
            this.btnBuild.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBuild.TabIndex = 17;
            this.btnBuild.TabStop = false;
            this.btnBuild.Click += new System.EventHandler(this.btnBuild_click);
            this.btnBuild.MouseEnter += new System.EventHandler(this.btnBuild_Enter);
            this.btnBuild.MouseLeave += new System.EventHandler(this.btnBuild_Leave);
            // 
            // btnAddPanel
            // 
            this.btnAddPanel.BackColor = System.Drawing.Color.Transparent;
            this.btnAddPanel.Image = global::gitOrchestrated.Properties.Resources.GreenPlus;
            this.btnAddPanel.Location = new System.Drawing.Point(3, 1);
            this.btnAddPanel.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddPanel.Name = "btnAddPanel";
            this.btnAddPanel.Size = new System.Drawing.Size(46, 46);
            this.btnAddPanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAddPanel.TabIndex = 5;
            this.btnAddPanel.TabStop = false;
            this.btnAddPanel.Click += new System.EventHandler(this.btnAddPanel_Click);
            this.btnAddPanel.MouseEnter += new System.EventHandler(this.btnAddPanel_Enter);
            this.btnAddPanel.MouseLeave += new System.EventHandler(this.btnAddPanelLeave);
            // 
            // lblAddPanel
            // 
            this.lblAddPanel.AutoSize = true;
            this.lblAddPanel.BackColor = System.Drawing.Color.Transparent;
            this.lblAddPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddPanel.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAddPanel.Location = new System.Drawing.Point(52, 13);
            this.lblAddPanel.Name = "lblAddPanel";
            this.lblAddPanel.Size = new System.Drawing.Size(93, 22);
            this.lblAddPanel.TabIndex = 18;
            this.lblAddPanel.Text = "Add Panel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(51, 409);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 22);
            this.label1.TabIndex = 19;
            this.label1.Text = "Build Server";
            // 
            // btnLogin
            // 
            this.btnLogin.AutoSize = true;
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLogin.Location = new System.Drawing.Point(207, 1);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(42, 16);
            this.btnLogin.TabIndex = 21;
            this.btnLogin.Text = "login";
            this.btnLogin.Click += new System.EventHandler(this.btnlogin_Click);
            this.btnLogin.MouseEnter += new System.EventHandler(this.btnLogin_Enter);
            this.btnLogin.MouseLeave += new System.EventHandler(this.btnLogin_Leave);
            // 
            // checkBoxTest
            // 
            this.checkBoxTest.AutoSize = true;
            this.checkBoxTest.Checked = true;
            this.checkBoxTest.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxTest.Location = new System.Drawing.Point(201, 433);
            this.checkBoxTest.Name = "checkBoxTest";
            this.checkBoxTest.Size = new System.Drawing.Size(53, 17);
            this.checkBoxTest.TabIndex = 22;
            this.checkBoxTest.Text = "Test?";
            this.checkBoxTest.UseVisualStyleBackColor = true;
            // 
            // btnImport
            // 
            this.btnImport.Image = global::gitOrchestrated.Properties.Resources.GreenPlus;
            this.btnImport.Location = new System.Drawing.Point(151, 2);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(46, 46);
            this.btnImport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnImport.TabIndex = 23;
            this.btnImport.TabStop = false;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // chbTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::gitOrchestrated.Properties.Resources.blueswirl;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(255, 451);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.checkBoxTest);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAddPanel);
            this.Controls.Add(this.btnBuild);
            this.Controls.Add(this.lblEPProtection);
            this.Controls.Add(this.lblDNS2);
            this.Controls.Add(this.lblDNS1);
            this.Controls.Add(this.lblIPAdd);
            this.Controls.Add(this.lblOrgNetName);
            this.Controls.Add(this.lblADJoin);
            this.Controls.Add(this.lblRAM);
            this.Controls.Add(this.lblCPUno);
            this.Controls.Add(this.lblWinEdition);
            this.Controls.Add(this.lblWinVer);
            this.Controls.Add(this.btnAddPanel);
            this.Controls.Add(this.lblTemplateVersion);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblVMName);
            this.Controls.Add(this.lblVDCName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "chbTest";
            this.Text = "gitOrchestrated";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuild)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnImport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.TextBox boxVDCName;
        private System.Windows.Forms.TextBox boxVMName;
        internal System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnAddPanel;
        private System.Windows.Forms.Label lblVMName;
        private System.Windows.Forms.Label lblVDCName;
        private System.Windows.Forms.Label lblTemplateVersion;
        private System.Windows.Forms.ComboBox boxTemplateVer;
        private System.Windows.Forms.TextBox boxOrgNetName;
        private System.Windows.Forms.Label lblWinVer;
        private System.Windows.Forms.Label lblWinEdition;
        private System.Windows.Forms.Label lblCPUno;
        private System.Windows.Forms.Label lblRAM;
        private System.Windows.Forms.Label lblADJoin;
        private System.Windows.Forms.Label lblOrgNetName;
        private System.Windows.Forms.Label lblIPAdd;
        private System.Windows.Forms.Label lblDNS1;
        private System.Windows.Forms.Label lblDNS2;
        private System.Windows.Forms.Label lblEPProtection;
        private System.Windows.Forms.ComboBox boxWinVersion;
        private System.Windows.Forms.TextBox boxIPAdd;
        private System.Windows.Forms.ComboBox boxRAM;
        private System.Windows.Forms.ComboBox boxCPUno;
        private System.Windows.Forms.ComboBox boxWinEdition;
        private System.Windows.Forms.ComboBox boxEPProtection;
        private System.Windows.Forms.TextBox boxDNS2;
        private System.Windows.Forms.TextBox boxDNS1;
        private System.Windows.Forms.ComboBox boxADJoin;
        private System.Windows.Forms.PictureBox btnBuild;
        private System.Windows.Forms.Label lblAddPanel;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label btnLogin;
        private System.Windows.Forms.CheckBox checkBoxTest;
        private System.Windows.Forms.PictureBox btnImport;
    }
}

