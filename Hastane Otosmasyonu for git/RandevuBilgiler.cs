using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane_Otomasyonu
{
    class RandevuBilgiler:KisiselBilgiler
    {
        public  string[,] branslar_doktorlar = new string[22, 3];
        public string bransad;
        public string randevu_saati;
        public DateTime randevutarih;
        
        //atama
        public RandevuBilgiler()
        {
            branslar_doktorlar[0, 0] = "Acil Tıp";
            branslar_doktorlar[0, 1] = "Harun Dönmez";
            branslar_doktorlar[0, 2] = "Olcay Yılmaz";

            branslar_doktorlar[1, 0] = "Ağız ve Diş Sağlığı";
            branslar_doktorlar[1, 1] = "Mert Demir";
            branslar_doktorlar[1, 2] = "Süleyman Demir";

            branslar_doktorlar[2, 0] = "Beyin ve Sinir Cerrahi";
            branslar_doktorlar[2, 1] = "Ahmet Kılıç";
            branslar_doktorlar[2, 2] = "Zeynep Kaya";

            branslar_doktorlar[3, 0] = "Çocuk Cerrahisi";
            branslar_doktorlar[3, 1] = "Fatma Yılmaz";
            branslar_doktorlar[3, 2] = "Ali Demir";

            branslar_doktorlar[4, 0] = "Çocuk Sağlığı ve Hastalıkları";
            branslar_doktorlar[4, 1] = "Burcu Aydın";
            branslar_doktorlar[4, 2] = "Murat Şahin";

            branslar_doktorlar[5, 0] = "Dahiliye";
            branslar_doktorlar[5, 1] = "Kemal Can";
            branslar_doktorlar[5, 2] = "Neslihan Ay";

            branslar_doktorlar[6, 0] = "Dermatoloji";
            branslar_doktorlar[6, 1] = "Selin Yıldız";
            branslar_doktorlar[6, 2] = "Barış Özcan";

            branslar_doktorlar[7, 0] = "Fizik Tedavi ve Rehabilitasyon";
            branslar_doktorlar[7, 1] = "Hüseyin Koç";
            branslar_doktorlar[7, 2] = "Meryem Demirtaş";

            branslar_doktorlar[8, 0] = "Genel Cerrahi";
            branslar_doktorlar[8, 1] = "Mustafa Arslan";
            branslar_doktorlar[8, 2] = "Sevgi Can";

            branslar_doktorlar[9, 0] = "Göz Hastalıkları";
            branslar_doktorlar[9, 1] = "Zeynep Kaya";
            branslar_doktorlar[9, 2] = "Serkan Yıldırım";

            branslar_doktorlar[10, 0] = "Gastroenteroloji";
            branslar_doktorlar[10, 1] = "Ozan Yılmaz";
            branslar_doktorlar[10, 2] = "Eda Arıkan";

            branslar_doktorlar[11, 0] = "Kardiyoloji";
            branslar_doktorlar[11, 1] = "Selim Kılıç";
            branslar_doktorlar[11, 2] = "Nalan Demir";

            branslar_doktorlar[12, 0] = "Kulak, Burun, Boğaz";
            branslar_doktorlar[12, 1] = "Ferhat Arslan";
            branslar_doktorlar[12, 2] = "Tülay Doğan";

            branslar_doktorlar[13, 0] = "Kalp ve Damar Cerrahisi";
            branslar_doktorlar[13, 1] = "Ahmet Dönmez";
            branslar_doktorlar[13, 2] = "Murat Kaya";

            branslar_doktorlar[14, 0] = "Onkoloji";
            branslar_doktorlar[14, 1] = "Esra Yılmaz";
            branslar_doktorlar[14, 2] = "Zafer Demir";

            branslar_doktorlar[15, 0] = "Ortopedi ve Travmatoloji";
            branslar_doktorlar[15, 1] = "Seda Koç";
            branslar_doktorlar[15, 2] = "Burak Şahin";

            branslar_doktorlar[16, 0] = "Nöroloji";
            branslar_doktorlar[16, 1] = "Meltem Yılmaz";
            branslar_doktorlar[16, 2] = "Cemil Arslan";

            branslar_doktorlar[17, 0] = "Plastik Cerrahi";
            branslar_doktorlar[17, 1] = "Deniz Çelik";
            branslar_doktorlar[17, 2] = "Ali Özdemir";

            branslar_doktorlar[18, 0] = "Patoloji";
            branslar_doktorlar[18, 1] = "Sibel Kaya";
            branslar_doktorlar[18, 2] = "Fikret Yılmaz";

            branslar_doktorlar[19, 0] = "Psikiyatri";
            branslar_doktorlar[19, 1] = "Nedim Aksoy";
            branslar_doktorlar[19, 2] = "Hülya Yavuz";

            branslar_doktorlar[20, 0] = "Radyoloji";
            branslar_doktorlar[20, 1] = "Cemre Demirtaş";
            branslar_doktorlar[20, 2] = "Gökhan Çelik";


            branslar_doktorlar[21, 0] = "Üroloji";
            branslar_doktorlar[21, 1] = "Hakan Yıldırım";
            branslar_doktorlar[21, 2] = "Cemil Çiçek";

        }
        public RandevuBilgiler(string adsoyad,string Tc)
        {
            
            ad = adsoyad;
            TC = Tc;
        }

        public override void VeriTabaninaKaydet()
        {
            SqlCommand komut = new SqlCommand("insert into Table_RandevuBilgi (RandevuBrans, DoktorAd_Soyad, Hastatc, RandevuSaat, RandevuTarih) values (@p1,@p2,@p3,@p4,@p5)",baglanti());
            
            komut.Parameters.AddWithValue("@p1", bransad);
            komut.Parameters.AddWithValue("@p2", ad);
            komut.Parameters.AddWithValue("@p3", TC);
            komut.Parameters.AddWithValue("@p4", randevu_saati);
            komut.Parameters.AddWithValue("@p5", randevutarih);
            komut.ExecuteNonQuery();

            baglanti().Close();

        }
    }
}
