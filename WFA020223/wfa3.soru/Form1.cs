using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfa3.soru
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
             
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            try
            {
                decimal maas = Convert.ToDecimal(txtMaas.Text);
                decimal zam = 0;

                if (rbtEvli.Checked)
                {
                    zam += rbtCs0.Checked ? maas * 0m : 0;
                    zam += rbtCs1.Checked ? maas * 0.05m : 0;
                    zam += rbtCs2.Checked ? maas * 0.10m : 0;
                    zam += rbtcs3u.Checked ? maas * 0.15m : 0;

                }

                zam += chkArapca.Checked ? maas * 0.1m : 0;
                zam += chkIng.Checked ? maas * 0.1m : 0;
                zam += chkItl.Checked ? maas * 0.05m : 0;
                zam += chkYun.Checked ? maas * 0.025m : 0;
                zam += ChkAlm.Checked ? maas * 0.1m : 0;
                zam += ChkFr.Checked ? maas * 0.1m : 0;

                lblSonuc.Text = ($"Aldığınız zam {zam} \n Toplam maaşınız{maas + zam}").ToString();

            }
            catch 
            {

                MessageBox.Show("Lütfen Giriş yapınız");
            }
        }
    }
}
