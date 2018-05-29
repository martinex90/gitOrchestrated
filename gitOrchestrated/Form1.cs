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
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_submit_Click(object sender, EventArgs e)
        {
            
            Browser bowser = new Browser
            {

                VDCName = "TDCHCXT-VDC02",
                VMName = "mape2016",
                TemplateVer = "Test",
                WinVer = "Windows2016",
                WinEdition = "Standard",
                CPUNo = "2.0",
                RAM = "8.0",
                ADJoin = "yes",
                OrgNetworkName = "TDCHCXT_PZ_IND2",
                IPAdd = "10.0.1.45",
                DNS1 = "10.0.1.10",
                DNS2 = "10.0.1.11",
                EndpointProtection = "no"
            };

            bowser.AutomateInput();
            
        }//Btn_Submit_Click

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            CustomPanel pn = new CustomPanel(this, "1", 248, 113);
            TextBox txtbx1 = (TextBox)Controls["tbVVMName"];

        }
    }//Form1
}//gitOchestrated
