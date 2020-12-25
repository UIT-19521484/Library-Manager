using System;
using System.Data;
using System.Linq;

using TableDependency.SqlClient;
using TableDependency.SqlClient.Base;
using TableDependency.SqlClient.Base.EventArgs;

namespace New_Library
{
    public class DatabaseListener : DatabaseData
    {

        private static SqlTableDependency<LibraryEntity.Book> deBook;
        private static SqlTableDependency<LibraryEntity.Genre> deGenre;
        private static SqlTableDependency<LibraryEntity.Reader> deReader;
        private static SqlTableDependency<LibraryEntity.Staff> deStaff;
        private static SqlTableDependency<LibraryEntity.Account> deAccount;

        #region OnChanged events
        private static void dbBookChanged(object sender, RecordChangedEventArgs<LibraryEntity.Book> e)
        {
            switch (e.ChangeType)
            {
                case TableDependency.SqlClient.Base.Enums.ChangeType.Insert:
                    DataRow row = dtBook.NewRow();
                    row["MaSach"] = e.Entity.MaSach;
                    row["TÊN SÁCH"] = e.Entity.TenSach;
                    row["TÁC GIẢ"] = e.Entity.TacGia;
                    row["THỂ LOẠI"] = (from DataRow dr in dtGenre.Rows
                                       where dr["MaTL"].ToString() == e.Entity.MaTL.ToString()
                                       select dr["TÊN THỂ LOẠI"]).FirstOrDefault();
                    row["NHÀ XUẤT BẢN"] = e.Entity.NhaXB;
                    row["CÓ SẴN"] = e.Entity.TonTai;
                    row["ĐÃ MƯỢN"] = e.Entity.DaMuon;
                    dtBook.Rows.Add(row);
                    break;
                case TableDependency.SqlClient.Base.Enums.ChangeType.Delete:
                    row = dtBook.Select("MaSach=" + e.Entity.MaSach).FirstOrDefault();
                    if (row != null)
                    {
                        row.Delete();
                    }
                    break;
                case TableDependency.SqlClient.Base.Enums.ChangeType.Update:
                    row = dtBook.Select("MaSach=" + e.Entity.MaSach).FirstOrDefault();
                    if (row != null)
                    {
                        row["MaSach"] = e.Entity.MaSach;
                        row["TÊN SÁCH"] = e.Entity.TenSach;
                        row["TÁC GIẢ"] = e.Entity.TacGia;
                        row["THỂ LOẠI"] = (from DataRow dr in dtGenre.Rows
                                           where dr["MaTL"].ToString() == e.Entity.MaTL.ToString()
                                           select dr["TÊN THỂ LOẠI"]).FirstOrDefault();
                        row["NHÀ XUẤT BẢN"] = e.Entity.NhaXB;
                        row["CÓ SẴN"] = e.Entity.TonTai;
                        row["ĐÃ MƯỢN"] = e.Entity.DaMuon;
                    }
                    row.AcceptChanges();
                    break;
            }

            GC.Collect();
        }

        private static void dbGenreChanged(object sender, RecordChangedEventArgs<LibraryEntity.Genre> e)
        {
            switch (e.ChangeType)
            {
                case TableDependency.SqlClient.Base.Enums.ChangeType.Insert:
                    DataRow row = dtGenre.NewRow();
                    row["MaTL"] = e.Entity.MaTL;
                    row["TÊN THỂ LOẠI"] = e.Entity.TenTL;
                    dtGenre.Rows.Add(row);
                    break;
                case TableDependency.SqlClient.Base.Enums.ChangeType.Delete:
                    row = dtGenre.Select("MaTL=" + e.Entity.MaTL).FirstOrDefault();
                    if (row != null)
                    {
                        dtGenre.Rows.Remove(row);
                    }
                    break;
                case TableDependency.SqlClient.Base.Enums.ChangeType.Update:
                    row = dtGenre.Select("MaTL=" + e.Entity.MaTL).FirstOrDefault();
                    if (row != null)
                    {
                        row["TÊN THỂ LOẠI"] = e.Entity.TenTL;
                    }
                    break;
            }

            GC.Collect();
        }

