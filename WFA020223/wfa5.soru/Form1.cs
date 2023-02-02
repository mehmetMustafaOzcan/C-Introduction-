using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfa5.soru
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            lstListe.Items.Add($"{txtAd.Text} {txtSoyad.Text} {txtSehir.Text}");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            lstListe.Items.RemoveAt(lstListe.SelectedIndex);
        }

    }
}
