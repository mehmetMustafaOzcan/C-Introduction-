using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFADuckHunt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        PictureBox pbordek = new PictureBox();
        PictureBox pbKopek = new PictureBox();
        int atishakki = 3;
        int ordeksayisi = 1;
        int vurulan;
        Random rnd = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {

            lblOrdekSayisi.Text = ordeksayisi.ToString();
            AtisHakkiFulle();
            sescal(WFADuckHunt.Properties.Resources.start);
            pbordek.Image = WFADuckHunt.Properties.Resources.ördekucan;
            resimozellik(pbordek, 210, 60, StretchImage);
           
            pnlordekucus.Controls.Add(pbordek);

            pbKopek.Image = WFADuckHunt.Properties.Resources.ordeklikopek;
            pbKopek.Width = 150;
            pbKopek.Height = 70;
            pnlordekucus.Controls.Add(pbKopek);
            pbKopek.Top = pnlordekucus.Height;
            pbKopek.Left = (pnlordekucus.Width / 2) - (pbKopek.Width / 2);

            tmrOrdekUcus.Start();
            tmrordekyatayucus.Start();
            pbordek.Click += Pbordek_Click;
            

        }
         void  resimozellik(PictureBox pb,int width,int height,PictureBoxSizeMode sizemode)
        {
            pb.Width = width;
            pb.Height = height;
            pb.SizeMode = sizemode;

        }
          
        

        private void AtisHakkiFulle()
        {
            flpAtishakki.Controls.Clear();
            for (int i = 0; i < atishakki; i++)
            {
                PictureBox pb = new PictureBox();

                pb.Width = 45;
                pb.Height = 65;
                pb.Image = WFADuckHunt.Properties.Resources.mermi;
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                flpAtishakki.Controls.Add(pb);
            }
        }

        private void Pbordek_Click(object sender, EventArgs e)
        {
            
            AtishakkiAzalt();
            tmrordekyatayucus.Stop();
            tmrOrdekUcus.Stop();
            vurulan++;
            lblVurulan.Text = vurulan.ToString();
            sescal(WFADuckHunt.Properties.Resources.duckfalling);

            if (Convert.ToBoolean(pbordek.Tag))
            {
                pbordek.Image = WFADuckHunt.Properties.Resources.kanatsiz;
            }
            else
            {
                pbordek.Image = WFADuckHunt.Properties.Resources.kanatsizters;
            }
            tmrOluOrdek.Start();
            
            

        }

        private void AtishakkiAzalt()
        {
            if (atishakki>1)
            {
                atishakki--;
                flpAtishakki.Controls.RemoveAt(flpAtishakki.Controls.Count - 1); 
            }
            else
            {
                DialogResult oyunsonu= MessageBox.Show("Game Over, Yeniden Oynamak İster Misiniz","Bilgi",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (oyunsonu==DialogResult.Yes)
                {

                    Application.Restart();
                }
                else
                {
                    Application.Exit();
                }
            }
        }

        int yatayucushizi;
        private void tmrOrdekUcus_Tick(object sender, EventArgs e)
        {
            if (pbordek.Right >= pnlordekucus.Width)
            {
                pbordek.Tag = false;
                yatayucushizi = -5;
                pbordek.Image = WFADuckHunt.Properties.Resources.ördekucanters;
            }
            else if (pbordek.Left <= 0)
            {
                pbordek.Tag = true;
                yatayucushizi = 5;
                pbordek.Image = WFADuckHunt.Properties.Resources.ördekucan;
            }
            pbordek.Left += yatayucushizi;
        }
        int dikeyucus;
       

        public PictureBoxSizeMode StretchImage { get; private set; }

        private void tmrordekyatayucus_Tick(object sender, EventArgs e)
        {
            if (pbordek.Bottom>=pnlordekucus.Height)
            {
                dikeyucus = -5;
            }
            else if (pbordek.Top<=0)
            {
                dikeyucus = 5;
            }
            pbordek.Top += dikeyucus;
        }

        void sescal(Stream ses)
        {
            SoundPlayer sp = new SoundPlayer();
            sp.Stream = ses;
            sp.Play();

        }

        private void pnlordekucus_Click(object sender, EventArgs e)
        {
            sescal(WFADuckHunt.Properties.Resources.gunshot);
            AtishakkiAzalt();
            
        }

        private void tmrOluOrdek_Tick(object sender, EventArgs e)
        {
            if (pbordek.Top >= pnlordekucus.Height)
            {
                tmrOluOrdek.Stop();
                tmrKopekCikis.Start();
                atishakki ++;
                AtisHakkiFulle();


            }
            else
            {
                
                pbordek.Top += 5;
                
            }
            
        }

        private void tmrKopekCikis_Tick(object sender, EventArgs e)
        {
            if (pbKopek.Bottom>=pnlordekucus.Height)
            {
                sescal(WFADuckHunt.Properties.Resources.dogbarking);
                pbKopek.Top -= 7;
                
            }
            else
            {
                tmrKopekCikis.Stop();
                System.Threading.Thread.Sleep(2000);
                tmrKopekSaklan.Start();
            }
        }

        private void tmrKopekSaklan_Tick(object sender, EventArgs e)
        {
            if (pbKopek.Top<=pnlordekucus.Height)
            {
                pbKopek.Top += 7;
            }
            else
            {
                tmrKopekSaklan.Stop();

                pbordek.Image = WFADuckHunt.Properties.Resources.ördekucan;
                pbordek.Top = rnd.Next(0, pnlordekucus.Height);
                pbordek.Left = rnd.Next(0, pnlordekucus.Width);
                tmrOrdekUcus.Start();
                tmrordekyatayucus.Start();
                
                ordeksayisi++;
                lblOrdekSayisi.Text = ordeksayisi.ToString();
            }
        }
    }
}
