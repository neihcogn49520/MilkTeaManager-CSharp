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
    public partial class frm_Login : Form
    {
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

        private void lb_Morri_Click(object sender, EventArgs e)
        {

        }

        private void tb_pass_IconRightClick(object sender, EventArgs e)
        {
            if (tb_pass.UseSystemPasswordChar)
            {
                tb_pass.UseSystemPasswordChar = false;
                tb_pass.IconRight = Properties.Resources._6351969_eye_key_look_password_security_icon;
            }
            else
            {
                tb_pass.UseSystemPasswordChar = true;
                tb_pass.IconRight = Properties.Resources._6351930_eye_password_see_view_icon;
            }
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            main.Show();
            this.Hide();
        }
    }
}
