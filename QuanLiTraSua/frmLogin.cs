using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanLiTraSua.PhanQuyen;
using QuanLiTraSua.CSDL;

namespace QuanLiTraSua
{
    public partial class frm_Login : Form
    {
        List<TaiKhoan> listTK = DanhSachTaiKhoan.Instance.ListTK;
        public frm_Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //set nền trong suốt cho lb_morri
            lb_Morri.Parent = pic_Login;
            lb_Morri.BackColor = Color.Transparent;

            lb_login.Parent = pn_login;
            lb_login.BackColor = Color.Transparent;

            //set opacity cho pn_login
            pn_login.Parent = pic_Login;
            pn_login.BackColor = Color.FromArgb(80, 0, 0, 0);

        }


        private void tb_pass_IconRightClick(object sender, EventArgs e)
        {
            if (txt_pass.UseSystemPasswordChar)
            {
                txt_pass.UseSystemPasswordChar = false;
                txt_pass.IconRight = Properties.Resources._6351969_eye_key_look_password_security_icon;
            }
            else
            {
                txt_pass.UseSystemPasswordChar = true;
                txt_pass.IconRight = Properties.Resources._6351930_eye_password_see_view_icon;
            }
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void bt_login_Click(object sender, EventArgs e)
        {
            QuanLiTraSuaEntities4 db = new QuanLiTraSuaEntities4();
            List<TAIKHOAN> tk = db.TAIKHOANs.ToList();
            if (KiemTraDangNhap(txt_username.Text, txt_pass.Text))
            {
                frmMain main = new frmMain();
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_username.Focus();
            }
        }

        bool KiemTraDangNhap(string tentk, string mk)
        {
            QuanLiTraSuaEntities4 db = new QuanLiTraSuaEntities4();
            List<TAIKHOAN> tk = db.TAIKHOANs.ToList();
            foreach (var ip in tk)
            {
                if (tentk.Trim().Equals(ip.MaNV.Trim()) && mk.Trim().Equals(ip.MK.Trim()))
                {
                    PQ.quyen = ip.PhanQuyen;
                    nv.manhanvien = ip.MaNV;
                    return true;
                }
            }
            return false;
        }

        private void txt_pass_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                bt_login.PerformClick();
            }
        }

        private void pic_Login_Click(object sender, EventArgs e)
        {

        }
    }
}
