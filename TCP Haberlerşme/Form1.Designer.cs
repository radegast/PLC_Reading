namespace TCP_Haberlerşme
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BtnBaglan = new System.Windows.Forms.Button();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.lbl7 = new System.Windows.Forms.Label();
            this.lbl8 = new System.Windows.Forms.Label();
            this.lbl9 = new System.Windows.Forms.Label();
            this.userControl11 = new TCP_Haberlerşme.UserControl1();
            this.LblBaglandi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "PLC Test - Özveri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "PLC IP Adresi:";
            // 
            // txtIP
            // 
            this.txtIP.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIP.Location = new System.Drawing.Point(164, 60);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(141, 30);
            this.txtIP.TabIndex = 2;
            this.txtIP.Text = "192.168.0.10";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Port: (def:502)";
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // BtnBaglan
            // 
            this.BtnBaglan.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnBaglan.ForeColor = System.Drawing.Color.Green;
            this.BtnBaglan.Location = new System.Drawing.Point(311, 59);
            this.BtnBaglan.Name = "BtnBaglan";
            this.BtnBaglan.Size = new System.Drawing.Size(137, 34);
            this.BtnBaglan.TabIndex = 10;
            this.BtnBaglan.Text = "Bağlan";
            this.BtnBaglan.UseVisualStyleBackColor = true;
            this.BtnBaglan.Click += new System.EventHandler(this.BtnBaglan_Click);
            // 
            // txtPort
            // 
            this.txtPort.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPort.Location = new System.Drawing.Point(164, 99);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(61, 30);
            this.txtPort.TabIndex = 43;
            this.txtPort.Text = "502";
            // 
            // lbl1
            // 
            this.lbl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lbl1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbl1.Location = new System.Drawing.Point(98, 162);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(82, 64);
            this.lbl1.TabIndex = 45;
            this.lbl1.Text = "1";
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl2
            // 
            this.lbl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lbl2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbl2.Location = new System.Drawing.Point(186, 162);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(82, 64);
            this.lbl2.TabIndex = 46;
            this.lbl2.Text = "2";
            this.lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl3
            // 
            this.lbl3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lbl3.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbl3.Location = new System.Drawing.Point(274, 162);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(82, 64);
            this.lbl3.TabIndex = 47;
            this.lbl3.Text = "3";
            this.lbl3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl4
            // 
            this.lbl4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lbl4.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbl4.Location = new System.Drawing.Point(98, 232);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(82, 64);
            this.lbl4.TabIndex = 48;
            this.lbl4.Text = "4";
            this.lbl4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl5
            // 
            this.lbl5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl5.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lbl5.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbl5.Location = new System.Drawing.Point(186, 232);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(82, 64);
            this.lbl5.TabIndex = 49;
            this.lbl5.Text = "5";
            this.lbl5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl6
            // 
            this.lbl6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl6.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lbl6.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbl6.Location = new System.Drawing.Point(274, 232);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(82, 64);
            this.lbl6.TabIndex = 50;
            this.lbl6.Text = "6";
            this.lbl6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl7
            // 
            this.lbl7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl7.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lbl7.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbl7.Location = new System.Drawing.Point(98, 305);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(82, 64);
            this.lbl7.TabIndex = 51;
            this.lbl7.Text = "7";
            this.lbl7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl8
            // 
            this.lbl8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl8.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lbl8.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbl8.Location = new System.Drawing.Point(186, 305);
            this.lbl8.Name = "lbl8";
            this.lbl8.Size = new System.Drawing.Size(82, 64);
            this.lbl8.TabIndex = 52;
            this.lbl8.Text = "8";
            this.lbl8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl9
            // 
            this.lbl9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl9.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lbl9.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbl9.Location = new System.Drawing.Point(274, 305);
            this.lbl9.Name = "lbl9";
            this.lbl9.Size = new System.Drawing.Size(82, 64);
            this.lbl9.TabIndex = 53;
            this.lbl9.Text = "9";
            this.lbl9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(730, 654);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(69, 45);
            this.userControl11.TabIndex = 44;
            // 
            // LblBaglandi
            // 
            this.LblBaglandi.AutoSize = true;
            this.LblBaglandi.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblBaglandi.ForeColor = System.Drawing.Color.Green;
            this.LblBaglandi.Location = new System.Drawing.Point(332, 104);
            this.LblBaglandi.Name = "LblBaglandi";
            this.LblBaglandi.Size = new System.Drawing.Size(93, 25);
            this.LblBaglandi.TabIndex = 54;
            this.LblBaglandi.Text = "Bağlandı";
            this.LblBaglandi.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 407);
            this.Controls.Add(this.LblBaglandi);
            this.Controls.Add(this.lbl9);
            this.Controls.Add(this.lbl8);
            this.Controls.Add(this.lbl7);
            this.Controls.Add(this.lbl6);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.BtnBaglan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GMTCNT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button BtnBaglan;
        private System.Windows.Forms.TextBox txtPort;
        private UserControl1 userControl11;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.Label lbl8;
        private System.Windows.Forms.Label lbl9;
        private System.Windows.Forms.Label LblBaglandi;
    }
}

