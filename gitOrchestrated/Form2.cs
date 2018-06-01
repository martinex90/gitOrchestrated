using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gitOrchestrated
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public string LoginResult { get; set; }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Credential.Username = textBox1.Text;
            Credential.Password = textBox2.Text;
            if (checkBox1.Checked == true)
            {
                Browser bws = new Browser();
                LoginResult = bws.VerifyLogin(Credential.Username, Credential.Password);
            }
            else
                LoginResult = "Success";

            this.Dispose();
        }
    }
}
