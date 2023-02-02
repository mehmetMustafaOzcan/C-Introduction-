namespace _2.soru
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chky5 = new System.Windows.Forms.CheckBox();
            this.chky10 = new System.Windows.Forms.CheckBox();
            this.chkYO10 = new System.Windows.Forms.CheckBox();
            this.txtUcret = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkYO10);
            this.groupBox1.Controls.Add(this.chky10);
            this.groupBox1.Controls.Add(this.chky5);
            this.groupBox1.Location = new System.Drawing.Point(45, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 225);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnHesapla);
            this.groupBox2.Controls.Add(this.lblSonuc);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtUcret);
            this.groupBox2.Location = new System.Drawing.Point(275, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 225);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // chky5
            // 
            this.chky5.AutoSize = true;
            this.chky5.Location = new System.Drawing.Point(50, 53);
            this.chky5.Name = "chky5";
            this.chky5.Size = new System.Drawing.Size(73, 17);
            this.chky5.TabIndex = 0;
            this.chky5.Text = "%5 İndirim";
            this.chky5.UseVisualStyleBackColor = true;
            // 
            // chky10
            // 
            this.chky10.AutoSize = true;
            this.chky10.Location = new System.Drawing.Point(50, 98);
            this.chky10.Name = "chky10";
            this.chky10.Size = new System.Drawing.Size(79, 17);
            this.chky10.TabIndex = 1;
            this.chky10.Text = "%10 İndirim";
            this.chky10.UseVisualStyleBackColor = true;
            // 
            // chkYO10
            // 
            this.chkYO10.AutoSize = true;
            this.chkYO10.Location = new System.Drawing.Point(50, 149);
            this.chkYO10.Name = "chkYO10";
            this.chkYO10.Size = new System.Drawing.Size(103, 17);
            this.chkYO10.TabIndex = 2;
            this.chkYO10.Text = "%10 Özel İndirim";
            this.chkYO10.UseVisualStyleBackColor = true;
            // 
            // txtUcret
            // 
            this.txtUcret.Location = new System.Drawing.Point(19, 62);
            this.txtUcret.Name = "txtUcret";
            this.txtUcret.Size = new System.Drawing.Size(149, 20);
            this.txtUcret.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(37, 113);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(104, 41);
            this.btnHesapla.TabIndex = 2;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // lblSonuc
            // 
            this.lblSonuc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSonuc.Location = new System.Drawing.Point(52, 185);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(76, 25);
            this.lblSonuc.TabIndex = 1;
            this.lblSonuc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 400);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkYO10;
        private System.Windows.Forms.CheckBox chky10;
        private System.Windows.Forms.CheckBox chky5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUcret;
    }
}

