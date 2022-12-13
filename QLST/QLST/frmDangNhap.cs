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
                var check = context.NguoiDungs.SingleOrDefault(p => p.IDNhanVien.Equals(tenDangNhap));
                if(check == null)
                {
                    MessageBox.Show("Tài khoản không tồn tại!!!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(check.MatKhau != matKhau)
                {
                    MessageBox.Show("Sai mật khẩu !!!", "Cảnh báo",MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            
        }
    }
}
