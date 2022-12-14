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
    public partial class frmGiaodien : Form
    {
        private QLSTDataDataContext context = new QLSTDataDataContext();
        public frmGiaodien()
        {
            InitializeComponent();
        }
        public frmGiaodien(int ID)
        {
            InitializeComponent();

            var checkQuyen = context.NguoiDungs.SingleOrDefault(p => p.IDNhanVien.Equals(ID));
            if (checkQuyen.ChucVuNV.TenChucVu.Equals("Cashier"))
            {
                mnsReport.Enabled = false;
                mnsAccount.Enabled = false;
                mnsQuanLy.Enabled = false;
                mnsRepo.Enabled = false;
            }else if (checkQuyen.ChucVuNV.TenChucVu.Equals("Ke toan"))
            {
                mnsCashier.Enabled = false;
                mnsAccount.Enabled = false;
                mnsQuanLy.Enabled = false;
                mnsRepo.Enabled = false;
            }
            if (checkQuyen.ChucVuNV.TenChucVu.Equals("Thu kho"))
            {
                mnsCashier.Enabled = false;
                mnsReport.Enabled = false;
                mnsAccount.Enabled = false;
                mnsQuanLy.Enabled = false;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void SignOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn đăng xuất?","Thông báo",MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                frmDangNhap frm = new frmDangNhap();
                this.Close();
                frm.ShowDialog();
                
            }
        }

        private void CashierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThuNgan obj = new frmThuNgan();  
            obj.Show();
            this.Hide();
        }

        private void NCCToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ChangePWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDoiMK obj = new frmDoiMK();  
            obj.Show();
            this.Hide();    
        }

        private void MemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhanvien frm = new frmNhanvien();
            frm.Show();
            this.Hide();
        }
    }
}
