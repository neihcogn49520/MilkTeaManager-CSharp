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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        
        /************************DESIGN SECTION****************************/
        private void btn_ban1_Click(object sender, EventArgs e)
        {
            frmOrderTS main = new frmOrderTS();
            main.Show();
            this.Hide();
        }

        private void picPhucVu_Click(object sender, EventArgs e)
        {
            if (pan_PhucVu.Visible == false)
            {
                pan_PhucVu.Visible = true;
                picPhucVu.Image = Properties.Resources._4829860_arrow_back_left_icon;
            }
            else
            {
                pan_PhucVu.Visible = false;
                picPhucVu.Image = Properties.Resources._4829859_arrow_next_right_icon__1_;
            }
        }


        private void btn_return_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            main.Show();
            this.Hide();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            panBan.Parent = pic_Nen;
            panBan.BackColor = Color.Transparent;
            pn_menu.Parent = pic_Nen;
            pn_menu.BackColor = Color.Transparent;
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
            frmMenu main = new frmMenu();
            main.Show();
            this.Hide();
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
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

        private void btnMangVe_Click(object sender, EventArgs e)
        {
            frmOrderTS main = new frmOrderTS();
            main.Show();
            this.Hide();
        }
    }
}
