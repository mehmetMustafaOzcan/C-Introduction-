namespace wfa4.soru
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
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.MaskedTextBox();
            this.lstkaldı = new System.Windows.Forms.ListBox();
            this.lstGecti = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.rbtGecti = new System.Windows.Forms.RadioButton();
            this.rbtKaldi = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(98, 42);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 20);
            this.txtAd.TabIndex = 0;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(98, 68);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtSoyad.TabIndex = 1;
            // 
            // lstkaldı
            // 
            this.lstkaldı.FormattingEnabled = true;
            this.lstkaldı.Location = new System.Drawing.Point(234, 38);
            this.lstkaldı.Name = "lstkaldı";
            this.lstkaldı.Size = new System.Drawing.Size(149, 95);
            this.lstkaldı.TabIndex = 2;
            // 
            // lstGecti
            // 
            this.lstGecti.FormattingEnabled = true;
            this.lstGecti.Location = new System.Drawing.Point(389, 38);
            this.lstGecti.Name = "lstGecti";
            this.lstGecti.Size = new System.Drawing.Size(150, 95);
            this.lstGecti.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Soyad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kaldı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(370, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gecti";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(52, 177);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "button1";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // rbtGecti
            // 
            this.rbtGecti.AutoSize = true;
            this.rbtGecti.Location = new System.Drawing.Point(15, 117);
            this.rbtGecti.Name = "rbtGecti";
            this.rbtGecti.Size = new System.Drawing.Size(50, 17);
            this.rbtGecti.TabIndex = 5;
            this.rbtGecti.TabStop = true;
            this.rbtGecti.Text = "Geçti";
            this.rbtGecti.UseVisualStyleBackColor = true;
            // 
            // rbtKaldi
            // 
            this.rbtKaldi.AutoSize = true;
            this.rbtKaldi.Location = new System.Drawing.Point(113, 117);
            this.rbtKaldi.Name = "rbtKaldi";
            this.rbtKaldi.Size = new System.Drawing.Size(48, 17);
            this.rbtKaldi.TabIndex = 5;
            this.rbtKaldi.TabStop = true;
            this.rbtKaldi.Text = "Kaldı";
            this.rbtKaldi.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 227);
            this.Controls.Add(this.rbtKaldi);
            this.Controls.Add(this.rbtGecti);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstGecti);
            this.Controls.Add(this.lstkaldı);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.MaskedTextBox txtSoyad;
        private System.Windows.Forms.ListBox lstkaldı;
        private System.Windows.Forms.ListBox lstGecti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.RadioButton rbtGecti;
        private System.Windows.Forms.RadioButton rbtKaldi;
    }
}

