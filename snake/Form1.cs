using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace snake
{
    public partial class Form1 : Form
    {
        private int[,] grid;
        private Rectangle[,] visual_grid;
        private int gSize = 16;
        private int startI;
        private int startJ;

        public Form1()
        {
            InitializeComponent();
            grid = new int[gSize, gSize];
            for (int i = 0; i < gSize; i++)
            {
                for (int j = 0; j < gSize; j++)
                {
                    grid[i,j] = new int();
                    grid[i, j] = 0;
                }
            }
            startI = gSize / 4;
            startJ = gSize / 2;
            grid[startI, startJ] = 1;
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            Pen blackpen = new Pen(Color.Black, 3);
            Graphics g = e.Graphics;
            visual_grid = new Rectangle[gSize, gSize];

            int rec_width = panel1.Width/gSize;
            int rec_height = panel1.Height/gSize;
            for (int i = 0; i < gSize; i++) {
                for (int j = 0; j < gSize; j++) {
                    visual_grid[i, j] = new Rectangle(rec_width * i, rec_height * j, rec_width, rec_height);
                    g.DrawRectangle(blackpen, visual_grid[i,j]);
                }
            }
            g.FillRectangle(Brushes.DarkBlue, visual_grid[startI, startJ]);
            g.Dispose();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
