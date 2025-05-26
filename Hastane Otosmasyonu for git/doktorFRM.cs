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
    public partial class doktorFRM: Form
    {
       
        public doktorFRM()
        {
            InitializeComponent();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            Doktor d = new Doktor(textBox1.Text, Convert.ToInt16(textBox2.Text));
            if (d.Bilgiler_DogruMu())
            {
                doktorFRM2 drfm2 = new doktorFRM2();
                drfm2.Show();
                this.Close();
            }
            else
            {
                textBox1.Clear();
                textBox2.Clear();
                MessageBox.Show("Hatalı kullanıcı adı veya şifre!!");
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            YetkiliGiris y = new YetkiliGiris();
            y.Show();
            this.Close();

        }
    }
}
