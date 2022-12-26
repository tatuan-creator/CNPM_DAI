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
            var lstNhanVien = context.NguoiDungs.ToList();
            dgvNhanVien.Rows.Clear();
            foreach(var item in lstNhanVien)
            {
                int index = dgvNhanVien.Rows.Add();
                dgvNhanVien.Rows[index].Cells[0].Value = item.HoTen;
                dgvNhanVien.Rows[index].Cells[1].Value = item.NgaySinh.Value.ToShortDateString();
                if(item.GioiTinh == 1)
                {
                    dgvNhanVien.Rows[index].Cells[2].Value = "Nam";
                }
                else
                {
                    dgvNhanVien.Rows[index].Cells[2].Value = "Nữ";
                }
                dgvNhanVien.Rows[index].Cells[3].Value = item.ChucVuNV.TenChucVu;
                dgvNhanVien.Rows[index].Cells[4].Value = item.Luong;
                dgvNhanVien.Rows[index].Cells[5].Value = item.NgayVaoLam.Value.ToShortDateString();
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
    }
}
