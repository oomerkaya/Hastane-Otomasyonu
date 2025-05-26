using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane_Otomasyonu
{
   class KisiselBilgiler:Veritabani
    {
        public string ad;
        public string soyad;
        public char cinsiyet;
        private string tc;
        public int dogumyılı;
        public int sifre;
        public string TC {
            get { return tc; }
            set { 
                if (value[0] == '0'||value.Length!=11)
                {
                   throw new Exception("T.C kimlik numarası '0' ile başlayamaz lütfen kimlik numaranızı kontrol ediniz.");
                }
                else
                {
                    tc = value;
                }
                    
             }
        }
       public override void VeriTabaninaKaydet()
        {
            SqlCommand komut = new SqlCommand("insert into Table_HastaBilgi (HastaAd,HastaSoyad,HastaTC,HastaCinsiyet,HastaDogumYili,HastaSifre) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti());

            komut.Parameters.AddWithValue("@p1", ad);
            komut.Parameters.AddWithValue("@p2", soyad);
            komut.Parameters.AddWithValue("@p3", tc);
            komut.Parameters.AddWithValue("@p4", cinsiyet);
            komut.Parameters.AddWithValue("@p5", dogumyılı);
            komut.Parameters.AddWithValue("@p6", sifre);
            komut.ExecuteNonQuery();

            baglanti().Close();

        }
    }
}
