using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class DataConnection
    {
        private static string connectionString;
        private static SqlConnection con;
        private static DataSet ds;
        private static SqlDataAdapter da;
        private static SqlDataReader rdr;

        public static void OpenConnection()
        {
            //
            //Nhập connection string của server database
            //
            connectionString = @"Data Source=DESKTOP-60EFUQD;Initial Catalog=QLThuVien;Persist Security Info=True;User ID=sa;Password=123456;";

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
        public static bool ExecuteQuery(SqlCommand cmd)
        {
            cmd = new SqlCommand();

            try
            {
                OpenConnection();

                cmd.Connection = con;
                //cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

                con.Close();
                return true;
            }
            catch (Exception e)
            {
                con.Close();
                //MessageBox.Show(e.Message);
                MessageBox.Show("Không thể hoàn thành lệnh!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        //
        //Sử dụng khi đọc dữ liệu từ database
        //
        public static SqlDataReader ExecuteReader(SqlCommand cmd)
        {
            try
            {
                OpenConnection();

                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;

                rdr = cmd.ExecuteReader();

                con.Close();
                return rdr;
            }
            catch (Exception)
            {
                con.Close();
                MessageBox.Show("Không thể hoàn thành lệnh!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public static DataSet GetDataSet(SqlCommand cmd)
        {
            OpenConnection();

            da = new SqlDataAdapter(cmd.ToString(), con);
            ds = new DataSet();
            da.Fill(ds);

            con.Close();
            return ds;
        }

        //
        //Sử dụng khi lấy dữ liệu từ một table
        //
        public static DataTable GetDataTable(SqlCommand cmd)
        {
            return GetDataSet(cmd).Tables[0];
        }

        //
        //Sử dụng khi lấy số lượng records
        //
        public static int ExecuteScalar(SqlCommand cmd)
        {
            OpenConnection();

            try
            {
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;

                int result = Convert.ToInt32(cmd.ExecuteScalar());
                con.Close();
                return result;
            }
            catch (Exception)
            {
                con.Close();
                MessageBox.Show("Không thể hoàn thành lệnh!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
    }
}
