using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using QuanLiTraSua.CSDL;
using QuanLiTraSua.PhanQuyen;


namespace QuanLiTraSua
{
    public partial class frmTaiKhoan : Form
    {
        public frmTaiKhoan()
        {
            InitializeComponent();
        }

        string del = "";
        DataTable dt;
        void xuat()
        {
            dt = new DataTable();
            dt.Columns.Add("ID", System.Type.GetType("System.String"));
            dt.Columns.Add("Tên đăng nhập", System.Type.GetType("System.String"));
            dt.Columns.Add("Mật khẩu", System.Type.GetType("System.String"));
            dt.Columns.Add("Phân quyền", System.Type.GetType("System.String"));
            QuanLiTraSuaEntities4 db = new QuanLiTraSuaEntities4();
            List<TAIKHOAN> tk = db.TAIKHOANs.ToList();
            List<NHANVIEN> listnv = db.NHANVIENs.ToList();
            dt.Clear();
            txtID.Text = setID();
            foreach (var item in tk)
            {
                dt.Rows.Add(new Object[] { item.ID, item.MaNV, item.MK, item.PhanQuyen });
            }
            dgvThongTinTK.DataSource = dt;
            //reset();
        }

        void reset()
        {
            txtTenDN.Text = "";
            txtMK.Text = "";
            txtPQ.Text = "";
        }
        int countID = 1;

        private string ID_auto()
        {
            string id;
            id = "N" + countID.ToString();
            return id;
        }
        string setID()
        {
            QuanLiTraSuaEntities4 db = new QuanLiTraSuaEntities4();
            countID = 1;
            foreach (var item in db.TAIKHOANs.ToList())
            {
                if (item.ID.Trim().Equals(ID_auto().Trim()))
                {
                    countID++;
                }
            }
            return ID_auto();

        }


        private void frmTaiKhoan_Load(object sender, EventArgs e)
        {
            QuanLiTraSuaEntities4 db = new QuanLiTraSuaEntities4();
            List<TAIKHOAN> tk = db.TAIKHOANs.ToList();
            foreach(var t in tk)
            {
                if(nv.manhanvien == t.MaNV)
                {
                    btnThem.Hide();
                }
            }
            txtTenDN.Text = nv.manhanvien;
            txtPQ.Text = PQ.quyen;
            txtMK.Focus();
            xuat();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            QuanLiTraSuaEntities4 db = new QuanLiTraSuaEntities4();
            TAIKHOAN tk = new TAIKHOAN();
            List<TAIKHOAN> listtk = db.TAIKHOANs.ToList();
            string kt = "";
            if (txtMK.Text == "") kt = kt + "Chưa nhập mật khẩu\n";
            foreach (var t in listtk)
            {
                if (txtTenDN.Text == t.MaNV) kt = kt + "Trùng mã nhân viên! Không thể thêm tài khoản.\n";
            }
            

            if (kt != "")
            {
                MessageBox.Show(kt);
            }
            else
            {
                tk.ID = ID_auto().Trim();
                tk.MaNV = txtTenDN.Text;
                tk.MK = txtMK.Text;
                tk.PhanQuyen = txtPQ.Text;
                db.TAIKHOANs.Add(tk);
                db.SaveChanges();
                xuat();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtTenDN.Text == "" && txtMK.Text == "" && txtPQ.Text == "")
            {
                MessageBox.Show("Chưa chọn cột để xóa");
            }
            else
            {
                if (del != "")
                {
                    try
                    {
                        QuanLiTraSuaEntities4 db = new QuanLiTraSuaEntities4();
                        string a = del.Trim();
                        var delete = (from d in db.TAIKHOANs where d.ID == a select d).Single();
                        db.TAIKHOANs.Remove(delete);
                        db.SaveChanges();
                        xuat();
                        del = "";
                    }
                    catch
                    {
                        MessageBox.Show("Không thể xóa tài khoản của nhân viên này!");
                    }
                }
                else
                {
                    MessageBox.Show("Bạn chưa chọn hàng để xóa!");
                }
            }
        }

        private void dgvThongTinTK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow dgv = dgvThongTinTK.Rows[e.RowIndex];
                txtID.Text = dgv.Cells[0].Value.ToString();
                txtTenDN.Text = dgv.Cells[1].Value.ToString();
                txtMK.Text = dgv.Cells[2].Value.ToString();
                txtPQ.Text = dgv.Cells[3].Value.ToString();
            }
            if (e.RowIndex >= 0)
            {
                del = dgvThongTinTK.Rows[e.RowIndex].Cells[0].FormattedValue.ToString().Trim();
            }
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string kt = "";
            if (txtID.Text == "" && txtTenDN.Text == "" && txtMK.Text == "" && txtPQ.Text == "")
            {
                MessageBox.Show("Chưa chọn hàng để sửa");
            }

            else
            {
                QuanLiTraSuaEntities4 db = new QuanLiTraSuaEntities4();
                List<TAIKHOAN> nv = db.TAIKHOANs.ToList();
                if (txtMK.Text == "") kt = kt + "Chưa nhập mật khẩu để sửa\n";
                
                if (kt != "")
                {
                    MessageBox.Show(kt);
                }
                else
                {
                    var update = (from u in db.TAIKHOANs where u.ID == del select u).Single();
                    update.MK = txtMK.Text;
                    db.SaveChanges();
                    xuat();
                }
            }
        }
    }
}
