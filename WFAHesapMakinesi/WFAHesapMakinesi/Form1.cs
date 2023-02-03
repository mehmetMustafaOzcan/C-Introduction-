using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAHesapMakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtYazi.Text += 0.ToString();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtYazi.Text += 1.ToString();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtYazi.Text += 2.ToString();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtYazi.Text += 3.ToString();

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtYazi.Text += 4.ToString();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtYazi.Text += 5.ToString();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtYazi.Text += 6.ToString();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtYazi.Text += 7.ToString();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtYazi.Text += 8.ToString();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtYazi.Text += 9.ToString();
        }

        private void button15_Click(object sender, EventArgs e)
        {

            if (txtYazi.Text != "" && !txtYazi.Text.Contains('.'))
            {
                txtYazi.Text += ",";
            }
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            lblSayilar.Text += txtYazi.Text + " + ";
            txtYazi.Clear();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtYazi.Text = string.Empty;
        }



        private void btnBol_Click(object sender, EventArgs e)
        {
            lblSayilar.Text += txtYazi.Text + " / ";
            txtYazi.Clear();
        }

        private void btnCarp_Click(object sender, EventArgs e)
        {
            lblSayilar.Text += txtYazi.Text + " * ";
            txtYazi.Clear();
        }

        private void btnCikar_Click(object sender, EventArgs e)
        {
            lblSayilar.Text += txtYazi.Text + " -";
            txtYazi.Clear();
        }
        private void button19_Click(object sender, EventArgs e)
        {
            double sonuc = 0;
            int i = 0;
            lblSayilar.Text += txtYazi.Text;
            string sayilarım = lblSayilar.Text;

            
            DataTable calc = new DataTable();          


            txtYazi.Text=calc.Compute(lblSayilar.Text, " ").ToString();
            
        }

        private void BtncE_Click(object sender, EventArgs e)
        {
            lblSayilar.Text = string.Empty;
            txtYazi.Text = string.Empty;
        }

        private void btnKokal_Click(object sender, EventArgs e)
        {

           lblSayilar.Text=( Math.Sqrt(Convert.ToDouble(txtYazi.Text))).ToString();
            txtYazi.Text = string.Empty;
        }

        private void btnKare_Click(object sender, EventArgs e)
        {
            lblSayilar.Text = (Math.Pow(Convert.ToDouble(txtYazi.Text),2)).ToString();
            txtYazi.Text = string.Empty;
        }

        
    }
}
