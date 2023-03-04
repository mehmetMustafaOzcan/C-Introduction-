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
    public partial class SiparisEkrani : Form
    {
        public SiparisEkrani()
        {
            InitializeComponent();
        }
        public List<Menu> MenulerSE;//= new List<Menu>();
        public List<Ekstra> Ekstralar;//= new List<Ekstra>();
        public Siparis siparis2;        
        decimal sizePrice = 1;
        decimal mainPrice = 0;
        decimal ekstra;
        decimal totalPrice = 0;
        string size, ekstraisimleri;

        private void Form2_Load(object sender, EventArgs e)
        {
            MenulerSE.Clear();
            Ekstralar.Clear();
            AddMenu("BigKing", 50);
            AddMenu("Double King Chicken", 45);
            AddEkstra("Ranch", 5);
            AddEkstra("Ketçap", 5);
            AddEkstra("BBQ", 5);
            AddEkstra("Hardal", 5);
            AddEkstra("Mayonez", 5);
            AddEkstra("Buffalo", 5);


            foreach (var item in Ekstralar)
            {
                CheckBox chk = new CheckBox();
                chk.Name = $"chk{item}";
                chk.Text = item.Name;
                
                 flpEkstra.Controls.Add(chk);  
            }
            
            


            foreach (var item in MenulerSE)
            {
                

                cbMenuSelect.Items.Add(item.Name);
            }

        }
        private void AddEkstra(string ekstraName, decimal price)
        {
            Ekstralar.Add(new Ekstra() { Name = ekstraName, Price = price });
        }

        private void AddMenu(string menuName, decimal price)
        {
            MenulerSE.Add(new Menu() { Name = menuName, Price = price });
        }

        private void cbMenuSelect_SelectedIndexChanged(object sender, EventArgs e)
        {

            foreach (var item in MenulerSE)
            {
                if (cbMenuSelect.SelectedItem == item.Name)
                {
                    mainPrice = item.Price;
                }

            }
            gbSize.Enabled = true;
            // lblTotalPrice.Text = Math.Round(mainPrice, 2).ToString();
        }

        //private void rbMiddle_CheckedChanged(object sender, EventArgs e)
        //{
        //    sizePrice = rbMiddle.Checked ? mainPrice * 1.05m : mainPrice;

        //    lblTotalPrice.Text = Math.Round(PriceWithSize, 2).ToString();
        //}

        //private void rbBig_CheckedChanged(object sender, EventArgs e)
        //{
        //    PriceWithSize = rbBig.Checked ? mainPrice * 1.1m : mainPrice;

        //    lblTotalPrice.Text = Math.Round(PriceWithSize, 2).ToString();
        //}

        //private void flpEkstra_MouseClick(object sender, MouseEventArgs e)
        //{


        //    lblTotalPrice.Text = Math.Round(PriceWithSize + ekstra, 2).ToString();
        //}

        private void EkstraKontrol()//checkboxları kontrol et ekli olanları al
        {
            ekstra = 0;
            ekstraisimleri = String.Empty;
            foreach (var item in flpEkstra.Controls.OfType<CheckBox>())
            {
                if (item.Checked)
                {
                    foreach (var ekstralar in Ekstralar)
                    {
                        if (item.Text == ekstralar.Name)
                        {
                            ekstra += ekstralar.Price;
                            ekstraisimleri += item.Text + " ";
                            break;

                        }

                    }
                }
            }
        }


        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {
            EkstraKontrol();
            SizeControl();            
            totalPrice += (nupPiece.Value * (mainPrice + sizePrice + ekstra));
            lblTotalPrice.Text = totalPrice.ToString();

            lstSiparisler.Items.Add($"{(cbMenuSelect.Text)} {nupPiece.Value} adet, {size} boy ({ekstraisimleri}) Toplam {lblTotalPrice.Text} ");

            siparis2.EkstraMalzemeGeliri += ekstra;
            siparis2.ToplamSiparisSayisi += lstSiparisler.Items.Count;
            siparis2.SatılanUrunAdeti+= nupPiece.Value;
            siparis2.Ciro += totalPrice;


        }

      
        private void button2_Click_1(object sender, EventArgs e)
        {
            TumSiparisler tumSiparisler = new TumSiparisler();
            tumSiparisler.MdiParent = ActiveForm;
            tumSiparisler.lblCiro.Text = siparis2.Ciro.ToString();
            tumSiparisler.lblSİparişSayisi.Text =siparis2.ToplamSiparisSayisi.ToString();
            tumSiparisler.lblSatilanUrun.Text = siparis2.SatılanUrunAdeti.ToString();

            tumSiparisler.Show();
        }

        private void SizeControl()
        {
            sizePrice = 0;
            foreach (var item in gbSize.Controls.OfType<RadioButton>())
            {
                if (item == rbBig && item.Checked)
                {
                    sizePrice = mainPrice * 0.1m;
                    size = item.Text;
                }

                else if (item == rbMiddle && item.Checked)
                {
                    sizePrice = mainPrice * 0.05m;
                    size = item.Text;
                }

            }
        }
    }
}

