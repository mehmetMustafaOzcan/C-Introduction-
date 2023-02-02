using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA020223
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTarih_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            DateTime dt = DateTime.Now;

            txtTarih.Text = dt.ToString("yyyy-MM-dd");
            txtGun.Text = dt.ToString("dddd dd dd");

            txtGun.ForeColor = Color.FromArgb(rnd.Next(0,255), rnd.Next(0,255), rnd.Next(0,255));
          
        }
    }
}
