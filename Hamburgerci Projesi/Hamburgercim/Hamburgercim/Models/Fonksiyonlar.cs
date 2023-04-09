using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hamburgercim.Models
{
    internal class Fonksiyonlar
    {/// <summary>
     /// Gonderilen 'Ekstra' tipli listeye Ekstra adı adı ve fiyat bilgileri set eder
     /// </summary>
     /// <param name="Ekstra "></param>
     /// <param name="ekstraName"></param>
     /// <param name="price"></param>
        public static void AddEkstra(List<Ekstra> list, string ekstraName, decimal price)
       
        {
            list.Add(new Ekstra() { Name = ekstraName, Price = price });
        }
        /// <summary>
        /// gonderilen 'Menu' tipli listeye menu adı ve fiyat bilgileri set eder
        /// </summary>
        /// <param name="list"></param>
        /// <param name="menuName"></param>
        /// <param name="price"></param>
        public static void AddMenu(List<Menu> list,string menuName, decimal price)
        {
            list.Add(new Menu() { Name = menuName, Price = price });
        }
        public static void CloseAllForm(Form mainForm,Form mdiChild)//açılan hariç tum formları kapat
        {
            foreach (Form frm in mainForm.MdiChildren)
            {
                if (frm != mdiChild)
                {
                    frm.Dispose();
                    frm.Close();
                }
            }

        }
    }
}
