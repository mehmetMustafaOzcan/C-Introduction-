namespace _160223ödev2
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
            this.txtAranan = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.rtbMetin = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMetinGetir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAranan
            // 
            this.txtAranan.Location = new System.Drawing.Point(100, 24);
            this.txtAranan.Name = "txtAranan";
            this.txtAranan.Size = new System.Drawing.Size(373, 20);
            this.txtAranan.TabIndex = 0;
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(524, 27);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(132, 59);
            this.btnAra.TabIndex = 1;
            this.btnAra.Text = "ARA";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // rtbMetin
            // 
            this.rtbMetin.Location = new System.Drawing.Point(12, 115);
            this.rtbMetin.Name = "rtbMetin";
            this.rtbMetin.Size = new System.Drawing.Size(776, 293);
            this.rtbMetin.TabIndex = 2;
            this.rtbMetin.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Aranacak Metin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Seçtiğiniz metinler";
            // 
            // btnMetinGetir
            // 
            this.btnMetinGetir.Location = new System.Drawing.Point(675, 27);
            this.btnMetinGetir.Name = "btnMetinGetir";
            this.btnMetinGetir.Size = new System.Drawing.Size(101, 59);
            this.btnMetinGetir.TabIndex = 4;
            this.btnMetinGetir.Text = "Aranacak Metin txt  Yükle";
            this.btnMetinGetir.UseVisualStyleBackColor = true;
            this.btnMetinGetir.Click += new System.EventHandler(this.btnMetinGetir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMetinGetir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbMetin);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtAranan);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAranan;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.RichTextBox rtbMetin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMetinGetir;
    }
}

