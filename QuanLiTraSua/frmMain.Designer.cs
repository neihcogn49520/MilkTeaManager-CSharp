
namespace QuanLiTraSua
{
    partial class frmMain
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
            this.pn_Desktop = new Guna.UI2.WinForms.Guna2Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panDrag = new System.Windows.Forms.Panel();
            this.btn_account = new Guna.UI2.WinForms.Guna2Button();
            this.pn_menu = new Guna.UI2.WinForms.Guna2Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pic_Home = new Guna.UI2.WinForms.Guna2PictureBox();
            this.bt_ThongKe = new Guna.UI2.WinForms.Guna2Button();
            this.bt_logout = new Guna.UI2.WinForms.Guna2Button();
            this.bt_SanPham = new Guna.UI2.WinForms.Guna2Button();
            this.bt_BaoCao = new Guna.UI2.WinForms.Guna2Button();
            this.bt_Menu = new Guna.UI2.WinForms.Guna2Button();
            this.bt_NhanVien = new Guna.UI2.WinForms.Guna2Button();
            this.pn_Desktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panDrag.SuspendLayout();
            this.pn_menu.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Home)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_Desktop
            // 
            this.pn_Desktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.pn_Desktop.Controls.Add(this.pictureBox2);
            this.pn_Desktop.Controls.Add(this.pictureBox1);
            this.pn_Desktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_Desktop.Location = new System.Drawing.Point(268, 53);
            this.pn_Desktop.Name = "pn_Desktop";
            this.pn_Desktop.ShadowDecoration.Parent = this.pn_Desktop;
            this.pn_Desktop.Size = new System.Drawing.Size(1060, 774);
            this.pn_Desktop.TabIndex = 0;
            this.pn_Desktop.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_Desktop_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.Image = global::QuanLiTraSua.Properties.Resources.GIF_MILKTEA;
            this.pictureBox2.Location = new System.Drawing.Point(211, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(638, 79);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 73;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::QuanLiTraSua.Properties.Resources.trasua;
            this.pictureBox1.Location = new System.Drawing.Point(60, 93);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(938, 617);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 72;
            this.pictureBox1.TabStop = false;
            // 
            // panDrag
            // 
            this.panDrag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.panDrag.Controls.Add(this.btn_account);
            this.panDrag.Dock = System.Windows.Forms.DockStyle.Top;
            this.panDrag.Location = new System.Drawing.Point(268, 0);
            this.panDrag.Name = "panDrag";
            this.panDrag.Size = new System.Drawing.Size(1060, 53);
            this.panDrag.TabIndex = 69;
            this.panDrag.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panDrag_MouseDown);
            // 
            // btn_account
            // 
            this.btn_account.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_account.CheckedState.Parent = this.btn_account;
            this.btn_account.CustomImages.Parent = this.btn_account;
            this.btn_account.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_account.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_account.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_account.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_account.DisabledState.Parent = this.btn_account;
            this.btn_account.FillColor = System.Drawing.Color.Transparent;
            this.btn_account.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btn_account.ForeColor = System.Drawing.Color.White;
            this.btn_account.HoverState.Parent = this.btn_account;
            this.btn_account.Image = global::QuanLiTraSua.Properties.Resources.user1;
            this.btn_account.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_account.Location = new System.Drawing.Point(871, 9);
            this.btn_account.Name = "btn_account";
            this.btn_account.ShadowDecoration.Parent = this.btn_account;
            this.btn_account.Size = new System.Drawing.Size(177, 35);
            this.btn_account.TabIndex = 7;
            this.btn_account.Text = "user";
            this.btn_account.TextOffset = new System.Drawing.Point(4, 0);
            // 
            // pn_menu
            // 
            this.pn_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(40)))));
            this.pn_menu.BorderColor = System.Drawing.Color.Navy;
            this.pn_menu.Controls.Add(this.panel2);
            this.pn_menu.Controls.Add(this.bt_ThongKe);
            this.pn_menu.Controls.Add(this.bt_logout);
            this.pn_menu.Controls.Add(this.bt_SanPham);
            this.pn_menu.Controls.Add(this.bt_BaoCao);
            this.pn_menu.Controls.Add(this.bt_Menu);
            this.pn_menu.Controls.Add(this.bt_NhanVien);
            this.pn_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pn_menu.Location = new System.Drawing.Point(0, 0);
            this.pn_menu.Name = "pn_menu";
            this.pn_menu.ShadowDecoration.Parent = this.pn_menu;
            this.pn_menu.Size = new System.Drawing.Size(268, 827);
            this.pn_menu.TabIndex = 67;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pic_Home);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(268, 148);
            this.panel2.TabIndex = 16;
            // 
            // pic_Home
            // 
            this.pic_Home.FillColor = System.Drawing.Color.Transparent;
            this.pic_Home.Image = global::QuanLiTraSua.Properties.Resources.trasua2;
            this.pic_Home.ImageRotate = 0F;
            this.pic_Home.Location = new System.Drawing.Point(36, 3);
            this.pic_Home.Name = "pic_Home";
            this.pic_Home.ShadowDecoration.Parent = this.pic_Home;
            this.pic_Home.Size = new System.Drawing.Size(192, 142);
            this.pic_Home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Home.TabIndex = 7;
            this.pic_Home.TabStop = false;
            this.pic_Home.Click += new System.EventHandler(this.pic_Home_Click);
            // 
            // bt_ThongKe
            // 
            this.bt_ThongKe.CheckedState.Parent = this.bt_ThongKe;
            this.bt_ThongKe.CustomImages.Parent = this.bt_ThongKe;
            this.bt_ThongKe.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.bt_ThongKe.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.bt_ThongKe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(25)))));
            this.bt_ThongKe.DisabledState.ForeColor = System.Drawing.Color.Gray;
            this.bt_ThongKe.DisabledState.Parent = this.bt_ThongKe;
            this.bt_ThongKe.FillColor = System.Drawing.Color.Transparent;
            this.bt_ThongKe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ThongKe.ForeColor = System.Drawing.Color.White;
            this.bt_ThongKe.HoverState.Parent = this.bt_ThongKe;
            this.bt_ThongKe.Image = global::QuanLiTraSua.Properties.Resources._4230540_analysis_graph;
            this.bt_ThongKe.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bt_ThongKe.ImageSize = new System.Drawing.Size(30, 30);
            this.bt_ThongKe.Location = new System.Drawing.Point(0, 514);
            this.bt_ThongKe.Name = "bt_ThongKe";
            this.bt_ThongKe.ShadowDecoration.Parent = this.bt_ThongKe;
            this.bt_ThongKe.Size = new System.Drawing.Size(262, 84);
            this.bt_ThongKe.TabIndex = 15;
            this.bt_ThongKe.Text = "Thống kê";
            this.bt_ThongKe.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bt_ThongKe.Click += new System.EventHandler(this.bt_ThongKe_Click);
            // 
            // bt_logout
            // 
            this.bt_logout.BackColor = System.Drawing.Color.Transparent;
            this.bt_logout.BorderColor = System.Drawing.Color.DimGray;
            this.bt_logout.CheckedState.Parent = this.bt_logout;
            this.bt_logout.CustomImages.Parent = this.bt_logout;
            this.bt_logout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_logout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt_logout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_logout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt_logout.DisabledState.Parent = this.bt_logout;
            this.bt_logout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bt_logout.FillColor = System.Drawing.Color.Transparent;
            this.bt_logout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.bt_logout.ForeColor = System.Drawing.Color.White;
            this.bt_logout.HoverState.Parent = this.bt_logout;
            this.bt_logout.Image = global::QuanLiTraSua.Properties.Resources.exit;
            this.bt_logout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bt_logout.ImageSize = new System.Drawing.Size(30, 30);
            this.bt_logout.Location = new System.Drawing.Point(0, 758);
            this.bt_logout.Name = "bt_logout";
            this.bt_logout.ShadowDecoration.Parent = this.bt_logout;
            this.bt_logout.Size = new System.Drawing.Size(268, 69);
            this.bt_logout.TabIndex = 1;
            this.bt_logout.Text = "Đăng xuất";
            this.bt_logout.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bt_logout.Click += new System.EventHandler(this.bt_logout_Click);
            // 
            // bt_SanPham
            // 
            this.bt_SanPham.CheckedState.Parent = this.bt_SanPham;
            this.bt_SanPham.CustomImages.Parent = this.bt_SanPham;
            this.bt_SanPham.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.bt_SanPham.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.bt_SanPham.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(25)))));
            this.bt_SanPham.DisabledState.ForeColor = System.Drawing.Color.Gray;
            this.bt_SanPham.DisabledState.Parent = this.bt_SanPham;
            this.bt_SanPham.FillColor = System.Drawing.Color.Transparent;
            this.bt_SanPham.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_SanPham.ForeColor = System.Drawing.Color.White;
            this.bt_SanPham.HoverState.Parent = this.bt_SanPham;
            this.bt_SanPham.Image = global::QuanLiTraSua.Properties.Resources.product_shape_ui_icon;
            this.bt_SanPham.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bt_SanPham.ImageSize = new System.Drawing.Size(30, 30);
            this.bt_SanPham.Location = new System.Drawing.Point(3, 334);
            this.bt_SanPham.Name = "bt_SanPham";
            this.bt_SanPham.ShadowDecoration.Parent = this.bt_SanPham;
            this.bt_SanPham.Size = new System.Drawing.Size(262, 84);
            this.bt_SanPham.TabIndex = 14;
            this.bt_SanPham.Text = "Sản phẩm";
            this.bt_SanPham.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bt_SanPham.Click += new System.EventHandler(this.bt_SanPham_Click);
            // 
            // bt_BaoCao
            // 
            this.bt_BaoCao.CheckedState.Parent = this.bt_BaoCao;
            this.bt_BaoCao.CustomImages.Parent = this.bt_BaoCao;
            this.bt_BaoCao.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.bt_BaoCao.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.bt_BaoCao.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(25)))));
            this.bt_BaoCao.DisabledState.ForeColor = System.Drawing.Color.Gray;
            this.bt_BaoCao.DisabledState.Parent = this.bt_BaoCao;
            this.bt_BaoCao.FillColor = System.Drawing.Color.Transparent;
            this.bt_BaoCao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_BaoCao.ForeColor = System.Drawing.Color.White;
            this.bt_BaoCao.HoverState.Parent = this.bt_BaoCao;
            this.bt_BaoCao.Image = global::QuanLiTraSua.Properties.Resources.report_icon;
            this.bt_BaoCao.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bt_BaoCao.ImageSize = new System.Drawing.Size(30, 30);
            this.bt_BaoCao.Location = new System.Drawing.Point(3, 424);
            this.bt_BaoCao.Name = "bt_BaoCao";
            this.bt_BaoCao.ShadowDecoration.Parent = this.bt_BaoCao;
            this.bt_BaoCao.Size = new System.Drawing.Size(262, 84);
            this.bt_BaoCao.TabIndex = 13;
            this.bt_BaoCao.Text = "Báo cáo doanh thu";
            this.bt_BaoCao.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bt_BaoCao.Click += new System.EventHandler(this.bt_BaoCao_Click);
            // 
            // bt_Menu
            // 
            this.bt_Menu.CheckedState.Parent = this.bt_Menu;
            this.bt_Menu.CustomImages.Parent = this.bt_Menu;
            this.bt_Menu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.bt_Menu.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.bt_Menu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(25)))));
            this.bt_Menu.DisabledState.ForeColor = System.Drawing.Color.Gray;
            this.bt_Menu.DisabledState.Parent = this.bt_Menu;
            this.bt_Menu.FillColor = System.Drawing.Color.Transparent;
            this.bt_Menu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Menu.ForeColor = System.Drawing.Color.White;
            this.bt_Menu.HoverState.Parent = this.bt_Menu;
            this.bt_Menu.Image = global::QuanLiTraSua.Properties.Resources.milk_tea;
            this.bt_Menu.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bt_Menu.ImageSize = new System.Drawing.Size(30, 30);
            this.bt_Menu.Location = new System.Drawing.Point(3, 244);
            this.bt_Menu.Name = "bt_Menu";
            this.bt_Menu.ShadowDecoration.Parent = this.bt_Menu;
            this.bt_Menu.Size = new System.Drawing.Size(262, 84);
            this.bt_Menu.TabIndex = 12;
            this.bt_Menu.Text = "Morri\'s menu";
            this.bt_Menu.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bt_Menu.Click += new System.EventHandler(this.bt_Menu_Click);
            // 
            // bt_NhanVien
            // 
            this.bt_NhanVien.CheckedState.Parent = this.bt_NhanVien;
            this.bt_NhanVien.CustomImages.Parent = this.bt_NhanVien;
            this.bt_NhanVien.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.bt_NhanVien.DisabledState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.bt_NhanVien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(25)))));
            this.bt_NhanVien.DisabledState.ForeColor = System.Drawing.Color.Gray;
            this.bt_NhanVien.DisabledState.Parent = this.bt_NhanVien;
            this.bt_NhanVien.FillColor = System.Drawing.Color.Transparent;
            this.bt_NhanVien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_NhanVien.ForeColor = System.Drawing.Color.White;
            this.bt_NhanVien.HoverState.Parent = this.bt_NhanVien;
            this.bt_NhanVien.Image = global::QuanLiTraSua.Properties.Resources._6590483_and_education_id_learning_pass_icon;
            this.bt_NhanVien.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bt_NhanVien.ImageSize = new System.Drawing.Size(30, 30);
            this.bt_NhanVien.Location = new System.Drawing.Point(3, 154);
            this.bt_NhanVien.Name = "bt_NhanVien";
            this.bt_NhanVien.ShadowDecoration.Parent = this.bt_NhanVien;
            this.bt_NhanVien.Size = new System.Drawing.Size(262, 84);
            this.bt_NhanVien.TabIndex = 11;
            this.bt_NhanVien.Text = "Nhân viên";
            this.bt_NhanVien.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bt_NhanVien.Click += new System.EventHandler(this.bt_NhanVien_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1328, 827);
            this.Controls.Add(this.pn_Desktop);
            this.Controls.Add(this.panDrag);
            this.Controls.Add(this.pn_menu);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pn_Desktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panDrag.ResumeLayout(false);
            this.pn_menu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Home)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pn_Desktop;
        private Guna.UI2.WinForms.Guna2Button bt_logout;
        private Guna.UI2.WinForms.Guna2Panel pn_menu;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2PictureBox pic_Home;
        private Guna.UI2.WinForms.Guna2Button bt_ThongKe;
        private Guna.UI2.WinForms.Guna2Button bt_SanPham;
        private Guna.UI2.WinForms.Guna2Button bt_BaoCao;
        private Guna.UI2.WinForms.Guna2Button bt_Menu;
        private Guna.UI2.WinForms.Guna2Button bt_NhanVien;
        private System.Windows.Forms.Panel panDrag;
        private Guna.UI2.WinForms.Guna2Button btn_account;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}