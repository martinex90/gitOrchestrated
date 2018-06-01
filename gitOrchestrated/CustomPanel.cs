using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gitOrchestrated
{
    class CustomPanel : Form
    {
        private TextBox boxVDCName = new TextBox();
        private TextBox boxVMName = new TextBox();
        private ComboBox boxTemplateVer = new ComboBox();
        private ComboBox boxWinVersion = new ComboBox();
        private ComboBox boxWinEdition = new ComboBox();
        private ComboBox boxCPUno = new ComboBox();
        private ComboBox boxRAM = new ComboBox();
        private ComboBox boxADJoin = new ComboBox();
        private ComboBox boxOrgNetName = new ComboBox();
        private TextBox boxIPAdd = new TextBox();
        private TextBox boxDNS1 = new TextBox();
        private TextBox boxDNS2 = new TextBox();
        private ComboBox boxEPProtection = new ComboBox();
        private PictureBox btnRemovePanel = new PictureBox();

        private Panel pn = new Panel();

        public CustomPanel(chbTest form, int ID, int StartX)
        {

            {
                // 
                // boxVDCName
                // 
                this.boxVDCName.Location = new System.Drawing.Point(0, 0);
                this.boxVDCName.Margin = new System.Windows.Forms.Padding(2);
                this.boxVDCName.Name = "boxVDCName";
                this.boxVDCName.Size = new System.Drawing.Size(129, 20);
                this.boxVDCName.TabIndex = 1;
                // 
                // boxVMName
                // 
                this.boxVMName.Location = new System.Drawing.Point(0, 26);
                this.boxVMName.Margin = new System.Windows.Forms.Padding(2);
                this.boxVMName.Name = "boxVMName";
                this.boxVMName.Size = new System.Drawing.Size(129, 20);
                this.boxVMName.TabIndex = 2;
                // 
                // boxTemplateVer
                // 
                this.boxTemplateVer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
                this.boxTemplateVer.FormattingEnabled = true;
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
                this.boxWinEdition.Size = new System.Drawing.Size(130, 21);
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
                // 
                // boxIPAdd
                // 
                this.boxIPAdd.Location = new System.Drawing.Point(0, 234);
                this.boxIPAdd.Name = "boxIPAdd";
                this.boxIPAdd.Size = new System.Drawing.Size(129, 20);
                this.boxIPAdd.TabIndex = 10;
                // 
                // boxDNS1
                // 
                this.boxDNS1.Location = new System.Drawing.Point(0, 260);
                this.boxDNS1.Name = "boxDNS1";
                this.boxDNS1.Size = new System.Drawing.Size(129, 20);
                this.boxDNS1.TabIndex = 11;
                // 
                // boxDNS2
                // 
                this.boxDNS2.Location = new System.Drawing.Point(0, 286);
                this.boxDNS2.Name = "boxDNS2";
                this.boxDNS2.Size = new System.Drawing.Size(129, 20);
                this.boxDNS2.TabIndex = 12;
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
                // btnRemovePanel
                //
                this.btnRemovePanel.BackColor = System.Drawing.Color.Transparent;
                this.btnRemovePanel.Image = global::gitOrchestrated.Properties.Resources.stopSign;
                this.btnRemovePanel.Location = new System.Drawing.Point(35, 336);
                this.btnRemovePanel.Margin = new System.Windows.Forms.Padding(2);
                this.btnRemovePanel.Name = "btnRemovePanel";
                this.btnRemovePanel.Size = new System.Drawing.Size(46, 46);
                this.btnRemovePanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                this.btnRemovePanel.TabIndex = 14;
                this.btnRemovePanel.TabStop = false;
                this.btnRemovePanel.Click += new System.EventHandler(this.btnRemovePanel_Click);
                this.btnRemovePanel.MouseEnter += new System.EventHandler(this.btnRemovePanel_Enter);
                this.btnRemovePanel.MouseLeave += new System.EventHandler(this.btnRemovePanelLeave);
                // 
                // panel1
                // 
                pn.Controls.Add(this.boxVDCName);
                pn.Controls.Add(this.boxVMName);
                pn.Controls.Add(this.boxTemplateVer);
                pn.Controls.Add(this.boxWinVersion);
                pn.Controls.Add(this.boxWinEdition);
                pn.Controls.Add(this.boxCPUno);
                pn.Controls.Add(this.boxRAM);
                pn.Controls.Add(this.boxADJoin);
                pn.Controls.Add(this.boxOrgNetName);
                pn.Controls.Add(this.boxIPAdd);
                pn.Controls.Add(this.boxDNS1);
                pn.Controls.Add(this.boxDNS2);
                pn.Controls.Add(this.boxEPProtection);
                pn.Controls.Add(this.btnRemovePanel);
                pn.BackColor = System.Drawing.Color.Transparent;
                pn.Location = new System.Drawing.Point(StartX, 50);
                pn.Name = "panel" + ID.ToString();
                pn.Size = new System.Drawing.Size(129,388);
                pn.TabIndex = 4;


                // This block of code first gets a collection of all controls in the initial panel.
                // Then it loops through all controls in the dynamically generated panel, and adds the values from the initial panel to the dynamic panel. 
                int i = 0;
                Control.ControlCollection fctrls = form.panel1.Controls;
                foreach(Control ctrl in pn.Controls)
                {
                    if (ctrl is TextBox)
                    {
                        TextBox tb = new TextBox();
                        tb = (TextBox)ctrl;
                        tb.Text = fctrls[i].Text;
                    }
                    if (ctrl is ComboBox)
                    {
                        ComboBox cb = new ComboBox();
                        cb = (ComboBox)ctrl;
                        cb.Text = fctrls[i].Text;
                    }

                    i++;
                }


                form.Controls.Add(this.pn);

            }
        }

        private void btnRemovePanelLeave(object sender, EventArgs e)
        {
            btnRemovePanel.Image = Properties.Resources.stopSign;
        }

        private void btnRemovePanel_Enter(object sender, EventArgs e)
        {

            btnRemovePanel.Image = Properties.Resources.selectedStopSign;
        }

        private void btnRemovePanel_Click(object sender, EventArgs e)
        {
            this.pn.Dispose();
        }
    }

}

