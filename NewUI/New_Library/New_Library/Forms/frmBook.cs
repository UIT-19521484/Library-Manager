using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

using TableDependency.SqlClient;
using TableDependency.SqlClient.Base;
using TableDependency.SqlClient.Base.EventArgs;

namespace New_Library.Forms
{
    public partial class frmBook : Form
    {
        DataTable dtBook;
        DataTable dtGenre;

        public frmBook()
        {
            InitializeComponent();
            SetupSqlTableDependency();
        }

        private void frmBook_Load(object sender, EventArgs e)
        {
            this.btnSearch.BackColor = ThemeColor.PrimaryColor;

            LoadData_Book();
            LoadData_Genre();
            LoadData_Author();
            LoadData_Publisher();
        }

        #region Load data
        private void LoadData_Book()
        {
            dtBook = DataConnection.GetDataTable(@"EXEC sp_select_all_books");
            dgvBook.DataSource = dtBook;
            dgvBook.Columns["MaSach"].Visible = false;
        }

        private void LoadData_Genre()
        {
            dtGenre = DataConnection.GetDataTable("sp_select_all_genres");
            DataRow dr = dtGenre.NewRow();
            dr[1] = "Tất cả thể loại";
            dtGenre.Rows.InsertAt(dr, 0);

            cbGenre.DisplayMember = dtGenre.Columns[1].ToString();
            cbGenre.DataSource = dtGenre;
        }

        private void LoadData_Publisher()
        {
            System.Collections.Generic.List<string> publisher = (from DataRow publisherName in dtBook.Rows
                                                                 select (string)publisherName["NHÀ XUẤT BẢN"]).Distinct().ToList();
            publisher.Insert(0, "Tất cả nhà xuất bản");
            cbPublisher.DataSource = publisher;
        }

        private void LoadData_Author()
        {
            System.Collections.Generic.List<string> author = (from DataRow authorName in dtBook.Rows
                                                              select (string)authorName["TÁC GIẢ"]).Distinct().ToList();
            author.Insert(0, "Tất cả tác giả");
            cbAuthor.DataSource = author;
        }
        #endregion

        #region SqlTableDependency
        private void dbBookChanged(object sender, RecordChangedEventArgs<LibraryEntity.Book> e)
        {
            if (IsHandleCreated)
            {
                switch (e.ChangeType)
                {
                    case TableDependency.SqlClient.Base.Enums.ChangeType.Insert:
                        DataRow row = dtBook.NewRow();
                        row["MaSach"] = e.Entity.MaSach;
                        row["TÊN SÁCH"] = e.Entity.TenSach;
                        row["TÁC GIẢ"] = e.Entity.TacGia;
                        row["THỂ LOẠI"] = (from DataRow dr in dtGenre.Rows
                                           where dr["MaTL"].ToString() == e.Entity.MaTL.ToString()
                                           select dr["TÊN THỂ LOẠI"]).FirstOrDefault();
                        row["NHÀ XUẤT BẢN"] = e.Entity.NhaXB;
                        row["CÓ SẴN"] = e.Entity.TonTai;
                        row["ĐÃ MƯỢN"] = e.Entity.DaMuon;
                        dtBook.Rows.Add(row);
                        dgvBook.BeginInvoke(new Action(() => { dgvBook.Refresh(); }));
                        break;
                    case TableDependency.SqlClient.Base.Enums.ChangeType.Delete:
                        while (dgvBook.SelectedRows.Count != 0)
                        {
                            row = ((DataRowView)dgvBook.SelectedRows[0].DataBoundItem).Row;
                            dtBook.Rows.Remove(row);
                        }
                        dgvBook.BeginInvoke(new Action(() => { dgvBook.Refresh(); dgvBook.ClearSelection(); }));
                        break;
                    case TableDependency.SqlClient.Base.Enums.ChangeType.Update:
                        dgvBook.SelectedRows[0].Cells["TenSach"].Value = e.Entity.TenSach;
                        dgvBook.SelectedRows[0].Cells["TacGia"].Value = e.Entity.TacGia;
                        dgvBook.SelectedRows[0].Cells["TheLoai"].Value = (from DataRow dr in dtGenre.Rows
                                                                          where dr["MaTL"].ToString() == e.Entity.MaTL.ToString()
                                                                          select dr["TÊN THỂ LOẠI"]).FirstOrDefault();
                        dgvBook.SelectedRows[0].Cells["NhaXuatBan"].Value = e.Entity.NhaXB;
                        dgvBook.SelectedRows[0].Cells["CoSan"].Value = e.Entity.TonTai;
                        dgvBook.BeginInvoke(new Action(() => { dgvBook.Refresh(); }));
                        break;
                }
                cbAuthor.BeginInvoke(new Action(LoadData_Author));
                cbPublisher.BeginInvoke(new Action(LoadData_Publisher));
            }
        }

        public void dbGenreChanged(object sender, RecordChangedEventArgs<LibraryEntity.Genre> e)
        {
            if (IsHandleCreated)
            {
                cbGenre.BeginInvoke(new Action(LoadData_Genre));
            }
        }

