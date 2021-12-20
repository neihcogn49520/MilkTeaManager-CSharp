
namespace QuanLiTraSua
{
    partial class frmDemo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lb_timKiem = new System.Windows.Forms.Label();
            this.txt_tiemKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.bt_sua = new Guna.UI2.WinForms.Guna2Button();
            this.bt_xoa = new Guna.UI2.WinForms.Guna2Button();
            this.bt_them = new Guna.UI2.WinForms.Guna2Button();
            this.txt_sdt = new Guna.UI2.WinForms.Guna2TextBox();
            this.lb_sdt = new System.Windows.Forms.Label();
            this.rbt_khac = new System.Windows.Forms.RadioButton();
            this.rbt_nu = new System.Windows.Forms.RadioButton();
            this.rbt_nam = new System.Windows.Forms.RadioButton();
            this.lb_ngaysinh = new System.Windows.Forms.Label();
            this.txt_hoTen = new Guna.UI2.WinForms.Guna2TextBox();
            this.lb_hoTen = new System.Windows.Forms.Label();
            this.txt_ID = new Guna.UI2.WinForms.Guna2TextBox();
            this.lb_ID = new System.Windows.Forms.Label();
            this.lb_gioiTinh = new System.Windows.Forms.Label();
            this.dtp_Ngaysinh = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dgv_TTKhachHang = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TTKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_timKiem
            // 
            this.lb_timKiem.AutoSize = true;
            this.lb_timKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.lb_timKiem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_timKiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.lb_timKiem.Location = new System.Drawing.Point(866, 261);
            this.lb_timKiem.Name = "lb_timKiem";
            this.lb_timKiem.Size = new System.Drawing.Size(105, 28);
            this.lb_timKiem.TabIndex = 48;
            this.lb_timKiem.Text = "Tìm kiếm:";
            // 
            // txt_tiemKiem
            // 
            this.txt_tiemKiem.BorderColor = System.Drawing.Color.SteelBlue;
            this.txt_tiemKiem.BorderThickness = 2;
            this.txt_tiemKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_tiemKiem.DefaultText = "";
            this.txt_tiemKiem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_tiemKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_tiemKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_tiemKiem.DisabledState.Parent = this.txt_tiemKiem;
            this.txt_tiemKiem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_tiemKiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_tiemKiem.FocusedState.Parent = this.txt_tiemKiem;
            this.txt_tiemKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_tiemKiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_tiemKiem.HoverState.Parent = this.txt_tiemKiem;
            this.txt_tiemKiem.IconRight = global::QuanLiTraSua.Properties.Resources._172546_search_icon;
            this.txt_tiemKiem.Location = new System.Drawing.Point(993, 258);
            this.txt_tiemKiem.Name = "txt_tiemKiem";
            this.txt_tiemKiem.PasswordChar = '\0';
            this.txt_tiemKiem.PlaceholderText = "";
            this.txt_tiemKiem.SelectedText = "";
            this.txt_tiemKiem.ShadowDecoration.Parent = this.txt_tiemKiem;
            this.txt_tiemKiem.Size = new System.Drawing.Size(223, 31);
            this.txt_tiemKiem.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_tiemKiem.TabIndex = 47;
            // 
            // bt_sua
            // 
            this.bt_sua.AutoRoundedCorners = true;
            this.bt_sua.BackColor = System.Drawing.Color.Transparent;
            this.bt_sua.BorderColor = System.Drawing.Color.SteelBlue;
            this.bt_sua.BorderRadius = 21;
            this.bt_sua.BorderThickness = 2;
            this.bt_sua.CheckedState.Parent = this.bt_sua;
            this.bt_sua.CustomImages.Parent = this.bt_sua;
            this.bt_sua.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_sua.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt_sua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_sua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt_sua.DisabledState.Parent = this.bt_sua;
            this.bt_sua.FillColor = System.Drawing.Color.White;
            this.bt_sua.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.bt_sua.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bt_sua.HoverState.Parent = this.bt_sua;
            this.bt_sua.Image = global::QuanLiTraSua.Properties.Resources._2931178_change_edit_pencil_creative_design_icon;
            this.bt_sua.Location = new System.Drawing.Point(1107, 190);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.ShadowDecoration.Parent = this.bt_sua;
            this.bt_sua.Size = new System.Drawing.Size(109, 45);
            this.bt_sua.TabIndex = 46;
            this.bt_sua.Text = "Sửa";
            this.bt_sua.UseTransparentBackground = true;
            // 
            // bt_xoa
            // 
            this.bt_xoa.AutoRoundedCorners = true;
            this.bt_xoa.BackColor = System.Drawing.Color.Transparent;
            this.bt_xoa.BorderColor = System.Drawing.Color.SteelBlue;
            this.bt_xoa.BorderRadius = 21;
            this.bt_xoa.BorderThickness = 2;
            this.bt_xoa.CheckedState.Parent = this.bt_xoa;
            this.bt_xoa.CustomImages.Parent = this.bt_xoa;
            this.bt_xoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_xoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt_xoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_xoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt_xoa.DisabledState.Parent = this.bt_xoa;
            this.bt_xoa.FillColor = System.Drawing.Color.White;
            this.bt_xoa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.bt_xoa.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bt_xoa.HoverState.Parent = this.bt_xoa;
            this.bt_xoa.Image = global::QuanLiTraSua.Properties.Resources._1303875_circle_minimize_minus_remove_close_icon;
            this.bt_xoa.Location = new System.Drawing.Point(1107, 56);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.ShadowDecoration.Parent = this.bt_xoa;
            this.bt_xoa.Size = new System.Drawing.Size(109, 45);
            this.bt_xoa.TabIndex = 45;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.UseTransparentBackground = true;
            // 
            // bt_them
            // 
            this.bt_them.AutoRoundedCorners = true;
            this.bt_them.BackColor = System.Drawing.Color.Transparent;
            this.bt_them.BorderColor = System.Drawing.Color.SteelBlue;
            this.bt_them.BorderRadius = 21;
            this.bt_them.BorderThickness = 2;
            this.bt_them.CheckedState.Parent = this.bt_them;
            this.bt_them.CustomImages.Parent = this.bt_them;
            this.bt_them.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bt_them.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bt_them.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bt_them.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bt_them.DisabledState.Parent = this.bt_them;
            this.bt_them.FillColor = System.Drawing.Color.White;
            this.bt_them.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.bt_them.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bt_them.HoverState.Parent = this.bt_them;
            this.bt_them.Image = global::QuanLiTraSua.Properties.Resources._4781840___add_circle_create_expand_icon;
            this.bt_them.Location = new System.Drawing.Point(1107, 124);
            this.bt_them.Name = "bt_them";
            this.bt_them.ShadowDecoration.Parent = this.bt_them;
            this.bt_them.Size = new System.Drawing.Size(109, 45);
            this.bt_them.TabIndex = 44;
            this.bt_them.Text = "Thêm ";
            this.bt_them.UseTransparentBackground = true;
            // 
            // txt_sdt
            // 
            this.txt_sdt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_sdt.DefaultText = "";
            this.txt_sdt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_sdt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_sdt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_sdt.DisabledState.Parent = this.txt_sdt;
            this.txt_sdt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_sdt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_sdt.FocusedState.Parent = this.txt_sdt;
            this.txt_sdt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_sdt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_sdt.HoverState.Parent = this.txt_sdt;
            this.txt_sdt.Location = new System.Drawing.Point(711, 138);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.PasswordChar = '\0';
            this.txt_sdt.PlaceholderText = "";
            this.txt_sdt.SelectedText = "";
            this.txt_sdt.ShadowDecoration.Parent = this.txt_sdt;
            this.txt_sdt.Size = new System.Drawing.Size(200, 31);
            this.txt_sdt.TabIndex = 43;
            // 
            // lb_sdt
            // 
            this.lb_sdt.AutoSize = true;
            this.lb_sdt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.lb_sdt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sdt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.lb_sdt.Location = new System.Drawing.Point(584, 141);
            this.lb_sdt.Name = "lb_sdt";
            this.lb_sdt.Size = new System.Drawing.Size(49, 28);
            this.lb_sdt.TabIndex = 42;
            this.lb_sdt.Text = "Sđt:";
            // 
            // rbt_khac
            // 
            this.rbt_khac.AutoSize = true;
            this.rbt_khac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.rbt_khac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt_khac.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.rbt_khac.Location = new System.Drawing.Point(917, 76);
            this.rbt_khac.Name = "rbt_khac";
            this.rbt_khac.Size = new System.Drawing.Size(78, 28);
            this.rbt_khac.TabIndex = 41;
            this.rbt_khac.TabStop = true;
            this.rbt_khac.Text = "Khác";
            this.rbt_khac.UseVisualStyleBackColor = false;
            // 
            // rbt_nu
            // 
            this.rbt_nu.AutoSize = true;
            this.rbt_nu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.rbt_nu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt_nu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.rbt_nu.Location = new System.Drawing.Point(826, 76);
            this.rbt_nu.Name = "rbt_nu";
            this.rbt_nu.Size = new System.Drawing.Size(58, 28);
            this.rbt_nu.TabIndex = 40;
            this.rbt_nu.TabStop = true;
            this.rbt_nu.Text = "Nữ";
            this.rbt_nu.UseVisualStyleBackColor = false;
            // 
            // rbt_nam
            // 
            this.rbt_nam.AutoSize = true;
            this.rbt_nam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.rbt_nam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt_nam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.rbt_nam.Location = new System.Drawing.Point(727, 76);
            this.rbt_nam.Name = "rbt_nam";
            this.rbt_nam.Size = new System.Drawing.Size(74, 28);
            this.rbt_nam.TabIndex = 39;
            this.rbt_nam.TabStop = true;
            this.rbt_nam.Text = "Nam";
            this.rbt_nam.UseVisualStyleBackColor = false;
            // 
            // lb_ngaysinh
            // 
            this.lb_ngaysinh.AutoSize = true;
            this.lb_ngaysinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.lb_ngaysinh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ngaysinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.lb_ngaysinh.Location = new System.Drawing.Point(139, 210);
            this.lb_ngaysinh.Name = "lb_ngaysinh";
            this.lb_ngaysinh.Size = new System.Drawing.Size(112, 28);
            this.lb_ngaysinh.TabIndex = 38;
            this.lb_ngaysinh.Text = "Ngày sinh:";
            // 
            // txt_hoTen
            // 
            this.txt_hoTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_hoTen.DefaultText = "";
            this.txt_hoTen.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_hoTen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_hoTen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_hoTen.DisabledState.Parent = this.txt_hoTen;
            this.txt_hoTen.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_hoTen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_hoTen.FocusedState.Parent = this.txt_hoTen;
            this.txt_hoTen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_hoTen.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_hoTen.HoverState.Parent = this.txt_hoTen;
            this.txt_hoTen.Location = new System.Drawing.Point(278, 138);
            this.txt_hoTen.Name = "txt_hoTen";
            this.txt_hoTen.PasswordChar = '\0';
            this.txt_hoTen.PlaceholderText = "";
            this.txt_hoTen.SelectedText = "";
            this.txt_hoTen.ShadowDecoration.Parent = this.txt_hoTen;
            this.txt_hoTen.Size = new System.Drawing.Size(200, 31);
            this.txt_hoTen.TabIndex = 37;
            // 
            // lb_hoTen
            // 
            this.lb_hoTen.AutoSize = true;
            this.lb_hoTen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.lb_hoTen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_hoTen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.lb_hoTen.Location = new System.Drawing.Point(139, 144);
            this.lb_hoTen.Name = "lb_hoTen";
            this.lb_hoTen.Size = new System.Drawing.Size(87, 28);
            this.lb_hoTen.TabIndex = 36;
            this.lb_hoTen.Text = "Họ  tên:";
            // 
            // txt_ID
            // 
            this.txt_ID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ID.DefaultText = "";
            this.txt_ID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_ID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_ID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_ID.DisabledState.Parent = this.txt_ID;
            this.txt_ID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_ID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_ID.FocusedState.Parent = this.txt_ID;
            this.txt_ID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_ID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_ID.HoverState.Parent = this.txt_ID;
            this.txt_ID.Location = new System.Drawing.Point(278, 74);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.PasswordChar = '\0';
            this.txt_ID.PlaceholderText = "";
            this.txt_ID.SelectedText = "";
            this.txt_ID.ShadowDecoration.Parent = this.txt_ID;
            this.txt_ID.Size = new System.Drawing.Size(200, 31);
            this.txt_ID.TabIndex = 35;
            // 
            // lb_ID
            // 
            this.lb_ID.AutoSize = true;
            this.lb_ID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.lb_ID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.lb_ID.Location = new System.Drawing.Point(139, 80);
            this.lb_ID.Name = "lb_ID";
            this.lb_ID.Size = new System.Drawing.Size(38, 28);
            this.lb_ID.TabIndex = 34;
            this.lb_ID.Text = "ID:";
            // 
            // lb_gioiTinh
            // 
            this.lb_gioiTinh.AutoSize = true;
            this.lb_gioiTinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.lb_gioiTinh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_gioiTinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(87)))), ((int)(((byte)(122)))));
            this.lb_gioiTinh.Location = new System.Drawing.Point(584, 76);
            this.lb_gioiTinh.Name = "lb_gioiTinh";
            this.lb_gioiTinh.Size = new System.Drawing.Size(106, 28);
            this.lb_gioiTinh.TabIndex = 33;
            this.lb_gioiTinh.Text = "Giới tính: ";
            // 
            // dtp_Ngaysinh
            // 
            this.dtp_Ngaysinh.BackColor = System.Drawing.Color.White;
            this.dtp_Ngaysinh.Checked = true;
            this.dtp_Ngaysinh.CheckedState.Parent = this.dtp_Ngaysinh;
            this.dtp_Ngaysinh.FillColor = System.Drawing.Color.White;
            this.dtp_Ngaysinh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtp_Ngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Ngaysinh.HoverState.Parent = this.dtp_Ngaysinh;
            this.dtp_Ngaysinh.Location = new System.Drawing.Point(278, 204);
            this.dtp_Ngaysinh.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_Ngaysinh.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_Ngaysinh.Name = "dtp_Ngaysinh";
            this.dtp_Ngaysinh.ShadowDecoration.Parent = this.dtp_Ngaysinh;
            this.dtp_Ngaysinh.Size = new System.Drawing.Size(200, 31);
            this.dtp_Ngaysinh.TabIndex = 32;
            this.dtp_Ngaysinh.Value = new System.DateTime(2021, 11, 2, 18, 56, 7, 267);
            // 
            // dgv_TTKhachHang
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_TTKhachHang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_TTKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_TTKhachHang.BackgroundColor = System.Drawing.Color.SeaShell;
            this.dgv_TTKhachHang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_TTKhachHang.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_TTKhachHang.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_TTKhachHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_TTKhachHang.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_TTKhachHang.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_TTKhachHang.EnableHeadersVisualStyles = false;
            this.dgv_TTKhachHang.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_TTKhachHang.Location = new System.Drawing.Point(3, 316);
            this.dgv_TTKhachHang.Name = "dgv_TTKhachHang";
            this.dgv_TTKhachHang.RowHeadersVisible = false;
            this.dgv_TTKhachHang.RowHeadersWidth = 51;
            this.dgv_TTKhachHang.RowTemplate.Height = 24;
            this.dgv_TTKhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_TTKhachHang.Size = new System.Drawing.Size(1330, 313);
            this.dgv_TTKhachHang.TabIndex = 31;
            this.dgv_TTKhachHang.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_TTKhachHang.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_TTKhachHang.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_TTKhachHang.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_TTKhachHang.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_TTKhachHang.ThemeStyle.BackColor = System.Drawing.Color.SeaShell;
            this.dgv_TTKhachHang.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_TTKhachHang.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_TTKhachHang.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_TTKhachHang.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_TTKhachHang.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_TTKhachHang.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_TTKhachHang.ThemeStyle.HeaderStyle.Height = 4;
            this.dgv_TTKhachHang.ThemeStyle.ReadOnly = false;
            this.dgv_TTKhachHang.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_TTKhachHang.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_TTKhachHang.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_TTKhachHang.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_TTKhachHang.ThemeStyle.RowsStyle.Height = 24;
            this.dgv_TTKhachHang.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_TTKhachHang.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // frmDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1336, 685);
            this.Controls.Add(this.lb_timKiem);
            this.Controls.Add(this.txt_tiemKiem);
            this.Controls.Add(this.bt_sua);
            this.Controls.Add(this.bt_xoa);
            this.Controls.Add(this.bt_them);
            this.Controls.Add(this.txt_sdt);
            this.Controls.Add(this.lb_sdt);
            this.Controls.Add(this.rbt_khac);
            this.Controls.Add(this.rbt_nu);
            this.Controls.Add(this.rbt_nam);
            this.Controls.Add(this.lb_ngaysinh);
            this.Controls.Add(this.txt_hoTen);
            this.Controls.Add(this.lb_hoTen);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.lb_ID);
            this.Controls.Add(this.lb_gioiTinh);
            this.Controls.Add(this.dtp_Ngaysinh);
            this.Controls.Add(this.dgv_TTKhachHang);
            this.Name = "frmDemo";
            this.Text = "frmDemo";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TTKhachHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_timKiem;
        private Guna.UI2.WinForms.Guna2TextBox txt_tiemKiem;
        private Guna.UI2.WinForms.Guna2Button bt_sua;
        private Guna.UI2.WinForms.Guna2Button bt_xoa;
        private Guna.UI2.WinForms.Guna2Button bt_them;
        private Guna.UI2.WinForms.Guna2TextBox txt_sdt;
        private System.Windows.Forms.Label lb_sdt;
        private System.Windows.Forms.RadioButton rbt_khac;
        private System.Windows.Forms.RadioButton rbt_nu;
        private System.Windows.Forms.RadioButton rbt_nam;
        private System.Windows.Forms.Label lb_ngaysinh;
        private Guna.UI2.WinForms.Guna2TextBox txt_hoTen;
        private System.Windows.Forms.Label lb_hoTen;
        private Guna.UI2.WinForms.Guna2TextBox txt_ID;
        private System.Windows.Forms.Label lb_ID;
        private System.Windows.Forms.Label lb_gioiTinh;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_Ngaysinh;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_TTKhachHang;
    }
}