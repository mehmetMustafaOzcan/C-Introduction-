using Hamburgercim.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using Menu = Hamburgercim.Models.Menu;

namespace Hamburgercim
{
    public partial class SiparisEkrani : Form
    {
        public SiparisEkrani()
        {
            InitializeComponent();
        }
        
        public List<Menu> MenulerSE;
        public List<Ekstra> Ekstralar;
        public Siparis siparis2;
      
        decimal sizePrice = 1, mainPrice = 0, ekstra, totalPrice = 0, singleProductPrice;
        string size, ekstraisimleri;

        private void Form2_Load(object sender, EventArgs e)
        {
            foreach (var item in Ekstralar)
            {
                CheckBox chk = new CheckBox();
                chk.Name = $"chk{item}";//checbox name set etme
                chk.Text = item.Name;//Ekstralar listemdeki Ekstra nesnemin adını chkbox textine yaz

                flpEkstra.Controls.Add(chk);//flowloyaouta ilgili checkboxu ekle. 
            }//Ekstralar listemdeki tüm nesneleri ekleme

            foreach (var item in MenulerSE)//MenulerSE listemdeki tüm nesneleri ekleme
            {
                cbMenuSelect.Items.Add(item.Name);
            }
        }
        private void cbMenuSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in MenulerSE)
         //MenulerSE listemdeki isimle comboboxdaki seçilenin ismi aynı ise mainPrice set et.
            {
                if (cbMenuSelect.SelectedItem == item.Name)
                {
                    mainPrice = item.Price;
                }
            }
            gbSize.Enabled = true;            
        }
        string siparisMetni;
        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {
            try
            {
                EkstraKontrol();//ekstra sos fiyat kontrolü
                SizeControl();//boyut set et
                singleProductPrice = nupPiece.Value * (mainPrice + sizePrice + ekstra);
                // singleProductPrice => son seçilen siparişlerin fiyatı

                DialogResult dr = MessageBox.Show($" ₺ {singleProductPrice} Siparişi Onaylıyor Musunuz?", "Siparişi Tamamla", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    totalPrice += (nupPiece.Value * (mainPrice + sizePrice + ekstra));
                    lblTotalPrice.Text = $"{totalPrice} ₺";
                    siparisMetni = $"{(cbMenuSelect.Text)} {nupPiece.Value} adet, {size} boy ( {ekstraisimleri} ) Toplam {nupPiece.Value * (mainPrice + sizePrice + ekstra) } ₺";

                    lstSiparisler.Items.Add(siparisMetni);

                    SetSiparisInfo();
                    ClearAllSelected();
                }
                else
                {
                    MessageBox.Show("İptal Edildi");
                    ClearAllSelected();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lütfen Menü ve {ex.Message}");
            }

        }
        public void button2_Click_1(object sender, EventArgs e)
        {
            TumSiparisler tumSiparisler = new TumSiparisler();
            tumSiparisler.MdiParent = ActiveForm;
            tumSiparisler.lblCiro.Text = siparis2.Ciro.ToString();
            tumSiparisler.lblSiparisSayisi.Text = siparis2.ToplamSiparisSayisi.ToString();
            tumSiparisler.lblSatilanUrun.Text = siparis2.SatılanUrunAdeti.ToString();
            tumSiparisler.lblEkstraMalzeme.Text = siparis2.EkstraMalzemeGeliri.ToString();
            tumSiparisler.lstTumSiparis.Items.AddRange(siparis2.TumSiparisler.ToArray());

            using (Stream stream = new FileStream("./tumsiparisler.xml", FileMode.Create, FileAccess.Write))
            {
                XmlSerializer xml = new XmlSerializer(typeof(Siparis));
                xml.Serialize(stream, siparis2);

            }


                this.Close();

            tumSiparisler.Show();
        }

        private void SizeControl()
        {
            sizePrice = 0;
            foreach (var item in gbSize.Controls.OfType<RadioButton>())
            {//groupbozdeki radiobuttonlara bak ve seçili olanlara gore ekstra fiyat ve seçilenin adını set et.
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
                else if (item == rbSmall && item.Checked)
                {
                    sizePrice = 0;
                    size = item.Text;
                }
               
            }
            if (size == null)//hiçbiri seçilmedi ise hata gönder
            {
                throw new Exception("Boyut Seçiniz");
            }

        }//Küçük -orta-büyük boyut kontrolü
        private void EkstraKontrol()//checkboxları kontrol et ekli olanları fiat ve isimlerini al
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
        private void ClearAllSelected()
        {
            cbMenuSelect.SelectedIndex = -1;
            gbSize.Enabled = false;
            size = null;
            foreach (var item in gbSize.Controls.OfType<RadioButton>())
            {
                item.Checked = false;
            }
            foreach (var item in flpEkstra.Controls.OfType<CheckBox>())
            {
                item.Checked = false;
            }
            nupPiece.Value = 1;
        }
        private void SetSiparisInfo()
        {//fiyat bilgilerini sipariş sınıfı nesneme set et, bu bilgi anasayfadaki sipiariş nesnem ile eşitelndiği için bilgiler her zaman güncel ve kaybolmuyor.
            siparis2.Ciro += singleProductPrice;
            siparis2.EkstraMalzemeGeliri += ekstra;
            siparis2.SatılanUrunAdeti += nupPiece.Value;
            siparis2.ToplamSiparisSayisi++;//her tık 1 sipariş
            siparis2.TumSiparisler.Add(siparisMetni);
        }
    }
}

