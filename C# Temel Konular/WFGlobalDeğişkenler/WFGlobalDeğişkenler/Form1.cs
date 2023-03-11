using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFGlobalDeğişkenler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string firmaAdi;
        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show(firmaAdi);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            firmaAdi = "MustafaÖzcan";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(firmaAdi);
        }
    }
}
