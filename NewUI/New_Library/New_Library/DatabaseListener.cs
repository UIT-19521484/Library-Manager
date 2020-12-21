using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TableDependency.SqlClient;
using TableDependency.SqlClient.Base;
using TableDependency.SqlClient.Base.EventArgs;

namespace New_Library
{
    public class DatabaseListener
    {
        public static DataTable dtBook;
        public static DataTable dtGenre;

        #region SqlTableDependency
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
                        //dtGenre.Rows.Remove(row);
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
                    break;
            }
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
        }

        private static SqlTableDependency<LibraryEntity.Book> deBook;
        private static SqlTableDependency<LibraryEntity.Genre> deGenre;
        public static void SetupSqlTableDependency()
        {
            dtBook = DataConnection.GetDataTable(@"EXEC sp_select_all_books");
            dtGenre = DataConnection.GetDataTable(@"EXEC sp_select_all_genres");

            var mapperBook = new ModelToTableMapper<LibraryEntity.Book>();
            mapperBook.AddMapping(c => c.MaSach, "MaSach");
            mapperBook.AddMapping(c => c.TenSach, "TenSach");
            mapperBook.AddMapping(c => c.NhaXB, "NhaXuatBan");
            mapperBook.AddMapping(c => c.MaTL, "MaTL");
            mapperBook.AddMapping(c => c.TacGia, "TacGia");
            mapperBook.AddMapping(c => c.TonTai, "TonTai");
            mapperBook.AddMapping(c => c.DaMuon, "DaMuon");

            deBook = new SqlTableDependency<LibraryEntity.Book>(DataConnection.ConnectionString, "SACH", mapper: mapperBook);
            deBook.OnChanged += dbBookChanged;
            deBook.Start();

            var mapperGenre = new ModelToTableMapper<LibraryEntity.Genre>();
            mapperGenre.AddMapping(c => c.MaTL, "MaTL");
            mapperGenre.AddMapping(c => c.TenTL, "TenTL");

            deGenre = new SqlTableDependency<LibraryEntity.Genre>(DataConnection.ConnectionString, "THELOAI", mapper: mapperGenre);
            deGenre.OnChanged += dbGenreChanged;
            deGenre.Start();
        }
        #endregion
    }
}
