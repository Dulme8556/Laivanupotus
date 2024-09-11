namespace Laivanupotus
{
    partial class Pelilauta
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            asetuksetToolStripMenuItem = new ToolStripMenuItem();
            suljeToolStripMenuItem = new ToolStripMenuItem();
            uusiPeliToolStripMenuItem = new ToolStripMenuItem();
            aloitaPeliToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { asetuksetToolStripMenuItem, aloitaPeliToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // asetuksetToolStripMenuItem
            // 
            asetuksetToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { suljeToolStripMenuItem, uusiPeliToolStripMenuItem });
            asetuksetToolStripMenuItem.Name = "asetuksetToolStripMenuItem";
            asetuksetToolStripMenuItem.Size = new Size(105, 29);
            asetuksetToolStripMenuItem.Text = "Asetukset";
            // 
            // suljeToolStripMenuItem
            // 
            suljeToolStripMenuItem.Name = "suljeToolStripMenuItem";
            suljeToolStripMenuItem.Size = new Size(270, 34);
            suljeToolStripMenuItem.Text = "Sulje";
            suljeToolStripMenuItem.Click += suljeToolStripMenuItem_Click;
            // 
            // uusiPeliToolStripMenuItem
            // 
            uusiPeliToolStripMenuItem.Name = "uusiPeliToolStripMenuItem";
            uusiPeliToolStripMenuItem.Size = new Size(270, 34);
            uusiPeliToolStripMenuItem.Text = "Uusi peli";
            uusiPeliToolStripMenuItem.Click += uusiPeliToolStripMenuItem_Click;
            // 
            // aloitaPeliToolStripMenuItem
            // 
            aloitaPeliToolStripMenuItem.Name = "aloitaPeliToolStripMenuItem";
            aloitaPeliToolStripMenuItem.Size = new Size(107, 29);
            aloitaPeliToolStripMenuItem.Text = "Aloita peli";
            aloitaPeliToolStripMenuItem.Click += aloitaPeliToolStripMenuItem_Click;
            // 
            // Pelilauta
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            Location = new Point(100, 50);
            MainMenuStrip = menuStrip1;
            Name = "Pelilauta";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem asetuksetToolStripMenuItem;
        private ToolStripMenuItem suljeToolStripMenuItem;
        private ToolStripMenuItem uusiPeliToolStripMenuItem;
        private ToolStripMenuItem aloitaPeliToolStripMenuItem;
    }
}