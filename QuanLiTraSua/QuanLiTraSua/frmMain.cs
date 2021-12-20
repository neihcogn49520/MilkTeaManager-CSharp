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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //set opacity cho pn_login
            pn_login.Parent = pic_Login;
            pn_login.BackColor = Color.FromArgb(80, 0, 0, 0);

        }

        private void pic_list_item_Click(object sender, EventArgs e)
        {
                if (pn_list_item.Visible == false)
                {
                    pn_list_item.Visible = true;
                }
                else
                {
                    pn_list_item.Visible = false;
                }
        }

        private void bt_QLKhachHang_Click(object sender, EventArgs e)
        {
            frmKhachHang main = new frmKhachHang();
            main.Show();
            this.Hide();
        }

        private void btn_NV_Click(object sender, EventArgs e)
        {
            frmNhanVien main = new frmNhanVien();
            main.Show();
            this.Hide();
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            frmMenu main = new frmMenu();
            main.Show();
            this.Hide();
        }

        private void bt_logout_Click(object sender, EventArgs e)
        {
            frm_Login log = new frm_Login();
            log.Show();
            this.Hide();
        }

        private void btn_kho_Click(object sender, EventArgs e)
        {
            frmSanPham log = new frmSanPham();
            log.Show();
            this.Hide();
        }
    }
}
