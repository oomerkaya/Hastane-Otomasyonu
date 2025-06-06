﻿using System;
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
    public partial class Birimlerimiz: Form
    {
        public Birimlerimiz()
        {
            InitializeComponent();
        }
        private void metroButton1_Click(object sender, EventArgs e)
        {
            AnaSayfa anasayfa = new AnaSayfa();
            anasayfa.Show();
            this.Close();
        }
        #region MenuStrip_Yönlendirme
        private void tarihçeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BaglantıCalıstır_Yönlendir.Menustrip_Yönlendir(1);
            this.Close();
        }
        private void misyonVeVizyonToolStripMenuItem_Click(object sender, EventArgs e)
        {

            BaglantıCalıstır_Yönlendir.Menustrip_Yönlendir(2);
            this.Close();
        }

        private void doktorlarımızToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BaglantıCalıstır_Yönlendir.Menustrip_Yönlendir(4);
        }
        #endregion
        #region Bağlantılar
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            BaglantıCalıstır_Yönlendir.BaglantiCalistir(1);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            BaglantıCalıstır_Yönlendir.BaglantiCalistir(2);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            BaglantıCalıstır_Yönlendir.BaglantiCalistir(3);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            BaglantıCalıstır_Yönlendir.BaglantiCalistir(4);
        }

        #endregion

        private void Birimlerimiz_Load(object sender, EventArgs e)
        {

        }

       
    }
}
