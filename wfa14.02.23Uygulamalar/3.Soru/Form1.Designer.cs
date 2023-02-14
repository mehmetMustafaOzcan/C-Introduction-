namespace _3.Soru
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
            this.btnDialogAc = new System.Windows.Forms.Button();
            this.btnFormac = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDialogAc
            // 
            this.btnDialogAc.Location = new System.Drawing.Point(127, 46);
            this.btnDialogAc.Name = "btnDialogAc";
            this.btnDialogAc.Size = new System.Drawing.Size(200, 110);
            this.btnDialogAc.TabIndex = 0;
            this.btnDialogAc.Text = "Dialog Form aç";
            this.btnDialogAc.UseVisualStyleBackColor = true;
            this.btnDialogAc.Click += new System.EventHandler(this.btnDialogAc_Click);
            // 
            // btnFormac
            // 
            this.btnFormac.Location = new System.Drawing.Point(441, 46);
            this.btnFormac.Name = "btnFormac";
            this.btnFormac.Size = new System.Drawing.Size(200, 110);
            this.btnFormac.TabIndex = 0;
            this.btnFormac.Text = "Form Aç";
            this.btnFormac.UseVisualStyleBackColor = true;
            this.btnFormac.Click += new System.EventHandler(this.btnFormac_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 221);
            this.Controls.Add(this.btnFormac);
            this.Controls.Add(this.btnDialogAc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDialogAc;
        private System.Windows.Forms.Button btnFormac;
    }
}

