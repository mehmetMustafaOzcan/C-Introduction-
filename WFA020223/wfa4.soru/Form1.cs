using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfa4.soru
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string ikinciad = "", sonAd;

            if (rbtGecti.Checked)
            {
                string ad = txtAd.Text.Trim();
                if (ad.Contains(' '))
                {
                    string[] büyükAd = ad.Split(' ');

                    //for (int i = 0; i < büyükAd.Length; i++)
                    //{
                    //    ikinciad = büyükAd[i+1];
                    //    ikinciad = ikinciad[i].ToString().ToUpper() + ikinciad.Substring(1,ikinciad.IndexOf(' '));
                    //    sonad += ikinciad;

                    //}

                    ikinciad = büyükAd[1];
                    ikinciad = ikinciad[0].ToString().ToUpper() + ikinciad.Substring(1);

                }
                else
                {
                    ad = txtAd.Text.Trim();
                    ad = ad[0].ToString().ToUpper() + ad.Substring(1);
                }


               // ad = ad[0].ToString().ToUpper() + ad.Substring(1, ad.IndexOf(' '));


                lstGecti.Items.Add(($"{ad}{ikinciad} {txtSoyad.Text.ToUpper()}"));
            }
            else if (rbtKaldi.Checked)
            {

                string ad = txtAd.Text;
                if (ad.Contains(' '))
                {
                    string[] büyükAd = ad.Split(' ');
                    ikinciad = büyükAd[1];
                    ikinciad = ikinciad[0].ToString().ToUpper() + ikinciad.Substring(1);

                }


                ad = ad[0].ToString().ToUpper() + ad.Substring(1);

                lstkaldı.Items.Add(($"{ad}{ikinciad} {txtSoyad.Text.ToUpper()}"));
            }
        }
    }
}
