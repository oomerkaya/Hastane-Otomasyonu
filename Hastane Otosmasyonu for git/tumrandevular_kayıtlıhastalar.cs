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
    public partial class tumrandevular_kayıtlıhastalar: Form
    {
        public tumrandevular_kayıtlıhastalar()
        {
            InitializeComponent();
        }
        public int no;
        private void tumrandevular_Load(object sender, EventArgs e)
        {
            Veritabani v4 = new Veritabani();

            switch (no)
            {
                case 1:
                    {
                        SqlDataAdapter dt = new SqlDataAdapter("Select * from Table_RandevuBilgi", v4.baglanti());

                        DataTable dataTable = new DataTable();

                        dt.Fill(dataTable);

                        dataGridView1.DataSource = dataTable;

                        v4.baglanti().Close();
                        break;
                    }
                case 2:
                    {
                        tumrandevular_kayıtlıhastalar trkh = new tumrandevular_kayıtlıhastalar();

                        trkh.Text = "Kayıtlı Hastalar";

                        SqlDataAdapter dt = new SqlDataAdapter("Select * from Table_HastaBilgi", v4.baglanti());

                        DataTable dataTable = new DataTable();

                        dt.Fill(dataTable);

                        dataGridView1.DataSource = dataTable;

                        v4.baglanti().Close();

                        break;
                    }
            }
            

           
        }

        
    }
}
