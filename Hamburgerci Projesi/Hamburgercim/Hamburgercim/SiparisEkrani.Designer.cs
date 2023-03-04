namespace Hamburgercim
{
    partial class SiparisEkrani
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMenuSelect = new System.Windows.Forms.ComboBox();
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.rbBig = new System.Windows.Forms.RadioButton();
            this.rbMiddle = new System.Windows.Forms.RadioButton();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.nupPiece = new System.Windows.Forms.NumericUpDown();
            this.btnSiparisEkle = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.flpEkstra = new System.Windows.Forms.FlowLayoutPanel();
            this.lstSiparisler = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbSize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupPiece)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(27, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 123);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(227, 462);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Toplam Tutar";
            // 
            // cbMenuSelect
            // 
            this.cbMenuSelect.FormattingEnabled = true;
            this.cbMenuSelect.Location = new System.Drawing.Point(21, 185);
            this.cbMenuSelect.Name = "cbMenuSelect";
            this.cbMenuSelect.Size = new System.Drawing.Size(182, 21);
            this.cbMenuSelect.TabIndex = 2;
            this.cbMenuSelect.SelectedIndexChanged += new System.EventHandler(this.cbMenuSelect_SelectedIndexChanged);
            // 
            // gbSize
            // 
            this.gbSize.Controls.Add(this.rbBig);
            this.gbSize.Controls.Add(this.rbMiddle);
            this.gbSize.Controls.Add(this.rbSmall);
            this.gbSize.Enabled = false;
            this.gbSize.Location = new System.Drawing.Point(21, 225);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(182, 49);
            this.gbSize.TabIndex = 3;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Boyut Seçin";
            // 
            // rbBig
            // 
            this.rbBig.AutoSize = true;
            this.rbBig.Location = new System.Drawing.Point(119, 19);
            this.rbBig.Name = "rbBig";
            this.rbBig.Size = new System.Drawing.Size(55, 17);
            this.rbBig.TabIndex = 0;
            this.rbBig.TabStop = true;
            this.rbBig.Text = "Büyük";
            this.rbBig.UseVisualStyleBackColor = true;
            // 
            // rbMiddle
            // 
            this.rbMiddle.AutoSize = true;
            this.rbMiddle.Location = new System.Drawing.Point(68, 19);
            this.rbMiddle.Name = "rbMiddle";
            this.rbMiddle.Size = new System.Drawing.Size(45, 17);
            this.rbMiddle.TabIndex = 0;
            this.rbMiddle.TabStop = true;
            this.rbMiddle.Text = "Orta";
            this.rbMiddle.UseVisualStyleBackColor = true;
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Location = new System.Drawing.Point(6, 19);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(56, 17);
            this.rbSmall.TabIndex = 0;
            this.rbSmall.TabStop = true;
            this.rbSmall.Text = "Küçük";
            this.rbSmall.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Menu Seçin";
            // 
            // nupPiece
            // 
            this.nupPiece.Location = new System.Drawing.Point(64, 436);
            this.nupPiece.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nupPiece.Name = "nupPiece";
            this.nupPiece.Size = new System.Drawing.Size(120, 20);
            this.nupPiece.TabIndex = 6;
            this.nupPiece.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnSiparisEkle
            // 
            this.btnSiparisEkle.Location = new System.Drawing.Point(31, 462);
            this.btnSiparisEkle.Name = "btnSiparisEkle";
            this.btnSiparisEkle.Size = new System.Drawing.Size(174, 47);
            this.btnSiparisEkle.TabIndex = 7;
            this.btnSiparisEkle.Text = "SİPARİŞ EKLE";
            this.btnSiparisEkle.UseVisualStyleBackColor = true;
            this.btnSiparisEkle.Click += new System.EventHandler(this.btnSiparisEkle_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(323, 459);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 47);
            this.button2.TabIndex = 7;
            this.button2.Text = "SİPARİŞİ TAMAMLA ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalPrice.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTotalPrice.Location = new System.Drawing.Point(255, 493);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(14, 13);
            this.lblTotalPrice.TabIndex = 1;
            this.lblTotalPrice.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 438);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Adet";
            // 
            // flpEkstra
            // 
            this.flpEkstra.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpEkstra.Location = new System.Drawing.Point(19, 280);
            this.flpEkstra.Name = "flpEkstra";
            this.flpEkstra.Size = new System.Drawing.Size(202, 150);
            this.flpEkstra.TabIndex = 9;
            // 
            // lstSiparisler
            // 
            this.lstSiparisler.FormattingEnabled = true;
            this.lstSiparisler.Location = new System.Drawing.Point(230, 35);
            this.lstSiparisler.Name = "lstSiparisler";
            this.lstSiparisler.Size = new System.Drawing.Size(267, 342);
            this.lstSiparisler.TabIndex = 10;
            // 
            // SiparisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 554);
            this.Controls.Add(this.lstSiparisler);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSiparisEkle);
            this.Controls.Add(this.nupPiece);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gbSize);
            this.Controls.Add(this.cbMenuSelect);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.flpEkstra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SiparisEkrani";
            this.Text = "Siparis Olustur";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.CursorChanged += new System.EventHandler(this.btnSiparisEkle_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupPiece)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMenuSelect;
        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.RadioButton rbBig;
        private System.Windows.Forms.RadioButton rbMiddle;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nupPiece;
        private System.Windows.Forms.Button btnSiparisEkle;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flpEkstra;
        private System.Windows.Forms.ListBox lstSiparisler;
        public System.Windows.Forms.Button button2;
    }
}