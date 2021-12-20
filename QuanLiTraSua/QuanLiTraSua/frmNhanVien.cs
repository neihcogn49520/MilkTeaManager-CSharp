using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLiTraSua
{
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            pan_TTNV.Parent = pic_Nen;
            pan_TTNV.BackColor = Color.Transparent;
            pn_menu.Parent = pic_Nen;
            pn_menu.BackColor = Color.Transparent;
            lbID.Parent = pan_TTNV;
            lbID.BackColor = Color.Transparent;
            lbHoTen.Parent = pan_TTNV;
            lbHoTen.BackColor = Color.Transparent;

            lbNgaySinh.Parent = pan_TTNV;
            lbNgaySinh.BackColor = Color.Transparent;
            lbCaLam.Parent = pan_TTNV;
            lbCaLam.BackColor = Color.Transparent;
            lbChucNang.Parent = pan_TTNV;
            lbChucNang.BackColor = Color.Transparent;
            lbGioiTinh.Parent = pan_TTNV;
            lbGioiTinh.BackColor = Color.Transparent;

            lbSDT.Parent = pan_TTNV;
            lbSDT.BackColor = Color.Transparent;
            lbCMND.Parent = pan_TTNV;
            lbCMND.BackColor = Color.Transparent;
            lbNgayVL.Parent = pan_TTNV;
            lbNgayVL.BackColor = Color.Transparent;
            lbTimKiem.Parent = pan_TTNV;
            lbTimKiem.BackColor = Color.Transparent;

            
        }


        private void btn_return_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            main.Show();
            this.Hide();
        }

        private void bt_KhachHang_Click(object sender, EventArgs e)
        {
            frmKhachHang main = new frmKhachHang();
            main.Show();
            this.Hide();
        }

        private void bt_NhanVien_Click(object sender, EventArgs e)
        {
            frmNhanVien main = new frmNhanVien();
            main.Show();
            this.Hide();
        }

        private void bt_menu_Click(object sender, EventArgs e)
        {
            frmOrderTS main = new frmOrderTS();
            main.Show();
            this.Hide();
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
           frmBaoCao main = new frmBaoCao();
            main.Show();
            this.Hide();
        }

        private void btnKho_Click(object sender, EventArgs e)
        {
            frmBaoCao main = new frmBaoCao();
            main.Show();
            this.Hide();
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            frmSanPham main = new frmSanPham();
            main.Show();
            this.Hide();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {

        }

        private void dtpNgaySinh_ValueChanged(object sender, EventArgs e)
        {
            int age = DateTime.Now.Year - dtpNgaySinh.Value.Year - (DateTime.Now.DayOfYear < dtpNgaySinh.Value.DayOfYear ? 1 : 0);

            if (age < 18)
            {
                MessageBox.Show("Chưa đủ tuổi");
            }

        }

        private void dtpNgayVL_ValueChanged(object sender, EventArgs e)
        {
            int kt = ((dtpNgayVL.Value.Year - (DateTime.Now.DayOfYear < dtpNgaySinh.Value.DayOfYear ? 1 : 0)) - (dtpNgaySinh.Value.Year - (DateTime.Now.DayOfYear < dtpNgaySinh.Value.DayOfYear ? 1 : 0)) );

            if (dtpNgaySinh.Value.Date.CompareTo(dtpNgayVL.Value.Date) == 1)
            {
                MessageBox.Show("Ngày vào làm phải lớn hơn ngày sinh");
            }
            if (kt < 18){
                MessageBox.Show("Không hợp lệ");
            }
        }

        private void dgvTTNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
