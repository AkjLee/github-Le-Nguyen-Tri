using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicContronl
{
    public partial class FrmMathBasic : Form
    {
        public FrmMathBasic()
        {
            InitializeComponent();
        }

        private void btCong_Click(object sender, EventArgs e)
        {
            try
            {
                var soThuNhat = txtSoThuNhat.Text;
                long nsoThuNhat = Convert.ToInt64(soThuNhat);

                var soThuHai = txtSoThuHai.Text;
                long nsoThuHai = long.Parse(soThuHai);
                var KetQua = nsoThuNhat + nsoThuHai;


                O.Text = KetQua.ToString("N10");
            }
            catch(FormatException ex)
            {
                MessageBox.Show($"Nhập số không nhập chữ:{ex.Message}");
            }
            catch(OverflowException ex)
            {
                MessageBox.Show($"Lỗi tràng số:{ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi chi tiết:{ex.Message}");
            }
        }

        private void btTru_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                var soThuNhat = txtSoThuNhat.Text;
                long nsoThuNhat = Convert.ToInt64(soThuNhat);

                var soThuHai = txtSoThuHai.Text;
                long nsoThuHai = long.Parse(soThuHai);
                var KetQua = nsoThuNhat - nsoThuHai;


                O.Text = KetQua.ToString("N10");
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Nhập số không nhập chữ:{ex.Message}");
            }
            catch (OverflowException ex)
            {
                MessageBox.Show($"Lỗi tràng số:{ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi chi tiết:{ex.Message}");
            }
        }

        private void btNhan_Click(object sender, EventArgs e)
        {
            try
            {
                var soThuNhat = txtSoThuNhat.Text;
                long nsoThuNhat = Convert.ToInt64(soThuNhat);

                var soThuHai = txtSoThuHai.Text;
                long nsoThuHai = long.Parse(soThuHai);
                var KetQua = nsoThuNhat * nsoThuHai;


                O.Text = KetQua.ToString("N10");
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Nhập số không nhập chữ:{ex.Message}");
            }
            catch (OverflowException ex)
            {
                MessageBox.Show($"Lỗi tràng số:{ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi chi tiết:{ex.Message}");
            }
        }

        private void btChia_Click(object sender, EventArgs e)
        {
            try
            {
                var soThuNhat = txtSoThuNhat.Text;
                double nsoThuNhat = Convert.ToDouble(soThuNhat);

                var soThuHai = txtSoThuHai.Text;
                double nsoThuHai = double.Parse(soThuHai);
                var KetQua = nsoThuNhat / nsoThuHai;


                O.Text = KetQua.ToString("N10");
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Nhập số không nhập chữ:{ex.Message}");
            }
            catch (OverflowException ex)
            {
                MessageBox.Show($"Lỗi tràng số:{ex.Message}");
            }
                    catch (Exception ex)
            {
                MessageBox.Show($"Lỗi chi tiết:{ex.Message}");
            }
        }
    }
}
