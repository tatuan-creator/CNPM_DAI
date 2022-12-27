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
    public partial class frmThemNV : Form
    {
        private QLSTDataDataContext context = new QLSTDataDataContext();
        public frmThemNV()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmCapnhatNV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLSLDataSet.ChucVu' table. You can move, or remove it, as needed.
            var datacmbChucVu = context.ChucVuNVs.ToList();
            cmbChucVu.DataSource = datacmbChucVu;
            cmbChucVu.DisplayMember = "TenChucVu";
            cmbChucVu.ValueMember = "IDChucVu";
        }

        private void btnCheckID_Click(object sender, EventArgs e)
        {
            string ID = txtMaNV.Text;
            var check = context.NguoiDungs.SingleOrDefault(p => p.TaiKhoan.Equals(ID));
            if(check != null)
            {
                MessageBox.Show("Tài khoản nhân viên đã tồn tại!", "Cảnh báo", MessageBoxButtons.OK);
                txtMaNV.Clear();
            }
            else
            {
                MessageBox.Show("Tài khoản nhân viên hợp lệ!", "Thông báo", MessageBoxButtons.OK);
                btnCheckID.Enabled= false;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            NguoiDung nguoidung = new NguoiDung();
            nguoidung.TaiKhoan = txtMaNV.Text;
            nguoidung.HoTen = txtHoTen.Text;
            nguoidung.NgaySinh = dtpBirthday.Value;
            nguoidung.ChucVu = cmbChucVu.SelectedIndex +1;
            nguoidung.GioiTinh = comboSex.SelectedIndex;
            nguoidung.NgayVaoLam = dtpStartDay.Value;
            nguoidung.Luong = float.Parse(txtLuong.Text);
            if (btnCheckID.Enabled)
            {
                MessageBox.Show("Vui lòng check mã nhân viên trước khi thêm!", "Cảnh báo", MessageBoxButtons.OK);
            }
            else
            {
                context.NguoiDungs.InsertOnSubmit(nguoidung);
                context.SubmitChanges();
                MessageBox.Show("Thêm nhân viên thành công", "Thông báo", MessageBoxButtons.OK);
                this.frmCapnhatNV_Load(sender, e);
            }
        }
    }
}
