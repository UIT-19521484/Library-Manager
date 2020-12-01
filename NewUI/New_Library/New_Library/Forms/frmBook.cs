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
    public partial class frmBook : Form
    {
        private string curBookName;
        private string curAuthorName;
        private string curGenreName;
        private string curPublisherName;
        private int curAvailable;
        private int curBorrowed;

        public frmBook()
        {
            InitializeComponent();
        }
        
        private void frmBook_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            this.btnEdit.BackColor = ThemeColor.PrimaryColor;
            this.btnEdit.ForeColor = Color.White;
            this.btnSearch.BackColor = ThemeColor.PrimaryColor;
            this.btnSearch.ForeColor = Color.White;
            LoadTheme();
            LoadData_Book();
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
            lblAuthor.ForeColor = ThemeColor.SecondaryColor;
            lblBookName.ForeColor = ThemeColor.SecondaryColor;
            lblGenre.ForeColor = ThemeColor.SecondaryColor;
            lblPublisherName.ForeColor = ThemeColor.SecondaryColor;
            lblAvailable.ForeColor = ThemeColor.SecondaryColor;
            lblBorrowed.ForeColor = ThemeColor.SecondaryColor;
        }

        void LoadData_Book()
        {
            string str = @"EXEC sp_select_all_books";
            DataTable dt = DataConnection.GetDataTable(str);
            dgvBook.DataSource = dt;
            dgvBook.BackgroundColor = Color.White;
            dgvBook.HeaderBgColor = ThemeColor.PrimaryColor;
            dgvBook.HeaderForeColor = Color.White;
            dgvBook.GridColor = Color.White;
        }

        private void dgvBook_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.dgvBook.ClearSelection();
        }

        void LoadData_Genre()
        {
            string sqlGenreName = @"EXEC sp_select_all_genres";
            DataTable dt = DataConnection.GetDataTable(sqlGenreName);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cboGenreName.Items.Add(dt.Rows[i]["TÊN THỂ LOẠI"]);
            }    
        }

        private void dgvBook_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = this.dgvBook.Rows[e.RowIndex];
                txtBookName.Text = row.Cells[0].Value.ToString();
                txtAuthorName.Text = row.Cells[1].Value.ToString();
                cboGenreName.Text = row.Cells[2].Value.ToString();
                txtPublisherName.Text = row.Cells[3].Value.ToString();
                txtAvailable.Text = row.Cells[4].Value.ToString();
                txtBorrowed.Text = row.Cells[5].Value.ToString();

                curBookName = txtBookName.Text;
                curAuthorName = txtAuthorName.Text;
                curGenreName = cboGenreName.Text;
                curPublisherName = txtPublisherName.Text;
                curAvailable = Int32.Parse(txtAvailable.Text);
                curBorrowed = Int32.Parse(txtBorrowed.Text);
            }
            catch (Exception)
            { }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtBookName.ReadOnly = !txtBookName.ReadOnly;
            txtAuthorName.ReadOnly = !txtAuthorName.ReadOnly;
            cboGenreName.Enabled = !cboGenreName.Enabled;
            txtPublisherName.ReadOnly = !txtPublisherName.ReadOnly;
            txtAvailable.ReadOnly = !txtAvailable.ReadOnly;
            txtBorrowed.ReadOnly = !txtBorrowed.ReadOnly;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "" || txtSearch.Text == null)
            {
                LoadData_Book();
                return;
            }
            string command = @"EXEC sp_search_books @TuKhoa = N'" + txtSearch.Text + "'";
            DataTable dt = DataConnection.GetDataTable(command);
            this.dgvBook.DataSource = dt;
            dgvBook.BackgroundColor = Color.White;
            dgvBook.HeaderBgColor = ThemeColor.PrimaryColor;
            dgvBook.HeaderForeColor = Color.White;
            dgvBook.GridColor = Color.White;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtAuthorName.ReadOnly == true)
            {
                DataTable dt = DataConnection.GetDataTable(@"EXEC sp_select_book @TenSach = N'" + txtBookName.Text + "', @TacGia = N'" 
                                            + txtAuthorName.Text + "', @NhaXuatBan = N'" + txtPublisherName.Text + "'");
                if (dt.Rows.Count == 1)
                {
                    string command = (@"EXEC sp_delete_book @TenSach = N'" + txtBookName.Text + "', @TacGia = N'"
                                      + txtAuthorName.Text + "', @NhaXuatBan = N'" + txtPublisherName.Text + "'");
                    DataConnection.ExecuteQuery(command);
                    MessageBox.Show("Xóa sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData_Book();
                }    
                else
                {
                    MessageBox.Show("Không tồn tại sách này!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }    
            }    
            else
            {
                MessageBox.Show("Đang trong chế độ edit! Vui lòng tắt trước khi xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtAuthorName.ReadOnly == false)
            {
                if (txtBookName.Text == "" || txtAuthorName.Text == "" || txtPublisherName.Text == "" || cboGenreName.Text == "")
                {
                    MessageBox.Show("Thông tin sách chưa đầy đủ! Hãy nhập lại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int no1, no2;
                bool check1 = Int32.TryParse(txtAvailable.Text, out no1);
                bool check2 = Int32.TryParse(txtBorrowed.Text, out no2);
                if (check1 == false || check2 == false || no1 <= 0 || no2 != 0)
                {
                    MessageBox.Show("Số lượng sách có sẵn phải > 0 và đã mượn phải = 0", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }   
                   
                DataTable dt = DataConnection.GetDataTable(@"EXEC sp_select_book @TenSach = N'" + txtBookName.Text + "', @TacGia = N'"
                                            + txtAuthorName.Text + "', @NhaXuatBan = N'" + txtPublisherName.Text + "'");
                if (dt.Rows.Count == 0)
                {
                    string command = (@"EXEC sp_insert_book @TenSach = N'" + txtBookName.Text + "', @TacGia = N'" + txtAuthorName.Text + "', @NhaXuatBan = N'" 
                                        + txtPublisherName.Text + "', @TenTL = N'" +cboGenreName.Text+ "', @TonTai = " + no1 + ", @DaMuon = " + no2);
                    DataConnection.ExecuteQuery(command);
                    MessageBox.Show("Thêm sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData_Book();
                }
                else
                {
                    MessageBox.Show("Đã tồn tại sách này!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Hãy bật chế độ edit! Điền thông tin sách trước khi thêm!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtAuthorName.ReadOnly == false && this.dgvBook.SelectedRows.Count > 0)
            {
                if (txtBookName.Text == "" || txtAuthorName.Text == "" || txtPublisherName.Text == "" || cboGenreName.Text == "")
                {
                    MessageBox.Show("Thông tin sách chưa đầy đủ! Hãy nhập lại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int no1, no2;
                bool check1 = Int32.TryParse(txtAvailable.Text, out no1);
                bool check2 = Int32.TryParse(txtBorrowed.Text, out no2);
                if (check1 == false || check2 == false || no1 < 0 || no2 < 0)
                {
                    MessageBox.Show("Số lượng sách có sẵn và đã mượn phải >= 0", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DataTable dt = DataConnection.GetDataTable(@"EXEC sp_select_book @TenSach = N'" +curBookName+"', @TacGia = N'"
                                                            +curAuthorName+"', @NhaXuatBan = N'"+curPublisherName+"'");
                int MaSach = Int32.Parse(dt.Rows[0][0].ToString());

                string command = (@"EXEC sp_update_book @MaSach = " + MaSach + ", @TenSach = N'" + txtBookName.Text + "', @TacGia = N'" + txtAuthorName.Text
                                 + "', @NhaXuatBan = N'" + txtPublisherName.Text + "', @TenTL = N'" + cboGenreName.Text + "', @TonTai = " + no1 + ", @DaMuon = " + no2);
                DataConnection.ExecuteQuery(command);
                MessageBox.Show("Cập nhật sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData_Book();

            }
            else
            {
                MessageBox.Show("Chưa bật chế độ edit hoặc Chưa chọn sách cần sửa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(sender, new EventArgs());
            }    
        }
    }
}
