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
    public partial class frmBaoCao : Form
    {
        public frmBaoCao()
        {
            InitializeComponent();
        }

        DataTable dt;
        static public List<xuatHD> listhd;
        private void btnThem_Click(object sender, EventArgs e)
        {
            listhd = new List<xuatHD>();
            QuanLiTraSuaEntities4 db = new QuanLiTraSuaEntities4();
            try
            {
                foreach (DataRow dr in dt.Rows)
                {
                    xuatHD hd = new xuatHD();
                    hd.stt = Convert.ToInt32(dr[0].ToString()); ;
                    hd.mahd = Convert.ToString(dr[1].ToString());
                    hd.manv = dr[2].ToString();
                    hd.ngayhd = Convert.ToDateTime(dr[3].ToString());
                    hd.tongtien = Convert.ToDecimal(dr[4].ToString());
                    listhd.Add(hd);
                }

                frmXuatHD b = new frmXuatHD();
                b.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmBaoCao_Load(object sender, EventArgs e)
        {
            dt = new DataTable();
            dt.Columns.Add("STT", System.Type.GetType("System.Int32"));
            dt.Columns.Add("Mã hóa đơn", System.Type.GetType("System.String"));
            dt.Columns.Add("Mã nhân viên", System.Type.GetType("System.String"));
            dt.Columns.Add("Ngày lập hóa đơn", System.Type.GetType("System.DateTime"));
            /*dgvThongTinGD.Columns["Ngày lập hóa đơn"].DefaultCellStyle.Format = "dd/MM/yyyy";*/
            dt.Columns.Add("Tổng tiền", System.Type.GetType("System.Decimal"));
            xuat();
        }

        decimal sum = 0;
        int dem = 1;
        void xuat()
        {
            dt.Clear();
            QuanLiTraSuaEntities4 db = new QuanLiTraSuaEntities4();
            List<HOADON> listhd = db.HOADONs.ToList();
            List<CTHD> cthd = db.CTHDs.ToList();
            List<SANPHAM> listsp = db.SANPHAMs.ToList();

            foreach (var hd in listhd)
            {
                foreach (var item in cthd)
                {
                    foreach (var sp in listsp)
                    {
                        if (item.MaMon.Equals(sp.MaMon))
                        {
                            if (hd.MaHD == item.MaHD)
                            {
                                sum += (Decimal)(item.Soluong * sp.DonGia);
                            }
                        }
                    }
                }
                dt.Rows.Add(new Object[] { dem, hd.MaHD, hd.MaNV, hd.NgayHD, sum });
                dem++;
                sum = 0;
            }
            dgvThongTinGD.DataSource = dt;
        }

        private void ckbXemTrongThang_CheckedChanged(object sender, EventArgs e)
        {
            QuanLiTraSuaEntities4 db = new QuanLiTraSuaEntities4();
            List<HOADON> listhd = db.HOADONs.ToList();
            List<CTHD> cthd = db.CTHDs.ToList();
            List<SANPHAM> listsp = db.SANPHAMs.ToList();
            dt = new DataTable();
            dt.Columns.Add("STT", System.Type.GetType("System.Int32"));
            dt.Columns.Add("Mã hóa đơn", System.Type.GetType("System.String"));
            dt.Columns.Add("Mã nhân viên", System.Type.GetType("System.String"));
            dt.Columns.Add("Ngày lập hóa đơn", System.Type.GetType("System.DateTime"));
            /*dgvThongTinGD.Columns["Ngày lập hóa đơn"].DefaultCellStyle.Format = "dd/MM/yyyy";*/
            dt.Columns.Add("Tổng tiền", System.Type.GetType("System.Decimal"));
            if (ckbXemTrongThang.Checked)
            {
                foreach (var hd in listhd)
                {
                    if (dtpNgayBD.Value.Month <= hd.NgayHD.Month && dtpNgayKT.Value.Month >= hd.NgayHD.Month)
                    {
                        foreach (var item in cthd)
                        {
                            foreach (var sp in listsp)
                            {
                                if (item.MaMon.Equals(sp.MaMon))
                                {
                                    if (hd.MaHD == item.MaHD)
                                    {
                                        sum += (Decimal)(item.Soluong * sp.DonGia);
                                    }
                                }
                            }
                        }
                        dt.Rows.Add(new Object[] { dem, hd.MaHD, hd.MaNV, hd.NgayHD, sum });
                        dem++;
                        sum = 0;
                    }
                }
                dgvThongTinGD.DataSource = dt;
            }
            else
            {
                xuat();
            }
        }
    }
}
