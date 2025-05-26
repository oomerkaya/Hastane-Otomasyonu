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
    public partial class G_T_SFRM: Form
    {
        public G_T_SFRM()
        {
            InitializeComponent();
        }

        private void G_T_SFRM_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("C:\\Users\\eksi2\\source\\repos\\Hastane Otomasyonu\\bilgi.txt");
            string kelime;
            while ((kelime=sr.ReadLine())!= null)
            {
                listBox1.Items.Add(kelime);
            }
            sr.Close();
        }
    }
}
