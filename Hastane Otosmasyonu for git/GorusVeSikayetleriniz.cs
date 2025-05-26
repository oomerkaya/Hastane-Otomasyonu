using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane_Otomasyonu
{
    public partial class GorusVeSikayetleriniz: Form
    {
        public GorusVeSikayetleriniz()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            AnaSayfa anasayfa = new AnaSayfa();
            anasayfa.Show();
            this.Close();
        }
        #region Bağlantılar
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
        #endregion

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("C:\\Users\\eksi2\\source\\repos\\Hastane Otomasyonu\\bilgi.txt");

            sw.WriteLine(textBox1.Text);
            sw.Write(richTextBox1.Text);
            sw.Close();

            MessageBox.Show("Bildiriminiz başarıyla gönderildi.");
            AnaSayfa anasayfa = new AnaSayfa();
            anasayfa.Show();
            this.Close();
        }
    }
}
