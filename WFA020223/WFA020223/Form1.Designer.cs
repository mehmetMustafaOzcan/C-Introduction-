namespace WFA020223
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
            this.btnTarih = new System.Windows.Forms.Button();
            this.txtTarih = new System.Windows.Forms.TextBox();
            this.txtGun = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnTarih
            // 
            this.btnTarih.Location = new System.Drawing.Point(61, 55);
            this.btnTarih.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTarih.Name = "btnTarih";
            this.btnTarih.Size = new System.Drawing.Size(112, 35);
            this.btnTarih.TabIndex = 0;
            this.btnTarih.Text = "Tarih";
            this.btnTarih.UseVisualStyleBackColor = true;
            this.btnTarih.Click += new System.EventHandler(this.btnTarih_Click);
            // 
            // txtTarih
            // 
            this.txtTarih.Location = new System.Drawing.Point(256, 36);
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.Size = new System.Drawing.Size(240, 26);
            this.txtTarih.TabIndex = 1;
            // 
            // txtGun
            // 
            this.txtGun.Location = new System.Drawing.Point(256, 91);
            this.txtGun.Name = "txtGun";
            this.txtGun.Size = new System.Drawing.Size(240, 26);
            this.txtGun.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 147);
            this.Controls.Add(this.txtGun);
            this.Controls.Add(this.txtTarih);
            this.Controls.Add(this.btnTarih);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTarih;
        private System.Windows.Forms.TextBox txtTarih;
        private System.Windows.Forms.TextBox txtGun;
    }
}

