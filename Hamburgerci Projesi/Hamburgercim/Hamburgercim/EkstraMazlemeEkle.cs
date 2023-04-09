using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hamburgercim.Models;

namespace Hamburgercim
{

    public partial class EkstraMazlemeEkle : Form
    {
        public List<Ekstra> EkstraEkleListe;
        public EkstraMazlemeEkle()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtEkstraMalzemeEkle.Text!="")
            {
                Fonksiyonlar.AddEkstra(EkstraEkleListe, txtEkstraMalzemeEkle.Text, nupPrice.Value);
                MessageBox.Show($"Eklenen Ekstra: {txtEkstraMalzemeEkle.Text}\nFiyat: {nupPrice.Value}");
            }
            else
            {
                MessageBox.Show("Ekstra Malzeme Adı Giriniz", "Ekstra Malzeme Adı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        }
    }
}
