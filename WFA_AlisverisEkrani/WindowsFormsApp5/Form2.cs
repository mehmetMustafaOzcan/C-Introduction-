using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlisverisEkrani
{
    public partial class Form2 : Form
    {
       // public List<string> urunler;
        public Form2()
        {
            InitializeComponent();

        }

        public List<string> urunler2;
        private void Form2_Load(object sender, EventArgs e)
        {
           // Form1 frm1 = new Form1();
            lblKarsilama.Text = $"Hoşgeldin {Form1.adsoyad}";
          
        }
        Form1 frm1 = new Form1();
       decimal fiyat;
        private void btnEkle_Click(object sender, EventArgs e)
        {         
                        
            if (lstBebek.SelectedItem!=null)
            {

                foreach (string item in lstBebek.SelectedItems)
                {
                    urunler2.Add(item.ToString());
                   
                    if (item == "Bebek Bezi")
                        fiyat += 100;
                     else if (item == "Islak Mendil")
                        fiyat += 10;
                    
                }
                lstBebek.SelectedItems.Clear();
            }
            else if (lstKirtasiye.SelectedItem!=null)
            {
                foreach (string item in lstKirtasiye.SelectedItems)
                {
                    urunler2.Add(item.ToString());
                    
                }
                 
                lstKirtasiye.SelectedItems.Clear();
            }
            else if (lstKiyafet.SelectedItem!=null)
            {
                foreach (string item in lstKiyafet.SelectedItems)
                {
                    urunler2.Add(item.ToString());
                    if (item == "Etek")
                        fiyat += 150;
                    else if (item == "Bluz")
                        fiyat += 110;
                }
               
                lstKiyafet.SelectedItems.Clear();
            }
            lstBebek.SelectedItems.Clear();
            // frm1.urunler = urunler2;

            Form1.fiyat = fiyat;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstKiyafet.SelectedItems.Clear();
            lstKirtasiye.SelectedItems.Clear();
            lstBebek.SelectedItems.Clear();
        }
    }
}
