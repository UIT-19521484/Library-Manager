using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New_Library
{
    public class DatabaseData
    {
        public static DataTable dtBook = DataConnection.GetDataTable(@"EXEC sp_select_all_books");
        public static DataTable dtGenre = DataConnection.GetDataTable(@"EXEC sp_select_all_genres");
        public static DataTable dtReader = DataConnection.GetDataTable(@"EXEC sp_select_all_readers");
        public static DataTable dtStaff = DataConnection.GetDataTable(@"EXEC sp_select_all_staff");
        public static DataTable dtAccount = DataConnection.GetDataTable(@"EXEC sp_select_all_accounts");
    }
}
