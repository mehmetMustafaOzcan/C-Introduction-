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

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            decimal girilen =Convert.ToDecimal(txtUcret.Text);
            decimal ucret = 0,ybucret=0,youcret=0,sonuc;

            

            if (chky10.Checked)
            {
                ucret = (girilen * (0.1m));
            }
            if (chky5.Checked)
            {
                ybucret = (girilen * (0.05m));
            }
            if (chkYO10.Checked)
            {
                youcret = (girilen * (0.1m));
            }

            sonuc = girilen - ucret - ybucret - youcret;
            lblSonuc.Text = sonuc.ToString();
        }
            

        }
    }

