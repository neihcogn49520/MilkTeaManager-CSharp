using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using QuanLiTraSua.PhanQuyen;
using QuanLiTraSua.CSDL;

namespace QuanLiTraSua
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            leftPanel = new Panel();
            leftPanel.Size = new Size(7, 68);
            pn_menu.Controls.Add(leftPanel);
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }

        private Guna2Button currentBT;
        private Panel leftPanel;
        private Form currentChildForm;

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        //Methos
        private void ActiveButton(object sender, Color color)
        {
            if (sender != null)
            {
                DisableBt();
                currentBT = (Guna2Button)sender;
                currentBT.BackColor = Color.FromArgb(26, 80, 139);
                currentBT.TextAlign = HorizontalAlignment.Center;
                currentBT.ImageAlign = HorizontalAlignment.Center;
                leftPanel.BackColor = color;
                leftPanel.Location = new Point(0, currentBT.Location.Y);
                leftPanel.Visible = true;
                leftPanel.BringToFront();
            }
        }
        private void DisableBt()
        {
            if (currentBT != null)
            {
                currentBT.BackColor = Color.FromArgb(0, 20, 40);
                currentBT.TextAlign = HorizontalAlignment.Left;
                currentBT.ImageAlign = HorizontalAlignment.Left;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if(currentChildForm != null)
            {
                //open only form
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pn_Desktop.Controls.Add(childForm);
            pn_Desktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        void PhanQuyen()
        {
            QuanLiTraSuaEntities3 db = new QuanLiTraSuaEntities3();
            switch (PQ.quyen)
            {
                case "Quản lí kho":
                    bt_NhanVien.Enabled = false;
                    bt_Menu.Enabled = false;
                    bt_BaoCao.Enabled = false;
                    bt_ThongKe.Enabled = false;
                    break;
                case "Thu ngân":
                    bt_NhanVien.Enabled = false;
                    bt_SanPham.Enabled = false;
                    bt_BaoCao.Enabled = false;
                    bt_ThongKe.Enabled = false;
                    break;
            }
            btn_account.Text = PQ.quyen;
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            //set opacity cho pn_login
            PhanQuyen();
        }

        private void bt_NhanVien_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color2);
            OpenChildForm(new frmNhanVien());
        }

        private void bt_Menu_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color3);
            OpenChildForm(new frmMenu());
        }

        private void bt_logout_Click(object sender, EventArgs e)
        {
            frm_Login log = new frm_Login();
            log.Show();
            this.Hide();
        }

        private void bt_SanPham_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color4);
            OpenChildForm(new frmSanPham());
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panDrag_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pic_Home_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            reset();
        }

        private void reset()
        {
            DisableBt();
            leftPanel.Visible = false;
        }

        private void bt_BaoCao_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color5);
            OpenChildForm(new frmBaoCao());
        }

        private void bt_ThongKe_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color6);
            OpenChildForm(new frmThongKe());
        }

        private void pn_Desktop_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
