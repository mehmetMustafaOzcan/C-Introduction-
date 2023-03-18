using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAAktarici
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtAktarılacak_TextChanged(object sender, EventArgs e)
        {
            lblYazi.Text = txtAktarılacak.Text;
            this.Text = txtAktarılacak.Text;
        }
    }
}
