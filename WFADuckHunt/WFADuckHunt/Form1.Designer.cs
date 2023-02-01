namespace WFADuckHunt
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
            this.pnlordekucus = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblOrdekSayisi = new System.Windows.Forms.Label();
            this.lblVurulan = new System.Windows.Forms.Label();
            this.tmrOrdekUcus = new System.Windows.Forms.Timer(this.components);
            this.tmrordekyatayucus = new System.Windows.Forms.Timer(this.components);
            this.flpAtishakki = new System.Windows.Forms.FlowLayoutPanel();
            this.tmrOluOrdek = new System.Windows.Forms.Timer(this.components);
            this.tmrKopekCikis = new System.Windows.Forms.Timer(this.components);
            this.tmrKopekSaklan = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // pnlordekucus
            // 
            this.pnlordekucus.BackColor = System.Drawing.Color.Transparent;
            this.pnlordekucus.Location = new System.Drawing.Point(0, 0);
            this.pnlordekucus.Name = "pnlordekucus";
            this.pnlordekucus.Size = new System.Drawing.Size(750, 336);
            this.pnlordekucus.TabIndex = 0;
            this.pnlordekucus.Click += new System.EventHandler(this.pnlordekucus_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(505, 383);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ördek Sayısı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(543, 418);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vurulan";
            // 
            // lblOrdekSayisi
            // 
            this.lblOrdekSayisi.AutoSize = true;
            this.lblOrdekSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOrdekSayisi.Location = new System.Drawing.Point(646, 383);
            this.lblOrdekSayisi.Name = "lblOrdekSayisi";
            this.lblOrdekSayisi.Size = new System.Drawing.Size(19, 20);
            this.lblOrdekSayisi.TabIndex = 2;
            this.lblOrdekSayisi.Text = "0";
            // 
            // lblVurulan
            // 
            this.lblVurulan.AutoSize = true;
            this.lblVurulan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblVurulan.Location = new System.Drawing.Point(646, 418);
            this.lblVurulan.Name = "lblVurulan";
            this.lblVurulan.Size = new System.Drawing.Size(19, 20);
            this.lblVurulan.TabIndex = 2;
            this.lblVurulan.Text = "0";
            // 
            // tmrOrdekUcus
            // 
            this.tmrOrdekUcus.Interval = 10;
            this.tmrOrdekUcus.Tick += new System.EventHandler(this.tmrOrdekUcus_Tick);
            // 
            // tmrordekyatayucus
            // 
            this.tmrordekyatayucus.Interval = 10;
            this.tmrordekyatayucus.Tick += new System.EventHandler(this.tmrordekyatayucus_Tick);
            // 
            // flpAtishakki
            // 
            this.flpAtishakki.BackColor = System.Drawing.Color.Transparent;
            this.flpAtishakki.Location = new System.Drawing.Point(37, 378);
            this.flpAtishakki.Name = "flpAtishakki";
            this.flpAtishakki.Size = new System.Drawing.Size(207, 71);
            this.flpAtishakki.TabIndex = 3;
            // 
            // tmrOluOrdek
            // 
            this.tmrOluOrdek.Interval = 10;
            this.tmrOluOrdek.Tick += new System.EventHandler(this.tmrOluOrdek_Tick);
            // 
            // tmrKopekCikis
            // 
            this.tmrKopekCikis.Tick += new System.EventHandler(this.tmrKopekCikis_Tick);
            // 
            // tmrKopekSaklan
            // 
            this.tmrKopekSaklan.Tick += new System.EventHandler(this.tmrKopekSaklan_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WFADuckHunt.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(749, 450);
            this.Controls.Add(this.flpAtishakki);
            this.Controls.Add(this.lblVurulan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblOrdekSayisi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlordekucus);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlordekucus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblOrdekSayisi;
        private System.Windows.Forms.Label lblVurulan;
        private System.Windows.Forms.Timer tmrOrdekUcus;
        private System.Windows.Forms.Timer tmrordekyatayucus;
        private System.Windows.Forms.FlowLayoutPanel flpAtishakki;
        private System.Windows.Forms.Timer tmrOluOrdek;
        private System.Windows.Forms.Timer tmrKopekCikis;
        private System.Windows.Forms.Timer tmrKopekSaklan;
    }
}

