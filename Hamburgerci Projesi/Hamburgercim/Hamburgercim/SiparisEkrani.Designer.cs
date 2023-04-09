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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbSize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupPiece)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(269, 466);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Toplam Tutar";
            // 
            // cbMenuSelect
            // 
            this.cbMenuSelect.FormattingEnabled = true;
            this.cbMenuSelect.Location = new System.Drawing.Point(25, 65);
            this.cbMenuSelect.Name = "cbMenuSelect";
            this.cbMenuSelect.Size = new System.Drawing.Size(194, 22);
            this.cbMenuSelect.TabIndex = 2;
            this.cbMenuSelect.SelectedIndexChanged += new System.EventHandler(this.cbMenuSelect_SelectedIndexChanged);
            // 
            // gbSize
            // 
            this.gbSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gbSize.Controls.Add(this.rbBig);
            this.gbSize.Controls.Add(this.rbMiddle);
            this.gbSize.Controls.Add(this.rbSmall);
            this.gbSize.Enabled = false;
            this.gbSize.ForeColor = System.Drawing.Color.White;
            this.gbSize.Location = new System.Drawing.Point(25, 128);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(194, 56);
            this.gbSize.TabIndex = 3;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Boyut Seçin";
            // 
            // rbBig
            // 
            this.rbBig.AutoSize = true;
            this.rbBig.Location = new System.Drawing.Point(119, 19);
            this.rbBig.Name = "rbBig";
            this.rbBig.Size = new System.Drawing.Size(57, 18);
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
            this.rbMiddle.Size = new System.Drawing.Size(48, 18);
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
            this.rbSmall.Size = new System.Drawing.Size(56, 18);
            this.rbSmall.TabIndex = 0;
            this.rbSmall.TabStop = true;
            this.rbSmall.Text = "Küçük";
            this.rbSmall.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(22, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "Menu Seçin";
            // 
            // nupPiece
            // 
            this.nupPiece.Location = new System.Drawing.Point(75, 399);
            this.nupPiece.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nupPiece.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupPiece.Name = "nupPiece";
            this.nupPiece.Size = new System.Drawing.Size(120, 22);
            this.nupPiece.TabIndex = 6;
            this.nupPiece.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnSiparisEkle
            // 
            this.btnSiparisEkle.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnSiparisEkle.Location = new System.Drawing.Point(25, 435);
            this.btnSiparisEkle.Name = "btnSiparisEkle";
            this.btnSiparisEkle.Size = new System.Drawing.Size(174, 52);
            this.btnSiparisEkle.TabIndex = 7;
            this.btnSiparisEkle.Text = "SİPARİŞ EKLE";
            this.btnSiparisEkle.UseVisualStyleBackColor = false;
            this.btnSiparisEkle.Click += new System.EventHandler(this.btnSiparisEkle_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.RosyBrown;
            this.button2.Location = new System.Drawing.Point(461, 435);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 52);
            this.button2.TabIndex = 7;
            this.button2.Text = "SİPARİŞİ TAMAMLA ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalPrice.ForeColor = System.Drawing.Color.LightCoral;
            this.lblTotalPrice.Location = new System.Drawing.Point(389, 466);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(19, 20);
            this.lblTotalPrice.TabIndex = 1;
            this.lblTotalPrice.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(27, 401);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 14);
            this.label4.TabIndex = 4;
            this.label4.Text = "Adet";
            // 
            // flpEkstra
            // 
            this.flpEkstra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.flpEkstra.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpEkstra.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.flpEkstra.Location = new System.Drawing.Point(17, 217);
            this.flpEkstra.Name = "flpEkstra";
            this.flpEkstra.Size = new System.Drawing.Size(202, 163);
            this.flpEkstra.TabIndex = 9;
            // 
            // lstSiparisler
            // 
            this.lstSiparisler.Font = new System.Drawing.Font("Gadugi", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstSiparisler.FormattingEnabled = true;
            this.lstSiparisler.ItemHeight = 14;
            this.lstSiparisler.Location = new System.Drawing.Point(246, 65);
            this.lstSiparisler.Name = "lstSiparisler";
            this.lstSiparisler.Size = new System.Drawing.Size(389, 284);
            this.lstSiparisler.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hamburgercim.Properties.Resources.bacgroundHamb;
            this.pictureBox1.Location = new System.Drawing.Point(12, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(714, 472);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // SiparisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(712, 591);
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
            this.Controls.Add(this.flpEkstra);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Name = "SiparisEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Siparis Olustur";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.CursorChanged += new System.EventHandler(this.btnSiparisEkle_Click);
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupPiece)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}