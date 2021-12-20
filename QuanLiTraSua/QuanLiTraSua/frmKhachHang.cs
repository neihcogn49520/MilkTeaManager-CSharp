using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanLiTraSua.CSDL;

namespace QuanLiTraSua
{
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }

        DataTable dt;
        string gt = "";
        string del = "";

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            pan_TTKH.Parent = pic_Nen;
            pan_TTKH.BackColor = Color.Transparent;
            pn_menu.Parent = pic_Nen;
            pn_menu.BackColor = Color.Transparent;
            lbID.Parent = pan_TTKH;
            lbID.BackColor = Color.Transparent;
            lbHoTen.Parent = pan_TTKH;
            lbHoTen.BackColor = Color.Transparent;

            lbNgaySinh.Parent = pan_TTKH;
            lbNgaySinh.BackColor = Color.Transparent;
            lbGioiTinh.Parent = pan_TTKH;
            lbGioiTinh.BackColor = Color.Transparent;
            lbSDT.Parent = pan_TTKH;
            lbSDT.BackColor = Color.Transparent;
            lbTimKiem.Parent = pan_TTKH;
            lbTimKiem.BackColor = Color.Transparent;

            //***************************************

            dt = new DataTable();
            dt.Columns.Add("Mã khách hàng", System.Type.GetType("System.String"));
            dt.Columns.Add("Tên khách hàng", System.Type.GetType("System.String"));
            dt.Columns.Add("Số điện thoại", System.Type.GetType("System.String"));
            dt.Columns.Add("Ngày sinh", System.Type.GetType("System.DateTime"));
            dt.Columns.Add("Giới tính", System.Type.GetType("System.String"));

            xuat();
        }

        void xuat()
        {
            dt.Clear();
            QuanLyTraSuaEntities db = new QuanLyTraSuaEntities();
            List<KHACHHANG> listkh = db.KHACHHANGs.ToList();
            txtID.Text = setID();
            foreach (var item in listkh)
            {
                dt.Rows.Add(new Object[] { item.MaKH, item.TenKH, item.SDT, item.Ngaysinh, item.Gioitinh });
            }
            dgvTTKH.DataSource = dt;
            reset();
        }

        int countID = 1;
        private string auto_id()
        {
            string id;
            if (countID < 10)
            {
                id = "KH0" + countID.ToString();
            }
            else
            {
                id = "KH" + countID.ToString();
            }
            return id;
        }
        string setID()
        {
            QuanLyTraSuaEntities db = new QuanLyTraSuaEntities();
            countID = 1;
            foreach (var item in db.KHACHHANGs.ToList())
            {
                if (item.MaKH.Trim().Equals(auto_id().Trim()))
                {
                    countID++;
                }
            }
            return auto_id();

        }

        void reset()
        {
            txtHoTen.Text = "";
            txtSDT.Text = "";
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Text == "" && txtSDT.Text == "" && rbtKhac.Checked != true && rbtNam.Checked != true && rbtNu.Checked != true)
            {
                MessageBox.Show("Chưa chọn cột để xóa");
            }
            else
            {
                if (del != "")
                {
                    try
                    {
                        QuanLyTraSuaEntities db = new QuanLyTraSuaEntities();
                        string a = del.Trim();
                        var delete = (from d in db.KHACHHANGs where d.MaKH == a select d).Single();
                        db.KHACHHANGs.Remove(delete);
                        db.SaveChanges();
                        xuat();
                        del = "";
                    }
                    catch
                    {
                        MessageBox.Show("Khách hàng này đang phục vụ, không thể xóa!");
                    }
                }
                else
                {
                    MessageBox.Show("Bạn chưa chọn hàng để xóa!");
                }
            }
        }
        

        private void btnThem_Click(object sender, EventArgs e)
        {
            QuanLyTraSuaEntities db = new QuanLyTraSuaEntities();
            KHACHHANG kh = new KHACHHANG();
            List<KHACHHANG> listnv = db.KHACHHANGs.ToList();
            string kt = "";
            if (txtHoTen.Text == "") kt = kt + "Chưa nhập tên Khách hàng\n";
            if (txtSDT.Text == "") kt = kt + "Chưa nhập số điện thoại\n";
            if (txtSDT.Text.Length < 10)
            {
                kt = kt + "Số điện thoại phải trên 10 số\n";
            }
            if (rbtKhac.Checked != true && rbtNam.Checked != true && rbtNu.Checked != true) kt = kt + "Chưa chọn giới tính\n";

            if (kt != "")
            {
                MessageBox.Show(kt);
            }
            else
            {
                string a = auto_id().Trim();
                kh.MaKH = a;
                kh.TenKH = txtHoTen.Text;
                kh.SDT = txtSDT.Text;
                kh.Ngaysinh = DateTime.Parse(dtpNgaySinh.Text);
                kh.Gioitinh = gt.Trim();
                db.KHACHHANGs.Add(kh);
                db.SaveChanges();
                xuat();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string kt = "";
            if (txtHoTen.Text == "" && txtSDT.Text == "" && rbtKhac.Checked != true && rbtNam.Checked != true && rbtNu.Checked != true)
            {
                MessageBox.Show("Chưa chọn hàng để sửa");
            }

            else
            {
                QuanLyTraSuaEntities db = new QuanLyTraSuaEntities();
                List<KHACHHANG> nv = db.KHACHHANGs.ToList();
                if (txtHoTen.Text == "") kt = kt + "Chưa nhập tên Khách hàng\n";
                if (txtSDT.Text == "") kt = kt + "Chưa nhập số điện thoại\n";
                if (txtSDT.Text.Length < 10)
                {
                    kt = kt + "Số điện thoại phải trên 10 số\n";
                }
                if (rbtKhac.Checked != true && rbtNam.Checked != true && rbtNu.Checked != true) kt = kt + "Chưa chọn giới tính\n";

                if (kt != "")
                {
                    MessageBox.Show(kt);
                }
                else
                {
                    var update = (from u in db.KHACHHANGs where u.MaKH == del select u).Single();
                    update.TenKH = txtHoTen.Text;
                    update.SDT = txtSDT.Text;
                    if (txtSDT.Text.Length < 10)
                    {
                        kt = kt + "Số điện thoại phải trên 10 số\n";
                    }
                    update.Ngaysinh = DateTime.Parse(dtpNgaySinh.Text);
                    update.Gioitinh = gt.Trim();
                    db.SaveChanges();
                    xuat();
                }
            }
        }

        private void rbtNam_CheckedChanged(object sender, EventArgs e)
        {
            gt = rbtNam.Text;
        }

        private void rbtNu_CheckedChanged(object sender, EventArgs e)
        {
            gt = rbtNu.Text;
        }

        private void rbtKhac_CheckedChanged(object sender, EventArgs e)
        {
            gt = rbtKhac.Text;
        }

        private void dgvTTKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow dgv = dgvTTKH.Rows[e.RowIndex];
                txtID.Text = dgv.Cells[0].Value.ToString();
                txtHoTen.Text = dgv.Cells[1].Value.ToString();
                txtSDT.Text = dgv.Cells[2].Value.ToString();
                dtpNgaySinh.Text = dgv.Cells[3].Value.ToString();

                if (dgv.Cells[4].Value.ToString() == "Nam")
                {
                    rbtNam.Checked = true;
                }
                else if (dgv.Cells[4].Value.ToString() == "Nữ")
                {
                    rbtNu.Checked = true;
                }    
                else if (dgv.Cells[4].Value.ToString() == "Khác")
                {
                    rbtKhac.Checked = true;
                }                   
            }
            dgvTTKH.CurrentCell.Selected = false;
            if (e.RowIndex >= 0)
            {
                del = dgvTTKH.Rows[e.RowIndex].Cells[0].FormattedValue.ToString().Trim();
            }
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dt = new DataTable();
                dt.Columns.Add("Mã khách hàng", System.Type.GetType("System.String"));
                dt.Columns.Add("Tên khách hàng", System.Type.GetType("System.String"));
                dt.Columns.Add("Số điện thoại", System.Type.GetType("System.String"));
                dt.Columns.Add("Ngày sinh", System.Type.GetType("System.DateTime"));
                dt.Columns.Add("Giới tính", System.Type.GetType("System.String"));
                QuanLyTraSuaEntities db = new QuanLyTraSuaEntities();
                var timkiem = db.KHACHHANGs.SqlQuery("select * from KHACHHANG where TenKH like '%" + txtTimKiem.Text + "%'").ToList();
                foreach (var kh in timkiem)
                {
                    dt.Rows.Add(new object[]
                    {
                        kh.MaKH,kh.TenKH,kh.SDT,kh.Ngaysinh,kh.Gioitinh
                    }); 
                    dgvTTKH.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
