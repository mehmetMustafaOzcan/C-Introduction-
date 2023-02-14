namespace _5.Soru
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
            this.lblAd = new System.Windows.Forms.Label();
            this.lblOrt = new System.Windows.Forms.Label();
            this.lblBasariDur = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(228, 73);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(35, 13);
            this.lblAd.TabIndex = 0;
            this.lblAd.Text = "label1";
            // 
            // lblOrt
            // 
            this.lblOrt.AutoSize = true;
            this.lblOrt.Location = new System.Drawing.Point(228, 118);
            this.lblOrt.Name = "lblOrt";
            this.lblOrt.Size = new System.Drawing.Size(35, 13);
            this.lblOrt.TabIndex = 0;
            this.lblOrt.Text = "label1";
            // 
            // lblBasariDur
            // 
            this.lblBasariDur.AutoSize = true;
            this.lblBasariDur.Location = new System.Drawing.Point(228, 165);
            this.lblBasariDur.Name = "lblBasariDur";
            this.lblBasariDur.Size = new System.Drawing.Size(35, 13);
            this.lblBasariDur.TabIndex = 0;
            this.lblBasariDur.Text = "label1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 304);
            this.Controls.Add(this.lblBasariDur);
            this.Controls.Add(this.lblOrt);
            this.Controls.Add(this.lblAd);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblAd;
        public System.Windows.Forms.Label lblOrt;
        public System.Windows.Forms.Label lblBasariDur;
    }
}