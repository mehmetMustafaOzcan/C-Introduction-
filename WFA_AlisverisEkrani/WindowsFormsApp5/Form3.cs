using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlisverisEkrani
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void lstUrunGoster_SelectedIndexChanged(object sender, EventArgs e)
        {
            
           
                
           
        }
        decimal sonuc;
        private void Form3_Load(object sender, EventArgs e)
        {       
               
              

            
        }

        private void btnDosyaSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.ShowDialog();
            txtDosyaYolu.Text = fd.FileName;
            fd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            fd.FilterIndex = 2;
        }

        private void btnYaz_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(txtDosyaYolu.Text);

            string okunan = sr.ReadToEnd();
            sr.Close();
            txtOkunan.Text=okunan;        

        }

        private void btnOku_Click(object sender, EventArgs e)
        {
            try
            {

                StreamWriter sw = new StreamWriter(txtDosyaYolu.Text);
                sw.WriteLine(txtOkunan.Text);
                sw.WriteLine("##"+lblFiyat.Text+"##");
                txtOkunan.Text = "";
                sw.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Dosya Yolu Seçiniz");
            }
        }
    }
}
