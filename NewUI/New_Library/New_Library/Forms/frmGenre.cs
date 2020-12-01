using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New_Library.Forms
{
    public partial class frmGenre : Form
    {
        private string curGenreName;
        public frmGenre()
        {
            InitializeComponent();
        }

        private void frmGenre_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            this.btnEdit.BackColor = ThemeColor.PrimaryColor;
            this.btnEdit.ForeColor = Color.White;
            this.btnSearch.BackColor = ThemeColor.PrimaryColor;
            this.btnSearch.ForeColor = Color.White;
            LoadTheme();
            LoadData_Genre();
        }

        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
            lblGenreName.ForeColor = ThemeColor.SecondaryColor;
        }

        void LoadData_Genre()
        {
            string str = @"EXEC sp_select_all_genres";
            DataTable dt = DataConnection.GetDataTable(str);
            dgvGenre.DataSource = dt;
            dgvGenre.BackgroundColor = Color.White;
            dgvGenre.HeaderBgColor = ThemeColor.PrimaryColor;
            dgvGenre.HeaderForeColor = Color.White;
            dgvGenre.GridColor = Color.White;
        }

        private void dgvGenre_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.dgvGenre.ClearSelection();
        }

        private void dgvGenre_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = this.dgvGenre.Rows[e.RowIndex];
                txtGenreName.Text = row.Cells[0].Value.ToString();
                curGenreName = txtGenreName.Text;
            }
            catch (Exception)
            { }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtGenreName.ReadOnly = !txtGenreName.ReadOnly;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "" || txtSearch.Text == null)
            {
                LoadData_Genre();
                return;
            }
            string command = @"EXEC sp_search_genres @TuKhoa = N'" + txtSearch.Text + "'";
            DataTable dt = DataConnection.GetDataTable(command);
            this.dgvGenre.DataSource = dt;
            dgvGenre.BackgroundColor = Color.White;
            dgvGenre.HeaderBgColor = ThemeColor.PrimaryColor;
            dgvGenre.HeaderForeColor = Color.White;
            dgvGenre.GridColor = Color.White;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (txtGenreName.ReadOnly == true)
            {
                if (txtGenreName.Text == "")
                {
                    MessageBox.Show("Không tồn tại thể loại này!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DataTable dt1 = DataConnection.GetDataTable(@"SELECT MaTL FROM THELOAI WHERE TenTL = N'" + txtGenreName.Text + "'");
                if (dt1.Rows.Count == 0)
                {
                    MessageBox.Show("Không tồn tại thể loại này!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DataTable dt = DataConnection.GetDataTable(@"EXEC sp_select_genre @TenTL = N'" + curGenreName + "'");
                if (dt.Rows.Count == 0)
                {

                    string command = @"EXEC sp_delete_genre @TenTL = N'" + txtGenreName.Text + "'";
                    DataConnection.ExecuteQuery(command);
                    MessageBox.Show("Xóa thể loại thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData_Genre();

                }
                else
                {
                    MessageBox.Show("Có sách đang thuộc thể loại này!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Đang trong chế độ edit! Vui lòng tắt trước khi xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (txtGenreName.ReadOnly == false)
            {
                if (txtGenreName.Text == "")
                {
                    MessageBox.Show("Thông tin thể loại chưa đầy đủ! Hãy nhập lại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DataTable dt = DataConnection.GetDataTable(@"SELECT * FROM THELOAI WHERE TenTL = N'" + txtGenreName.Text + "'");
                if (dt.Rows.Count == 0)
                {
                    string command = @"INSERT INTO THELOAI (TenTL) VALUES (N'" + txtGenreName.Text + "')";
                    DataConnection.ExecuteQuery(command);
                    MessageBox.Show("Thêm thể loại thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData_Genre();
                }
                else
                {
                    MessageBox.Show("Đã tồn tại thể loại này!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Hãy bật chế độ edit! Điền thông tin thể loại trước khi thêm!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtGenreName.ReadOnly == false && this.dgvGenre.SelectedRows.Count > 0)
            {
                if (txtGenreName.Text == "")
                {
                    MessageBox.Show("Thông tin thể loại chưa đầy đủ! Hãy nhập lại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (curGenreName != null || curGenreName == "")
                {
                    DataTable dt = DataConnection.GetDataTable(@"SELECT MaTL FROM THELOAI WHERE TenTL = N'" + curGenreName + "'");
                    int MaTL = Int32.Parse(dt.Rows[0][0].ToString());

                    string command = @"UPDATE THELOAI SET TenTL = N'" + txtGenreName.Text + "' WHERE MaTL = " + MaTL;
                    DataConnection.ExecuteQuery(command);
                }

                MessageBox.Show("Cập nhật thể loại thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData_Genre();
            }
            else
            {
                MessageBox.Show("Chưa bật chế độ edit hoặc Chưa chọn thể loại cần sửa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
