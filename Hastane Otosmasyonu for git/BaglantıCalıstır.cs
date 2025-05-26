using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane_Otomasyonu
{
    class BaglantıCalıstır_Yönlendir
    {
        public static void BaglantiCalistir(int no)
        {
            if (no == 1)//instagram
            {
                var psi = new System.Diagnostics.ProcessStartInfo
                {
                    FileName = "https://www.instagram.com/pauhastane",
                    UseShellExecute = true
                };
                System.Diagnostics.Process.Start(psi);
            }
            else if (no == 2)//youtube
            {
                var psi = new System.Diagnostics.ProcessStartInfo
                {
                    FileName = "https://www.youtube.com/channel/UCRbsEyX-6tkpaxvZ8Ec1AVA",
                    UseShellExecute = true
                };
                System.Diagnostics.Process.Start(psi);
            }
            else if (no == 3)//twitter
            {
                var psi = new System.Diagnostics.ProcessStartInfo
                {
                    FileName = "https://twitter.com/pauhastane",
                    UseShellExecute = true
                };
                System.Diagnostics.Process.Start(psi);
            }
            else if(no == 4)//Paü
            {

                var psi = new System.Diagnostics.ProcessStartInfo
                {
                    FileName = "https://www.pau.edu.tr/",
                    UseShellExecute = true
                };
                System.Diagnostics.Process.Start(psi);
            }
            else if (no == 5)//sağlık bakanlığı
            {
                var psi = new System.Diagnostics.ProcessStartInfo
                {
                    FileName = "https://www.saglik.gov.tr/",
                    UseShellExecute = true
                };
                System.Diagnostics.Process.Start(psi);
            }
            else if (no == 6)
            {
                var psi = new System.Diagnostics.ProcessStartInfo
                {
                    FileName = "https://hastane.pau.edu.tr/ulasim",
                    UseShellExecute = true
                };
                System.Diagnostics.Process.Start(psi);
            }
        }
        public static void Menustrip_Yönlendir(int no)
        {
            switch (no)
            { 
                //tarihce
                case 1 : 
                { 
                    Tarihce tarihce = new Tarihce();
                    tarihce.Show();
                        break;
                }
                //misyon ve vizyon
                case 2: 
                {
                        Misyon_ve_Vizyon msv = new Misyon_ve_Vizyon();
                        msv.Show();
                        break;
                }
                //yonetim bilgileri
                case 3:
                    {
                        break;
                    }
                //doktorlarımız
                case 4:
                    {
                        tumdoktorlar td = new tumdoktorlar();
                        td.Show();
                        break;
                    }
                //iletişim bilgileri
                case 6:
                    {
                        iletisimbilgileri ib = new iletisimbilgileri();
                        ib.Show();
                        break;
                    }
                //Görüş ve Önerileriniz
                case 7:
                    {
                        GorusVeSikayetleriniz gvs = new GorusVeSikayetleriniz();
                        gvs.Show();
                        break;
                    }
            }
        }

    }
}