        private static void dbReaderChanged(object sender, RecordChangedEventArgs<LibraryEntity.Reader> e)
        {
            switch (e.ChangeType)
            {
                case TableDependency.SqlClient.Base.Enums.ChangeType.Insert:
                    DataRow row = dtReader.NewRow();
                    row["MaDG"] = e.Entity.MaDG;
                    row["HỌ TÊN"] = e.Entity.HoTen;
                    row["GIỚI TÍNH"] = e.Entity.GioiTinh;
                    row["NGÀY SINH"] = e.Entity.NgaySinh.ToString();
                    row["ĐỊA CHỈ"] = e.Entity.DiaChi;
                    row["SĐT"] = e.Entity.DiaChi;
                    row["Email"] = e.Entity.Email;
                    dtReader.Rows.Add(row);
                    break;
                case TableDependency.SqlClient.Base.Enums.ChangeType.Delete:
                    row = dtReader.Select("MaDG=" + e.Entity.MaDG).FirstOrDefault();
                    if (row != null)
                    {
                        dtReader.Rows.Remove(row);
                    }
                    break;
                case TableDependency.SqlClient.Base.Enums.ChangeType.Update:
                    row = dtReader.Select("MaDG=" + e.Entity.MaDG).FirstOrDefault();
                    if (row != null)
                    {
                        row["HỌ TÊN"] = e.Entity.HoTen;
                        row["GIỚI TÍNH"] = e.Entity.GioiTinh;
                        row["NGÀY SINH"] = e.Entity.NgaySinh.ToString();
                        row["ĐỊA CHỈ"] = e.Entity.DiaChi;
                        row["SĐT"] = e.Entity.DiaChi;
                        row["Email"] = e.Entity.Email;
                    }
                    break;
            }

            GC.Collect();
        }

        private static void dbStaffChanged(object sender, RecordChangedEventArgs<LibraryEntity.Staff> e)
        {
            switch (e.ChangeType)
            {
                case TableDependency.SqlClient.Base.Enums.ChangeType.Insert:
                    DataRow row = dtStaff.NewRow();
                    row["MaNV"] = e.Entity.MaNV;
                    row["HỌ TÊN"] = e.Entity.HoTen;
                    row["GIỚI TÍNH"] = e.Entity.GioiTinh;
                    row["NGÀY SINH"] = e.Entity.NgaySinh.ToString();
                    row["ĐỊA CHỈ"] = e.Entity.DiaChi;
                    row["SĐT"] = e.Entity.SDT;
                    row["TÀI KHOẢN"] = e.Entity.TenTaiKhoan;
                    DataRow r = dtAccount.Select("[TÊN TÀI KHOẢN]='" + e.Entity.TenTaiKhoan + "'").FirstOrDefault();
                    if (r != null)
                    {
                        r["HỌ TÊN"] = e.Entity.HoTen;
                    }    
                    dtStaff.Rows.Add(row);
                    break;
                case TableDependency.SqlClient.Base.Enums.ChangeType.Delete:
                    row = dtStaff.Select("MaNV=" + e.Entity.MaNV).FirstOrDefault();
                    if (row != null)
                    {
                        dtStaff.Rows.Remove(row);
                    }
                    break;
                case TableDependency.SqlClient.Base.Enums.ChangeType.Update:
                    row = dtStaff.Select("MaNV=" + e.Entity.MaNV).FirstOrDefault();
                    if (row != null)
                    {
                        row["HỌ TÊN"] = e.Entity.HoTen;
                        row["GIỚI TÍNH"] = e.Entity.GioiTinh;
                        row["NGÀY SINH"] = e.Entity.NgaySinh.ToString();
                        row["ĐỊA CHỈ"] = e.Entity.DiaChi;
                        row["SĐT"] = e.Entity.SDT;
                        row["TÀI KHOẢN"] = e.Entity.TenTaiKhoan;
                    }
                    
                    break;
            }

            GC.Collect();
        }

        private static void dbAccountChanged(object sender, RecordChangedEventArgs<LibraryEntity.Account> e)
        {
            switch (e.ChangeType)
            {
                case TableDependency.SqlClient.Base.Enums.ChangeType.Insert:
                    DataRow row = dtAccount.NewRow();
                    row["HỌ TÊN"] = dtStaff.Select("[TÀI KHOẢN]='" + e.Entity.TenTaiKhoan + "'").FirstOrDefault().Field<string>("HỌ TÊN");
                    row["TÊN TÀI KHOẢN"] = e.Entity.TenTaiKhoan;
                    row["PHÂN QUYỀN"] = e.Entity.PhanQuyen;
                    dtAccount.Rows.Add(row);
                    break;
                case TableDependency.SqlClient.Base.Enums.ChangeType.Delete:
                    row = dtAccount.Select("[TÊN TÀI KHOẢN]='" + e.Entity.TenTaiKhoan + "'").FirstOrDefault();
                    if (row != null)
                    {
                        dtAccount.Rows.Remove(row);
                    }
                    break;
                case TableDependency.SqlClient.Base.Enums.ChangeType.Update:
                    row = dtAccount.Select("[TÊN TÀI KHOẢN]='" + e.EntityOldValues.TenTaiKhoan + "'").FirstOrDefault();
                    if (row != null)
                    {
                        row["TÊN TÀI KHOẢN"] = e.Entity.TenTaiKhoan;
                        row["PHÂN QUYỀN"] = e.Entity.PhanQuyen;
                    }
                    DataRow dr = dtStaff.Select("[HỌ TÊN]='" + row["HỌ TÊN"].ToString() + "'").FirstOrDefault();
                    if (dr != null)
                    {
                        dr["TÀI KHOẢN"] = e.Entity.TenTaiKhoan;  
                    }    
                    break;
            }

            GC.Collect();
        }
        #endregion

