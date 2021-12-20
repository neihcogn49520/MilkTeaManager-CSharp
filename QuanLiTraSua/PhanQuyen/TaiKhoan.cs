using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLiTraSua.PhanQuyen
{
    public class TaiKhoan
    {
        public enum LoaiTK
        {
            quanly,
            nhanvienbh,
            nhanvienkho,
        }
        private string tentk;
        public string Tentk
        {
            get => tentk;
            set => tentk = value;
        }

        private string matkhau;
        public string Matkhau
        {
            get => matkhau;
            set => matkhau = value;
        }

        private LoaiTK loaitk;
        public LoaiTK Loaitk
        {
            get { return loaitk; }
            set => loaitk = value;
        }
        private string hienthiten;
        public string Hienthiten
        {
            get
            {
                switch (Loaitk)
                {
                    case LoaiTK.nhanvienkho:
                        Hienthiten = "nvkho";
                        break;
                    case LoaiTK.nhanvienbh:
                        Hienthiten = "nvbanhang";
                        break;
                    case LoaiTK.quanly:
                        Hienthiten = "quanly";
                        break;
                    default:
                        Hienthiten = "quanly";
                        break;
                }
                return hienthiten;
            }
            set => hienthiten = value;
        }

        public TaiKhoan(string tentk, string matkhau, LoaiTK loaitk)
        {
            this.Tentk = tentk;
            this.Matkhau = matkhau;
            this.Loaitk = loaitk;
        }
    }
}
