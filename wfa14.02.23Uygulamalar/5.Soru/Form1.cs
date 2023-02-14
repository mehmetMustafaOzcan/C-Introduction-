using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5.Soru
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string durum = "";
            double sonuc = 0;
            string isim = txtAd.Text.Trim();
             isim =txtAd.Text[0].ToString().ToUpper() + txtAd.Text.Substring(1).ToLower();         

            if (!txtAd.Text.Any(char.IsDigit)|| !txtAd.Text.Any(char.IsPunctuation))
            {
                if (txtAd.Text.Contains(' '))
                {
                    
                    string[] isimler = isim.Split(' ');

                    for (int i = 0; i < isimler.Length; i++)
                    {
                        isimler[i] = isimler[i][0].ToString().ToUpper() + isimler[i].ToString().Substring(1).ToLower();

                    }

                    foreach (var item in isimler)
                    {
                        isim += item + " ";
                    }
                }
                try
                {
                    int not1 = Convert.ToInt32(txtS1.Text);
                    int not2 = Convert.ToInt32(txtS2.Text);
                    int not3 = Convert.ToInt32(txtS3.Text);

                    if (not1<100&& not2 < 100 && not3 < 100 && not1 > 0 && not2 > 0 && not3 > 0)
                    {
                        sonuc = Convert.ToDouble((not1 + not2 + not3) / 3d);
                        if (sonuc >= 50)
                        {
                            durum = "Geçti";
                        }
                        else if (sonuc < 50)
                        {
                            durum = "Kaldı";
                        }

                        Form2 frm2 = new Form2();

                        frm2.lblAd.Text = isim + " " + txtSoyad.Text.ToUpper();
                        frm2.lblBasariDur.Text = durum;
                        frm2.lblOrt.Text = Math.Round(sonuc, 2).ToString();
                        frm2.ShowDialog(); 
                    }
                    else
                    {
                        MessageBox.Show("Notu sadece 0-100 arası giriniz");
                        
                    }

                }
                catch (Exception)
                {

                    MessageBox.Show("Sadece sayi giriniz");
                    Application.Restart();
                   // Application.Exit();
                }

            }
            else
            {
                MessageBox.Show("Lütfen Gerçek İsim Giriniz");
            }


            

        }
    }
}
