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
        //DataTable dtBook = DataConnection.GetDataTable(@"EXEC sp_select_all_books");
        //DataTable dtGenre = DataConnection.GetDataTable("sp_select_all_genres");

        public frmBook()
        {
            InitializeComponent();
            //SetupSqlTableDependency();
        }

        private void frmBook_Load(object sender, EventArgs e)
        {
            LoadData_Book();
            LoadData_Genre();
            LoadData_Author();
            LoadData_Publisher();
        }

        #region Load data
        private void LoadData_Book()
        {
            dgvBook.DataSource = DatabaseData.dtBook;
            dgvBook.Columns["MaSach"].Visible = false;
        }

        public void LoadData_Genre()
        {
            DataTable dt = DatabaseData.dtGenre.Copy();
            DataRow dr = dt.NewRow();
            dr[1] = "Tất cả thể loại";
            dt.Rows.InsertAt(dr, 0);

            cbGenre.DisplayMember = dt.Columns[1].ToString();
            cbGenre.DataSource = dt;
        }

        public void LoadData_Publisher()
        {
            System.Collections.Generic.List<string> publisher = (from DataRow publisherName in DatabaseData.dtBook.Rows
                                                                 select (string)publisherName["NHÀ XUẤT BẢN"]).Distinct().ToList();
            publisher.Insert(0, "Tất cả nhà xuất bản");
            cbPublisher.DataSource = publisher;
        }

        public void LoadData_Author()
        {
            System.Collections.Generic.List<string> author = (from DataRow authorName in DatabaseData.dtBook.Rows
                                                              select (string)authorName["TÁC GIẢ"]).Distinct().ToList();
            author.Insert(0, "Tất cả tác giả");
            cbAuthor.DataSource = author;
        }
        #endregion

        //#region SqlTableDependency
        //private void dbBookChanged(object sender, RecordChangedEventArgs<LibraryEntity.Book> e)
        //{
        //    if (IsHandleCreated)
        //    {
        //        switch (e.ChangeType)
        //        {
        //            case TableDependency.SqlClient.Base.Enums.ChangeType.Insert:
        //                DataRow row = dtBook.NewRow();
        //                row["MaSach"] = e.Entity.MaSach;
        //                row["TÊN SÁCH"] = e.Entity.TenSach;
        //                row["TÁC GIẢ"] = e.Entity.TacGia;
        //                row["THỂ LOẠI"] = (from DataRow dr in dtGenre.Rows
        //                                   where dr["MaTL"].ToString() == e.Entity.MaTL.ToString()
        //                                   select dr["TÊN THỂ LOẠI"]).FirstOrDefault();
        //                row["NHÀ XUẤT BẢN"] = e.Entity.NhaXB;
        //                row["CÓ SẴN"] = e.Entity.TonTai;
        //                row["ĐÃ MƯỢN"] = e.Entity.DaMuon;
        //                dtBook.Rows.Add(row);
        //                dgvBook.BeginInvoke(new Action(() => { dgvBook.Refresh(); }));
        //                break;
        //            case TableDependency.SqlClient.Base.Enums.ChangeType.Delete:
        //                row = dtBook.Select("MaSach=" + e.Entity.MaSach).FirstOrDefault();
        //                if (row != null)
        //                {
        //                    row.Delete();
        //                }
        //                break;
        //            case TableDependency.SqlClient.Base.Enums.ChangeType.Update:
        //                row = dtBook.Select("MaSach=" + e.Entity.MaSach).FirstOrDefault();
        //                if (row != null)
        //                {
        //                    row["MaSach"] = e.Entity.MaSach;
        //                    row["TÊN SÁCH"] = e.Entity.TenSach;
        //                    row["TÁC GIẢ"] = e.Entity.TacGia;
        //                    row["THỂ LOẠI"] = (from DataRow dr in dtGenre.Rows
        //                                       where dr["MaTL"].ToString() == e.Entity.MaTL.ToString()
        //                                       select dr["TÊN THỂ LOẠI"]).FirstOrDefault();
        //                    row["NHÀ XUẤT BẢN"] = e.Entity.NhaXB;
        //                    row["CÓ SẴN"] = e.Entity.TonTai;
        //                    row["ĐÃ MƯỢN"] = e.Entity.DaMuon;
        //                }
        //                row.AcceptChanges();
        //                break;
        //        }
        //        cbAuthor.BeginInvoke(new Action(LoadData_Author));
        //        cbPublisher.BeginInvoke(new Action(LoadData_Publisher));
        //    }
        //}

        //public void dbGenreChanged(object sender, RecordChangedEventArgs<LibraryEntity.Genre> e)
        //{
        //    if (IsHandleCreated)
        //    {
        //        cbGenre.BeginInvoke(new Action(LoadData_Genre));
        //    }
        //}

        //SqlTableDependency<LibraryEntity.Book> deBook;
        //SqlTableDependency<LibraryEntity.Genre> deGenre;
        //private void SetupSqlTableDependency()
        //{
        //    var mapperBook = new ModelToTableMapper<LibraryEntity.Book>();
        //    mapperBook.AddMapping(c => c.MaSach, "MaSach");
        //    mapperBook.AddMapping(c => c.TenSach, "TenSach");
        //    mapperBook.AddMapping(c => c.NhaXB, "NhaXuatBan");
        //    mapperBook.AddMapping(c => c.MaTL, "MaTL");
        //    mapperBook.AddMapping(c => c.TacGia, "TacGia");
        //    mapperBook.AddMapping(c => c.TonTai, "TonTai");
        //    mapperBook.AddMapping(c => c.DaMuon, "DaMuon");

        //    deBook = new SqlTableDependency<LibraryEntity.Book>(DataConnection.ConnectionString, "SACH", mapper: mapperBook);
        //    deBook.OnChanged += dbBookChanged;
        //    deBook.Start();

        //    var mapperGenre = new ModelToTableMapper<LibraryEntity.Genre>();
        //    mapperGenre.AddMapping(c => c.MaTL, "MaTL");
        //    mapperGenre.AddMapping(c => c.TenTL, "TenTL");

        //    deGenre = new SqlTableDependency<LibraryEntity.Genre>(DataConnection.ConnectionString, "THELOAI", mapper: mapperGenre);
        //    deGenre.OnChanged += dbGenreChanged;
        //    deGenre.Start();
        //}
        //#endregion

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
            ((DataTable)dgvBook.DataSource).DefaultView.RowFilter = RowFilter();
        }

        private void cbGenre_Leave(object sender, EventArgs e)
        {

            if (cbGenre.SelectedItem == null)
            {
                cbGenre.SelectedIndex = 0;
            }
        }

        private void cbAuthor_Leave(object sender, EventArgs e)
        {
            if (cbAuthor.SelectedItem == null)
            {
                cbAuthor.SelectedIndex = 0;
            }
        }

        private void cbPublisher_Leave(object sender, EventArgs e)
        {
            if (cbPublisher.SelectedItem == null)
            {
                cbPublisher.SelectedIndex = 0;
            }
        }

        private void cbAuthor_Enter(object sender, EventArgs e)
        {
            LoadData_Author();
        }

        private void cbGenre_Enter(object sender, EventArgs e)
        {
            LoadData_Genre();
        }

        private void cbPublisher_Enter(object sender, EventArgs e)
        {
            LoadData_Publisher();
        }
        #endregion

        private void dgvBook_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.dgvBook.ClearSelection();

            this.BeginInvoke(new Action(() =>
            {
                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;
            }));
        }

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
            dgvBook.Columns["MaSach"].Visible = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
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
                while (dgvBook.SelectedRows.Count != 0)
                {
                    string cmd = @"EXEC sp_delete_book @MaSach = " + dgvBook.SelectedRows[0].Cells["MaSach"].Value.ToString();
                    if (DataConnection.ExecuteQuery(cmd))
                    {
                        //MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thất bại khi xoá" + dgvBook.SelectedRows[0].Cells["TenSach"].Value, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                MessageBox.Show("Hoàn thành xóa dữ liệu sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            dgvBook.Refresh();
            GC.Collect();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            (new Forms.Book.frmAddBook()).ShowDialog();
            dgvBook.Refresh();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            LibraryEntity.Book book = new LibraryEntity.Book();

            book.MaSach = (int)dgvBook.SelectedRows[0].Cells["MaSach"].Value;
            book.TenSach = (string)dgvBook.SelectedRows[0].Cells["TenSach"].Value;
            book.TacGia = (string)dgvBook.SelectedRows[0].Cells["TacGia"].Value;
            book.MaTL = (int)(from DataRow dr in DatabaseData.dtGenre.Rows
                              where dr["TÊN THỂ LOẠI"].ToString() == (string)dgvBook.SelectedRows[0].Cells["TheLoai"].Value
                              select dr["MaTL"]).FirstOrDefault();
            book.NhaXB = (string)dgvBook.SelectedRows[0].Cells["NhaXuatBan"].Value;
            book.TonTai = (int)dgvBook.SelectedRows[0].Cells["CoSan"].Value;

            (new Forms.Book.frmEditBook(book)).ShowDialog();
            dgvBook.Refresh();
        }
    }
}