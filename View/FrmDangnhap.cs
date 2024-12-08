using QLyDiemSinhvien.Conntroller;
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
    public partial class FrmDangnhap : Form
    {
        private string roleUsers = "";
        private accountcontroller account;

        public FrmDangnhap()
        {
            InitializeComponent();
            account = new accountcontroller();
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            string taikhoan = txtTaikhoan.Text;
            string matkhau = txtMatkhau.Text;

            bool checkAccount = account.CheckAccountLogin(taikhoan, matkhau);
            if (checkAccount)
            {
                MessageBox.Show("Đăng nhập thành công");
                this.Hide();
                FrmQuanly frmQuanly = new FrmQuanly();
                frmQuanly.Show();
            }
            else
            {
                DialogResult result = MessageBox.Show("Đăng nhập thất bại! Bạn có muốn thử lại không?\nNếu không, vui lòng đăng ký tài khoản.",
                    "Thông báo",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("Vui lòng thử lại đăng nhập!", "Thử lại", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (result == DialogResult.No)
                {
                    this.Hide();
                    FrmDangky frmDangKy = new FrmDangky();
                    frmDangKy.Show();
                }
            }
        }

        private void linkFrmDangky_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            FrmDangky dangky = new FrmDangky();
            dangky.Show();
        }
    }
}
