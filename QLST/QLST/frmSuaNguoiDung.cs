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
        public frmSuaNguoiDung()
        {
            InitializeComponent();
        }

        private void pibBack2_Click(object sender, EventArgs e)
        {
            frmNhanvien obj = new frmNhanvien();
            obj.Show();
            this.Hide();
        }
    }
}