        #region Map model to table
        private static ModelToTableMapper<LibraryEntity.Book> MapBook()
        {
            var mapperBook = new ModelToTableMapper<LibraryEntity.Book>();
            mapperBook.AddMapping(c => c.MaSach, "MaSach");
            mapperBook.AddMapping(c => c.TenSach, "TenSach");
            mapperBook.AddMapping(c => c.NhaXB, "NhaXuatBan");
            mapperBook.AddMapping(c => c.MaTL, "MaTL");
            mapperBook.AddMapping(c => c.TacGia, "TacGia");
            mapperBook.AddMapping(c => c.TonTai, "TonTai");
            mapperBook.AddMapping(c => c.DaMuon, "DaMuon");

            return mapperBook;
        }

        private static ModelToTableMapper<LibraryEntity.Genre> MapGenre()
        {
            var mapperGenre = new ModelToTableMapper<LibraryEntity.Genre>();
            mapperGenre.AddMapping(c => c.MaTL, "MaTL");
            mapperGenre.AddMapping(c => c.TenTL, "TenTL");

            return mapperGenre;
        }

        private static ModelToTableMapper<LibraryEntity.Reader> MapReader()
        {
            var mapperReader = new ModelToTableMapper<LibraryEntity.Reader>();
            mapperReader.AddMapping(c => c.MaDG, "MaDG");
            mapperReader.AddMapping(c => c.HoTen, "HoTen");
            mapperReader.AddMapping(c => c.GioiTinh, "GioiTinh");
            mapperReader.AddMapping(c => c.NgaySinh, "NgaySinh");
            mapperReader.AddMapping(c => c.DiaChi, "DiaChi");
            mapperReader.AddMapping(c => c.SDT, "SDT");
            mapperReader.AddMapping(c => c.Email, "Email");

            return mapperReader;
        }

        private static ModelToTableMapper<LibraryEntity.Staff> MapStaff()
        {
            var mapperStaff = new ModelToTableMapper<LibraryEntity.Staff>();
            mapperStaff.AddMapping(c => c.MaNV, "MaNV");
            mapperStaff.AddMapping(c => c.HoTen, "HoTen");
            mapperStaff.AddMapping(c => c.GioiTinh, "GioiTinh");
            mapperStaff.AddMapping(c => c.NgaySinh, "NgaySinh");
            mapperStaff.AddMapping(c => c.DiaChi, "DiaChi");
            mapperStaff.AddMapping(c => c.SDT, "SDT");
            mapperStaff.AddMapping(c => c.TenTaiKhoan, "TenTaiKhoan");

            return mapperStaff;
        }

        private static ModelToTableMapper<LibraryEntity.Account> MapAccount()
        {
            var mapperAccount = new ModelToTableMapper<LibraryEntity.Account>();
            mapperAccount.AddMapping(c => c.TenTaiKhoan, "TenTaiKhoan");
            mapperAccount.AddMapping(c => c.MatKhau, "MatKhau");
            mapperAccount.AddMapping(c => c.PhanQuyen, "PhanQuyen");

            return mapperAccount;
        }
        #endregion

        public static void SetupSqlTableDependency()
        {
            var mapperBook = MapBook();
            deBook = new SqlTableDependency<LibraryEntity.Book>(DataConnection.ConnectionString, "SACH", mapper: mapperBook);
            deBook.OnChanged += dbBookChanged;
            deBook.Start();

            var mapperGenre = MapGenre();
            deGenre = new SqlTableDependency<LibraryEntity.Genre>(DataConnection.ConnectionString, "THELOAI", mapper: mapperGenre);
            deGenre.OnChanged += dbGenreChanged;
            deGenre.Start();

            var mapperReader = MapReader();
            deReader = new SqlTableDependency<LibraryEntity.Reader>(DataConnection.ConnectionString, "DOCGIA", mapper: mapperReader);
            deReader.OnChanged += dbReaderChanged;
            deReader.Start();

            var mapperStaff = MapStaff();
            deStaff = new SqlTableDependency<LibraryEntity.Staff>(DataConnection.ConnectionString, "NHANVIEN", mapper: mapperStaff);
            deStaff.OnChanged += dbStaffChanged;
            deStaff.Start();

            var mapperAccount = MapAccount();
            deAccount = new SqlTableDependency<LibraryEntity.Account>(DataConnection.ConnectionString, "TAIKHOAN", mapper: mapperAccount, includeOldValues: true);
            deAccount.OnChanged += dbAccountChanged;
            deAccount.Start();
        }

        public static void Dispose()
        {
            deBook.Stop();
            deGenre.Stop();
            deReader.Stop();
            deStaff.Stop();
        }
    }
}
