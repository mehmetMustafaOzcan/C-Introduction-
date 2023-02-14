namespace AlisverisEkrani
{
    partial class Form3
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
            this.lstUrunGoster = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.btnYaz = new System.Windows.Forms.Button();
            this.btnOku = new System.Windows.Forms.Button();
            this.btnDosyaSec = new System.Windows.Forms.Button();
            this.txtDosyaYolu = new System.Windows.Forms.TextBox();
            this.txtOkunan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstUrunGoster
            // 
            this.lstUrunGoster.FormattingEnabled = true;
            this.lstUrunGoster.Location = new System.Drawing.Point(15, 26);
            this.lstUrunGoster.Name = "lstUrunGoster";
            this.lstUrunGoster.Size = new System.Drawing.Size(116, 225);
            this.lstUrunGoster.TabIndex = 0;
            this.lstUrunGoster.SelectedIndexChanged += new System.EventHandler(this.lstUrunGoster_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Aldığınız Ürünler";
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Location = new System.Drawing.Point(146, 256);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(35, 13);
            this.lblFiyat.TabIndex = 2;
            this.lblFiyat.Text = "label2";
            // 
            // btnYaz
            // 
            this.btnYaz.Location = new System.Drawing.Point(309, 152);
            this.btnYaz.Name = "btnYaz";
            this.btnYaz.Size = new System.Drawing.Size(88, 23);
            this.btnYaz.TabIndex = 3;
            this.btnYaz.Text = "Dosyadan Oku";
            this.btnYaz.UseVisualStyleBackColor = true;
            this.btnYaz.Click += new System.EventHandler(this.btnYaz_Click);
            // 
            // btnOku
            // 
            this.btnOku.Location = new System.Drawing.Point(174, 152);
            this.btnOku.Name = "btnOku";
            this.btnOku.Size = new System.Drawing.Size(96, 23);
            this.btnOku.TabIndex = 4;
            this.btnOku.Text = "Dosyaya Yaz";
            this.btnOku.UseVisualStyleBackColor = true;
            this.btnOku.Click += new System.EventHandler(this.btnOku_Click);
            // 
            // btnDosyaSec
            // 
            this.btnDosyaSec.Location = new System.Drawing.Point(174, 72);
            this.btnDosyaSec.Name = "btnDosyaSec";
            this.btnDosyaSec.Size = new System.Drawing.Size(104, 23);
            this.btnDosyaSec.TabIndex = 5;
            this.btnDosyaSec.Text = "Dosya Sec";
            this.btnDosyaSec.UseVisualStyleBackColor = true;
            this.btnDosyaSec.Click += new System.EventHandler(this.btnDosyaSec_Click);
            // 
            // txtDosyaYolu
            // 
            this.txtDosyaYolu.Location = new System.Drawing.Point(174, 46);
            this.txtDosyaYolu.Name = "txtDosyaYolu";
            this.txtDosyaYolu.Size = new System.Drawing.Size(223, 20);
            this.txtDosyaYolu.TabIndex = 6;
            // 
            // txtOkunan
            // 
            this.txtOkunan.Location = new System.Drawing.Point(438, 44);
            this.txtOkunan.Multiline = true;
            this.txtOkunan.Name = "txtOkunan";
            this.txtOkunan.ReadOnly = true;
            this.txtOkunan.Size = new System.Drawing.Size(138, 207);
            this.txtOkunan.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(435, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Dosyadan Okunan";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 279);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOkunan);
            this.Controls.Add(this.txtDosyaYolu);
            this.Controls.Add(this.btnDosyaSec);
            this.Controls.Add(this.btnOku);
            this.Controls.Add(this.btnYaz);
            this.Controls.Add(this.lblFiyat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstUrunGoster);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListBox lstUrunGoster;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.Button btnYaz;
        private System.Windows.Forms.Button btnOku;
        private System.Windows.Forms.Button btnDosyaSec;
        private System.Windows.Forms.TextBox txtDosyaYolu;
        public System.Windows.Forms.TextBox txtOkunan;
        private System.Windows.Forms.Label label2;
    }
}