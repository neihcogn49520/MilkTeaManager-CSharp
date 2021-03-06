using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using QuanLiTraSua.CSDL;
using QuanLiTraSua.PhanQuyen;

namespace QuanLiTraSua
{
    public partial class frmOrderTS : Form
    {
        public frmOrderTS()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            numSL.ForeColor = Color.White;
        }
        public frmOrderTS(string value)
        {
            InitializeComponent();
            this.Value = value;
        }
        public string Value{get; set;}

        private void frmOrderTS_Load(object sender, EventArgs e)
        {
            lb_ChangeBan.Text = Value;
            xuat();
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            this.Hide();
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
        DataTable dt;
        string del = "", del1="";

        

        void xuat()
        {
            dt = new DataTable();
            dt.Columns.Add("STT", System.Type.GetType("System.Int32"));
            dt.Columns.Add("ID nhân viên", System.Type.GetType("System.String"));
            dt.Columns.Add("Tên món", System.Type.GetType("System.String"));
            dt.Columns.Add("Số lượng", System.Type.GetType("System.Int32"));
            dt.Columns.Add("Size", System.Type.GetType("System.String"));
            dt.Columns.Add("Tổng tiền", System.Type.GetType("System.Decimal"));
            QuanLiTraSuaEntities4 db = new QuanLiTraSuaEntities4();
            SANPHAM sp = new SANPHAM();
            List<SANPHAM> listsp = db.SANPHAMs.ToList();
            List<CTHD> listcthd = db.CTHDs.ToList();
            List<HOADON> listhd = db.HOADONs.ToList();
            List<NHANVIEN> listnv = db.NHANVIENs.ToList();
            txtMaHD.Text = gethoadon.mahoadon;
            txtIDNV.Text = nv.manhanvien;
            dtpNgayHD.Value = DateTime.Now;
            string n = "";
            foreach (var tensp in listsp)
            {
                string test = "";
                if (!test.Equals(tensp.TenMon))
                {
                    test = tensp.TenMon;
                    n = test;
                    foreach (var ten in listsp)
                    {
                        if (!n.Equals(ten.TenMon))
                        {
                            n = n;
                        }
                        else
                        {
                            cbo_Menu.Items.Remove(n);
                        }
                    }
                }
                cbo_Menu.Items.Add(n);
            }


            int dem = 1;
            decimal sum = 0;
            string tenmon = "";
            dt.Clear();
            decimal Thanhtien = 0;
            foreach (var item in listcthd)
            {
                foreach (var hd in listhd)
                {
                    foreach (var itm in listsp)
                    {
                        
                        if (txtMaHD.Text.Equals(hd.MaHD) && hd.MaHD.Equals(item.MaHD))
                        {
                            if (item.MaMon.Equals(itm.MaMon))
                            {
                                tenmon = itm.TenMon;
                                sum = itm.DonGia;
                                decimal tongtien = (decimal)item.Soluong * sum;
                                
                                Thanhtien += tongtien;
                                txtTongCong.Text = Convert.ToString(Thanhtien);
                                dt.Rows.Add(new Object[] { dem, txtIDNV.Text , tenmon, item.Soluong, item.Size, tongtien });
                                dem++;
                                break;
                            }                            
                        }
                    }
                }
                
            }
            dgvTTOrder.DataSource = dt;
            numSL.Value = 0;
        }
                
        private void btnXoa_Click(object sender, EventArgs e)
        {
            QuanLiTraSuaEntities4 db = new QuanLiTraSuaEntities4();
            string tenmonan = "";
            int b = 0;
            foreach (var maban in db.CTHDs.ToList())
            {
                foreach (var tban in db.BANs.ToList())
                {
                    if (lb_ChangeBan.Text.Trim().Equals(tban.TenBan))
                    {
                        b = tban.MaBan;
                    }
                }
            }
            foreach (var mahang in db.CTHDs.ToList())
            {
                foreach (var msp in db.SANPHAMs.ToList())
                {
                    if (cbo_Menu.Text.Equals(msp.TenMon))
                    {
                        tenmonan = msp.MaMon;                        
                    }
                }
            }
            var delete = (from d in db.CTHDs where d.MaBan == b && d.MaHD == txtMaHD.Text && d.MaMon==tenmonan select d).Single();
            db.CTHDs.Remove(delete);
            db.SaveChanges();
            xuat();
            del = "";
            del1 = "";
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            frmHoaDon m = new frmHoaDon();
            gethoadon.mahoadon = txtMaHD.Text;

            if (txtKhachDua.Text == "")
            {
                MessageBox.Show("Vui lòn nhập tiền khách đưa trước khi in");
            }
            else
            {
                gettienkhachdua.tienkhachdua = Convert.ToDecimal(txtKhachDua.Text);
                gettongtien.tongtien = Convert.ToDecimal(txtTongCong.Text);
                QuanLiTraSuaEntities4 db = new QuanLiTraSuaEntities4();
                string tenmonan = "";
                foreach (var mahang in db.CTHDs.ToList())
                {
                    foreach (var msp in db.SANPHAMs.ToList())
                    {
                        if (mahang.MaMon.Equals(msp.MaMon))
                        {
                            tenmonan = msp.MaMon;
                            var update = (from u in db.SANPHAMs where u.MaMon == tenmonan select u).Single();
                            update.SL = Convert.ToInt32(update.SL - numSL.Value);
                            db.SaveChanges();
                            m.Show();
                            this.Close();
                        }
                    }
                }
                
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            QuanLiTraSuaEntities4 db = new QuanLiTraSuaEntities4();
            var chitiethoadon = db.CTHDs.ToList();
            CTHD cthd = new CTHD();
            string kt = "";
            if (cbo_Menu.Text == "") kt = kt + "vui lòng chọn tên sản phẩm\n";
            if (numSL.Value == 0) kt = kt + "vui lòng nhập số lượng\n";
            if (kt != "")
            {
                MessageBox.Show(kt);
            }
            else
            {
                try
                {
                    if (del != "")
                    {
                        var update = (from u in db.CTHDs where u.MaHD == txtMaHD.Text && u.Size == cbo_Size.Text select u).Single();
                        update.Soluong = Convert.ToInt32(numSL.Value);
                        db.SaveChanges();
                        del = "";
                    }
                    else
                    {
                        string tenmonan = "";
                        int b = 0;
                        cthd.MaHD = txtMaHD.Text;
                        foreach (var maban in db.CTHDs.ToList())
                        {
                            foreach (var tban in db.BANs.ToList())
                            {
                                if (lb_ChangeBan.Text.Trim().Equals(tban.TenBan))
                                {
                                    b = tban.MaBan;
                                }
                            }
                        }
                        decimal temp = 0;
                        int s = 1;
                        foreach (var mahang in db.CTHDs.ToList())
                        {
                            foreach (var msp in db.SANPHAMs.ToList())
                            {
                                if (mahang.MaMon.Equals(msp.MaMon))
                                {
                                    temp = msp.DonGia;
                                }
                                if (cbo_Menu.Text.Equals(msp.TenMon) && cbo_Size.Text.Equals(msp.Size))
                                {
                                    tenmonan = msp.MaMon;
                                }
                            }
                            if (txtMaHD.Text.Equals(mahang.MaHD) && tenmonan.Equals(mahang.MaMon) && cbo_Size.Text.Equals(mahang.Size))
                            {
                                s = 0;
                            }
                        }
                        if (s == 0)
                        {
                            MessageBox.Show("Sản phẩm này đã có trong chi tiết hóa đơn");
                        }
                        else
                        {
                            cthd.MaHD = gethoadon.mahoadon;
                            cthd.MaBan = b;
                            cthd.MaMon = tenmonan;
                            cthd.Size = cbo_Size.Text;
                            cthd.Soluong = Convert.ToInt32(numSL.Value);
                            cthd.DonGia = temp * Convert.ToInt32(numSL.Value);
                            db.CTHDs.Add(cthd);
                            db.SaveChanges();
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Lỗi ngoại lệ");
                }
            }
            xuat();
        }

        private void dgvTTOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panDrag_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbo_Size_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbo_Menu_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbo_Size.Items.Clear();
            QuanLiTraSuaEntities4 db = new QuanLiTraSuaEntities4();
            List<SANPHAM> listsp = db.SANPHAMs.ToList();
            foreach(var item in listsp)
            {
                if (cbo_Menu.Text.Equals(item.TenMon))
                {
                    string s = item.Size;
                    cbo_Size.Items.Add(s);
                }
            }
        }

        private void txtTongCong_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtTongCong_Load(object sender, EventArgs e)
        {
            QuanLiTraSuaEntities4 db = new QuanLiTraSuaEntities4();
            List<SANPHAM> listsp = db.SANPHAMs.ToList();
            List<CTHD> listcthd = db.CTHDs.ToList();
            List<HOADON> listhd = db.HOADONs.ToList();
            decimal sum = 0;
            string tenmon = "";
            foreach (var item in listcthd)
            {
                foreach (var hd in listhd)
                {
                    foreach (var itm in listsp)
                    {
                        if (txtMaHD.Text.Equals(hd.MaHD) && hd.MaHD.Equals(item.MaHD))
                        {
                            if (item.MaMon.Equals(itm.MaMon))
                            {
                                tenmon = itm.TenMon;
                                sum = itm.DonGia;
                                decimal tongtien = (decimal)item.Soluong * sum;
                                txtTongCong.Text = Convert.ToString(tongtien);
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void numSL_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void txtKhachDua_TextChanged(object sender, EventArgs e)
        {
            txtTienThua.Text = Convert.ToString(Convert.ToDecimal(txtKhachDua.Text) - Convert.ToDecimal(txtTongCong.Text));
        }

        private void dgvTTOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow dgv = dgvTTOrder.Rows[e.RowIndex];
                txtMaHD.Text = gethoadon.mahoadon;
                txtIDNV.Text = dgv.Cells[1].Value.ToString();
                cbo_Menu.Text = dgv.Cells[3].Value.ToString();
                numSL.Text = dgv.Cells[4].Value.ToString();
                cbo_Size.Text = dgv.Cells[5].Value.ToString();
            }
            del = dgvTTOrder.Rows[e.RowIndex].Cells[0].FormattedValue.ToString().Trim();
            del1 = dgvTTOrder.Rows[e.RowIndex].Cells[3].FormattedValue.ToString().Trim();
        }
    }
}
