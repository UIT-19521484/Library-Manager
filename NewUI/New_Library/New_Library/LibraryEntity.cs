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
    }
}
