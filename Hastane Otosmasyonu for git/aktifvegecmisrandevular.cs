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
    public partial class aktifvegecmisrandevular: Form
    {
        public string tc;
        Veritabani v3 = new Veritabani();
        public aktifvegecmisrandevular()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Randevu r = new Randevu();
            r.T_C = tc;
            r.Show();
            this.Close();
        }

        private void aktifvegecmisrandevular_Load(object sender, EventArgs e)
        {

            SqlDataAdapter da = new SqlDataAdapter("Select * from Table_RandevuBilgi where Hastatc=@p1", v3.baglanti());
            da.SelectCommand.Parameters.AddWithValue("@p1", tc);
            
            DataTable dt = new DataTable();
           
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            v3.baglanti().Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete  from Table_RandevuBilgi where RandevuBrans=@p1", v3.baglanti());

            komut.Parameters.AddWithValue("@p1", metroComboBox1.Text);
            komut.ExecuteNonQuery();

            v3.baglanti().Close();

            MessageBox.Show("Randevunuz başarıyla silindi!!");

            aktifvegecmisrandevular_Load(sender, null);
        }
    }
}
