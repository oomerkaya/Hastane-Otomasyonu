using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane_Otomasyonu
{
    public partial class OnlineRandevu: Form
    {
        public OnlineRandevu()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            AnaSayfa anasayfa = new AnaSayfa();
            anasayfa.Show();
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hasta_Kayıt hastakayıt = new Hasta_Kayıt();
            hastakayıt.Show();
            this.Close();
        }
       // string T_C;
        private void button1_Click(object sender, EventArgs e)
        {
            Veritabani v1 = new Veritabani();
            SqlCommand komut = new SqlCommand("Select * from Table_HastaBilgi where HastaTC=@p1 and HastaSifre=@p2",v1.baglanti());
            komut.Parameters.AddWithValue("@p1", M_TextBox_TC.Text);
            komut.Parameters.AddWithValue("@p2", TextBox_Sifre.Text);
            SqlDataReader dr1 = komut.ExecuteReader();
            if (dr1.Read())
            {
                Randevu randevu = new Randevu();
                randevu.T_C = M_TextBox_TC.Text;
                randevu.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Hatalı T.C veya şifre!!");
                M_TextBox_TC.Clear();
                TextBox_Sifre.Clear();
                return;
            }
            v1.baglanti().Close();
           



        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GorusVeSikayetleriniz gvs = new GorusVeSikayetleriniz();
            gvs.Show();
            this.Close();
        }

     
    }
}
