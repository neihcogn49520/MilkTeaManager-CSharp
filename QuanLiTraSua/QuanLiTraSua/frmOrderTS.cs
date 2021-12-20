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
    public partial class frmOrderTS : Form
    {
        public frmOrderTS()
        {
            InitializeComponent();
        }

        private void frmOrderTS_Load(object sender, EventArgs e)
        {
            pan_TTOrder.Parent = pic_Order;
            pan_TTOrder.BackColor = Color.Transparent;
            lb_TenBan.Parent = pic_Order;
            lb_TenBan.BackColor = Color.Transparent;
            lb_Ngay.Parent = pic_Order;
            lb_Ngay.BackColor = Color.Transparent;
            btn_return.Parent = pic_Order;
            btn_return.BackColor = Color.Transparent;
        }

        private void btn_ThemMon_Click(object sender, EventArgs e)
        {
            frmSanPham sp = new frmSanPham();
            sp.Show();
            this.Hide();
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            menu.Show();
            this.Hide();
        }
    }
}
