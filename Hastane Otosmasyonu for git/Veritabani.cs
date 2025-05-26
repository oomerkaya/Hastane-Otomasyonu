using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Hastane_Otomasyonu
{
   class Veritabani
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=GIGABYTE-AORUS;Initial Catalog=Hastane_Otomasyonu;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
        public virtual void VeriTabaninaKaydet()
        {

        }
        



    }
}
