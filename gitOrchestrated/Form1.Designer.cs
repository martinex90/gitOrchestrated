namespace gitOrchestrated
{
    partial class Form1
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
            this.btn_submit = new System.Windows.Forms.Button();
            this.tbVMName = new System.Windows.Forms.TextBox();
            this.tbTemplateVer = new System.Windows.Forms.TextBox();
            this.tbWinVer = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(15, 808);
            this.btn_submit.Margin = new System.Windows.Forms.Padding(6);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(150, 44);
            this.btn_submit.TabIndex = 0;
            this.btn_submit.Text = "Open";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.Btn_submit_Click);
            // 
            // tbVMName
            // 
            this.tbVMName.Location = new System.Drawing.Point(21, 41);
            this.tbVMName.Name = "tbVMName";
            this.tbVMName.Size = new System.Drawing.Size(196, 31);
            this.tbVMName.TabIndex = 1;
            // 
            // tbTemplateVer
            // 
            this.tbTemplateVer.Location = new System.Drawing.Point(21, 91);
            this.tbTemplateVer.Name = "tbTemplateVer";
            this.tbTemplateVer.Size = new System.Drawing.Size(196, 31);
            this.tbTemplateVer.TabIndex = 2;
            // 
            // tbWinVer
            // 
            this.tbWinVer.Location = new System.Drawing.Point(21, 142);
            this.tbWinVer.Name = "tbWinVer";
            this.tbWinVer.Size = new System.Drawing.Size(196, 31);
            this.tbWinVer.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbVMName);
            this.panel1.Controls.Add(this.tbWinVer);
            this.panel1.Controls.Add(this.tbTemplateVer);
            this.panel1.Location = new System.Drawing.Point(15, 121);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 503);
            this.panel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::gitOrchestrated.Properties.Resources.GreenPlus;
            this.pictureBox1.Location = new System.Drawing.Point(15, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 891);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_submit);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.TextBox tbVMName;
        private System.Windows.Forms.TextBox tbTemplateVer;
        private System.Windows.Forms.TextBox tbWinVer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

