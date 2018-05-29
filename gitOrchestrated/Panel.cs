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
        public CustomPanel(Form1 form, string ID, int StartX, int StartY)
        {
            {
                this.tbVMName = new TextBox();
                this.tbTemplateVer = new TextBox();
                this.tbWinVer = new TextBox();
                pn = new Panel();
                // 
                // tbVMName
                // 
                this.tbVMName.Location = new System.Drawing.Point(21, 41);
                this.tbVMName.Name = "tbVVMName" + ID;
                this.tbVMName.Size = new System.Drawing.Size(196, 31);
                this.tbVMName.TabIndex = 1;
                // 
                // tbTemplateVer
                // 
                this.tbTemplateVer.Location = new System.Drawing.Point(21, 91);
                this.tbTemplateVer.Name = "tbTemplateVer" + ID;
                this.tbTemplateVer.Size = new System.Drawing.Size(196, 31);
                this.tbTemplateVer.TabIndex = 2;
                // 
                // tbWinVer
                // 
                this.tbWinVer.Location = new System.Drawing.Point(21, 142);
                this.tbWinVer.Name = "tbWinVer" + ID;
                this.tbWinVer.Size = new System.Drawing.Size(196, 31);
                this.tbWinVer.TabIndex = 3;
                // 
                // panel1
                // 
                pn.Controls.Add(this.tbVMName);
                pn.Controls.Add(this.tbWinVer);
                pn.Controls.Add(this.tbTemplateVer);
                pn.Location = new System.Drawing.Point(StartX, StartY);
                pn.Name = "panel" + ID;
                pn.Size = new System.Drawing.Size(243, 503);
                pn.TabIndex = 4;

                form.Controls.Add(this.pn);
                this.pn.PerformLayout();

            }
        }

        private System.Windows.Forms.TextBox tbVMName;
        private System.Windows.Forms.TextBox tbTemplateVer;
        private System.Windows.Forms.TextBox tbWinVer;
        private Panel pn;
    }

}

