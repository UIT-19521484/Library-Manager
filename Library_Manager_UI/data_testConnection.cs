using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Manager_UI
{
    class data_testConnection
    {
        private static string connectionString;
        private static SqlConnection con;
        private static DataSet ds;
        private static SqlCommand cmd;
        private static SqlDataAdapter da;
        private static SqlDataReader rdr;

        public static void OpenConnection()
        {
            //
            //Nhập connection string của server database
            //
            connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLThuVien;User ID=sa;Password=Huy123456";

            con = new SqlConnection(connectionString);

            try
            {
                con.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể kết nối tới CSDL!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        //
        //Sử dụng khi thay đổi dữ liệu trong database
        //
        public static bool ExecuteQuery(string sqlCommand)
        {
            cmd = new SqlCommand();

            try
            {
                OpenConnection();

                cmd.Connection = con;
                cmd.CommandText = sqlCommand;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

                con.Close();
                return true;
            }
            catch (Exception)
            {
                con.Close();
                MessageBox.Show("Không thể thực thi lệnh này!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        //
        //Sử dụng khi đọc dữ liệu từ database
        //
        public static SqlDataReader ExecuteReader(string sqlCommand)
        {
            cmd = new SqlCommand();

            try
            {
                OpenConnection();

                cmd.Connection = con;
                cmd.CommandText = sqlCommand;
                cmd.CommandType = CommandType.Text;

                rdr = cmd.ExecuteReader();

                con.Close();
                return rdr;
            }
            catch (Exception)
            {
                con.Close();
                MessageBox.Show("Không thế thực thi lệnh này!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public static DataSet GetDataSet(string sqlCommand)
        {
            OpenConnection();

            da = new SqlDataAdapter(sqlCommand, con);
            ds = new DataSet();
            da.Fill(ds);

            con.Close();
            return ds;
        }

        //
        //Sử dụng khi lấy dữ liệu từ một table
        //
        public static DataTable GetDataTable(string sqlCommand)
        {
            return GetDataSet(sqlCommand).Tables[0];
        }

        //
        //Sử dụng khi lấy số lượng records
        //
        public static int ExecuteScalar(string sqlCommand)
        {
            OpenConnection();

            try
            {
                cmd.Connection = con;
                cmd.CommandText = sqlCommand;
                cmd.CommandType = CommandType.Text;

                int result = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();
                return result;
            }
            catch (Exception)
            {
                con.Close();
                MessageBox.Show("Không thể thực thi lệnh này", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
    }
}
