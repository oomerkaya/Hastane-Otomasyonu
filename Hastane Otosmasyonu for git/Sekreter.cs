using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane_Otomasyonu
{
    class Sekreter:Yetkili
    {
        public Sekreter()
        {
            girisYapti();
        }
        public Sekreter(string kullaniciAD, int girilenSIFRE)
        {
            girilenkullaniciad = kullaniciAD;
            girilensifre = girilenSIFRE;

            //default
            kullanici_ad = "s123!";
            sifre = 4321;
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
            MessageBox.Show("'Sekreter' giriş yaptı!");
        }
    }
}
