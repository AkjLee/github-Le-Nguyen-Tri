using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dangnhap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            text_username.Focus();
            text_password.Focus();
        }
        private void bthuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void dangnhap()
        {
            if (text_username.Text.Length == 0 && text_password.Text.Length == 0)
                MessageBox.Show("Bạn chưa đăng nhập tài khoản mật khẩu");
            else
                if (text_username.Text.Length == 0)
                MessageBox.Show("Bạn chưa đăng nhập tài khoản");
            else
                    if (text_password.Text.Length == 0)
                MessageBox.Show("Bạn chưa đăng nhập mật khẩu");
            else
                    if (this.text_username.Text == "LNTri" && this.text_password.Text == "123@abc")
                MessageBox.Show("Bạn đăng nhập tài khoản mật khẩu thành công");
            else
                MessageBox.Show("Bạn đăng nhập thất bại");
        }

        private void btdangnhap_Click(object sender, EventArgs e)
        {
        /*    if (text_username.Text.Length == 0 && text_password.Text.Length == 0)
                MessageBox.Show("Bạn chưa đăng nhập tài khoản mật khẩu");
            else
                if (text_username.Text.Length == 0)
                MessageBox.Show("Bạn chưa đăng nhập tài khoản");
            else
                    if (text_password.Text.Length == 0)
                MessageBox.Show("Bạn chưa đăng nhập mật khẩu");
            else
                             if (this.text_username.Text == "LNTri" && this.text_password.Text == "123@abc")
                MessageBox.Show("Bạn đăng nhập thành công");
            else
                MessageBox.Show("Bạn đăng nhập thất bại");*/
            Form2 fm = new Form2();
            if (this.text_username.Text == "LNTri" && this.text_password.Text == "123@abc")
            {
                fm.Show();             
            }
            dangnhap();
            this.Hide();
        }
    }

       




}

