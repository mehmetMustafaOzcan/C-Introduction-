using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlisverisEkrani
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            txtAd.Text = "Mustafa";
            txtSoyad.Text = "1234";
        }
        public static string adsoyad;
        public List<string> urunler=new List<string>();
        public static decimal fiyat;
        private void btnGiriş_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();

            if (txtAd.Text == "Mustafa" && txtSoyad.Text == "1234")
            {
                adsoyad = txtAd.Text;
              frm2.Show();
              frm2.urunler2 = urunler;
              
                //Hide();

            }
           
            txtSoyad.PasswordChar = '*';
            lblCekilen.Text = frm2.lblKarsilama.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            txtSoyad.PasswordChar = '*';
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtSoyad.PasswordChar = '\0';
            }
            else
            {
                txtSoyad.PasswordChar = '*';
            }
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
          
            frm3.lstUrunGoster.Items.Clear();
            frm3.txtOkunan.Lines= urunler.ToArray();
            foreach (var item in urunler)
            {                
                frm3.lstUrunGoster.Items.Add(item);
            }
            frm3.lblFiyat.Text = ($"Toplam Fiyat: {fiyat}");
            frm3.ShowDialog();
            
        }



       
    }
}
