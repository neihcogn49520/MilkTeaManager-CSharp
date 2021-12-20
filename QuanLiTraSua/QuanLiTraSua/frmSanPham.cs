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
    public partial class frmSanPham : Form
    {
        public frmSanPham()
        {
            InitializeComponent();
        }


        private void btn_return_Click(object sender, EventArgs e)
        {
            frmMenu m = new frmMenu();
            m.Show();
            this.Hide();
        }

        DataTable dt;
        string gt = "";
        string del = "";

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            pn_menu.Parent = pic_SanPham;
            pn_menu.BackColor = Color.Transparent;
            pan_TTSP.Parent = pic_SanPham;
            pan_TTSP.BackColor = Color.Transparent;
    
              //*************************************

            dt = new DataTable();
            dt.Columns.Add("Mã món", System.Type.GetType("System.String"));
            dt.Columns.Add("Tên món", System.Type.GetType("System.String"));
            dt.Columns.Add("Đơn giá", System.Type.GetType("System.Decimal"));
            dt.Columns.Add("Size", System.Type.GetType("System.String"));
            dt.Columns.Add("Số lượng tồn", System.Type.GetType("System.Int32"));
            dt.Columns.Add("Số lượng đã bán", System.Type.GetType("System.Int32"));

            xuat();
        }

        void xuat()
        {
            dt.Clear();
            QuanLyTraSuaEntities db = new QuanLyTraSuaEntities();
            List<SANPHAM> listkh = db.SANPHAMs.ToList();
            txtMaMon.Text = setID();
            foreach (var item in listkh)
            {
                dt.Rows.Add(new Object[] { item.MaMon, item.TenMon, item.DonGia, item.Size, item.SLTon, item.SLDaBan });
            }
            dgvTTSP.DataSource = dt;
            reset();
        }

        int countID = 1;
        private string auto_id()
        {
            string id;
            if (countID < 10)
            {
                id = "M0" + countID.ToString();
            }
            else
            {
                id = "M" + countID.ToString();
            }
            return id;
        }
        string setID()
        {
            QuanLyTraSuaEntities db = new QuanLyTraSuaEntities();
            countID = 1;
            foreach (var item in db.SANPHAMs.ToList())
            {
                if (item.MaMon.Trim().Equals(auto_id().Trim()))
                {
                    countID++;
                }
            }
            return auto_id();

        }

        void reset()
        {
            txtTenMon.Text = "";
            txtDonGia.Text = "";
        }

        private void bt_KhachHang_Click(object sender, EventArgs e)
        {
            frmKhachHang m = new frmKhachHang();
            m.Show();
            this.Hide();
        }

        private void bt_NhanVien_Click(object sender, EventArgs e)
        {
            frmNhanVien m = new frmNhanVien();
            m.Show();
            this.Hide();
        }

        private void bt_menu_Click(object sender, EventArgs e)
        {
            frmMenu m = new frmMenu();
            m.Show();
            this.Hide();
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            frmBaoCao m = new frmBaoCao();
            m.Show();
            this.Hide();
        }

        private void btnKho_Click(object sender, EventArgs e)
        {
            frmBaoCao m = new frmBaoCao();
            m.Show();
            this.Hide();
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            frmSanPham m = new frmSanPham();
            m.Show();
            this.Hide();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dt = new DataTable();
                dt.Columns.Add("Mã món", System.Type.GetType("System.String"));
                dt.Columns.Add("Tên món", System.Type.GetType("System.String"));
                dt.Columns.Add("Đơn giá", System.Type.GetType("System.Decimal"));
                dt.Columns.Add("Size", System.Type.GetType("System.String"));
                dt.Columns.Add("Số lượng tồn", System.Type.GetType("System.Int32"));
                dt.Columns.Add("Số lượng đã bán", System.Type.GetType("System.Int32"));
                QuanLyTraSuaEntities db = new QuanLyTraSuaEntities();
                var timkiem = db.SANPHAMs.SqlQuery("select * from SANPHAM where TenMon like '%" + txtTimKiem.Text + "%'").ToList();
                foreach (var sp in timkiem)
                {
                    dt.Rows.Add(new object[]
                    {
                        sp.MaMon, sp.TenMon, sp.DonGia, sp.Size,  sp.SLTon, sp.SLDaBan
                    });
                    dgvTTSP.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string kt = "";
            if (txtTenMon.Text == "" && txtDonGia.Text == "" && cbo_Size.Text == "" && Convert.ToInt32(nSLDB.Value) == 0 && Convert.ToInt32(nSLT.Value) == 0)
            {
                MessageBox.Show("Chưa chọn hàng để sửa");
            }

            else
            {
                QuanLyTraSuaEntities db = new QuanLyTraSuaEntities();
                List<SANPHAM> nv = db.SANPHAMs.ToList();
                if (txtTenMon.Text == "") kt = kt + "Chưa nhập tên món\n";
                if (txtDonGia.Text == "") kt = kt + "Chưa nhập đơn giá\n";
                if (cbo_Size.Text == "") kt = kt + "Chưa nhập size\n";

                if (kt != "")
                {
                    MessageBox.Show(kt);
                }
                else
                {
                    var update = (from u in db.SANPHAMs where u.MaMon == del select u).Single();
                    update.TenMon = txtTenMon.Text;
                    update.SLDaBan = Convert.ToInt32(nSLDB.Value);
                    update.SLTon = Convert.ToInt32(nSLT.Value);
                    update.DonGia = Convert.ToInt32(txtDonGia.Text);
                    update.Size = cbo_Size.Text;
                    db.SaveChanges();
                    xuat();
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            QuanLyTraSuaEntities db = new QuanLyTraSuaEntities();
            SANPHAM sp = new SANPHAM();
            List<SANPHAM> listnv = db.SANPHAMs.ToList();
            string kt = "";
            if (txtTenMon.Text == "") kt = kt + "Chưa nhập tên món\n";
            if (txtDonGia.Text == "") kt = kt + "Chưa nhập đơn giá\n";
            if (Convert.ToInt32(nSLT.Value) == 0) kt = kt + "Chưa nhập số lượng  tồn\n";
            if(cbo_Size.Text == "") kt = kt + "Chưa nhập size\n";

            if (kt != "")
            {
                MessageBox.Show(kt);
            }
            else
            {
                string a = auto_id().Trim();
                sp.MaMon = a;
                sp.TenMon = txtTenMon.Text;
                sp.DonGia = Convert.ToInt32(txtDonGia.Text);
                sp.Size = cbo_Size.Text;
                sp.SLTon = Convert.ToInt32(nSLT.Value);
                sp.SLDaBan = Convert.ToInt32(nSLDB.Value);
                db.SANPHAMs.Add(sp);
                db.SaveChanges();
                xuat();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtTenMon.Text == "" && txtDonGia.Text == "" && cbo_Size.Text == "" && Convert.ToInt32(nSLDB.Value) == 0 && Convert.ToInt32(nSLT.Value) == 0)
            {
                MessageBox.Show("Chưa chọn cột để xóa");
            }
            else
            {
                if (del != "")
                {
                   QuanLyTraSuaEntities db = new QuanLyTraSuaEntities();
                   string a = del.Trim();
                   var delete = (from d in db.SANPHAMs where d.MaMon == a select d).Single();
                   db.SANPHAMs.Remove(delete);
                   db.SaveChanges();
                   xuat();
                   del = "";
                }
                else
                {
                    MessageBox.Show("Bạn chưa chọn hàng để xóa!");
                }
            }
        }

        private void dgvTTSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow dgv = dgvTTSP.Rows[e.RowIndex];
                txtMaMon.Text = dgv.Cells[0].Value.ToString();
                txtTenMon.Text = dgv.Cells[1].Value.ToString();
                txtDonGia.Text = dgv.Cells[2].Value.ToString();
                cbo_Size.Text = dgv.Cells[3].Value.ToString();
                nSLT.Value = Convert.ToInt32(dgv.Cells[4].Value.ToString());
                nSLDB.Value = Convert.ToInt32(dgv.Cells[5].Value.ToString());
            }
            dgvTTSP.CurrentCell.Selected = false;
            if (e.RowIndex >= 0)
            {
                del = dgvTTSP.Rows[e.RowIndex].Cells[0].FormattedValue.ToString().Trim();
            }
        }
    }
}
