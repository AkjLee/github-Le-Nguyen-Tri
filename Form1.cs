using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (seconds == 0)
            {
                timer1.Stop();
                Bitmap bitmap = new Bitmap(@"C:\Users\thile\source\repos\Timer\Timer\anh.gif");
                pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
                pictureBox1.Image = bitmap;
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\thile\source\repos\Timer\Timer\HappyNewYear-ABBA_3rkqc.wav");
                player.Play();
            }
            else
            {
                seconds--;
                lbtimer.Text = $"{seconds / 60}:{seconds % 60}";
            }

        }

        int seconds = 0;

        private void btbatdau_Click(object sender, EventArgs e)
        {
            seconds = (int)Nbtimer.Value*60 ;
            timer1.Start();
        }

        private void btketthuc_Click(object sender, EventArgs e)
        {
            timer1.Stop();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void lbtimer_Click(object sender, EventArgs e)
        {

        }
    }
}
