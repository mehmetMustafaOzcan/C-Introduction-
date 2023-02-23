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
using Menu = Hamburgercim.Models.Menu;
namespace Hamburgercim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public List<Menu> Menuler = new List<Menu>();

        public List<Ekstra> EkstraMalzeme = new List<Ekstra>();
        public Siparis siparis = new Siparis();
        private void siparişBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SiparisEkrani siparisolustur = new SiparisEkrani();

            siparisolustur.MenulerSE = Menuler;
            siparisolustur.Ekstralar = EkstraMalzeme;
            siparisolustur.siparis2 = siparis;
            siparisolustur.MdiParent = this;
            
            siparisolustur.Show();

        }

        private void menüEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuEkle MenuEkle = new MenuEkle();

            MenuEkle.MenuEkleListe = Menuler;
            MenuEkle.MdiParent = this;
            MenuEkle.Show();
        }

        private void ekstraMalzemeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EkstraMazlemeEkle EkstraMalzemeEkleEkranı = new EkstraMazlemeEkle();
            EkstraMalzemeEkleEkranı.EkstraEkleListe = EkstraMalzeme;
            EkstraMalzemeEkleEkranı.MdiParent = this;
            EkstraMalzemeEkleEkranı.Show();
        }
        
    }
}
