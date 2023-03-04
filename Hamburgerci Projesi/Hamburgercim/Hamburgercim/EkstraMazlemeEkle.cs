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
            EkstraEkleListe.Add(new Ekstra() { Name = txtEkstraMalzemeEkle.Text, Price = nupPrice.Value });

        }
    }
}
