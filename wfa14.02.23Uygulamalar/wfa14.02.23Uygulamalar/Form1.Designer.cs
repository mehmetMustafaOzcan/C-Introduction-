namespace wfa14._02._23Uygulamalar
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
            this.txtYazi = new System.Windows.Forms.TextBox();
            this.lblSayac = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtYazi
            // 
            this.txtYazi.Location = new System.Drawing.Point(26, 12);
            this.txtYazi.MaxLength = 255;
            this.txtYazi.Multiline = true;
            this.txtYazi.Name = "txtYazi";
            this.txtYazi.Size = new System.Drawing.Size(727, 359);
            this.txtYazi.TabIndex = 0;
            this.txtYazi.TextChanged += new System.EventHandler(this.txtYazi_TextChanged);
            // 
            // lblSayac
            // 
            this.lblSayac.AutoSize = true;
            this.lblSayac.Location = new System.Drawing.Point(700, 398);
            this.lblSayac.Name = "lblSayac";
            this.lblSayac.Size = new System.Drawing.Size(35, 13);
            this.lblSayac.TabIndex = 1;
            this.lblSayac.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSayac);
            this.Controls.Add(this.txtYazi);
            this.Name = "Form1";
            this.Text = "Form1";
           
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtYazi;
        private System.Windows.Forms.Label lblSayac;
    }
}

