using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLiTraSua.CSDL;

namespace QuanLiTraSua.PhanQuyen
{
    public class DanhSachTaiKhoan
    {
        private static DanhSachTaiKhoan instance;

        public static DanhSachTaiKhoan Instance
        {
            get
            {
                if (instance == null)
                    instance = new DanhSachTaiKhoan();
                return instance;
            }
            set => instance = value;
        }

        List<TaiKhoan> listTK;

        public List<TaiKhoan> ListTK
        {
            get => listTK;
            set => listTK = value;
        }

        DanhSachTaiKhoan()
        {
            listTK = new List<TaiKhoan>();
            QuanLiTraSuaEntities3 db = new QuanLiTraSuaEntities3();
            TAIKHOAN tk = new TAIKHOAN();
            /*QLCHDMEntities1 db = new QLCHDMEntities1();
            List<C_user> listUser = db.C_user.ToList();
            foreach(var user in listUser)
            {
                listTK.Add(new TaiKhoan(user.tendangnhap, user.matkhau, TaiKhoan.LoaiTK.quanly));
                listTK.Add(new TaiKhoan(user.tendangnhap, user.matkhau, TaiKhoan.LoaiTK.nhanvien));
            }*/
            listTK.Add(new TaiKhoan("admin", "admin", TaiKhoan.LoaiTK.quanly));
            listTK.Add(new TaiKhoan("nvkho", "nvkho", TaiKhoan.LoaiTK.nhanvienkho));
            listTK.Add(new TaiKhoan("nvbanhang", "nvbanhang",TaiKhoan.LoaiTK.nhanvienbh));
        }
    }
}
