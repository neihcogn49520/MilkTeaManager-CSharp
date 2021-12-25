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
    public partial class frmHoaDon : Form
    {
        public frmHoaDon()
        {
            InitializeComponent();
        }
        DataTable dt;
        decimal Thanhtien = 0;
        void xuat()
        {
            dt = new DataTable();
            dt.Columns.Add("STT", System.Type.GetType("System.Int32"));
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
            int dem = 1;
            decimal sum = 0;
            string tenmon = "";
            dt.Clear();
            
            foreach (var item in listcthd)
            {
                foreach (var hd in listhd)
                {
                    foreach (var itm in listsp)
                    {

                        if (gethoadon.mahoadon.Equals(hd.MaHD) && hd.MaHD.Equals(item.MaHD))
                        {
                            if (item.MaMon.Equals(itm.MaMon))
                            {
                                tenmon = itm.TenMon;
                                sum = itm.DonGia;
                                decimal tongtien = (decimal)item.Soluong * sum;

                                Thanhtien += tongtien;
                                txtTongTien.Text = Convert.ToString(Thanhtien);
                                dt.Rows.Add(new Object[] { dem,  tenmon, item.Soluong, item.Size, tongtien });
                                dem++;
                                break;
                            }
                        }
                    }
                }
                dataGridView1.DataSource = dt;
            }
        }
        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            txtID.Text = gethoadon.mahoadon;
            txtTienKhachTra.Text = Convert.ToString(gettienkhachdua.tienkhachdua);
            txtTienThua.Text = Convert.ToString(gettienkhachdua.tienkhachdua - gettongtien.tongtien);
            txtNhanVien.Text = nv.manhanvien;
            xuat();
        }

        private void pic_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
