using QLyDiemSinhvien.Conntroller;
using QLyDiemSinhvien.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLyDiemSinhvien.View
{
    public partial class FrmDangky : Form
    {
        private string captchaCode;
        private accountcontroller account;
     
        public FrmDangky()
        {
            InitializeComponent();
            account = new accountcontroller();
            
            LoadCaptcha();
        }
        private string GenerateCaptcha()
        {
            Random rand = new Random();
            string captcha = rand.Next(1000, 9999).ToString();
            return captcha;
        }
        private void LoadCaptcha()
        {
            captchaCode = GenerateCaptcha();
            lbCaptcha.Text = captchaCode;
        }

        private void btnDangky_Click(object sender, EventArgs e)
        {
            string taikhoan = txtTaikhoan.Text.Trim();
            string matkhau = txtMatkhau.Text.Trim();
            string nhaplai = txtNhaplai.Text.Trim();
            string chucvu = txtChucvu.Text.Trim();
            string captcha = txtCaptcha.Text.Trim();

            if (string.IsNullOrEmpty(taikhoan) || string.IsNullOrEmpty(matkhau) || string.IsNullOrEmpty(captcha))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            if (captcha != captchaCode)
            {
                MessageBox.Show("Captcha không đúng!");
                return;
            }

            if (matkhau != nhaplai)
            {
                MessageBox.Show("Mật khẩu không khớp!");
                return;
            }
            int id = 0;
            accountmodel modelAccount = new accountmodel(id, taikhoan, matkhau, chucvu);
            bool addAccount = account.AddAccount(modelAccount);
            if (addAccount)
            {
                MessageBox.Show("Đăng nhập thành công!");
                this.Close();
                FrmDangnhap frmDangnhap = new FrmDangnhap();
                frmDangnhap.Show();
            }
            else 
            {
                MessageBox.Show("Thông báo", "Tiêu đề", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmDangnhap frmDangnhap = new FrmDangnhap();
            frmDangnhap.Show();
        }
    }
}
