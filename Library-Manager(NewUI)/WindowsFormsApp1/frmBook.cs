using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmBook : Form
    {
        public frmBook()
        {
            InitializeComponent();
        }

        private void frmBook_Load(object sender, EventArgs e)
        {
            dgvBook.DataSource = DataConnection.GetDataTable(new System.Data.SqlClient.SqlCommand("sp_select_all_books"));

            //Chỉnh sửa kích thước column cho phù hợp
            dgvBook.Columns["TÊN SÁCH"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvBook.Columns["TÁC GIẢ"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvBook.Columns["THỂ LOẠI"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvBook.Columns["NHÀ XUẤT BẢN"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvBook.Columns["CÓ SẴN"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvBook.Columns["ĐÃ MƯỢN"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            //Căn lề
            dgvBook.Columns["CÓ SẴN"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvBook.Columns["ĐÃ MƯỢN"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvBook.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //Chỉnh border
            dgvBook.CellBorderStyle = DataGridViewCellBorderStyle.Single;

            DataTable dt = DataConnection.GetDataTable(new System.Data.SqlClient.SqlCommand("sp_select_all_genres"));
            DataRow dr = dt.NewRow();
            dr[0] = "Tất cả thể loại";
            dt.Rows.InsertAt(dr, 0);
            cbGenre.DisplayMember = "TÊN THỂ LOẠI";
            cbGenre.DataSource = dt;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            (new frmAddBook()).ShowDialog();

            dgvBook.DataSource = DataConnection.GetDataTable(new System.Data.SqlClient.SqlCommand("sp_select_all_books"));
            dgvBook.Refresh();
        }

        private void dgvBook_Enter(object sender, EventArgs e)
        {
            //dgvBook.DataSource = DataConnection.GetDataTable(new System.Data.SqlClient.SqlCommand("sp_select_all_books"));
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            using (System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand())
            {
                int ID_Genre = Convert.ToInt32
                    (DataConnection.ExecuteQuery(new System.Data.SqlClient.SqlCommand("select MaTL from THELOAI where TenTL = '" + dgvBook.SelectedRows[0].Cells[2].Value + "'")));

                cmd.CommandText = "select MaSach from SACH where TenSach = @TenSach and TacGia = @TacGia and MaTL = @MaTL and NhaXuatBan = @NhaXuatBan";
                cmd.Parameters.AddWithValue("@TenSach", dgvBook.SelectedRows[0].Cells[0].Value);
                cmd.Parameters.AddWithValue("@TacGia", dgvBook.SelectedRows[0].Cells[1].Value);
                cmd.Parameters.AddWithValue("@NhaXuatBan", dgvBook.SelectedRows[0].Cells[3].Value);
                cmd.Parameters.AddWithValue("@MaTL", ID_Genre);

                int ID_Book = DataConnection.ExecuteScalar(cmd);

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_delete_book";
                cmd.Parameters.AddWithValue("@MaSach", ID_Book);
                
                if (DataConnection.ExecuteQuery(cmd))
                {
                    MessageBox.Show("Xóa sách thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }    
                else
                {
                    MessageBox.Show("Xóa sách không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                dgvBook.DataSource = DataConnection.GetDataTable(new System.Data.SqlClient.SqlCommand("sp_select_all_books"));
                dgvBook.Refresh();
            }    
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            (new frmEditBook
            (dgvBook.SelectedRows[0].Cells[0].Value.ToString(),
            dgvBook.SelectedRows[0].Cells[1].Value.ToString(),
            dgvBook.SelectedRows[0].Cells[2].Value.ToString(),
            dgvBook.SelectedRows[0].Cells[3].Value.ToString(),
            dgvBook.SelectedRows[0].Cells[4].Value.ToString())).ShowDialog();
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                dgvBook.DataSource = DataConnection.GetDataTable(new System.Data.SqlClient.SqlCommand("sp_select_all_books"));
            }

            DataView dv = ((DataTable)dgvBook.DataSource).DefaultView;
            dv.RowFilter = string.Format("[{0}] like '%{1}%'", cbFilter.Text, txtSearch.Text);
            dgvBook.DataSource = dv.ToTable();
        }

        private void cbGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvBook.DataSource = DataConnection.GetDataTable(new System.Data.SqlClient.SqlCommand("sp_select_all_books"));

            if (cbGenre.SelectedIndex == 0)
            {
                return;
            }

            using (DataView dv = ((DataTable)dgvBook.DataSource).DefaultView)
            {
                dv.RowFilter = string.Format("[{0}] like '%{1}%'", "THỂ LOẠI", cbGenre.Text);
                dgvBook.DataSource = dv.ToTable();
            }    
        }
    }
}
