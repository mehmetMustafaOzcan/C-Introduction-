using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgercim.Models
{
    public class Siparis
    {
        public decimal Ciro { get; set; }
        public decimal ToplamSiparisSayisi { get; set; }
        public decimal EkstraMalzemeGeliri { get; set; }
        public decimal SatılanUrunAdeti { get; set; }
        public List<string> TumSiparisler = new List<string>();
    }
}
