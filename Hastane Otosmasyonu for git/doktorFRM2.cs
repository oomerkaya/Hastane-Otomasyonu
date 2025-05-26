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
    public partial class doktorFRM2: Form
    {

        public doktorFRM2()
        {
            InitializeComponent();
        }

        private void doktorFRM2_Load(object sender, EventArgs e)
        {
            Doktor d = new Doktor();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AnaSayfa ana = new AnaSayfa();
            ana.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            YetkiliGiris yg = new YetkiliGiris();
            yg.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            GorusVeSikayetleriniz GvS= new GorusVeSikayetleriniz();
            GvS.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tumrandevular_kayıtlıhastalar tr = new tumrandevular_kayıtlıhastalar();
            tr.no = 1;
            tr.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            bolumegorerandevular bgr = new bolumegorerandevular();
            bgr.Show();
           
        }

        private void button8_Click(object sender, EventArgs e)
        {
            doktoragorerandevular dgr = new doktoragorerandevular();
            dgr.Show();
        }
    }
}
