using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfa14._02._23Uygulamalar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void txtYazi_TextChanged(object sender, EventArgs e)
        {
           
            lblSayac.Text = (txtYazi.MaxLength-txtYazi.TextLength).ToString();
          
            lblSayac.ForeColor = Color.FromArgb(txtYazi.TextLength, 0, 0);
        }

       
    }
}
