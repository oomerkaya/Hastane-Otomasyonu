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
    public partial class tumdoktorlar: Form
    {
        public tumdoktorlar()
        {
            InitializeComponent();
        }
       
        private void tumdoktorlar_Load(object sender, EventArgs e)
        {
            RandevuBilgiler d = new RandevuBilgiler();

          for(int i = 0; i < 21; i++)
            {
                for (int j = 1; j < 3; j++)
                {
                    listBox1.Items.Add(d.branslar_doktorlar[i,j]);
                }
            }
           
        }
    }
}
