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
                    Browser bowser = new Browser();

                    foreach (Control boxctrl in panelctrl.Controls)
                    {
                        switch (i)
                        {
                            case 0:
                                bowser.VDCName = boxctrl.Text;
                                break;
                            case 1:
                                bowser.VMName = boxctrl.Text;
                                break;
                            case 2:
                                bowser.TemplateVer = boxctrl.Text;
                                break;
                            case 3:
                                bowser.WinVer = boxctrl.Text;
                                break;
                            case 4:
                                bowser.WinEdition = boxctrl.Text;
                                break;
                            case 5:
                                bowser.CPUNo = boxctrl.Text;
                                break;
                            case 6:
                                bowser.RAM = boxctrl.Text;
                                break;
                            case 7:
                                bowser.ADJoin = boxctrl.Text;
                                break;
                            case 8:
                                bowser.OrgNetworkName = boxctrl.Text;
                                break;
                            case 9:
                                bowser.IPAdd = boxctrl.Text;
                                break;
                            case 10:
                                bowser.DNS1 = boxctrl.Text;
                                break;
                            case 11:
                                bowser.DNS2 = boxctrl.Text;
                                break;
                            case 12:
                                bowser.EndpointProtection = boxctrl.Text;
                                break;
                        }//switch

                        i++;
                    }//foreach box

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

        private int ID = 1;
        private int X = 227;
        private void btnAddPanel_Click(object sender, EventArgs e)
        {
            CustomPanel pn = new CustomPanel(this, ID, X);
            ID++;
            X = X + 135;
            var x = this.Size.Width + 135;
            var y = this.Size.Height;
            this.Size = new Size(x, y);

            x = this.btnLogin.Location.X + 135;
            y = this.btnLogin.Location.Y;
            this.btnLogin.Location = new Point(x, y);
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
    }//Form1
}//gitOchestrated
