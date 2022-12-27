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
    public partial class frmNhanvien : Form
    {
        private QLSTDataDataContext context = new QLSTDataDataContext();
        DataGridViewRow row = new DataGridViewRow();
        public frmNhanvien()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmNhanvien_Load(object sender, EventArgs e)
        {   
           load_data();
        }
        private void load_data()
        {
            var lstNhanVien = context.NguoiDungs.Where(x => x.isActive == 1).ToList();
            dgvNhanVien.Rows.Clear();
            foreach (var item in lstNhanVien)
            {
                int index = dgvNhanVien.Rows.Add();
                dgvNhanVien.Rows[index].Cells[0].Value = item.HoTen;
                dgvNhanVien.Rows[index].Cells[2].Value = item.NgaySinh.Value.ToShortDateString();
                if (item.GioiTinh == 1)
                {
                    dgvNhanVien.Rows[index].Cells[3].Value = "Nam";
                }
                else
                {
                    dgvNhanVien.Rows[index].Cells[3].Value = "Nữ";
                }
                dgvNhanVien.Rows[index].Cells[4].Value = item.ChucVuNV.TenChucVu;
                dgvNhanVien.Rows[index].Cells[5].Value = item.Luong;
                dgvNhanVien.Rows[index].Cells[6].Value = item.NgayVaoLam.Value.ToShortDateString();
                dgvNhanVien.Rows[index].Cells[1].Value = item.TaiKhoan;
            }
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            frmGiaodien frm = new frmGiaodien();
            frm.Show();
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmThemNV frm = new frmThemNV();
            frm.Show();
        }
        
        private void btnDel_Click(object sender, EventArgs e)
        {
            string m = row.Cells[1].Value.ToString();
            var check = context.NguoiDungs.SingleOrDefault(p => p.TaiKhoan.Equals(m));
            if(check != null)
            {
                if (MessageBox.Show("Bạn có muốn xoá người dùng đã chọn: " + check.TaiKhoan,"Cảnh báo",MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    check.isActive = 0;
                    context.SubmitChanges();
                    load_data();
                }
            }
            
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > 0)
            {
                row = this.dgvNhanVien.Rows[e.RowIndex];
            }
        }

        private void btnFix_Click(object sender, EventArgs e)
        {
            string m = row.Cells[1].Value.ToString();
            var check = context.NguoiDungs.SingleOrDefault(p => p.TaiKhoan.Equals(m));
            if (check != null)
            {
                frmSuaNguoiDung frm = new frmSuaNguoiDung(check.IDNhanVien);
                frm.Show();
                this.Hide();
            }
        }
    }
}
