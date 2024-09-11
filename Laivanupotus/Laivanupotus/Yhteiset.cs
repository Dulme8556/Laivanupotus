using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Configuration;

namespace Laivanupotus
{
    internal class Yhteiset
    {
        private int riviMaara;
        private int torniMaara;
        private int cellSize;
        private bool laivatLaitettu = true;

        private Label[,] gridLabel;
        private List<Point> laivojen_paikat = new List<Point>();

        private int numerot = 1;
        private string kirjaimet = "ABCDEFGHIJ";
        private int seuraavaKirjain = 0;

        public Yhteiset(int riviMaara, int torniMaara, int cellSize)
        {
            this.riviMaara = riviMaara;
            this.torniMaara = torniMaara;
            this.cellSize = cellSize;
        }

        private void sijainnit()
        {
            for (int i = 0; i < riviMaara; i++)
            {
                for (int j = 0; j < torniMaara; j++)
                {
                    Label laatta = gridLabel[i, j];

                    if (i == 0)
                    {
                        laatta.Text = numerot.ToString();
                        numerot++;
                    }

                    if (j == 0)
                    {
                        laatta.Text = kirjaimet[seuraavaKirjain].ToString();
                        seuraavaKirjain++;
                    }

                    if (i == 0 && j == 0)
                    {
                        laatta.Text = "A 1";
                    }
                }
            }
        }

        public void LuoRistikko(Form form)
        {
            gridLabel = new Label[riviMaara, torniMaara];

            int yOffset = 35;

            for (int i = 0; i < riviMaara; i++)
            {
                for (int j = 0; j < torniMaara; j++)
                {
                    var label = new Label();
                    label.Size = new Size(cellSize, cellSize);
                    label.Location = new Point(j * cellSize, i * cellSize + yOffset);
                    label.Tag = new Point(i, j);
                    label.MouseDown += Label_MouseDown;
                    label.BackColor = Color.Gray;
                    label.BorderStyle = BorderStyle.FixedSingle;

                    form.Controls.Add(label);
                    gridLabel[i, j] = label;
                }
            }

            sijainnit();
        }

        public void asetaLaivatLaitetuiksi()
        {
            laivatLaitettu = false;
        }

        private void Label_MouseDown(object sender, MouseEventArgs e)
        {
            var label = (Label)sender;
            var position = (Point)label.Tag;

            if (laivatLaitettu)
            {
                if (label.BackColor == Color.Gray)
                {
                    label.BackColor = Color.Black;
                    laivojen_paikat.Add(position);
                }
                else if (label.BackColor == Color.Black)
                {
                    label.BackColor = Color.Gray;
                    laivojen_paikat.Remove(position);
                }
                
            }
            else if (e.Button == MouseButtons.Left)
            {
                if (label.BackColor != Color.Blue)
                {
                    label.BackColor = Color.Blue;
                }

                else if (label.BackColor == Color.Blue)
                {
                    if (laivojen_paikat.Contains(position))
                    {
                        label.BackColor = Color.Black;
                    }
                    else
                    {
                        label.BackColor = Color.Gray;
                    }
                }
            }

            else if (e.Button == MouseButtons.Right)
            {
                if (label.BackColor != Color.Red)
                {
                    label.BackColor = Color.Red;
                }

                else if (label.BackColor == Color.Red)
                {
                    if (laivojen_paikat.Contains(position))
                    {
                        label.BackColor = Color.Black;
                    }
                    else
                    {
                        label.BackColor = Color.Gray;
                    }
                }
            }
        }
    }
}
