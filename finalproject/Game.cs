using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalproject
{
    public partial class Game : Form
    {
        bool isDragging = false;
        public Game()
        {
            InitializeComponent();
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);
            UpdateStyles();

        }

        private void Game_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox_purple_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                PictureBox pictureBox = (PictureBox)sender;
                pictureBox.Location = new Point(pictureBox.Left + e.X - pictureBox.Width / 2,
                                                pictureBox.Top + e.Y - pictureBox.Height / 2);
            }
        }

        private void pictureBox_purple_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
        }

        private void pictureBox_purple_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void pictureBox_purple_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
        }

        private void pictureBox_green_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
        }

        private void pictureBox_green_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                PictureBox pictureBox = (PictureBox)sender;
                pictureBox.Location = new Point(pictureBox.Left + e.X - pictureBox.Width / 2,
                                                pictureBox.Top + e.Y - pictureBox.Height / 2);
            }
        }

        private void pictureBox_green_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void pictureBox_blue_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void pictureBox_blue_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                PictureBox pictureBox = (PictureBox)sender;
                pictureBox.Location = new Point(pictureBox.Left + e.X - pictureBox.Width / 2,
                                                pictureBox.Top + e.Y - pictureBox.Height / 2);
            }
        }

        private void pictureBox_blue_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
        }
    }
}
