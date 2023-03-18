using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAAcikKapaliTipDonusumler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            short kucukksayı = 12345;
            int buyuksayı = kucukksayı;  //int, shortu kapsadığı için kapalı tip dönüşüm.

            string sayı = "1234";
            int x = Convert.ToInt32(sayı); //açık tip dönüşüm

            int deger = int.Parse(sayı); //parse yöntemi çeviri

            double x1= 25.25;
            int x2 = (int)x1;  //cast yöntemi

            MessageBox.Show(x2.ToString());
        }
    }
}
