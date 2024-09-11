using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laivanupotus
{
    public partial class Merkkaukset : Form
    {
        public Merkkaukset()
        {
            InitializeComponent();
            LuoRistikko();
            this.StartPosition = FormStartPosition.Manual;
        }

        private void LuoRistikko()
        {
            int riviMaara = 10;
            int torniMaara = 10;
            int cellSize = 80;

            Yhteiset yhteiset = new Yhteiset(riviMaara, torniMaara, cellSize);
            yhteiset.LuoRistikko(this);
            yhteiset.asetaLaivatLaitetuiksi();
        }
    }
}