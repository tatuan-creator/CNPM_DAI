﻿using System;
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
    public partial class frmThuNgan : Form
    {
        public frmThuNgan()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pibBack_Click(object sender, EventArgs e)
        {
            frmGiaodien obj = new frmGiaodien();
            obj.Show();
            this.Hide();    
        }
    }
}
