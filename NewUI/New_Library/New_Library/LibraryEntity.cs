using System;

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

        public class Receipt
        {
            private int maHD;
            
            private int maDG;
            private DateTime ngayMuon;
            private DateTime ngayTra;
            private string tinhTrang;
            private int tongSL;
            private int chiPhi;
            private string sDT;

            public int MaHD { get => maHD; set => maHD = value; }
            public int MaDG { get => maDG; set => maDG = value; }
            public DateTime NgayMuon { get => ngayMuon; set => ngayMuon = value; }
            public DateTime NgayTra { get => ngayTra; set => ngayTra = value; }
            public string TinhTrang { get => tinhTrang; set => tinhTrang = value; }
            public int TongSL { get => tongSL; set => tongSL = value; }
            public int ChiPhi { get => chiPhi; set => chiPhi = value; }
            public string SDT { get => sDT; set => sDT = value; }
            
        }

        public class Detail
        {
            private int maHD;
            private int maSach;
            private int sL;

            public int MaHD { get => maHD; set => maHD = value; }
            public int MaSach { get => maSach; set => maSach = value; }
            public int SL { get => sL; set => sL = value; }
        }
    }
}
