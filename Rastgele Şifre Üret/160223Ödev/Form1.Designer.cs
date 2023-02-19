namespace _160223Ödev
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
            this.btnSifreOlustur = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudSifreUzunluk = new System.Windows.Forms.NumericUpDown();
            this.nudSifreSayisi = new System.Windows.Forms.NumericUpDown();
            this.chkOzelKar = new System.Windows.Forms.CheckBox();
            this.chkDigit = new System.Windows.Forms.CheckBox();
            this.ChkBuyukHarf = new System.Windows.Forms.CheckBox();
            this.chkKucukHRF = new System.Windows.Forms.CheckBox();
            this.lblSonuclar = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSifreUzunluk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSifreSayisi)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSifreOlustur);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nudSifreUzunluk);
            this.groupBox1.Controls.Add(this.nudSifreSayisi);
            this.groupBox1.Controls.Add(this.chkOzelKar);
            this.groupBox1.Controls.Add(this.chkDigit);
            this.groupBox1.Controls.Add(this.ChkBuyukHarf);
            this.groupBox1.Controls.Add(this.chkKucukHRF);
            this.groupBox1.Location = new System.Drawing.Point(38, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 375);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnSifreOlustur
            // 
            this.btnSifreOlustur.Location = new System.Drawing.Point(235, 337);
            this.btnSifreOlustur.Name = "btnSifreOlustur";
            this.btnSifreOlustur.Size = new System.Drawing.Size(75, 23);
            this.btnSifreOlustur.TabIndex = 3;
            this.btnSifreOlustur.Text = "Oluştur";
            this.btnSifreOlustur.UseVisualStyleBackColor = true;
            this.btnSifreOlustur.Click += new System.EventHandler(this.btnSifreOlustur_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifre uzunluğu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Şifre Sayısı";
            // 
            // nudSifreUzunluk
            // 
            this.nudSifreUzunluk.Location = new System.Drawing.Point(112, 269);
            this.nudSifreUzunluk.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudSifreUzunluk.Name = "nudSifreUzunluk";
            this.nudSifreUzunluk.Size = new System.Drawing.Size(120, 20);
            this.nudSifreUzunluk.TabIndex = 1;
            this.nudSifreUzunluk.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // nudSifreSayisi
            // 
            this.nudSifreSayisi.Location = new System.Drawing.Point(112, 216);
            this.nudSifreSayisi.Name = "nudSifreSayisi";
            this.nudSifreSayisi.Size = new System.Drawing.Size(120, 20);
            this.nudSifreSayisi.TabIndex = 1;
            this.nudSifreSayisi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // chkOzelKar
            // 
            this.chkOzelKar.AutoSize = true;
            this.chkOzelKar.Location = new System.Drawing.Point(52, 111);
            this.chkOzelKar.Name = "chkOzelKar";
            this.chkOzelKar.Size = new System.Drawing.Size(90, 17);
            this.chkOzelKar.TabIndex = 0;
            this.chkOzelKar.Text = "Özel Karakter";
            this.chkOzelKar.UseVisualStyleBackColor = true;
            // 
            // chkDigit
            // 
            this.chkDigit.AutoSize = true;
            this.chkDigit.Location = new System.Drawing.Point(52, 88);
            this.chkDigit.Name = "chkDigit";
            this.chkDigit.Size = new System.Drawing.Size(60, 17);
            this.chkDigit.TabIndex = 0;
            this.chkDigit.Text = "Rakam";
            this.chkDigit.UseVisualStyleBackColor = true;
            // 
            // ChkBuyukHarf
            // 
            this.ChkBuyukHarf.AutoSize = true;
            this.ChkBuyukHarf.Location = new System.Drawing.Point(52, 65);
            this.ChkBuyukHarf.Name = "ChkBuyukHarf";
            this.ChkBuyukHarf.Size = new System.Drawing.Size(79, 17);
            this.ChkBuyukHarf.TabIndex = 0;
            this.ChkBuyukHarf.Text = "Büyük Harf";
            this.ChkBuyukHarf.UseVisualStyleBackColor = true;
            // 
            // chkKucukHRF
            // 
            this.chkKucukHRF.AutoSize = true;
            this.chkKucukHRF.Location = new System.Drawing.Point(52, 42);
            this.chkKucukHRF.Name = "chkKucukHRF";
            this.chkKucukHRF.Size = new System.Drawing.Size(80, 17);
            this.chkKucukHRF.TabIndex = 0;
            this.chkKucukHRF.Text = "Küçük Harf";
            this.chkKucukHRF.UseVisualStyleBackColor = true;
            // 
            // lblSonuclar
            // 
            this.lblSonuclar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSonuclar.Location = new System.Drawing.Point(422, 27);
            this.lblSonuclar.Name = "lblSonuclar";
            this.lblSonuclar.Size = new System.Drawing.Size(274, 375);
            this.lblSonuclar.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 442);
            this.Controls.Add(this.lblSonuclar);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSifreUzunluk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSifreSayisi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSifreOlustur;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudSifreUzunluk;
        private System.Windows.Forms.NumericUpDown nudSifreSayisi;
        private System.Windows.Forms.CheckBox chkOzelKar;
        private System.Windows.Forms.CheckBox chkDigit;
        private System.Windows.Forms.CheckBox ChkBuyukHarf;
        private System.Windows.Forms.CheckBox chkKucukHRF;
        private System.Windows.Forms.Label lblSonuclar;
    }
}

