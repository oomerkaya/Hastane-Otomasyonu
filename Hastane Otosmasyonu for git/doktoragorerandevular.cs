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
    public partial class doktoragorerandevular: Form
    {
        public doktoragorerandevular()
        {
            InitializeComponent();
        }

        private void doktoragorerandevular_Load(object sender, EventArgs e)
        {
            Veritabani v6 = new Veritabani();

            SqlCommand komut = new SqlCommand("Select DoktorAd_Soyad, Count(*) from Table_RandevuBilgi group by DoktorAd_Soyad", v6.baglanti());

            SqlDataReader dr2 = komut.ExecuteReader();

            while (dr2.Read())
            {
                chart1.Series["Doktor-Hasta Sayısı"].Points.AddXY(dr2[0], dr2[1]);
            }

            v6.baglanti().Close();
        }
    }
}
