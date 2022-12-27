namespace QLST
{
    partial class frmGiaodien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGiaodien));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.HomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsCashier = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsQuanLy = new System.Windows.Forms.ToolStripMenuItem();
            this.NCCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GuestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HanghoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsRepo = new System.Windows.Forms.ToolStripMenuItem();
            this.NhaphangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TrahangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsReport = new System.Windows.Forms.ToolStripMenuItem();
            this.doanhThuCuốiNgàyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchPhiếuNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchPhiếuTrảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangePWToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SignOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HomeToolStripMenuItem,
            this.mnsCashier,
            this.mnsQuanLy,
            this.mnsRepo,
            this.mnsReport,
            this.mnsAccount,
            this.SignOutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // HomeToolStripMenuItem
            // 
            this.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem";
            this.HomeToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.HomeToolStripMenuItem.Text = "Trang chủ ";
            // 
            // mnsCashier
            // 
            this.mnsCashier.Name = "mnsCashier";
            this.mnsCashier.Size = new System.Drawing.Size(88, 24);
            this.mnsCashier.Text = "Thu ngân";
            this.mnsCashier.Click += new System.EventHandler(this.CashierToolStripMenuItem_Click);
            // 
            // mnsQuanLy
            // 
            this.mnsQuanLy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NCCToolStripMenuItem,
            this.GuestToolStripMenuItem,
            this.MemberToolStripMenuItem,
            this.HanghoaToolStripMenuItem,
            this.BillToolStripMenuItem});
            this.mnsQuanLy.Name = "mnsQuanLy";
            this.mnsQuanLy.Size = new System.Drawing.Size(76, 24);
            this.mnsQuanLy.Text = "Quản lý";
            // 
            // NCCToolStripMenuItem
            // 
            this.NCCToolStripMenuItem.Name = "NCCToolStripMenuItem";
            this.NCCToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.NCCToolStripMenuItem.Text = "Nhà cung cấp";
            this.NCCToolStripMenuItem.Click += new System.EventHandler(this.NCCToolStripMenuItem_Click);
            // 
            // GuestToolStripMenuItem
            // 
            this.GuestToolStripMenuItem.Name = "GuestToolStripMenuItem";
            this.GuestToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.GuestToolStripMenuItem.Text = "Khách hàng";
            // 
            // MemberToolStripMenuItem
            // 
            this.MemberToolStripMenuItem.Name = "MemberToolStripMenuItem";
            this.MemberToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.MemberToolStripMenuItem.Text = "Nhân viên";
            this.MemberToolStripMenuItem.Click += new System.EventHandler(this.MemberToolStripMenuItem_Click);
            // 
            // HanghoaToolStripMenuItem
            // 
            this.HanghoaToolStripMenuItem.Name = "HanghoaToolStripMenuItem";
            this.HanghoaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.HanghoaToolStripMenuItem.Text = "Hàng hóa";
            // 
            // BillToolStripMenuItem
            // 
            this.BillToolStripMenuItem.Name = "BillToolStripMenuItem";
            this.BillToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.BillToolStripMenuItem.Text = "Hóa đơn";
            // 
            // mnsRepo
            // 
            this.mnsRepo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NhaphangToolStripMenuItem,
            this.TrahangToolStripMenuItem});
            this.mnsRepo.Name = "mnsRepo";
            this.mnsRepo.Size = new System.Drawing.Size(89, 24);
            this.mnsRepo.Text = "Kho hàng";
            // 
            // NhaphangToolStripMenuItem
            // 
            this.NhaphangToolStripMenuItem.Name = "NhaphangToolStripMenuItem";
            this.NhaphangToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.NhaphangToolStripMenuItem.Text = "Nhập hàng";
            // 
            // TrahangToolStripMenuItem
            // 
            this.TrahangToolStripMenuItem.Name = "TrahangToolStripMenuItem";
            this.TrahangToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.TrahangToolStripMenuItem.Text = "Trả hàng";
            // 
            // mnsReport
            // 
            this.mnsReport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doanhThuCuốiNgàyToolStripMenuItem,
            this.danhSáchPhiếuNhậpToolStripMenuItem,
            this.danhSáchPhiếuTrảToolStripMenuItem});
            this.mnsReport.Name = "mnsReport";
            this.mnsReport.Size = new System.Drawing.Size(77, 24);
            this.mnsReport.Text = "Báo cáo";
            // 
            // doanhThuCuốiNgàyToolStripMenuItem
            // 
            this.doanhThuCuốiNgàyToolStripMenuItem.Name = "doanhThuCuốiNgàyToolStripMenuItem";
            this.doanhThuCuốiNgàyToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.doanhThuCuốiNgàyToolStripMenuItem.Text = "Doanh thu cuối ngày";
            // 
            // danhSáchPhiếuNhậpToolStripMenuItem
            // 
            this.danhSáchPhiếuNhậpToolStripMenuItem.Name = "danhSáchPhiếuNhậpToolStripMenuItem";
            this.danhSáchPhiếuNhậpToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.danhSáchPhiếuNhậpToolStripMenuItem.Text = "Danh sách phiếu nhập";
            // 
            // danhSáchPhiếuTrảToolStripMenuItem
            // 
            this.danhSáchPhiếuTrảToolStripMenuItem.Name = "danhSáchPhiếuTrảToolStripMenuItem";
            this.danhSáchPhiếuTrảToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.danhSáchPhiếuTrảToolStripMenuItem.Text = "Danh sách phiếu trả";
            // 
            // mnsAccount
            // 
            this.mnsAccount.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChangePWToolStripMenuItem});
            this.mnsAccount.Name = "mnsAccount";
            this.mnsAccount.Size = new System.Drawing.Size(144, 24);
            this.mnsAccount.Text = "Quản lý tài khoản";
            // 
            // ChangePWToolStripMenuItem
            // 
            this.ChangePWToolStripMenuItem.Name = "ChangePWToolStripMenuItem";
            this.ChangePWToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ChangePWToolStripMenuItem.Text = "Đổi mật khẩu";
            this.ChangePWToolStripMenuItem.Click += new System.EventHandler(this.ChangePWToolStripMenuItem_Click);
            // 
            // SignOutToolStripMenuItem
            // 
            this.SignOutToolStripMenuItem.Name = "SignOutToolStripMenuItem";
            this.SignOutToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.SignOutToolStripMenuItem.Text = "Đăng xuất";
            this.SignOutToolStripMenuItem.Click += new System.EventHandler(this.SignOutToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 526);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Font = new System.Drawing.Font("NSimSun", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(413, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "ASTOP";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1067, 524);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmGiaodien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmGiaodien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGiaodien";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnsCashier;
        private System.Windows.Forms.ToolStripMenuItem mnsQuanLy;
        private System.Windows.Forms.ToolStripMenuItem NCCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GuestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HanghoaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnsRepo;
        private System.Windows.Forms.ToolStripMenuItem NhaphangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TrahangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnsReport;
        private System.Windows.Forms.ToolStripMenuItem doanhThuCuốiNgàyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSáchPhiếuNhậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSáchPhiếuTrảToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnsAccount;
        private System.Windows.Forms.ToolStripMenuItem SignOutToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem HomeToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem ChangePWToolStripMenuItem;
    }
}