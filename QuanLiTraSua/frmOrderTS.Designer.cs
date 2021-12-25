
namespace QuanLiTraSua
{
    partial class frmOrderTS
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
            this.lb_ChangeBan = new System.Windows.Forms.Label();
            this.dtpNgayHD = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lb_Ngay = new System.Windows.Forms.Label();
            this.pan_TTOrder = new Guna.UI2.WinForms.Guna2Panel();
            this.txtIDNV = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.numSL = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.cbo_Size = new System.Windows.Forms.ComboBox();
            this.cbo_Menu = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTienThua = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOrder = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnIn = new Guna.UI2.WinForms.Guna2Button();
            this.txtKhachDua = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTongCong = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaHD = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvTTOrder = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.panDrag = new System.Windows.Forms.Panel();
            this.pan_TTOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panDrag.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_ChangeBan
            // 
            this.lb_ChangeBan.AutoSize = true;
            this.lb_ChangeBan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.lb_ChangeBan.Font = new System.Drawing.Font("Snap ITC", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ChangeBan.ForeColor = System.Drawing.Color.White;
            this.lb_ChangeBan.Location = new System.Drawing.Point(35, 112);
            this.lb_ChangeBan.Name = "lb_ChangeBan";
            this.lb_ChangeBan.Size = new System.Drawing.Size(113, 36);
            this.lb_ChangeBan.TabIndex = 55;
            this.lb_ChangeBan.Text = "BÀN 1";
            // 
            // dtpNgayHD
            // 
            this.dtpNgayHD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpNgayHD.Checked = true;
            this.dtpNgayHD.CheckedState.Parent = this.dtpNgayHD;
            this.dtpNgayHD.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.dtpNgayHD.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dtpNgayHD.ForeColor = System.Drawing.Color.White;
            this.dtpNgayHD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayHD.HoverState.Parent = this.dtpNgayHD;
            this.dtpNgayHD.Location = new System.Drawing.Point(1161, 112);
            this.dtpNgayHD.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgayHD.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgayHD.Name = "dtpNgayHD";
            this.dtpNgayHD.ShadowDecoration.Parent = this.dtpNgayHD;
            this.dtpNgayHD.Size = new System.Drawing.Size(160, 31);
            this.dtpNgayHD.TabIndex = 52;
            this.dtpNgayHD.Value = new System.DateTime(2021, 11, 5, 23, 45, 17, 220);
            // 
            // lb_Ngay
            // 
            this.lb_Ngay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Ngay.AutoSize = true;
            this.lb_Ngay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.lb_Ngay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Ngay.ForeColor = System.Drawing.Color.White;
            this.lb_Ngay.Location = new System.Drawing.Point(1075, 115);
            this.lb_Ngay.Name = "lb_Ngay";
            this.lb_Ngay.Size = new System.Drawing.Size(67, 28);
            this.lb_Ngay.TabIndex = 51;
            this.lb_Ngay.Text = "Ngày:";
            // 
            // pan_TTOrder
            // 
            this.pan_TTOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pan_TTOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.pan_TTOrder.BorderColor = System.Drawing.Color.Silver;
            this.pan_TTOrder.Controls.Add(this.txtIDNV);
            this.pan_TTOrder.Controls.Add(this.label8);
            this.pan_TTOrder.Controls.Add(this.numSL);
            this.pan_TTOrder.Controls.Add(this.cbo_Size);
            this.pan_TTOrder.Controls.Add(this.cbo_Menu);
            this.pan_TTOrder.Controls.Add(this.label9);
            this.pan_TTOrder.Controls.Add(this.txtTienThua);
            this.pan_TTOrder.Controls.Add(this.label1);
            this.pan_TTOrder.Controls.Add(this.btnOrder);
            this.pan_TTOrder.Controls.Add(this.btnXoa);
            this.pan_TTOrder.Controls.Add(this.btnIn);
            this.pan_TTOrder.Controls.Add(this.txtKhachDua);
            this.pan_TTOrder.Controls.Add(this.txtTongCong);
            this.pan_TTOrder.Controls.Add(this.label7);
            this.pan_TTOrder.Controls.Add(this.label5);
            this.pan_TTOrder.Controls.Add(this.txtMaHD);
            this.pan_TTOrder.Controls.Add(this.label4);
            this.pan_TTOrder.Controls.Add(this.label3);
            this.pan_TTOrder.Controls.Add(this.label2);
            this.pan_TTOrder.Location = new System.Drawing.Point(23, 191);
            this.pan_TTOrder.Name = "pan_TTOrder";
            this.pan_TTOrder.ShadowDecoration.Color = System.Drawing.Color.Silver;
            this.pan_TTOrder.ShadowDecoration.Depth = 40;
            this.pan_TTOrder.ShadowDecoration.Parent = this.pan_TTOrder;
            this.pan_TTOrder.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(12);
            this.pan_TTOrder.Size = new System.Drawing.Size(1298, 319);
            this.pan_TTOrder.TabIndex = 1;
            // 
            // txtIDNV
            // 
            this.txtIDNV.BorderColor = System.Drawing.Color.White;
            this.txtIDNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIDNV.DefaultText = "";
            this.txtIDNV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIDNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIDNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDNV.DisabledState.Parent = this.txtIDNV;
            this.txtIDNV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDNV.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.txtIDNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDNV.FocusedState.Parent = this.txtIDNV;
            this.txtIDNV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIDNV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDNV.HoverState.Parent = this.txtIDNV;
            this.txtIDNV.Location = new System.Drawing.Point(230, 96);
            this.txtIDNV.Name = "txtIDNV";
            this.txtIDNV.PasswordChar = '\0';
            this.txtIDNV.PlaceholderText = "";
            this.txtIDNV.SelectedText = "";
            this.txtIDNV.ShadowDecoration.Parent = this.txtIDNV;
            this.txtIDNV.Size = new System.Drawing.Size(200, 29);
            this.txtIDNV.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtIDNV.TabIndex = 69;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(72, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 28);
            this.label8.TabIndex = 66;
            this.label8.Text = "Số lượng:";
            // 
            // numSL
            // 
            this.numSL.BackColor = System.Drawing.Color.Transparent;
            this.numSL.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numSL.DisabledState.Parent = this.numSL;
            this.numSL.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.numSL.FocusedState.Parent = this.numSL;
            this.numSL.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numSL.ForeColor = System.Drawing.Color.Black;
            this.numSL.Location = new System.Drawing.Point(230, 241);
            this.numSL.Name = "numSL";
            this.numSL.ShadowDecoration.Parent = this.numSL;
            this.numSL.Size = new System.Drawing.Size(200, 32);
            this.numSL.TabIndex = 65;
            this.numSL.UpDownButtonFillColor = System.Drawing.Color.White;
            this.numSL.UpDownButtonForeColor = System.Drawing.Color.Black;
            this.numSL.ValueChanged += new System.EventHandler(this.numSL_ValueChanged);
            // 
            // cbo_Size
            // 
            this.cbo_Size.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbo_Size.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.cbo_Size.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_Size.ForeColor = System.Drawing.Color.White;
            this.cbo_Size.FormattingEnabled = true;
            this.cbo_Size.Location = new System.Drawing.Point(824, 27);
            this.cbo_Size.Name = "cbo_Size";
            this.cbo_Size.Size = new System.Drawing.Size(200, 28);
            this.cbo_Size.TabIndex = 64;
            this.cbo_Size.SelectedIndexChanged += new System.EventHandler(this.cbo_Size_SelectedIndexChanged);
            // 
            // cbo_Menu
            // 
            this.cbo_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.cbo_Menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_Menu.ForeColor = System.Drawing.Color.White;
            this.cbo_Menu.FormattingEnabled = true;
            this.cbo_Menu.Location = new System.Drawing.Point(230, 169);
            this.cbo_Menu.Name = "cbo_Menu";
            this.cbo_Menu.Size = new System.Drawing.Size(200, 28);
            this.cbo_Menu.TabIndex = 63;
            this.cbo_Menu.SelectedIndexChanged += new System.EventHandler(this.cbo_Menu_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(668, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 28);
            this.label9.TabIndex = 61;
            this.label9.Text = "Size:";
            // 
            // txtTienThua
            // 
            this.txtTienThua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTienThua.BorderColor = System.Drawing.Color.White;
            this.txtTienThua.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTienThua.DefaultText = "";
            this.txtTienThua.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTienThua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTienThua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTienThua.DisabledState.Parent = this.txtTienThua;
            this.txtTienThua.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTienThua.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.txtTienThua.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTienThua.FocusedState.Parent = this.txtTienThua;
            this.txtTienThua.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTienThua.ForeColor = System.Drawing.Color.White;
            this.txtTienThua.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTienThua.HoverState.Parent = this.txtTienThua;
            this.txtTienThua.Location = new System.Drawing.Point(824, 241);
            this.txtTienThua.Name = "txtTienThua";
            this.txtTienThua.PasswordChar = '\0';
            this.txtTienThua.PlaceholderText = "";
            this.txtTienThua.SelectedText = "";
            this.txtTienThua.ShadowDecoration.Parent = this.txtTienThua;
            this.txtTienThua.Size = new System.Drawing.Size(200, 30);
            this.txtTienThua.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtTienThua.TabIndex = 60;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(72, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 28);
            this.label1.TabIndex = 59;
            this.label1.Text = "Menu:";
            // 
            // btnOrder
            // 
            this.btnOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOrder.BackColor = System.Drawing.Color.Transparent;
            this.btnOrder.BorderRadius = 15;
            this.btnOrder.CheckedState.Parent = this.btnOrder;
            this.btnOrder.CustomImages.Parent = this.btnOrder;
            this.btnOrder.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOrder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOrder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOrder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOrder.DisabledState.Parent = this.btnOrder;
            this.btnOrder.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.btnOrder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnOrder.ForeColor = System.Drawing.Color.White;
            this.btnOrder.HoverState.Parent = this.btnOrder;
            this.btnOrder.Location = new System.Drawing.Point(1101, 209);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.ShadowDecoration.Parent = this.btnOrder;
            this.btnOrder.Size = new System.Drawing.Size(127, 38);
            this.btnOrder.TabIndex = 57;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseTransparentBackground = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.BackColor = System.Drawing.Color.Transparent;
            this.btnXoa.BorderRadius = 15;
            this.btnXoa.CheckedState.Parent = this.btnXoa;
            this.btnXoa.CustomImages.Parent = this.btnXoa;
            this.btnXoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoa.DisabledState.Parent = this.btnXoa;
            this.btnXoa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.HoverState.Parent = this.btnXoa;
            this.btnXoa.Location = new System.Drawing.Point(1101, 57);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ShadowDecoration.Parent = this.btnXoa;
            this.btnXoa.Size = new System.Drawing.Size(127, 38);
            this.btnXoa.TabIndex = 56;
            this.btnXoa.Text = " Xóa";
            this.btnXoa.UseTransparentBackground = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnIn
            // 
            this.btnIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIn.BackColor = System.Drawing.Color.Transparent;
            this.btnIn.BorderRadius = 15;
            this.btnIn.CheckedState.Parent = this.btnIn;
            this.btnIn.CustomImages.Parent = this.btnIn;
            this.btnIn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnIn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnIn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnIn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnIn.DisabledState.Parent = this.btnIn;
            this.btnIn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(161)))), ((int)(((byte)(251)))));
            this.btnIn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnIn.ForeColor = System.Drawing.Color.White;
            this.btnIn.HoverState.Parent = this.btnIn;
            this.btnIn.Location = new System.Drawing.Point(1101, 133);
            this.btnIn.Name = "btnIn";
            this.btnIn.ShadowDecoration.Parent = this.btnIn;
            this.btnIn.Size = new System.Drawing.Size(127, 38);
            this.btnIn.TabIndex = 55;
            this.btnIn.Text = "In";
            this.btnIn.UseTransparentBackground = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // txtKhachDua
            // 
            this.txtKhachDua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtKhachDua.BorderColor = System.Drawing.Color.White;
            this.txtKhachDua.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKhachDua.DefaultText = "";
            this.txtKhachDua.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtKhachDua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtKhachDua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtKhachDua.DisabledState.Parent = this.txtKhachDua;
            this.txtKhachDua.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtKhachDua.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.txtKhachDua.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtKhachDua.FocusedState.Parent = this.txtKhachDua;
            this.txtKhachDua.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtKhachDua.ForeColor = System.Drawing.Color.White;
            this.txtKhachDua.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtKhachDua.HoverState.Parent = this.txtKhachDua;
            this.txtKhachDua.Location = new System.Drawing.Point(824, 169);
            this.txtKhachDua.Name = "txtKhachDua";
            this.txtKhachDua.PasswordChar = '\0';
            this.txtKhachDua.PlaceholderText = "";
            this.txtKhachDua.SelectedText = "";
            this.txtKhachDua.ShadowDecoration.Parent = this.txtKhachDua;
            this.txtKhachDua.Size = new System.Drawing.Size(200, 28);
            this.txtKhachDua.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtKhachDua.TabIndex = 54;
            this.txtKhachDua.TextChanged += new System.EventHandler(this.txtKhachDua_TextChanged);
            // 
            // txtTongCong
            // 
            this.txtTongCong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTongCong.BorderColor = System.Drawing.Color.White;
            this.txtTongCong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTongCong.DefaultText = "";
            this.txtTongCong.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTongCong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTongCong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTongCong.DisabledState.Parent = this.txtTongCong;
            this.txtTongCong.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTongCong.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.txtTongCong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTongCong.FocusedState.Parent = this.txtTongCong;
            this.txtTongCong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTongCong.ForeColor = System.Drawing.Color.White;
            this.txtTongCong.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTongCong.HoverState.Parent = this.txtTongCong;
            this.txtTongCong.Location = new System.Drawing.Point(824, 96);
            this.txtTongCong.Name = "txtTongCong";
            this.txtTongCong.PasswordChar = '\0';
            this.txtTongCong.PlaceholderText = "";
            this.txtTongCong.SelectedText = "";
            this.txtTongCong.ShadowDecoration.Parent = this.txtTongCong;
            this.txtTongCong.Size = new System.Drawing.Size(200, 29);
            this.txtTongCong.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtTongCong.TabIndex = 52;
            this.txtTongCong.TextChanged += new System.EventHandler(this.txtTongCong_TextChanged);
            this.txtTongCong.Load += new System.EventHandler(this.txtTongCong_Load);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(72, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 28);
            this.label7.TabIndex = 48;
            this.label7.Text = "ID NV:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(72, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 28);
            this.label5.TabIndex = 46;
            this.label5.Text = "Mã hóa đơn:";
            // 
            // txtMaHD
            // 
            this.txtMaHD.BorderColor = System.Drawing.Color.White;
            this.txtMaHD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaHD.DefaultText = "";
            this.txtMaHD.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaHD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaHD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaHD.DisabledState.Parent = this.txtMaHD;
            this.txtMaHD.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaHD.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.txtMaHD.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaHD.FocusedState.Parent = this.txtMaHD;
            this.txtMaHD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaHD.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaHD.HoverState.Parent = this.txtMaHD;
            this.txtMaHD.Location = new System.Drawing.Point(230, 23);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.PasswordChar = '\0';
            this.txtMaHD.PlaceholderText = "";
            this.txtMaHD.SelectedText = "";
            this.txtMaHD.ShadowDecoration.Parent = this.txtMaHD;
            this.txtMaHD.Size = new System.Drawing.Size(200, 29);
            this.txtMaHD.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtMaHD.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(667, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 28);
            this.label4.TabIndex = 42;
            this.label4.Text = "Tiền thừa";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(667, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 28);
            this.label3.TabIndex = 41;
            this.label3.Text = "Khách đưa:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(668, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 28);
            this.label2.TabIndex = 40;
            this.label2.Text = "Tổng cộng:";
            // 
            // dgvTTOrder
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvTTOrder.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTTOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTTOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTTOrder.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.dgvTTOrder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTTOrder.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(70)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTTOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTTOrder.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(70)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTTOrder.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTTOrder.EnableHeadersVisualStyles = false;
            this.dgvTTOrder.GridColor = System.Drawing.Color.White;
            this.dgvTTOrder.Location = new System.Drawing.Point(23, 531);
            this.dgvTTOrder.Name = "dgvTTOrder";
            this.dgvTTOrder.RowHeadersVisible = false;
            this.dgvTTOrder.RowHeadersWidth = 51;
            this.dgvTTOrder.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.dgvTTOrder.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTTOrder.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvTTOrder.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(70)))), ((int)(((byte)(185)))));
            this.dgvTTOrder.RowTemplate.Height = 24;
            this.dgvTTOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTTOrder.Size = new System.Drawing.Size(1298, 321);
            this.dgvTTOrder.TabIndex = 68;
            this.dgvTTOrder.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.dgvTTOrder.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvTTOrder.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvTTOrder.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(70)))), ((int)(((byte)(185)))));
            this.dgvTTOrder.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvTTOrder.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.dgvTTOrder.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.dgvTTOrder.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(40)))));
            this.dgvTTOrder.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvTTOrder.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.dgvTTOrder.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvTTOrder.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvTTOrder.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvTTOrder.ThemeStyle.ReadOnly = false;
            this.dgvTTOrder.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.dgvTTOrder.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            this.dgvTTOrder.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvTTOrder.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvTTOrder.ThemeStyle.RowsStyle.Height = 24;
            this.dgvTTOrder.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(70)))), ((int)(((byte)(185)))));
            this.dgvTTOrder.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvTTOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTTOrder_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::QuanLiTraSua.Properties.Resources.GIF_MENU;
            this.pictureBox1.Location = new System.Drawing.Point(419, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(506, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 69;
            this.pictureBox1.TabStop = false;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.DisabledState.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Image = global::QuanLiTraSua.Properties.Resources.back_icon;
            this.guna2Button1.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Button1.Location = new System.Drawing.Point(1293, 12);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(41, 39);
            this.guna2Button1.TabIndex = 70;
            this.guna2Button1.Click += new System.EventHandler(this.btn_return_Click);
            // 
            // panDrag
            // 
            this.panDrag.Controls.Add(this.guna2Button1);
            this.panDrag.Dock = System.Windows.Forms.DockStyle.Top;
            this.panDrag.Location = new System.Drawing.Point(0, 0);
            this.panDrag.Name = "panDrag";
            this.panDrag.Size = new System.Drawing.Size(1346, 62);
            this.panDrag.TabIndex = 71;
            this.panDrag.Paint += new System.Windows.Forms.PaintEventHandler(this.panDrag_Paint);
            this.panDrag.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panDrag_MouseDown);
            // 
            // frmOrderTS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1346, 874);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panDrag);
            this.Controls.Add(this.lb_ChangeBan);
            this.Controls.Add(this.dgvTTOrder);
            this.Controls.Add(this.dtpNgayHD);
            this.Controls.Add(this.lb_Ngay);
            this.Controls.Add(this.pan_TTOrder);
            this.Name = "frmOrderTS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmOrderTS";
            this.Load += new System.EventHandler(this.frmOrderTS_Load);
            this.pan_TTOrder.ResumeLayout(false);
            this.pan_TTOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panDrag.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgayHD;
        private System.Windows.Forms.Label lb_Ngay;
        private Guna.UI2.WinForms.Guna2Panel pan_TTOrder;
        private Guna.UI2.WinForms.Guna2TextBox txtKhachDua;
        private Guna.UI2.WinForms.Guna2TextBox txtTongCong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtMaHD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2TextBox txtTienThua;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnOrder;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2Button btnIn;
        private System.Windows.Forms.ComboBox cbo_Menu;
        private System.Windows.Forms.ComboBox cbo_Size;
        private System.Windows.Forms.Label lb_ChangeBan;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvTTOrder;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2NumericUpDown numSL;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Panel panDrag;
        private Guna.UI2.WinForms.Guna2TextBox txtIDNV;
    }
}