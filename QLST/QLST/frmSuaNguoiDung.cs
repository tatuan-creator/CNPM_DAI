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
    public partial class frmSuaNguoiDung : Form
    {
        private QLSTDataDataContext context = new QLSTDataDataContext();
        public frmSuaNguoiDung(int ID)
        {
            var load_Data = context.NguoiDungs.SingleOrDefault(p => p.IDNhanVien.Equals(ID));
            InitializeComponent();

            txtHoTen.Text = load_Data.HoTen;
            dtpBirthday.Value = (DateTime)load_Data.NgaySinh;
            dtpStartDay.Value = (DateTime)load_Data.NgayVaoLam;

            txtMaNV.Text = load_Data.TaiKhoan;
            txtMaNV.Enabled = false;
            txtLuong.Text = load_Data.Luong.ToString();

            cmbChucVu.Text = load_Data.ChucVuNV.TenChucVu;
            if (load_Data.GioiTinh == 0)
            {
                cmbSex.Text = "Nữ";
            }
            else cmbSex.Text = "Nam";
        }

        private void pibBack2_Click(object sender, EventArgs e)
        {
            frmNhanvien obj = new frmNhanvien();
            obj.Show();
            this.Hide();
        }
    }
}
