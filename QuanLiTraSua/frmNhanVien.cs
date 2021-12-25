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
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }

        DataTable dt;
        string gt = "";
        string del = "";

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            
            dt = new DataTable();
            dt.Columns.Add("Mã nhân viên", System.Type.GetType("System.String"));
            dt.Columns.Add("Tên nhân viên", System.Type.GetType("System.String"));
            dt.Columns.Add("Ngày sinh", System.Type.GetType("System.DateTime"));
            dt.Columns.Add("Số chứng minh thư", System.Type.GetType("System.String"));
            dt.Columns.Add("Số điện thoại", System.Type.GetType("System.String"));
            dt.Columns.Add("Giới tính", System.Type.GetType("System.String"));
            dt.Columns.Add("Ngày vào làm", System.Type.GetType("System.DateTime"));
            dt.Columns.Add("Ca làm", System.Type.GetType("System.String"));
            dt.Columns.Add("Chức vụ", System.Type.GetType("System.String"));
            dt.Columns.Add("Lương", System.Type.GetType("System.Decimal"));
            xuat();
        }

        void xuat()
        {
            dt.Clear();
            QuanLiTraSuaEntities4 db = new QuanLiTraSuaEntities4();
            List<NHANVIEN> listnv = db.NHANVIENs.ToList();
            txtID.Text = setID();
            foreach (var item in listnv)
            {
                dt.Rows.Add(new Object[] { item.MaNV, item.TenNV, item.Ngaysinh, item.CMND ,item.SDT, item.Gioitinh, item.Ngayvl, item.Calam, item.Chucvu,item.HSLuong });
            }
            dgvTTNV.DataSource = dt;
            reset();
        }

        int countID = 1;
        private string ID_auto()
        {
            string id;
            if (countID < 10)
            {
                id = "NV0" + countID.ToString();
            }
            else
            {
                id = "NV" + countID.ToString();
            }
            return id;
        }
        string setID()
        {
            QuanLiTraSuaEntities4 db = new QuanLiTraSuaEntities4();
            countID = 1;
            foreach (var item in db.NHANVIENs.ToList())
            {
                if (item.MaNV.Trim().Equals(ID_auto().Trim()))
                {
                    countID++;
                }
            }
            return ID_auto();

        }

        void reset()
        {
            txtHoTen.Text = "";
            txtSDT.Text = "";
        }


        private void dtpNgaySinh_ValueChanged(object sender, EventArgs e)
        {
            int age = DateTime.Now.Year - dtpNgaySinh.Value.Year - (DateTime.Now.DayOfYear < dtpNgaySinh.Value.DayOfYear ? 1 : 0);

            if (age < 18)
            {
                MessageBox.Show("Chưa đủ tuổi");
            }

        }

        private void dtpNgayVL_ValueChanged(object sender, EventArgs e)
        {
            int kt = ((dtpNgayVL.Value.Year - (DateTime.Now.DayOfYear < dtpNgaySinh.Value.DayOfYear ? 1 : 0)) - (dtpNgaySinh.Value.Year - (DateTime.Now.DayOfYear < dtpNgaySinh.Value.DayOfYear ? 1 : 0)) );

            if (dtpNgaySinh.Value.Date.CompareTo(dtpNgayVL.Value.Date) == 1)
            {
                MessageBox.Show("Ngày vào làm phải lớn hơn ngày sinh");
            }
            if (kt < 18){
                MessageBox.Show("Không hợp lệ");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Text == "" && txtSDT.Text == "" && txtCMND.Text == "" && cbb_ChucVu.Text == "" && cbo_Calam.Text == ""  && rbtKhac.Checked != true && rbtNam.Checked != true && rbtNu.Checked != true)
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
                        var delete = (from d in db.NHANVIENs where d.MaNV == a select d).Single();
                        db.NHANVIENs.Remove(delete);
                        db.SaveChanges();
                        xuat();
                        del = "";
                    }
                    catch
                    {
                        MessageBox.Show("Không thể xóa nhân viên này!");
                    }
                }
                else
                {
                    MessageBox.Show("Bạn chưa chọn hàng để xóa!");
                }
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dt = new DataTable();
                dt.Columns.Add("Mã nhân viên", System.Type.GetType("System.String"));
                dt.Columns.Add("Tên nhân viên", System.Type.GetType("System.String"));
                dt.Columns.Add("Ngày sinh", System.Type.GetType("System.DateTime"));
                dt.Columns.Add("Số chứng minh thư", System.Type.GetType("System.String"));
                dt.Columns.Add("Số điện thoại", System.Type.GetType("System.String"));
                dt.Columns.Add("Giới tính", System.Type.GetType("System.String"));
                dt.Columns.Add("Ngày vào làm", System.Type.GetType("System.DateTime"));
                dt.Columns.Add("Ca làm", System.Type.GetType("System.String"));
                dt.Columns.Add("Chức vụ", System.Type.GetType("System.String"));

                QuanLiTraSuaEntities4 db = new QuanLiTraSuaEntities4();
                var timkiem = db.NHANVIENs.SqlQuery("select * from NHANVIEN where TenNV like '%" + txtTimKiem.Text + "%'").ToList();
                foreach (var nv in timkiem)
                {
                    dt.Rows.Add(new object[]
                    {
                        nv.MaNV, nv.TenNV, nv.Ngaysinh, nv.CMND ,nv.SDT, nv.Gioitinh, nv.Ngayvl, nv.Calam, nv.Chucvu
                    });
                    dgvTTNV.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            QuanLiTraSuaEntities4 db = new QuanLiTraSuaEntities4();
            NHANVIEN nv = new NHANVIEN();
            List<NHANVIEN> listnv = db.NHANVIENs.ToList();
            string kt = "";
            if (txtHoTen.Text == "") kt = kt + "Chưa nhập tên nhân viên\n";
            if (txtSDT.Text == "") kt = kt + "Chưa nhập số điện thoại\n";
            if (txtCMND.Text == "") kt = kt + "Chưa nhập số chứng minh thư\n";
            if (cbo_Calam.Text == "") kt = kt + "Chưa chọn ca làm\n";
            if (cbb_ChucVu.Text == "") kt = kt + "Chưa chọn chức vụ\n";


            if (dtpNgaySinh.Value.Year == DateTime.Now.Year)
            {
                kt = kt + "Chưa chọn ngày sinh\n";
            }

            if (txtSDT.Text.Length < 11)
            {
                kt = kt + "Số điện thoại phải từ 10 số trở lên\n";
            }
            if (txtCMND.Text.Length < 10)
            {
                kt = kt + "Chứng minh thư phải từ 9 số trở lên\n";
            }
            if (rbtKhac.Checked != true && rbtNam.Checked != true && rbtNu.Checked != true) kt = kt + "Chưa chọn giới tính\n";

            if (kt != "")
            {
                MessageBox.Show(kt);
            }
            else
            {
                string a = ID_auto().Trim();
                nv.MaNV = a;
                nv.TenNV = txtHoTen.Text;
                nv.Ngaysinh = DateTime.Parse(dtpNgaySinh.Text);
                nv.CMND = txtCMND.Text;
                nv.SDT = txtSDT.Text;
                nv.Gioitinh = gt.Trim();
                nv.Ngayvl = DateTime.Parse(dtpNgayVL.Text);
                nv.Calam = cbo_Calam.Text;
                nv.Chucvu = cbb_ChucVu.Text;
                db.NHANVIENs.Add(nv);
                db.SaveChanges();
                xuat();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string kt = "";
            if (txtHoTen.Text == "" && txtSDT.Text == "" && txtCMND.Text == "" && cbb_ChucVu.Text == "" && cbo_Calam.Text == "" && rbtKhac.Checked != true && rbtNam.Checked != true && rbtNu.Checked != true)
            {
                MessageBox.Show("Chưa chọn hàng để sửa");
            }

            else
            {
                QuanLiTraSuaEntities4 db = new QuanLiTraSuaEntities4();
                List<NHANVIEN> nv = db.NHANVIENs.ToList();
                if (txtHoTen.Text == "") kt = kt + "Chưa nhập tên nhân viên\n";
                if (txtSDT.Text == "") kt = kt + "Chưa nhập số điện thoại\n";
                if (txtCMND.Text == "") kt = kt + "Chưa nhập số chứng minh thư\n";
                if (cbo_Calam.Text == "") kt = kt + "Chưa chọn ca làm\n";
                if (cbb_ChucVu.Text == "") kt = kt + "Chưa chọn chức vụ\n";
                if (txtSDT.Text.Length < 11)
                {
                    kt = kt + "Số điện thoại phải từ 10 số trở lên\n";
                }
                if (txtCMND.Text.Length < 10)
                {
                    kt = kt + "Chứng minh thư phải từ 9 số trở lên\n";
                }
                if (rbtKhac.Checked != true && rbtNam.Checked != true && rbtNu.Checked != true) kt = kt + "Chưa chọn giới tính\n";

                if (kt != "")
                {
                    MessageBox.Show(kt);
                }
                else
                {
                    var update = (from u in db.NHANVIENs where u.MaNV == del select u).Single();
                    update.TenNV = txtHoTen.Text;
                    update.SDT = txtSDT.Text;
                    update.Ngaysinh = DateTime.Parse(dtpNgaySinh.Text);
                    update.CMND = txtCMND.Text;
                    update.Gioitinh = gt.Trim();
                    update.Ngayvl = DateTime.Parse(dtpNgayVL.Text);
                    update.Calam = cbo_Calam.Text;
                    update.Chucvu = cbb_ChucVu.Text;
                    db.SaveChanges();
                    xuat();
                }
            }
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
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


        private void pn_menu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_return_Click_1(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            main.Show();
            this.Hide();
        }

        void themtk()
        {
            
        }

        private void btn_TaoTK_Click(object sender, EventArgs e)
        {
            nv.manhanvien = txtID.Text;
            frmTaiKhoan tk = new frmTaiKhoan();
            switch (cbb_ChucVu.Text)
            {
                case "Quản lí kho":
                    PQ.quyen = cbb_ChucVu.Text;
                    tk.ShowDialog();
                    break;
                case "Thu ngân":
                    PQ.quyen = cbb_ChucVu.Text;
                    tk.ShowDialog();
                    break;
                default:
                    MessageBox.Show("Không thể cấp tài khoản cho nhân viên có chức vụ này!!!");
                    /*this.Show();*/
                    break;
            }

        }

        private void dgvTTNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            QuanLiTraSuaEntities4 db = new QuanLiTraSuaEntities4();
            List<TAIKHOAN> nv = db.TAIKHOANs.ToList();
            if (e.RowIndex >= 0)
            {
                DataGridViewRow dgv = dgvTTNV.Rows[e.RowIndex];
                txtID.Text = dgv.Cells[0].Value.ToString();
                txtHoTen.Text = dgv.Cells[1].Value.ToString();
                dtpNgaySinh.Text = dgv.Cells[2].Value.ToString();
                txtCMND.Text = dgv.Cells[3].Value.ToString();
                txtSDT.Text = dgv.Cells[4].Value.ToString();
                btn_TaoTK.Enabled = true;
                string tk = dgv.Cells[0].Value.ToString();
                btn_TaoTK.Text = "Tạo TK";
                foreach (var t in nv)
                {
                    if (tk == t.MaNV)
                    {
                        btn_TaoTK.Text = "Sửa TK";
                    }
                }
                

                if (dgv.Cells[5].Value.ToString() == "Nam")
                {
                    rbtNam.Checked = true;
                }
                else if (dgv.Cells[5].Value.ToString() == "Nữ")
                {
                    rbtNu.Checked = true;
                }
                else if (dgv.Cells[5].Value.ToString() == "Khác")
                {
                    rbtKhac.Checked = true;
                }
                dtpNgayVL.Text = dgv.Cells[6].Value.ToString();
                cbo_Calam.Text = dgv.Cells[7].Value.ToString();
                cbb_ChucVu.Text = dgv.Cells[8].Value.ToString();
            }
            dgvTTNV.CurrentCell.Selected = false;
            if (e.RowIndex >= 0)
            {
                del = dgvTTNV.Rows[e.RowIndex].Cells[0].FormattedValue.ToString().Trim();
            }
        }
    }
}
