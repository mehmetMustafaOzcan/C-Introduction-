using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
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
        // Anaform olduğu için tüm veriler aşağıdaki tanımlı fieldlarda taplanması için oluşturuldu.
        public List<Menu> Menuler = new List<Menu>();
        public List<Ekstra> EkstraMalzeme = new List<Ekstra>();
        public Siparis siparis = new Siparis();
        private void siparişBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SiparisEkrani siparisolustur = new SiparisEkrani();
            Fonksiyonlar.CloseAllForm(this, siparisolustur);

            //Açılan formdaki 'siparis2' nesnem ile bu sayfadaki 'siparis' nesnemi eşitle, diğer satrılardaki eşitlemelerde aynı şekilde.
            siparisolustur.siparis2 = siparis;
            siparisolustur.MenulerSE = Menuler;
            siparisolustur.Ekstralar = EkstraMalzeme;
            siparisolustur.MdiParent = this;
                            
            siparisolustur.Show();


        }

        private void menüEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuEkle MenuEkle = new MenuEkle();
            Fonksiyonlar.CloseAllForm(this, MenuEkle);
          //Açılan formdaki 'MenuEkleListe' listesi ile bu sayfadaki 'Menuler' listemi eşitle
            MenuEkle.MenuEkleListe = Menuler;
            MenuEkle.MdiParent = this;
            MenuEkle.Show();
        }

        private void ekstraMalzemeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EkstraMazlemeEkle EkstraMalzemeEkleEkranı = new EkstraMazlemeEkle();
         //Açılan formdaki 'EkstraEkleListe' listesi ile bu sayfadaki 'EkstraMalzeme' listemi eşitle
            EkstraMalzemeEkleEkranı.EkstraEkleListe = EkstraMalzeme;
            EkstraMalzemeEkleEkranı.MdiParent = this;
            Fonksiyonlar.CloseAllForm(this, EkstraMalzemeEkleEkranı);
            EkstraMalzemeEkleEkranı.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Default menuleri ekleme
            Fonksiyonlar.AddMenu(Menuler, "BigKing", 50);
            Fonksiyonlar.AddMenu(Menuler, "KingChicken", 45);
            Fonksiyonlar.AddMenu(Menuler, "SteakHouse Menü", 45);
            Fonksiyonlar.AddMenu(Menuler, "Whooper Menü", 45);
            Fonksiyonlar.AddMenu(Menuler, "Whooper Junier Menü", 45);
            Fonksiyonlar.AddMenu(Menuler, "KingChicken", 45);
            
            
            //Default Ekstra Malzeme Ekleme
            Fonksiyonlar.AddEkstra(EkstraMalzeme,"Ranch", 5);
            Fonksiyonlar.AddEkstra(EkstraMalzeme,"Ketçap", 5);
            Fonksiyonlar.AddEkstra(EkstraMalzeme,"BBQ", 5);
            Fonksiyonlar.AddEkstra(EkstraMalzeme,"Hardal", 5);
            Fonksiyonlar.AddEkstra(EkstraMalzeme,"Mayonez", 5);
            Fonksiyonlar.AddEkstra(EkstraMalzeme,"Buffalo", 5);

            //Dosya kayıt işlemi ile siparişler hiç silinmiyor.
            using (Stream stream = new FileStream("./tumsiparisler.xml", FileMode.OpenOrCreate, FileAccess.Read))
            {
                XmlSerializer xml = new XmlSerializer(typeof(Siparis));
                try
                {
                    siparis = (Siparis)xml.Deserialize(stream);
                }
                catch (Exception) { }
               
            }

        }

        private void siparişBilgileriToolStripMenuItem1_Click(object sender, EventArgs e)
        {
       //Bu secenek sipariş ekranı sayfasındaki siparişi tamamla butonu ile ayn işleve sahip olduğu için alt satırda eşitlemeler yapıldı.
            SiparisEkrani siparisolustur = new SiparisEkrani();
            siparisolustur.siparis2 = siparis;
            Fonksiyonlar.CloseAllForm(this, siparisolustur);
            siparisolustur.button2_Click_1(sender, e);
        }
    }
}
