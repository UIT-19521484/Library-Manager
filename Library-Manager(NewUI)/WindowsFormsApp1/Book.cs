using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Book
    {
        public static bool IsExist(string name, string author, int genre, string publisher)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_check_book_is_exists";
                cmd.Parameters.AddWithValue("@TenSach", name);
                cmd.Parameters.AddWithValue("@TacGia", author);
                cmd.Parameters.AddWithValue("@NhaXuatBan", publisher);
                cmd.Parameters.AddWithValue("@MaTL", genre);

                if (DataConnection.ExecuteScalar(cmd) < 1)
                {
                    return false;
                }
                return true;
            }
        }
    }
}
