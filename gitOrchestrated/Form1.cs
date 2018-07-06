using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace gitOrchestrated
{
    public partial class chbTest : Form
    {

        public chbTest()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

 

        private void btnBuild_click(object sender, EventArgs e)
        {
            if (Credential.Username == null || Credential.Username == "")
            {
                MessageBox.Show("Invalid Username.");
                return;
            }

            foreach (Control panelctrl in this.Controls)
            {

                if (panelctrl is Panel)
                {
                    int i = 0;
                    
                    Server server = new Server();

                    foreach (Control boxctrl in panelctrl.Controls)
                    {
                        switch (i)
                        {
                            case 0:
                                server.VDCName = boxctrl.Text;
                                break;
                            case 1:
                                server.VMName = boxctrl.Text;
                                break;
                            case 2:
                                server.TemplateVer = boxctrl.Text;
                                break;
                            case 3:
                                server.WinVer = boxctrl.Text;
                                break;
                            case 4:
                                server.WinEdition = boxctrl.Text;
                                break;
                            case 5:
                                server.CPUNo = boxctrl.Text;
                                break;
                            case 6:
                                server.RAM = boxctrl.Text;
                                break;
                            case 7:
                                server.ADJoin = boxctrl.Text;
                                break;
                            case 8:
                                server.OrgNetworkName = boxctrl.Text;
                                break;
                            case 9:
                                server.IPAdd = boxctrl.Text;
                                break;
                            case 10:
                                server.DNS1 = boxctrl.Text;
                                break;
                            case 11:
                                server.DNS2 = boxctrl.Text;
                                break;
                            case 12:
                                server.EndpointProtection = boxctrl.Text;
                                break;
                        }//switch

                        i++;
                    }//foreach box

                    Browser bowser = new Browser(server);

                    new Thread(() =>
                    {
                        Thread.CurrentThread.IsBackground = true;
                        bowser.AutomateInput(checkBoxTest);
                    }).Start();

                }//if panel
            }//foreach panel
        }//btnBuild.Click()

        private void btnBuild_Enter(object sender, EventArgs e)
        {
            btnBuild.Image = Properties.Resources.selectedbrick;
        }

        private void btnBuild_Leave(object sender, EventArgs e)
        {
            btnBuild.Image = Properties.Resources.brick;
        }


        private void btnAddPanel_Click(object sender, EventArgs e)
        {
            CustomPanel pn = new CustomPanel(this);
            pn.CopyFromOriginalPanel();
        }

        private void btnAddPanel_Enter(object sender, EventArgs e)
        {
            btnAddPanel.Image = Properties.Resources.selectedGreenPlus;
        }

        private void btnAddPanelLeave(object sender, EventArgs e)
        {
            btnAddPanel.Image = Properties.Resources.GreenPlus;

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
             
            Form2 f2 = new Form2();
            f2.Owner = this;
            f2.ShowDialog();

            if (f2.LoginResult == "Success")
                btnLogin.Text = Credential.Username;
            if (f2.LoginResult == "Failed")
                btnLogin.Text = "Failed";

        }

        private void btnLogin_Enter(object sender, EventArgs e)
        {
            btnLogin.ForeColor = SystemColors.ButtonShadow;
        }

        private void btnLogin_Leave(object sender, EventArgs e)
        {
            btnLogin.ForeColor = SystemColors.Control;
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            ExcelImport ei = new ExcelImport(@"C:\Users\mape\Documents\fanovand.xlsx");
            //MessageBox.Show(ei.ReadCell("B", 2));
            ei.ExcelImportServer(this);
        }
    }//Form1
}//gitOchestrated
