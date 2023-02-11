namespace AlisverisEkrani
{
    partial class Form2
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
            this.lblKarsilama = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TpKiyafet = new System.Windows.Forms.TabPage();
            this.lstKiyafet = new System.Windows.Forms.ListBox();
            this.tpKirt = new System.Windows.Forms.TabPage();
            this.lstKirtasiye = new System.Windows.Forms.ListBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lstBebek = new System.Windows.Forms.ListBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.TpKiyafet.SuspendLayout();
            this.tpKirt.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblKarsilama
            // 
            this.lblKarsilama.AutoSize = true;
            this.lblKarsilama.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKarsilama.Location = new System.Drawing.Point(313, 9);
            this.lblKarsilama.Name = "lblKarsilama";
            this.lblKarsilama.Size = new System.Drawing.Size(10, 13);
            this.lblKarsilama.TabIndex = 0;
            this.lblKarsilama.Text = ",";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TpKiyafet);
            this.tabControl1.Controls.Add(this.tpKirt);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 23);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(151, 181);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            this.tabControl1.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // TpKiyafet
            // 
            this.TpKiyafet.Controls.Add(this.lstKiyafet);
            this.TpKiyafet.Location = new System.Drawing.Point(4, 22);
            this.TpKiyafet.Name = "TpKiyafet";
            this.TpKiyafet.Padding = new System.Windows.Forms.Padding(3);
            this.TpKiyafet.Size = new System.Drawing.Size(143, 155);
            this.TpKiyafet.TabIndex = 0;
            this.TpKiyafet.Text = "Kıyafet";
            this.TpKiyafet.UseVisualStyleBackColor = true;
            // 
            // lstKiyafet
            // 
            this.lstKiyafet.FormattingEnabled = true;
            this.lstKiyafet.Items.AddRange(new object[] {
            "Etek",
            "Bluz"});
            this.lstKiyafet.Location = new System.Drawing.Point(7, 7);
            this.lstKiyafet.Name = "lstKiyafet";
            this.lstKiyafet.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstKiyafet.Size = new System.Drawing.Size(120, 134);
            this.lstKiyafet.TabIndex = 4;
            // 
            // tpKirt
            // 
            this.tpKirt.Controls.Add(this.lstKirtasiye);
            this.tpKirt.Location = new System.Drawing.Point(4, 22);
            this.tpKirt.Name = "tpKirt";
            this.tpKirt.Padding = new System.Windows.Forms.Padding(3);
            this.tpKirt.Size = new System.Drawing.Size(143, 155);
            this.tpKirt.TabIndex = 2;
            this.tpKirt.Text = "Kırtasiye";
            this.tpKirt.UseVisualStyleBackColor = true;
            // 
            // lstKirtasiye
            // 
            this.lstKirtasiye.FormattingEnabled = true;
            this.lstKirtasiye.Items.AddRange(new object[] {
            "Kalem",
            "defter",
            "kağıt"});
            this.lstKirtasiye.Location = new System.Drawing.Point(6, 6);
            this.lstKirtasiye.Name = "lstKirtasiye";
            this.lstKirtasiye.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstKirtasiye.Size = new System.Drawing.Size(117, 134);
            this.lstKirtasiye.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lstBebek);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(143, 155);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "bebek";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lstBebek
            // 
            this.lstBebek.FormattingEnabled = true;
            this.lstBebek.Items.AddRange(new object[] {
            "Bebek Bezi",
            "Islak Mendil"});
            this.lstBebek.Location = new System.Drawing.Point(6, 6);
            this.lstBebek.Name = "lstBebek";
            this.lstBebek.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstBebek.Size = new System.Drawing.Size(131, 147);
            this.lstBebek.TabIndex = 0;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(310, 157);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 47);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "Sepete EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 240);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblKarsilama);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tabControl1.ResumeLayout(false);
            this.TpKiyafet.ResumeLayout(false);
            this.tpKirt.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblKarsilama;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TpKiyafet;
        private System.Windows.Forms.TabPage tpKirt;
        private System.Windows.Forms.Button btnEkle;
        public System.Windows.Forms.ListBox lstBebek;
        public System.Windows.Forms.ListBox lstKirtasiye;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox lstKiyafet;
    }
}