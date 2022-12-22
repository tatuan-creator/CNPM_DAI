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
            this.CashierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NCCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GuestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HanghoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RepositoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NhaphangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TrahangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doanhThuCuốiNgàyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchPhiếuNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchPhiếuTrảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AccmanagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SignOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ChangePWToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.CashierToolStripMenuItem,
            this.ManagerToolStripMenuItem,
            this.RepositoryToolStripMenuItem,
            this.ReportToolStripMenuItem,
            this.AccmanagementToolStripMenuItem,
            this.SignOutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // HomeToolStripMenuItem
            // 
            this.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem";
            this.HomeToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.HomeToolStripMenuItem.Text = "Trang chủ ";
            // 
            // CashierToolStripMenuItem
            // 
            this.CashierToolStripMenuItem.Name = "CashierToolStripMenuItem";
            this.CashierToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.CashierToolStripMenuItem.Text = "Thu ngân";
            this.CashierToolStripMenuItem.Click += new System.EventHandler(this.CashierToolStripMenuItem_Click);
            // 
            // ManagerToolStripMenuItem
            // 
            this.ManagerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NCCToolStripMenuItem,
            this.GuestToolStripMenuItem,
            this.MemberToolStripMenuItem,
            this.HanghoaToolStripMenuItem,
            this.BillToolStripMenuItem});
            this.ManagerToolStripMenuItem.Name = "ManagerToolStripMenuItem";
            this.ManagerToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.ManagerToolStripMenuItem.Text = "Quản lý";
            // 
            // NCCToolStripMenuItem
            // 
            this.NCCToolStripMenuItem.Name = "NCCToolStripMenuItem";
            this.NCCToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.NCCToolStripMenuItem.Text = "Nhà cung cấp";
            this.NCCToolStripMenuItem.Click += new System.EventHandler(this.NCCToolStripMenuItem_Click);
            // 
            // GuestToolStripMenuItem
            // 
            this.GuestToolStripMenuItem.Name = "GuestToolStripMenuItem";
            this.GuestToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.GuestToolStripMenuItem.Text = "Khách hàng";
            // 
            // MemberToolStripMenuItem
            // 
            this.MemberToolStripMenuItem.Name = "MemberToolStripMenuItem";
            this.MemberToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.MemberToolStripMenuItem.Text = "Nhân viên";
            // 
            // HanghoaToolStripMenuItem
            // 
            this.HanghoaToolStripMenuItem.Name = "HanghoaToolStripMenuItem";
            this.HanghoaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.HanghoaToolStripMenuItem.Text = "Hàng hóa";
            // 
            // BillToolStripMenuItem
            // 
            this.BillToolStripMenuItem.Name = "BillToolStripMenuItem";
            this.BillToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.BillToolStripMenuItem.Text = "Hóa đơn";
            // 
            // RepositoryToolStripMenuItem
            // 
            this.RepositoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NhaphangToolStripMenuItem,
            this.TrahangToolStripMenuItem});
            this.RepositoryToolStripMenuItem.Name = "RepositoryToolStripMenuItem";
            this.RepositoryToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.RepositoryToolStripMenuItem.Text = "Kho hàng";
            // 
            // NhaphangToolStripMenuItem
            // 
            this.NhaphangToolStripMenuItem.Name = "NhaphangToolStripMenuItem";
            this.NhaphangToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.NhaphangToolStripMenuItem.Text = "Nhập hàng";
            // 
            // TrahangToolStripMenuItem
            // 
            this.TrahangToolStripMenuItem.Name = "TrahangToolStripMenuItem";
            this.TrahangToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.TrahangToolStripMenuItem.Text = "Trả hàng";
            // 
            // ReportToolStripMenuItem
            // 
            this.ReportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doanhThuCuốiNgàyToolStripMenuItem,
            this.danhSáchPhiếuNhậpToolStripMenuItem,
            this.danhSáchPhiếuTrảToolStripMenuItem});
            this.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem";
            this.ReportToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.ReportToolStripMenuItem.Text = "Báo cáo";
            // 
            // doanhThuCuốiNgàyToolStripMenuItem
            // 
            this.doanhThuCuốiNgàyToolStripMenuItem.Name = "doanhThuCuốiNgàyToolStripMenuItem";
            this.doanhThuCuốiNgàyToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.doanhThuCuốiNgàyToolStripMenuItem.Text = "Doanh thu cuối ngày";
            // 
            // danhSáchPhiếuNhậpToolStripMenuItem
            // 
            this.danhSáchPhiếuNhậpToolStripMenuItem.Name = "danhSáchPhiếuNhậpToolStripMenuItem";
            this.danhSáchPhiếuNhậpToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.danhSáchPhiếuNhậpToolStripMenuItem.Text = "Danh sách phiếu nhập";
            // 
            // danhSáchPhiếuTrảToolStripMenuItem
            // 
            this.danhSáchPhiếuTrảToolStripMenuItem.Name = "danhSáchPhiếuTrảToolStripMenuItem";
            this.danhSáchPhiếuTrảToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.danhSáchPhiếuTrảToolStripMenuItem.Text = "Danh sách phiếu trả";
            // 
            // AccmanagementToolStripMenuItem
            // 
            this.AccmanagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChangePWToolStripMenuItem});
            this.AccmanagementToolStripMenuItem.Name = "AccmanagementToolStripMenuItem";
            this.AccmanagementToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.AccmanagementToolStripMenuItem.Text = "Quản lý tài khoản";
            // 
            // SignOutToolStripMenuItem
            // 
            this.SignOutToolStripMenuItem.Name = "SignOutToolStripMenuItem";
            this.SignOutToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.SignOutToolStripMenuItem.Text = "Đăng xuất";
            this.SignOutToolStripMenuItem.Click += new System.EventHandler(this.SignOutToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 426);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Font = new System.Drawing.Font("NSimSun", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(310, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "ASTOP";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 426);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ChangePWToolStripMenuItem
            // 
            this.ChangePWToolStripMenuItem.Name = "ChangePWToolStripMenuItem";
            this.ChangePWToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ChangePWToolStripMenuItem.Text = "Đổi mật khẩu";
            this.ChangePWToolStripMenuItem.Click += new System.EventHandler(this.ChangePWToolStripMenuItem_Click);
            // 
            // frmGiaodien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
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
        private System.Windows.Forms.ToolStripMenuItem CashierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NCCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GuestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HanghoaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RepositoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NhaphangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TrahangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doanhThuCuốiNgàyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSáchPhiếuNhậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSáchPhiếuTrảToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AccmanagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SignOutToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem HomeToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem ChangePWToolStripMenuItem;
    }
}