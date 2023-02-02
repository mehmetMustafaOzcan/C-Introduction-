namespace wfa3.soru
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbtEvli = new System.Windows.Forms.RadioButton();
            this.rbtBekar = new System.Windows.Forms.RadioButton();
            this.rbtCs0 = new System.Windows.Forms.RadioButton();
            this.rbtCs1 = new System.Windows.Forms.RadioButton();
            this.rbtCs2 = new System.Windows.Forms.RadioButton();
            this.rbtcs3u = new System.Windows.Forms.RadioButton();
            this.chkArapca = new System.Windows.Forms.CheckBox();
            this.chkIng = new System.Windows.Forms.CheckBox();
            this.ChkFr = new System.Windows.Forms.CheckBox();
            this.ChkAlm = new System.Windows.Forms.CheckBox();
            this.chkYun = new System.Windows.Forms.CheckBox();
            this.chkItl = new System.Windows.Forms.CheckBox();
            this.txtMaas = new System.Windows.Forms.TextBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtBekar);
            this.groupBox1.Controls.Add(this.rbtEvli);
            this.groupBox1.Location = new System.Drawing.Point(71, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Medeni Hal";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtcs3u);
            this.groupBox2.Controls.Add(this.rbtCs2);
            this.groupBox2.Controls.Add(this.rbtCs1);
            this.groupBox2.Controls.Add(this.rbtCs0);
            this.groupBox2.Location = new System.Drawing.Point(71, 169);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 165);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Çocuk Sayısı";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkItl);
            this.groupBox3.Controls.Add(this.chkYun);
            this.groupBox3.Controls.Add(this.ChkAlm);
            this.groupBox3.Controls.Add(this.ChkFr);
            this.groupBox3.Controls.Add(this.chkIng);
            this.groupBox3.Controls.Add(this.chkArapca);
            this.groupBox3.Location = new System.Drawing.Point(311, 29);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 173);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bildiğiniz Diller";
            // 
            // rbtEvli
            // 
            this.rbtEvli.AutoSize = true;
            this.rbtEvli.Location = new System.Drawing.Point(13, 25);
            this.rbtEvli.Name = "rbtEvli";
            this.rbtEvli.Size = new System.Drawing.Size(42, 17);
            this.rbtEvli.TabIndex = 0;
            this.rbtEvli.TabStop = true;
            this.rbtEvli.Text = "Evli";
            this.rbtEvli.UseVisualStyleBackColor = true;
            // 
            // rbtBekar
            // 
            this.rbtBekar.AutoSize = true;
            this.rbtBekar.Location = new System.Drawing.Point(13, 54);
            this.rbtBekar.Name = "rbtBekar";
            this.rbtBekar.Size = new System.Drawing.Size(53, 17);
            this.rbtBekar.TabIndex = 0;
            this.rbtBekar.TabStop = true;
            this.rbtBekar.Text = "Bekar";
            this.rbtBekar.UseVisualStyleBackColor = true;
            // 
            // rbtCs0
            // 
            this.rbtCs0.AutoSize = true;
            this.rbtCs0.Location = new System.Drawing.Point(13, 30);
            this.rbtCs0.Name = "rbtCs0";
            this.rbtCs0.Size = new System.Drawing.Size(31, 17);
            this.rbtCs0.TabIndex = 0;
            this.rbtCs0.TabStop = true;
            this.rbtCs0.Text = "0";
            this.rbtCs0.UseVisualStyleBackColor = true;
            // 
            // rbtCs1
            // 
            this.rbtCs1.AutoSize = true;
            this.rbtCs1.Location = new System.Drawing.Point(13, 53);
            this.rbtCs1.Name = "rbtCs1";
            this.rbtCs1.Size = new System.Drawing.Size(31, 17);
            this.rbtCs1.TabIndex = 0;
            this.rbtCs1.TabStop = true;
            this.rbtCs1.Text = "1";
            this.rbtCs1.UseVisualStyleBackColor = true;
            // 
            // rbtCs2
            // 
            this.rbtCs2.AutoSize = true;
            this.rbtCs2.Location = new System.Drawing.Point(13, 76);
            this.rbtCs2.Name = "rbtCs2";
            this.rbtCs2.Size = new System.Drawing.Size(31, 17);
            this.rbtCs2.TabIndex = 0;
            this.rbtCs2.TabStop = true;
            this.rbtCs2.Text = "2";
            this.rbtCs2.UseVisualStyleBackColor = true;
            // 
            // rbtcs3u
            // 
            this.rbtcs3u.AutoSize = true;
            this.rbtcs3u.Location = new System.Drawing.Point(13, 99);
            this.rbtcs3u.Name = "rbtcs3u";
            this.rbtcs3u.Size = new System.Drawing.Size(71, 17);
            this.rbtcs3u.TabIndex = 0;
            this.rbtcs3u.TabStop = true;
            this.rbtcs3u.Text = "3 ve üzeri";
            this.rbtcs3u.UseVisualStyleBackColor = true;
            // 
            // chkArapca
            // 
            this.chkArapca.AutoSize = true;
            this.chkArapca.Location = new System.Drawing.Point(13, 24);
            this.chkArapca.Name = "chkArapca";
            this.chkArapca.Size = new System.Drawing.Size(60, 17);
            this.chkArapca.TabIndex = 0;
            this.chkArapca.Text = "Arapça";
            this.chkArapca.UseVisualStyleBackColor = true;
            // 
            // chkIng
            // 
            this.chkIng.AutoSize = true;
            this.chkIng.Location = new System.Drawing.Point(13, 49);
            this.chkIng.Name = "chkIng";
            this.chkIng.Size = new System.Drawing.Size(64, 17);
            this.chkIng.TabIndex = 0;
            this.chkIng.Text = "İngilizce";
            this.chkIng.UseVisualStyleBackColor = true;
            // 
            // ChkFr
            // 
            this.ChkFr.AutoSize = true;
            this.ChkFr.Location = new System.Drawing.Point(13, 74);
            this.ChkFr.Name = "ChkFr";
            this.ChkFr.Size = new System.Drawing.Size(71, 17);
            this.ChkFr.TabIndex = 0;
            this.ChkFr.Text = "Fransızca";
            this.ChkFr.UseVisualStyleBackColor = true;
            // 
            // ChkAlm
            // 
            this.ChkAlm.AutoSize = true;
            this.ChkAlm.Location = new System.Drawing.Point(13, 99);
            this.ChkAlm.Name = "ChkAlm";
            this.ChkAlm.Size = new System.Drawing.Size(67, 17);
            this.ChkAlm.TabIndex = 0;
            this.ChkAlm.Text = "Almanca";
            this.ChkAlm.UseVisualStyleBackColor = true;
            // 
            // chkYun
            // 
            this.chkYun.AutoSize = true;
            this.chkYun.Location = new System.Drawing.Point(13, 124);
            this.chkYun.Name = "chkYun";
            this.chkYun.Size = new System.Drawing.Size(69, 17);
            this.chkYun.TabIndex = 0;
            this.chkYun.Text = "Yunanca";
            this.chkYun.UseVisualStyleBackColor = true;
            // 
            // chkItl
            // 
            this.chkItl.AutoSize = true;
            this.chkItl.Location = new System.Drawing.Point(13, 149);
            this.chkItl.Name = "chkItl";
            this.chkItl.Size = new System.Drawing.Size(69, 17);
            this.chkItl.TabIndex = 0;
            this.chkItl.Text = "İtalyanca";
            this.chkItl.UseVisualStyleBackColor = true;
            // 
            // txtMaas
            // 
            this.txtMaas.Location = new System.Drawing.Point(311, 209);
            this.txtMaas.Name = "txtMaas";
            this.txtMaas.Size = new System.Drawing.Size(200, 20);
            this.txtMaas.TabIndex = 1;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(311, 235);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(200, 23);
            this.btnHesapla.TabIndex = 2;
            this.btnHesapla.Text = "Maaş Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // lblSonuc
            // 
            this.lblSonuc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonuc.Location = new System.Drawing.Point(311, 272);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(200, 62);
            this.lblSonuc.TabIndex = 3;
            this.lblSonuc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 359);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.txtMaas);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.RadioButton rbtBekar;
        private System.Windows.Forms.RadioButton rbtEvli;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtcs3u;
        private System.Windows.Forms.RadioButton rbtCs2;
        private System.Windows.Forms.RadioButton rbtCs1;
        private System.Windows.Forms.RadioButton rbtCs0;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkItl;
        private System.Windows.Forms.CheckBox chkYun;
        private System.Windows.Forms.CheckBox ChkAlm;
        private System.Windows.Forms.CheckBox ChkFr;
        private System.Windows.Forms.CheckBox chkIng;
        private System.Windows.Forms.CheckBox chkArapca;
        private System.Windows.Forms.TextBox txtMaas;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label lblSonuc;
    }
}

