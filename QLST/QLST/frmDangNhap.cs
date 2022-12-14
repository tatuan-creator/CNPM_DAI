using QLST.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLST
{
    public partial class frmDangNhap : Form
    {
        private QLSTDataDataContext context = new QLSTDataDataContext();
        public frmDangNhap()
        {
            InitializeComponent();
            var nho = context.NguoiDungs.SingleOrDefault(p => p.NhoMK == 1);
            if(nho == null)
            {
                cbxRemember.Checked = false;
            }
            else
            {
                txtTenDangNhap.Text = nho.TaiKhoan;
                txtMatKhau.Text = nho.MatKhau;
                cbxRemember.Checked = true;
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtTenDangNhap.Text;
            string matKhau = txtMatKhau.Text;
            if(tenDangNhap == "")
            {
                MessageBox.Show("Tên đăng nhập trống !!!","Cảnh báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else if(matKhau == "")
            {
                MessageBox.Show("Mật khẩu trống !!!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var check = context.NguoiDungs.SingleOrDefault(p => p.TaiKhoan.Equals(tenDangNhap));
                if(check == null)
                {
                    MessageBox.Show("Tài khoản không tồn tại!!!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(check.MatKhau != matKhau)
                {
                    MessageBox.Show("Sai mật khẩu !!!", "Cảnh báo",MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    if(cbxRemember.Checked == true && context.NguoiDungs.SingleOrDefault( p => p.NhoMK == 1) == null)
                    {
                        var temp = context.NguoiDungs.SingleOrDefault(p => p.TaiKhoan == txtTenDangNhap.Text);
                        _ = temp.NhoMK == 1;
                        context.SubmitChanges();
                    }
                    else
                    {
                        var nho = context.NguoiDungs.SingleOrDefault(p => p.NhoMK == 1);
                        if(nho != null)
                        {
                            _ = nho.NhoMK == 0;

                        }
                    }
                    frmGiaodien frm = new frmGiaodien(check.IDNhanVien);
                    frm.Show();
                    this.Hide();
                }
            }
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void picshow_Click(object sender, EventArgs e)
        {
            txtMatKhau.PasswordChar = '\0';
            pichide.Visible = true;
            picshow.Visible = false;
        }

        private void pichide_Click(object sender, EventArgs e)
        {
            txtMatKhau.PasswordChar = '*';
            pichide.Visible = false;
            picshow.Visible = true;
        }
    }
}
