namespace WFAAktarici
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
            this.txtAktarılacak = new System.Windows.Forms.TextBox();
            this.lblYazi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAktarılacak
            // 
            this.txtAktarılacak.Location = new System.Drawing.Point(46, 29);
            this.txtAktarılacak.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAktarılacak.Name = "txtAktarılacak";
            this.txtAktarılacak.Size = new System.Drawing.Size(261, 26);
            this.txtAktarılacak.TabIndex = 0;
            this.txtAktarılacak.TextChanged += new System.EventHandler(this.txtAktarılacak_TextChanged);
            // 
            // lblYazi
            // 
            this.lblYazi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblYazi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblYazi.Location = new System.Drawing.Point(46, 72);
            this.lblYazi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYazi.Name = "lblYazi";
            this.lblYazi.Size = new System.Drawing.Size(261, 44);
            this.lblYazi.TabIndex = 1;
            this.lblYazi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblYazi.UseMnemonic = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 125);
            this.Controls.Add(this.lblYazi);
            this.Controls.Add(this.txtAktarılacak);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAktarılacak;
        private System.Windows.Forms.Label lblYazi;
    }
}

