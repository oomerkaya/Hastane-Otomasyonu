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
    public partial class Randevu: Form
    {
        public  string T_C;
        AnaSayfa anasayfa = new AnaSayfa();
        RandevuBilgiler rb = new RandevuBilgiler();
        aktifvegecmisrandevular AvGR = new aktifvegecmisrandevular();
        public Randevu()
        {
            InitializeComponent();
        }
       
        private void Randevu_Load(object sender, EventArgs e)
        {

            dateTimePicker1.MinDate = DateTime.Today;

            Veritabani v2 = new Veritabani();

            SqlCommand komut = new SqlCommand("Select * from Table_HastaBilgi where HastaTC=@p1",v2.baglanti());
            komut.Parameters.AddWithValue("@p1", T_C);

            SqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                label4.Text = dr["HastaAd"].ToString();
                label5.Text = dr["HastaSoyad"].ToString();
                label6.Text = dr["HastaTC"].ToString();
                label8.Text = dr["HastaDogumYili"].ToString();
            }

            dr.Close();
            v2.baglanti().Close();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            OnlineRandevu o_r = new OnlineRandevu();
            o_r.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            anasayfa.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GorusVeSikayetleriniz gvs = new GorusVeSikayetleriniz();
            gvs.Show();
            this.Close();
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

          metroComboBox2.Items.Clear();

          for(int i = 0; i <22; i++)
            {
                if (rb.branslar_doktorlar[i, 0] == metroComboBox1.Text)
                {
                    for(int j = 1; j < 3; j++)
                    {
                        metroComboBox2.Items.Add(rb.branslar_doktorlar[i, j]);
                    }
                }
            }
        }
        #region PictureBox ArkaPlan Değiştir
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            rb.randevu_saati = "09:00";

            pictureBox2.BackColor = Color.Red;
            label12.BackColor = Color.Red;

            pictureBox3.BackColor = Color.LimeGreen;
            label13.BackColor = Color.LimeGreen;

            pictureBox4.BackColor = Color.LimeGreen;
            label14.BackColor = Color.LimeGreen;

            pictureBox5.BackColor = Color.LimeGreen;
            label15.BackColor = Color.LimeGreen;

            pictureBox6.BackColor = Color.LimeGreen;
            label16.BackColor = Color.LimeGreen;

            pictureBox7.BackColor = Color.LimeGreen;
            label17.BackColor = Color.LimeGreen;

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            rb.randevu_saati = "10:00";

            pictureBox2.BackColor = Color.LimeGreen;
            label12.BackColor = Color.LimeGreen;

            pictureBox3.BackColor = Color.Red;
            label13.BackColor = Color.Red;

            pictureBox4.BackColor = Color.LimeGreen;
            label14.BackColor = Color.LimeGreen;

            pictureBox5.BackColor = Color.LimeGreen;
            label15.BackColor = Color.LimeGreen;

            pictureBox6.BackColor = Color.LimeGreen;
            label16.BackColor = Color.LimeGreen;

            pictureBox7.BackColor = Color.LimeGreen;
            label17.BackColor = Color.LimeGreen;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            rb.randevu_saati = "11:00";

            pictureBox2.BackColor = Color.LimeGreen;
            label12.BackColor = Color.LimeGreen;

            pictureBox3.BackColor = Color.LimeGreen;
            label13.BackColor = Color.LimeGreen;

            pictureBox4.BackColor = Color.Red;
            label14.BackColor = Color.Red;

            pictureBox5.BackColor = Color.LimeGreen;
            label15.BackColor = Color.LimeGreen;

            pictureBox6.BackColor = Color.LimeGreen;
            label16.BackColor = Color.LimeGreen;

            pictureBox7.BackColor = Color.LimeGreen;
            label17.BackColor = Color.LimeGreen;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            rb.randevu_saati = "13:30";

            pictureBox2.BackColor = Color.LimeGreen;
            label12.BackColor = Color.LimeGreen;

            pictureBox3.BackColor = Color.LimeGreen;
            label13.BackColor = Color.LimeGreen;

            pictureBox4.BackColor = Color.LimeGreen;
            label14.BackColor = Color.LimeGreen;

            pictureBox5.BackColor = Color.Red;
            label15.BackColor = Color.Red;

            pictureBox6.BackColor = Color.LimeGreen;
            label16.BackColor = Color.LimeGreen;

            pictureBox7.BackColor = Color.LimeGreen;
            label17.BackColor = Color.LimeGreen;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            rb.randevu_saati = "14:30";

            pictureBox2.BackColor = Color.LimeGreen;
            label12.BackColor = Color.LimeGreen;

            pictureBox3.BackColor = Color.LimeGreen;
            label13.BackColor = Color.LimeGreen;

            pictureBox4.BackColor = Color.LimeGreen;
            label14.BackColor = Color.LimeGreen;

            pictureBox5.BackColor = Color.LimeGreen;
            label15.BackColor = Color.LimeGreen;

            pictureBox6.BackColor = Color.Red;
            label16.BackColor = Color.Red;

            pictureBox7.BackColor = Color.LimeGreen;
            label17.BackColor = Color.LimeGreen;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            rb.randevu_saati = "15:30";

            pictureBox2.BackColor = Color.LimeGreen;
            label12.BackColor = Color.LimeGreen;

            pictureBox3.BackColor = Color.LimeGreen;
            label13.BackColor = Color.LimeGreen;

            pictureBox4.BackColor = Color.LimeGreen;
            label14.BackColor = Color.LimeGreen;

            pictureBox5.BackColor = Color.LimeGreen;
            label15.BackColor = Color.LimeGreen;

            pictureBox6.BackColor = Color.LimeGreen;
            label16.BackColor = Color.LimeGreen;

            pictureBox7.BackColor = Color.Red;
            label17.BackColor = Color.Red;
        }
        #endregion
        
        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
        
           
            RandevuBilgiler rb2 = new RandevuBilgiler(metroComboBox2.Text,T_C);
            rb2.bransad = metroComboBox1.Text;
            rb2.randevutarih = dateTimePicker1.Value;
            rb2.randevu_saati = rb.randevu_saati;
            rb2.VeriTabaninaKaydet();
            anasayfa.Show();
            this.Close();

            MessageBox.Show("Randevunuz başarıyla oluşturuldu.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AvGR.tc = T_C;
            AvGR.Show();
            this.Close();
        }

        private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            materialFlatButton1.Enabled = true;
        }
    }
}
