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
    public partial class bolumegorerandevular: Form
    {
        public bolumegorerandevular()
        {
            InitializeComponent();
        }

        private void bolumegorerandevular_Load(object sender, EventArgs e)
        {
            Veritabani v5 = new Veritabani();

            SqlCommand komut = new SqlCommand("Select RandevuBrans, Count(*) from Table_RandevuBilgi group by RandevuBrans",v5.baglanti());

            SqlDataReader dr2 = komut.ExecuteReader();

            while (dr2.Read())
            {
                chart1.Series["Randevular"].Points.AddXY(dr2[0], dr2[1]);
            }

            v5.baglanti().Close();
        }
    }
}
