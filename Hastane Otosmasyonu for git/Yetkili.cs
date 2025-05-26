using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane_Otomasyonu
{
    abstract class Yetkili:KisiselBilgiler
    {
        public  string kullanici_ad;
        public string girilenkullaniciad;
        public int girilensifre;
        public abstract bool Bilgiler_DogruMu();
        public abstract void girisYapti();

        
     
    }
}
