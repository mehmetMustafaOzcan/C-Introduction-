using Hamburgercim.Models;
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
            if (txtMenuAdi.Text !="")
            {//Seçilen boş değilse yazılanları menuye ekle
                Fonksiyonlar.AddMenu(MenuEkleListe, txtMenuAdi.Text, nupFiyat.Value);
                MessageBox.Show($"Eklenen Menu: {txtMenuAdi.Text}\nFiyat: {nupFiyat.Value}");
            }
            else
            {
                MessageBox.Show("Menü Adı Giriniz", "Menü Adı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


    }
}
