using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Manager_UI
{
    public partial class frmGenres : Form
    {
        public frmGenres()
        {
            InitializeComponent();
            LoadDataGridView_Genres();
            LoadComboBox_Genres();
        }

        void LoadDataGridView_Genres()
        {
            string str = @"select * from TheLoaiSach";
            DataTable dt = DataConnection.GetDataTable(str);
            dgvGenres.DataSource = dt;
        }
        void LoadComboBox_Genres()
        {
            string str = @"select * from TheLoaiSach";
            cboGenreCode.DisplayMember = "MaTL";
            cboGenreCode.DataSource = DataConnection.GetDataTable(str);
            DataTable dt = DataConnection.GetDataTable(str);
            dgvGenres.DataSource = dt;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string them = @"insert into TheLoaiSach (MaTL, TenTheLoai) values ('" + cboGenreCode.Text + "', N'" + txtGenreName.Text + "')";

            if (cboGenreCode.Text == "")
                MessageBox.Show("Mã sách không được trống!");
            else
            {
                DataTable dt = DataConnection.GetDataTable("Select * from TheLoaiSach where MaTL = '" + cboGenreCode.Text + "'");
                if (dt.Rows.Count <= 0)
                {
                    try
                    {
                        DataConnection.ExecuteQuery(them);
                        MessageBox.Show("Thêm thể loại sách thành công!!");
                        LoadDataGridView_Genres();
                    }
                    catch (Exception) { }
                }
                else
                {
                    MessageBox.Show("Mã thể loại đã tồn tại!");
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //mã ko sửa được
            string up = @"update TheLoaiSach set MaTL='" + cboGenreCode.Text + "',TenTheLoai=N'" + txtGenreName.Text + "' where MaTL='" + cboGenreCode.Text + "'";
            if (cboGenreCode.Text == "")
                MessageBox.Show("Mã Thể Loại không được để trống!");
            else
            {
                DataConnection.ExecuteQuery(up);
                LoadDataGridView_Genres();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string xoa = @"delete from TheLoaiSach where MaTL='" + cboGenreCode.Text + "'";

            if (cboGenreCode.Text == "")
            {
                MessageBox.Show("Mã Thể Loại không được để trống!");
            }
            else
            {
                DataTable dt = DataConnection.GetDataTable(@"select * from TheLoaiSach");
                if (dt.Rows.Count > 0)
                {
                    DialogResult dialog = MessageBox.Show("Bạn có muốn xóa thể loại " + txtGenreName.Text + " không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialog == DialogResult.Yes)
                    {
                        try
                        {
                            DataConnection.ExecuteQuery(xoa);
                            MessageBox.Show("Xóa thể loại sách thành công!");
                            LoadDataGridView_Genres();
                        }
                        catch (Exception)
                        {
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Mã Thể Loại không tồn tại!");
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string str = @"select * from TheLoaiSach where MaTL LIKE N'%" + txtSearch.Text + "%' or TenTheLoai LIKE N'%" + txtSearch.Text + "%'";

            DataTable dt = DataConnection.GetDataTable(str);
            dgvGenres.DataSource = dt;
        }

        private void dgvGenres_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvGenres.Rows[e.RowIndex];
                cboGenreCode.Text = row.Cells[0].Value.ToString();
                txtGenreName.Text = row.Cells[1].Value.ToString();
            }
            catch (Exception)
            { }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void frmGenres_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }
    }
}
