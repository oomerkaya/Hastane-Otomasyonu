using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Hastane_Otomasyonu
{
    public partial class AnaSayfa: Form
    {
        GorusVeSikayetleriniz gvs = new GorusVeSikayetleriniz();
        public AnaSayfa()
        {
            InitializeComponent();
        }
        private void BTN_birimlerimiz_Click(object sender, EventArgs e)
        {
            Birimlerimiz birimler = new Birimlerimiz();
            birimler.Show();
            this.Hide();
        }
        private void AnaSayfa_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        
        }
        #region Bağlantılar
        //Instagram=1
        //Youtube=2
        //twitter=3
        //paüanasayfa=4
        //saglıkbakanlıgı=5
        //ulaşım=6
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            BaglantıCalıstır_Yönlendir.BaglantiCalistir(1);
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            BaglantıCalıstır_Yönlendir.BaglantiCalistir(2);
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            BaglantıCalıstır_Yönlendir.BaglantiCalistir(3);
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            BaglantıCalıstır_Yönlendir.BaglantiCalistir(4);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            BaglantıCalıstır_Yönlendir.BaglantiCalistir(5);
        }
        private void ulaşımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BaglantıCalıstır_Yönlendir.BaglantiCalistir(6);
        }
        #endregion
        #region MenuStrip_Yönlendirme
        //tarihce=1
        //MvV=2
        //yonetim bilgileri=3
        //doktorlarımız=4
        //iletişim bilgileri=6
        //Görüş ve Şikayetleriniz=7
        private void tarihçeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            BaglantıCalıstır_Yönlendir.Menustrip_Yönlendir(1);
            this.Hide();
        }
        private void misyonVeVizyonToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            BaglantıCalıstır_Yönlendir.Menustrip_Yönlendir(2);
            this.Hide();
        }
        private void yönetimBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BaglantıCalıstır_Yönlendir.Menustrip_Yönlendir(3);
        }

        private void doktorlarımızToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BaglantıCalıstır_Yönlendir.Menustrip_Yönlendir(4);
        }
        private void iletişimBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BaglantıCalıstır_Yönlendir.Menustrip_Yönlendir(6);
            this.Hide();
        }


        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            OnlineRandevu O_R = new OnlineRandevu();
            O_R.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gvs.Show();
            this.Hide();
        }

        private void görüşVeÖnerilerinizToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gvs.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            YetkiliGiris yg = new YetkiliGiris();
            yg.Show();
            this.Hide();

        }

        
    }
}
