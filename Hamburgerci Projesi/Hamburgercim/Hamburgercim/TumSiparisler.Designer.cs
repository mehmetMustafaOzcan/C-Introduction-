namespace Hamburgercim
{
    partial class TumSiparisler
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCiro = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblSiparisSayisi = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblEkstraMalzeme = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblSatilanUrun = new System.Windows.Forms.Label();
            this.lstTumSiparis = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(27, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "TÜM SİPARİŞLER";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCiro);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(396, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 50);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ciro";
            // 
            // lblCiro
            // 
            this.lblCiro.AutoSize = true;
            this.lblCiro.ForeColor = System.Drawing.Color.Firebrick;
            this.lblCiro.Location = new System.Drawing.Point(19, 23);
            this.lblCiro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCiro.Name = "lblCiro";
            this.lblCiro.Size = new System.Drawing.Size(52, 17);
            this.lblCiro.TabIndex = 1;
            this.lblCiro.Text = "label1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblSiparisSayisi);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(396, 182);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(190, 50);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Toplam Sipariş Sayısı";
            // 
            // lblSiparisSayisi
            // 
            this.lblSiparisSayisi.AutoSize = true;
            this.lblSiparisSayisi.ForeColor = System.Drawing.Color.Firebrick;
            this.lblSiparisSayisi.Location = new System.Drawing.Point(19, 23);
            this.lblSiparisSayisi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSiparisSayisi.Name = "lblSiparisSayisi";
            this.lblSiparisSayisi.Size = new System.Drawing.Size(52, 17);
            this.lblSiparisSayisi.TabIndex = 1;
            this.lblSiparisSayisi.Text = "label1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblEkstraMalzeme);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(396, 260);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(190, 50);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ekstra Malzeme Geliri";
            // 
            // lblEkstraMalzeme
            // 
            this.lblEkstraMalzeme.AutoSize = true;
            this.lblEkstraMalzeme.ForeColor = System.Drawing.Color.Firebrick;
            this.lblEkstraMalzeme.Location = new System.Drawing.Point(19, 23);
            this.lblEkstraMalzeme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEkstraMalzeme.Name = "lblEkstraMalzeme";
            this.lblEkstraMalzeme.Size = new System.Drawing.Size(52, 17);
            this.lblEkstraMalzeme.TabIndex = 1;
            this.lblEkstraMalzeme.Text = "label1";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblSatilanUrun);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.Location = new System.Drawing.Point(396, 338);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(190, 50);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Satılan Ürün Adedi";
            // 
            // lblSatilanUrun
            // 
            this.lblSatilanUrun.AutoSize = true;
            this.lblSatilanUrun.ForeColor = System.Drawing.Color.Firebrick;
            this.lblSatilanUrun.Location = new System.Drawing.Point(19, 22);
            this.lblSatilanUrun.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSatilanUrun.Name = "lblSatilanUrun";
            this.lblSatilanUrun.Size = new System.Drawing.Size(52, 17);
            this.lblSatilanUrun.TabIndex = 1;
            this.lblSatilanUrun.Text = "label1";
            // 
            // lstTumSiparis
            // 
            this.lstTumSiparis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstTumSiparis.FormattingEnabled = true;
            this.lstTumSiparis.Location = new System.Drawing.Point(31, 104);
            this.lstTumSiparis.Name = "lstTumSiparis";
            this.lstTumSiparis.Size = new System.Drawing.Size(349, 342);
            this.lstTumSiparis.TabIndex = 2;
            // 
            // TumSiparisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 506);
            this.Controls.Add(this.lstTumSiparis);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TumSiparisler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        internal System.Windows.Forms.Label lblCiro;
        internal System.Windows.Forms.Label lblSiparisSayisi;
        internal System.Windows.Forms.Label lblEkstraMalzeme;
        internal System.Windows.Forms.Label lblSatilanUrun;
        internal System.Windows.Forms.ListBox lstTumSiparis;
    }
}