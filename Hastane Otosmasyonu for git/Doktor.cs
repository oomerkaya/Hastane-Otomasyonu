using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane_Otomasyonu
{
    class Doktor:Yetkili
    {
        public Doktor()
        {
            girisYapti();
        }
        public Doktor(string kullaniciAD, int girilenSIFRE)
        {
            girilenkullaniciad = kullaniciAD;
            girilensifre = girilenSIFRE;

            //default
            kullanici_ad = "d123!";
            sifre = 1234;
        }
        public override bool Bilgiler_DogruMu()
        {
            if (girilenkullaniciad == kullanici_ad && girilensifre == sifre)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override void girisYapti()
        {
            MessageBox.Show("'Doktor' giriş yaptı!");
        }
    }
}
