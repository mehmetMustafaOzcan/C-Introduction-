using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _160223Ödev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSifreOlustur_Click(object sender, EventArgs e)
        {
            lblSonuclar.Text = "";

            string sifre = ""; //Guid.NewGuid().ToString("N").Substring(0, (int)nudSifreUzunluk.Value);
            Random rnd = new Random();
            string harfler = "abcdefghıijklmnoöprsştuüvyz";
            string ozelkar = "!'^+&/()=?_.:;";
            string sayilar = "0123456789";
            if (chkKucukHRF.Checked|| ChkBuyukHarf.Checked|| chkOzelKar.Checked|| chkDigit.Checked)
            {

                for (int j = 0; j < nudSifreSayisi.Value; j++)
                {
                    for (int i = 0; i < nudSifreUzunluk.Value;)
                    {
                        
                        if (chkKucukHRF.Checked)
                        {
                            sifre += harfler[rnd.Next(0, 26)];
                            i++;
                        }
                        if (ChkBuyukHarf.Checked && i < nudSifreUzunluk.Value)
                        {
                           sifre= sifre.Insert(rnd.Next(0, sifre.Length), harfler[rnd.Next(0,26)].ToString().ToUpper());//rastegele bir sıraya harf insert et.
                            i++;
                        }
                        if (chkDigit.Checked && i < nudSifreUzunluk.Value)
                        {
                            sifre = sifre.Insert(rnd.Next(0, sifre.Length), sayilar[rnd.Next(0, sayilar.Length)].ToString());//rastegele bir sıraya karakter insert et.
                            i++;
                        }
                        if (chkOzelKar.Checked && i < nudSifreUzunluk.Value)
                        {
                            sifre = sifre.Insert(rnd.Next(0, sifre.Length),ozelkar[rnd.Next(0, ozelkar.Length)].ToString());
                            i++;
                        }
                        

                    }
                    lblSonuclar.Text += $"{j+1}) {sifre}\n\n";
                    sifre = "";
                }
            }
            else
            {
                MessageBox.Show("Seçenek Seçin");
            }
          

            
        }
    }
}
