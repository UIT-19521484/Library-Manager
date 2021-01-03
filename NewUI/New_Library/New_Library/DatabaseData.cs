using System.Data;

namespace New_Library
{
    public class DatabaseData
    {
        public static DataTable dtBook = DataConnection.GetDataTable(@"EXEC sp_select_all_books");
        public static DataTable dtGenre = DataConnection.GetDataTable(@"EXEC sp_select_all_genres");
        public static DataTable dtReader = DataConnection.GetDataTable(@"EXEC sp_select_all_readers");
        public static DataTable dtStaff = DataConnection.GetDataTable(@"EXEC sp_select_all_staff");
        public static DataTable dtAccount = DataConnection.GetDataTable(@"EXEC sp_select_all_accounts");
        public static DataTable dtReceipt = DataConnection.GetDataTable(@"EXEC sp_select_all_receipts");
   
    }
}
