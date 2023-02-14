using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2.soru
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*1- )Eğer şifre 6 karakterden az ise düşük
             2-) Eğer şifre 6 karakterden fazla ve sadece tek tip karakter içeriyorsa //(harf - sayi - özel karakter) => düşük
             3-) Eğer şifre 6 karakterden fazla ve üçlü kombinasyon varsa  yüksek
             4-) Eğer şifre 6 karakterde fazla ve iki tip karakterden oluşuyorsa(harfSayi - harfOzelKarakter - sayiÖzelKarakter) => orta*/

        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {
            int sayac = 0;
           
            if (txtSifre.TextLength < 6)
            {
                lblZorlukDerecesi.ForeColor = Color.Red;
                lblZorlukDerecesi.Text = "Düşük";
            }
            else if (txtSifre.TextLength >= 6)
            {
                foreach (var item in txtSifre.Text)
                {
                    if ((item >= 'a' && item <= 'z')|| (item >= 'A' && item <= 'Z'))
                    {
                        sayac++;
                        break;
                    }
                }
                foreach (var item in txtSifre.Text)
                {
                    if (item >= '0' && item <= '9')
                    {
                        sayac++;
                        break;
                    }
                }
                foreach (var item in txtSifre.Text)
                {
                    if ((item >= '!' && item <= '/') || (item >= ':' && item <= '@'))
                    {
                        sayac++;
                        break;
                    }
                }
                if (sayac == 3)
                {
                    lblZorlukDerecesi.ForeColor = Color.Green;
                    lblZorlukDerecesi.Text = "Yüksek";
                }
                else if (sayac == 2)
                {
                    lblZorlukDerecesi.ForeColor = Color.Goldenrod;
                    lblZorlukDerecesi.Text = "Orta";
                }
                else
                {
                    lblZorlukDerecesi.ForeColor = Color.Red;
                    lblZorlukDerecesi.Text = "Düşük";
                }
                
            }
           
        }
    }
}

