using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QuanLiTraSua.CSDL;
using QuanLiTraSua.PhanQuyen;

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
            frmMain m = new frmMain();
            m.Show();
            this.Hide();
        }

        DataTable dt;
        string del = "";

        
        private void frmSanPham_Load(object sender, EventArgs e)
        {
            nSLT.ForeColor = Color.White;
            dt = new DataTable();
            dt.Columns.Add("Mã món", System.Type.GetType("System.String"));
            dt.Columns.Add("Tên món", System.Type.GetType("System.String"));
            dt.Columns.Add("Đơn giá", System.Type.GetType("System.Decimal"));
            dt.Columns.Add("Size", System.Type.GetType("System.String"));
            dt.Columns.Add("Số lượng đã bán", System.Type.GetType("System.Int32"));

            xuat();
        }

        void xuat()
        {
            dt.Clear();
            QuanLiTraSuaEntities3 db = new QuanLiTraSuaEntities3();
            List<SANPHAM> listsp = db.SANPHAMs.ToList();
            txtMaMon.Text = setID();
            foreach (var item in listsp)
            {
                dt.Rows.Add(new Object[] { item.MaMon, item.TenMon, item.DonGia, item.Size, item.SL });
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
            QuanLiTraSuaEntities3 db = new QuanLiTraSuaEntities3();
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
                QuanLiTraSuaEntities3 db = new QuanLiTraSuaEntities3();
                var timkiem = db.SANPHAMs.SqlQuery("select * from SANPHAM where TenMon like '%" + txtTimKiem.Text + "%'").ToList();
                foreach (var sp in timkiem)
                {
                    dt.Rows.Add(new object[]
                    {
                        sp.MaMon, sp.TenMon, sp.DonGia, sp.Size,  sp.SL
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
            if (txtTenMon.Text == "" && txtDonGia.Text == "" && cbo_Size.Text == "" && Convert.ToInt32(nSLT.Value) == 0)
            {
                MessageBox.Show("Chưa chọn hàng để sửa");
            }

            else
            {
                QuanLiTraSuaEntities3 db = new QuanLiTraSuaEntities3();
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
                    update.DonGia = Convert.ToInt32(txtDonGia.Text);
                    update.Size = cbo_Size.Text;
                    update.SL = Convert.ToInt32(nSLT.Value);
                    db.SaveChanges();
                    xuat();
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            QuanLiTraSuaEntities3 db = new QuanLiTraSuaEntities3();
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
                int test = 0;
                foreach (var sanpham in db.SANPHAMs.ToList())
                {
                    if (txtTenMon.Text.Trim().Equals(sanpham.TenMon.Trim()) && cbo_Size.Text.Trim().Equals(sanpham.Size.Trim()))
                    {
                        var update = (from u in db.SANPHAMs where u.TenMon == txtTenMon.Text && u.Size == cbo_Size.Text select u).Single();
                        update.TenMon = txtTenMon.Text;
                        update.DonGia = sanpham.DonGia;
                        update.Size = cbo_Size.Text;
                        update.SL = Convert.ToInt32(nSLT.Value) + sanpham.SL;
                        db.SaveChanges();
                        xuat();
                        test = 0;
                        break;
                    }
                    else
                    {
                        test = 1;
                    }
                }
                SANPHAM sp = new SANPHAM();
                if(test == 1)
                {
                    string a = auto_id().Trim();
                    sp.MaMon = a;
                    sp.TenMon = txtTenMon.Text;
                    sp.DonGia = Convert.ToDecimal(txtDonGia.Text);
                    sp.Size = cbo_Size.Text;
                    sp.SL = Convert.ToInt32(nSLT.Value);
                    db.SANPHAMs.Add(sp);
                    db.SaveChanges();
                    xuat();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTenMon.Text == "" && txtDonGia.Text == "" && cbo_Size.Text == "" && Convert.ToInt32(nSLT.Value) == 0)
                {
                    MessageBox.Show("Chưa chọn cột để xóa");
                }
                else
                {
                    if (del != "")
                    {
                        QuanLiTraSuaEntities3 db = new QuanLiTraSuaEntities3();
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
            catch
            {
                MessageBox.Show("Sản phẩm đang đươc xử lý không thể xóa");
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
            }
            if (e.RowIndex >= 0)
            {
                del = dgvTTSP.Rows[e.RowIndex].Cells[0].FormattedValue.ToString().Trim();
            }

        }

        private void dgvTTSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtTenMon_TextChanged(object sender, EventArgs e)
        {
     
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void nSLT_ValueChanged(object sender, EventArgs e)
        {
            if(nSLT.Value <= 0)
            {
                MessageBox.Show("Nhập số lượng lớn hơn 0!");
            }
        }
    }
}