        SqlTableDependency<LibraryEntity.Book> deBook;
        SqlTableDependency<LibraryEntity.Genre> deGenre;
        private void SetupSqlTableDependency()
        {
            var mapperBook = new ModelToTableMapper<LibraryEntity.Book>();
            mapperBook.AddMapping(c => c.MaSach, "MaSach");
            mapperBook.AddMapping(c => c.TenSach, "TenSach");
            mapperBook.AddMapping(c => c.NhaXB, "NhaXuatBan");
            mapperBook.AddMapping(c => c.MaTL, "MaTL");
            mapperBook.AddMapping(c => c.TacGia, "TacGia");
            mapperBook.AddMapping(c => c.TonTai, "TonTai");
            mapperBook.AddMapping(c => c.DaMuon, "DaMuon");

            deBook = new SqlTableDependency<LibraryEntity.Book>(DataConnection.ConnectionString, "SACH", mapper: mapperBook);
            deBook.OnChanged += dbBookChanged;
            deBook.Start();

            var mapperGenre = new ModelToTableMapper<LibraryEntity.Genre>();
            mapperGenre.AddMapping(c => c.MaTL, "MaTL");
            mapperGenre.AddMapping(c => c.TenTL, "TenTL");

            deGenre = new SqlTableDependency<LibraryEntity.Genre>(DataConnection.ConnectionString, "THELOAI", mapper: mapperGenre);
            deGenre.OnChanged += dbGenreChanged;
            deGenre.Start();
        }
        #endregion

        private void dgvBook_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.dgvBook.ClearSelection();
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "" || txtSearch.Text == null)
            {
                dgvBook.DataSource = dtBook;
                return;
            }
            string command = @"EXEC sp_search_books @TuKhoa = N'" + txtSearch.Text + "'";
            DataTable dt = DataConnection.GetDataTable(command);

            this.dgvBook.DataSource = dt;
            dgvBook.Columns["MaSach"].Visible = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string cmd = @"EXEC sp_delete_book @MaSach = " + dgvBook.SelectedRows[0].Cells["MaSach"].Value.ToString();

            string msg = "Bạn thật sự muốn xóa những cuốn sách này?\n\n";

            for (int i = 0; i < dgvBook.SelectedRows.Count; i++)
            {
                msg += (i + 1).ToString() + ". " + dgvBook.SelectedRows[i].Cells["TenSach"].Value
                                    + " - Tác giả: " + dgvBook.SelectedRows[i].Cells["TacGia"].Value
                                    + " - Nhà xuất bản: " + dgvBook.SelectedRows[i].Cells["NhaXuatBan"].Value
                                    + "\n";
            }

            DialogResult rs = MessageBox.Show(msg, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rs == DialogResult.Yes)
            {
                if (DataConnection.ExecuteQuery(cmd))
                {
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            GC.Collect();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            (new Forms.Book.frmAddBook()).ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            LibraryEntity.Book book = new LibraryEntity.Book();

            book.MaSach = (int)dgvBook.SelectedRows[0].Cells["MaSach"].Value;
            book.TenSach = (string)dgvBook.SelectedRows[0].Cells["TenSach"].Value;
            book.TacGia = (string)dgvBook.SelectedRows[0].Cells["TacGia"].Value;
            book.MaTL = (int)(from DataRow dr in dtGenre.Rows
                              where dr["TÊN THỂ LOẠI"].ToString() == (string)dgvBook.SelectedRows[0].Cells["TheLoai"].Value
                              select dr["MaTL"]).FirstOrDefault();
            book.NhaXB = (string)dgvBook.SelectedRows[0].Cells["NhaXuatBan"].Value;
            book.TonTai = (int)dgvBook.SelectedRows[0].Cells["CoSan"].Value;

            (new Forms.Book.frmEditBook(book)).ShowDialog();
        }

        #region Filter
        private string RowFilter()
        {
            string columnGenreFilter = "";
            string columnAuthorFilter = "";
            string columnPulisherFilter = "";

            string rowFilter;

            switch (cbGenre.SelectedIndex)
            {
                case 0:
                    break;
                default:
                    columnGenreFilter = string.Format("[THỂ LOẠI] = '{0}'", cbGenre.Text);
                    break;
            }

            switch (cbAuthor.SelectedIndex)
            {
                case 0:
                    break;
                default:
                    columnAuthorFilter = string.Format("[TÁC GIẢ] = '{0}'", cbAuthor.Text);
                    break;
            }

            switch (cbPublisher.SelectedIndex)
            {
                case 0:
                    break;
                default:
                    columnPulisherFilter = string.Format("[NHÀ XUẤT BẢN] = '{0}'", cbPublisher.Text);
                    break;
            }

            rowFilter = columnGenreFilter;
            if (rowFilter != "" && columnAuthorFilter != "")
            {
                rowFilter += " and " + columnAuthorFilter;
            }
            else
            {
                rowFilter += columnAuthorFilter;
            }
            if (rowFilter != "" && columnPulisherFilter != "")
            {
                rowFilter += " and " + columnPulisherFilter;
            }
            else
            {
                rowFilter += columnPulisherFilter;
            }

            return rowFilter;
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtBook.DefaultView.RowFilter = RowFilter();
        }
        #endregion

        private void dgvBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (dgvBook.SelectedRows.Count)
            {
                case 0:
                    btnDelete.Enabled = false;
                    btnUpdate.Enabled = false;
                    break;
                default:
                    btnDelete.Enabled = true;
                    btnUpdate.Enabled = true;
                    break;
            }
        }
    }
}