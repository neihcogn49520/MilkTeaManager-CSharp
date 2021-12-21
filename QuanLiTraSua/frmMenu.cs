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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        int countID = 1;
        private string ID_auto()
        {
            string id;
            if (countID < 10)
            {
                id = "HD0" + countID.ToString();
            }
            else
            {
                id = "HD" + countID.ToString();
            }
            return id;
        }
        string setID()
        {
            QuanLiTraSuaEntities4 db = new QuanLiTraSuaEntities4();
            countID = 1;
            foreach (var item in db.HOADONs.ToList())
            {
                if (item.MaHD.Trim().Equals(ID_auto().Trim()))
                {
                    countID++;
                }
            }
            return ID_auto();

        }
        void themhd()
        {
            QuanLiTraSuaEntities4 db = new QuanLiTraSuaEntities4();
            DateTime now = DateTime.Now;
            HOADON hd = new HOADON();
            hd.MaHD = setID();
            hd.MaNV = nv.manhanvien;
            //hd.MaNV = "NV01";
            hd.NgayHD = now;
            db.HOADONs.Add(hd);
            db.SaveChanges();
            gethoadon.mahoadon = hd.MaHD;
        }
        /************************DESIGN SECTION****************************/
        private void btn_ban1_Click(object sender, EventArgs e)
        {
            frmOrderTS main = new frmOrderTS(); 
            themhd();
            main.Value = btn_ban1.Text; 
            main.Show();
            this.Hide();
        }

        private void picPhucVu_Click(object sender, EventArgs e)
        {
            if (pan_PhucVu.Visible == false)
            {
                pan_PhucVu.Visible = true;
                picPhucVu.Image = Properties.Resources.arrow;
            }
            else
            {
                pan_PhucVu.Visible = false;
                picPhucVu.Image = Properties.Resources.arrow_back_icon;
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
           
        }

        private void btnMangVe_Click(object sender, EventArgs e)
        {
            frmOrderTS main = new frmOrderTS();
            themhd();
            main.Value = btnMangVe.Text;
            main.Show();
            this.Hide();
        }

        private void btn_ban2_Click(object sender, EventArgs e)
        {
            frmOrderTS main = new frmOrderTS(); 
            themhd();
            main.Value = btn_ban2.Text;
            main.Show();
            this.Hide();
        }

        private void btn_ban3_Click(object sender, EventArgs e)
        {
            frmOrderTS main = new frmOrderTS(); 
            themhd();
            main.Value = btn_ban3.Text;
            main.Show();
            this.Hide();
        }

        private void btn_ban4_Click(object sender, EventArgs e)
        {
            frmOrderTS main = new frmOrderTS(); 
            themhd();
            main.Value = btn_ban4.Text;
            main.Show();
            this.Hide();
        }

        private void btn_ban5_Click(object sender, EventArgs e)
        {
            frmOrderTS main = new frmOrderTS();
            themhd();
            main.Value = btn_ban5.Text;
            main.Show();
            this.Hide();
        }

        private void btn_ban6_Click(object sender, EventArgs e)
        {
            frmOrderTS main = new frmOrderTS(); 
            themhd();
            main.Value = btn_ban6.Text;
            main.Show();
            this.Hide();
        }

        private void btn_ban7_Click(object sender, EventArgs e)
        {
            frmOrderTS main = new frmOrderTS(); 
            themhd();
            main.Value = btn_ban7.Text;
            main.Show();
            this.Hide();
        }

        private void btn_ban8_Click(object sender, EventArgs e)
        {
            frmOrderTS main = new frmOrderTS(); 
            themhd();
            main.Value = btn_ban8.Text;
            main.Show();
            this.Hide();
        }

        private void btn_ban9_Click(object sender, EventArgs e)
        {
            frmOrderTS main = new frmOrderTS(); 
            themhd();
            main.Value = btn_ban9.Text;
            main.Show();
            this.Hide();
        }

        private void btn_ban10_Click(object sender, EventArgs e)
        {
            frmOrderTS main = new frmOrderTS(); 
            themhd();
            main.Value = btn_ban10.Text;
            main.Show();
            this.Hide();
        }

        private void btn_ban11_Click(object sender, EventArgs e)
        {
            frmOrderTS main = new frmOrderTS(); 
            themhd();
            main.Value = btn_ban11.Text;
            main.Show();
            this.Hide();
        }

        private void btn_ban12_Click(object sender, EventArgs e)
        {
            frmOrderTS main = new frmOrderTS(); 
            themhd();
            main.Value = btn_ban12.Text;
            main.Show();
            this.Hide();
        }

        private void panBan_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
