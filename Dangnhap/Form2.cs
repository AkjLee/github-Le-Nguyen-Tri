using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Media;

namespace Dangnhap
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public int HappyNewYear { get; private set; }

        private void Form2_Load(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(@"C:\Users\thile\source\repos\Xay-dung-ung-dung-voi-.NET-Framework---Nhom-2\testapp1\Dangnhap\Resources\hinh-anh-dong-chuc-mung-nam-moi-gif-1.gif");
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.Image = bitmap;
           /* System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\thile\source\repos\testapp1\Dangnhap\Resources\HappyNewYear-ABBA_3rkqc.wav");
            player.Play();*/
        }

    }
}
