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
    public partial class frmThongKe : Form
    {
        public frmThongKe()
        {
            InitializeComponent();
        }
        public class ThongKe
        {
            public string mamon { get; private set; }
            public int sl { get; private set; }

            public string Mamon
            {
                get { return mamon; }
                set { mamon = value; }
            }

            public int Soluong
            {
                get { return sl; }
                set { sl = value; }
            }
            public ThongKe(string mamon, int sl)
            {
                this.mamon = mamon;
                this.sl = sl;
            }
        }

        public class Them
        {
            public string mamon { get; private set; }
            public int sl { get; private set; }

            public string Mamon
            {
                get { return mamon; }
                set { mamon = value; }
            }

            public int Soluong
            {
                get { return sl; }
                set { sl = value; }
            }
            public Them(string mamon, int sl)
            {
                this.mamon = mamon;
                this.sl = sl;
            }
        }

        public class DoanhThu
        {
            public DateTime thang { get; private set; }
            public decimal tong { get; private set; }

            public DateTime Thang
            {
                get { return thang; }
                set { thang = value; }
            }

            public decimal TongTien
            {
                get { return tong; }
                set { tong = value; }
            }
            public DoanhThu(DateTime thang, decimal tong)
            {
                this.thang = thang;
                this.tong = tong;
            }
        }

        public class TongDoanhThu
        {
            public string thang { get; private set; }
            public decimal tong { get; private set; }

            public string Thang
            {
                get { return thang; }
                set { thang = value; }
            }

            public decimal TongTien
            {
                get { return tong; }
                set { tong = value; }
            }
            public TongDoanhThu(string thang, decimal tong)
            {
                this.thang = thang;
                this.tong = tong;
            }
        }

        List<ThongKe> t = new List<ThongKe>();
        List<Them> a = new List<Them>();
        List<DoanhThu> dt = new List<DoanhThu>();
        List<TongDoanhThu> tdt = new List<TongDoanhThu>();

        void loadProduct()
        {
            using (QuanLiTraSuaEntities3 db = new QuanLiTraSuaEntities3())
            {
                List<SANPHAM> sp = db.SANPHAMs.ToList();
                List<HOADON> hd = db.HOADONs.ToList();
                List<CTHD> cthd = db.CTHDs.ToList();
                int count = 0;
                string tenmon = "";
                foreach (var lsp in sp)
                {
                    foreach (var lcthd in cthd)
                    {
                        if (lsp.MaMon.Equals(lcthd.MaMon))
                        {
                            tenmon = lsp.TenMon;
                            count = lcthd.Soluong;

                            t.Add(new ThongKe(tenmon, count));
                        }
                    }
                }
                for (int i = 0; i < t.Count; i++)
                {
                    count = t[i].sl;
                    tenmon = t[i].mamon;
                    bool kt = true;
                    for (int j = i + 1; j < t.Count; j++)
                    {
                        if (t[i].mamon == t[j].mamon)
                        {
                            count += t[j].sl;
                            t.Remove(t[j]);
                            j--;
                            kt = false;
                        }
                    }
                    if (kt == false)
                    {
                        tenmon = t[i].mamon;
                        t.Remove(t[i]);
                        i--;
                    }
                    a.Add(new Them(tenmon, count));
                    a.Sort((x, y) => {
                        int ret = y.sl.CompareTo(x.sl);
                        return ret != 0 ? ret : x.sl.CompareTo(y.sl);
                    });
                }

                for (int i = 7; i < a.Count; i++)
                {
                    a.Remove(a[i]);
                    i--;
                }

                chartProduct.DataSource = a;
                chartProduct.Series[0].XValueMember = "mamon";
                chartProduct.Series[0].YValueMembers = "sl";
                chartProduct.ChartAreas["ChartArea1"].AxisX.Interval = 1;
                chartProduct.DataBind();
            }
        }

        void loadRevenue()
        {
            using (QuanLiTraSuaEntities3 db = new QuanLiTraSuaEntities3())
            {
                List<HOADON> hd = db.HOADONs.ToList();
                List<CTHD> cthd = db.CTHDs.ToList();
                List<SANPHAM> sp = db.SANPHAMs.ToList();

                
                DateTime date;
                foreach (var lhd in hd)
                {
                    foreach (var lcthd in cthd)
                    {
                        decimal sum = 0;
                        foreach (var lsp in sp)
                        {
                            if (lcthd.MaHD == lhd.MaHD && lcthd.MaMon == lsp.MaMon)
                            {
                                sum += Convert.ToDecimal(lcthd.Soluong) * lsp.DonGia;
                                decimal tongtien = 0;
                                tongtien += sum;
                                date = lhd.NgayHD;
                                dt.Add(new DoanhThu(date, tongtien));
                            }
                        }
                    }
                }
                decimal tong = 0;

                for (int i = 0; i < dt.Count; i++)
                {
                    tong = dt[i].tong;
                    date = dt[i].thang;
                    bool kt = true;
                    for (int j = i + 1; j < dt.Count; j++)
                    {
                        if (dt[i].thang.Month == dt[j].thang.Month)
                        {
                            tong += dt[j].tong;
                            dt.Remove(dt[j]);
                            j--;
                            kt = false;
                        }
                    }
                    if (kt == false)
                    {
                       /* date.AddMonths(dt[i].thang.Month);*/
                        dt.Remove(dt[i]);
                        i--;
                    }
                    string d = date.ToString("yyyy-dd-MM");
                    string s = d.Substring(8);
                    tdt.Add(new TongDoanhThu(s, tong));
                }

                chartRevenue.DataSource = tdt;
                chartRevenue.Series[0].XValueMember = "thang";
                chartRevenue.Series[0].YValueMembers = "tong";
                chartRevenue.ChartAreas["ChartArea1"].AxisX.Interval = 1;
                chartRevenue.DataBind();
            }
        }

        private void frmThongKe_Load(object sender, EventArgs e)
        {
            this.chartProduct.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;
            this.chartProduct.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.White;
            this.chartProduct.ChartAreas[0].AxisX.LabelStyle.IntervalOffset = 1;

            this.chartRevenue.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;
            this.chartRevenue.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.White;
            this.chartRevenue.ChartAreas[0].AxisX.LabelStyle.IntervalOffset = 1;

            loadProduct();
            loadRevenue();
        }
    }

}
