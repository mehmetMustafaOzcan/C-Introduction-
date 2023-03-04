using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Menu = Hamburgercim.Models.Menu;



namespace Hamburgercim
{
    
    public partial class MenuEkle : Form
    {
        public MenuEkle()
        {
            InitializeComponent();
        }
        public List<Menu> MenuEkleListe;
        private void btnMenuKaydet_Click(object sender, EventArgs e)
        {
            MenuEkleListe.Add(new Menu() { Name = txtMenuAdi.Text , Price = nupFiyat.Value });
        }
    }
}
