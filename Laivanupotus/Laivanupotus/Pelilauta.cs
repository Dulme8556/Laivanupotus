using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Laivanupotus
{
    public partial class Pelilauta : Form
    {
        Merkkaukset merkkaukset;

        private bool laivatLaitettu;

        Yhteiset yhteiset;

        public Pelilauta()
        {
            InitializeComponent();
            LuoRistikko();
            this.StartPosition = FormStartPosition.Manual;
        }

        private void LuoRistikko()
        {
            luoMerkkaukset();

            int riviMaara = 10;
            int torniMaara = 10;
            int cellSize = 80;

            yhteiset = new Yhteiset(riviMaara, torniMaara, cellSize);
            yhteiset.LuoRistikko(this);
        }

        private void luoMerkkaukset()
        {
            merkkaukset = new Merkkaukset();
            merkkaukset.Show();
        }

        private void suljeMerkkaukset()
        {
            merkkaukset.Close();
        }

        private void suljeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            suljeMerkkaukset();
            this.Close();
        }

        private void uusiPeliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            suljeMerkkaukset();

            Pelilauta uusiPeli = new Pelilauta();
            uusiPeli.FormClosed += UusiPeli_FormClosed;
            uusiPeli.Show();
        }

        private void UusiPeli_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
            this.Close();
        }

        private void aloitaPeliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            yhteiset.asetaLaivatLaitetuiksi();
        }
    }
}