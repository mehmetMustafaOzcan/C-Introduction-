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

namespace _160223ödev2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void btnAra_Click(object sender, EventArgs e)
        {
            //MetniOku();

            ArananMetniBoya();

        }

        private void ArananMetniBoya()
        {
            string aranan = txtAranan.Text;
            string orjinal = rtbMetin.Text;
            string metin = rtbMetin.Text;

            rtbMetin.Text = "";

            while (orjinal.Contains(aranan) && aranan != "")
            {
                metin = orjinal.Remove(orjinal.IndexOf(aranan));// aranan metne kadar olan kısmı kes

                rtbMetin.SelectionColor = Color.Black;
                rtbMetin.SelectedText = metin;          //metnin kesilmiş halde ekle
                rtbMetin.SelectionColor = Color.Red;
                rtbMetin.SelectedText = aranan;     //aranan metni ekle rengi üst satırda kırmızı yaptık ekledik 
                orjinal = orjinal.Substring(orjinal.IndexOf(aranan) + aranan.Length); //aranan metinden sonrasını kes ve whilw ilw kontrol et aranan metin yine varsa tekra dön
            }
            rtbMetin.SelectionColor = Color.Black;
            rtbMetin.SelectedText = orjinal;//en son kalanı eklemek için whiledan çıkınca ekle.
        }
        /*
        private void MetniOku()
        {
            StreamReader sr = new StreamReader("C:\\Users\\ÖZCAN\\Desktop\\odev.txt");
            rtbMetin.Text = sr.ReadToEnd();
        }
        */

        private void btnMetinGetir_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Filter = "txt files (*.txt)|*.txt";
            OFD.ShowDialog();
            string path = OFD.FileName;
            try
            {
                StreamReader sr = new StreamReader(path);
                rtbMetin.Text = sr.ReadToEnd();
            }
            catch (Exception)
            {

                MessageBox.Show("Dosya Yolu Bulunamadı");
            }
            
        }
    }
}
