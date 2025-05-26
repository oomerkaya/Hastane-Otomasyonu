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
    public partial class sekreterFRM2: Form
    {
        public sekreterFRM2()
        {
            InitializeComponent();
        }

        private void sekreterFRM2_Load(object sender, EventArgs e)
        {
            Sekreter s = new Sekreter();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AnaSayfa anasayfa = new AnaSayfa();
            anasayfa.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            YetkiliGiris yg = new YetkiliGiris();
            yg.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tumrandevular_kayıtlıhastalar tsgv = new tumrandevular_kayıtlıhastalar();
            tsgv.no = 2;
            tsgv.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            BaglantıCalıstır_Yönlendir.BaglantiCalistir(5);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tumdoktorlar td = new tumdoktorlar();
            td.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            G_T_SFRM gts = new G_T_SFRM();
            gts.Show();
        }
    }
}
