using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TableDependency.SqlClient;
using TableDependency.SqlClient.Base;
using TableDependency.SqlClient.Base.EventArgs;

namespace New_Library
{
    public class LibraryEntity
    {
        public class Book
        {
            private int maSach;
            private string tenSach;
            private string tacGia;
            private string nhaXB;
            private int maTL;
            private int tonTai;
            private int daMuon;

            public int MaSach { get => maSach; set => maSach = value; }
            public string TenSach { get => tenSach; set => tenSach = value; }
            public string TacGia { get => tacGia; set => tacGia = value; }
            public string NhaXB { get => nhaXB; set => nhaXB = value; }
            public int MaTL { get => maTL; set => maTL = value; }
            public int TonTai { get => tonTai; set => tonTai = value; }
            public int DaMuon { get => daMuon; set => daMuon = value; }
        }

        public class Genre
        {
            private int maTL;
            private string tenTL;

            public int MaTL { get => maTL; set => maTL = value; }
            public string TenTL { get => tenTL; set => tenTL = value; }
        }

        public class Reader
        {
            private int maDG;
            private string hoTen;
            private string gioiTinh;
            private DateTime ngaySinh;
            private string diaChi;
            private string sDT;
            private string email;

            public int MaDG { get => maDG; set => maDG = value; }
            public string HoTen { get => hoTen; set => hoTen = value; }
            public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
            public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
            public string DiaChi { get => diaChi; set => diaChi = value; }
            public string SDT { get => sDT; set => sDT = value; }
            public string Email { get => email; set => email = value; }
        }

        public class Staff
        {
            private int maNV;
            private string hoTen;
            private string gioiTinh;
            private DateTime ngaySinh;
            private string diaChi;
            private string sDT;
            private string tenTaiKhoan;

            public int MaNV { get => maNV; set => maNV = value; }
            public string HoTen { get => hoTen; set => hoTen = value; }
            public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
            public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
            public string DiaChi { get => diaChi; set => diaChi = value; }
            public string SDT { get => sDT; set => sDT = value; }
            public string TenTaiKhoan { get => tenTaiKhoan; set => tenTaiKhoan = value; }
        }

        public class Account
        {
            private string tenTaiKhoan;
            private string matKhau;
            private string phanQuyen;

            public string TenTaiKhoan { get => tenTaiKhoan; set => tenTaiKhoan = value; }
            public string MatKhau { get => matKhau; set => matKhau = value; }
            public string PhanQuyen { get => phanQuyen; set => phanQuyen = value; }
        }
    }
}
