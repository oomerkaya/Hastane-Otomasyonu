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
    
    public partial class Hasta_Kayıt: Form
    {

        KisiselBilgiler kb1 = new KisiselBilgiler();
        public Hasta_Kayıt()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            OnlineRandevu O_R = new OnlineRandevu();
            O_R.Show();
            this.Close();
        }
        private void FormuTemizle()
        {
            textBoxAd.Clear();
            textBoxSoyad.Clear();
            maskedTextBoxTC.Clear();
            radioButtonErkek.Checked = false;
            radioButtonKaıdn.Checked = false;
           
        }
        private void BTN_Kayıt_Click(object sender, EventArgs e)
        {
            kb1.ad = textBoxAd.Text;
            kb1.soyad = textBoxSoyad.Text;
            if (kb1.ad == ""||kb1.soyad=="")
            {
                MessageBox.Show("Ad, Soyad boş olamaz!!");
                FormuTemizle();
                return;
            }
            try { 
            kb1.TC = maskedTextBoxTC.Text;
            }
            catch (Exception ex){
                MessageBox.Show(ex.Message);
                FormuTemizle();
                return;
            }

            if (radioButtonErkek.Checked)
            {
                kb1.cinsiyet = 'E';
            }
            else if (radioButtonKaıdn.Checked)
            {
                kb1.cinsiyet = 'K';
            }
            else
            {
                MessageBox.Show("Cinsiyet Seçilmedi!!");
                FormuTemizle();
                return;
            }

            kb1.dogumyılı = (int)dateTimePicker1.Value.Year;

            Random rnd = new Random();
            kb1.sifre=rnd.Next(99, 999);
            MessageBox.Show("Kaydınız başarıyla oluşturuldu şifreniz: " + kb1.sifre);
            kb1.VeriTabaninaKaydet();
            metroButton1_Click(metroButton1, EventArgs.Empty);

        }
    }
}
