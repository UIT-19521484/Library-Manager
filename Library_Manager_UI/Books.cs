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
    public partial class frmBooks : Form
    {
        public frmBooks()
        {
            InitializeComponent();
            LoadData_Books();
            LoadData_GenreCode();
        }

        void LoadData_Books()
        {
            string str = @"select * from Sach";
            DataTable dt = DataConnection.GetDataTable(str);
            dgvBooks.DataSource = dt;
        }
        void LoadData_GenreCode()
        {
            string sqlGenreCode = "select * from TheLoaiSach";
            cboGenreCode.DisplayMember = "MaTL";
            cboGenreCode.DataSource = DataConnection.GetDataTable(sqlGenreCode);
        }

        private void dgvBooks_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvBooks.Rows[e.RowIndex];
                txtBookCode.Text = row.Cells[0].Value.ToString();
                cboGenreCode.Text = row.Cells[1].Value.ToString();
                txtBookName.Text = row.Cells[2].Value.ToString();
                txtAuthor.Text = row.Cells[3].Value.ToString();
                txtPublisher.Text = row.Cells[4].Value.ToString();
                txtAvailable.Text = row.Cells[5].Value.ToString();
                txtBorrowTimes.Text = row.Cells[6].Value.ToString();
            }
            catch (Exception)
            { }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string them = @"insert into Sach(MaSach,MaTL,TenSach,TacGia,NhaXuatBan,TonTai,SoLanMuon) values ('" + txtBookCode.Text + "','" + cboGenreCode.Text + "',N'" 
                            + txtBookName.Text + "',N'" + txtAuthor.Text + "',N'" + txtPublisher.Text + "', CAST('" + txtAvailable.Text + "' AS int), CAST('" + txtBorrowTimes.Text + "' AS int))";

            if (txtBookCode.Text == "")
                MessageBox.Show("Mã sách không được trống!");
            else
            {
                DataTable dt = DataConnection.GetDataTable("Select * from Sach where MaSach = '" + txtBookCode.Text + "'");
                if (dt.Rows.Count <= 0)
                {
                    try
                    {
                        DataConnection.ExecuteQuery(them);
                        MessageBox.Show("Thêm sách thành công!!");
                        LoadData_Books();
                    }
                    catch (Exception) { }
                }
                else
                {
                    MessageBox.Show("Mã sách đã tồn tại!");
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string xoa = @"delete from Sach where MaSach='" + txtBookCode.Text + "'";
            if (txtBookCode.Text == "")
                MessageBox.Show("Mã sách không được trống!");
            else
            {
                DataTable dt = DataConnection.GetDataTable("Select * from Sach where MaSach = '" + txtBookCode.Text + "'");
                if (dt.Rows.Count > 0)
                {
                    DialogResult dialog = MessageBox.Show("Bạn có muốn xóa sách có tựa " + txtBookName.Text + " không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialog == DialogResult.Yes)
                    {
                        try
                        {
                            DataConnection.ExecuteQuery(xoa);
                            MessageBox.Show("Xóa sách thành công!!");
                            LoadData_Books();
                        }
                        catch (Exception)
                        {
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Mã sách không tồn tại!");
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //mã sách luôn không đổi
            try
            {
                string capnhat = @"update Sach set MaSach='" + txtBookCode.Text + "',MaTL='" + cboGenreCode.Text + "',TenSach=N'" + txtBookName.Text + "',TacGia=N'" + txtAuthor.Text + "',NhaXuatBan=N'" + txtPublisher.Text + "',TonTai='" + txtAvailable.Text + "',SoLanMuon='" + txtBorrowTimes.Text + "' where MaSach='" + txtBookCode.Text + "'";
                DataConnection.ExecuteQuery(capnhat);
                MessageBox.Show("Cập nhật thành công!!");
                LoadData_Books();
            }
            catch (Exception)
            {
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string str = @"select * from Sach where MaSach LIKE N'%" + txtSearch.Text + "%' or TenSach LIKE N'%" + txtSearch.Text + "%' or TacGia LIKE N'%" 
                        + txtSearch.Text + "%' or NhaXuatBan LIKE N'%" + txtSearch.Text + "%' or MaTL LIKE '%" + txtSearch.Text + "%'";
            DataTable dt = DataConnection.GetDataTable(str);
            dgvBooks.DataSource = dt;
        }

        private void frmBooks_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }

        
    }
}
