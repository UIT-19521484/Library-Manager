using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

using TableDependency.SqlClient;
using TableDependency.SqlClient.Base;
using TableDependency.SqlClient.Base.EventArgs;

namespace New_Library.Forms
{
    public partial class frmBook : Form
    {
        /*private string curBookName;
        private string curAuthorName;
        private string curGenreName;
        private string curPublisherName;
        private int curAvailable;
        private int curBorrowed;*/

        DataTable dtBook = new DataTable();

        public frmBook()
        {
            InitializeComponent();
            SetupSqlTableDependency();
        }

        public class Book
        {
            private int maSach;
            private string tenSach;
            private string tacGia;
            private string nhaXB;
            private int maTL;
            private int tonTai;
            private int daMuon;

            public int MaSach { get => maSach; set => maSach = value; }
            public string TenSach { get => tenSach; set => tenSach = value; }
            public string TacGia { get => tacGia; set => tacGia = value; }
            public string NhaXB { get => nhaXB; set => nhaXB = value; }
            public int TonTai { get => tonTai; set => tonTai = value; }
            public int DaMuon { get => daMuon; set => daMuon = value; }
            public int MaTL { get => maTL; set => maTL = value; }
        }

        private void frmBook_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            this.btnSearch.BackColor = ThemeColor.PrimaryColor;
            this.btnSearch.ForeColor = Color.White;

            LoadData_Book();
            LoadData_Genre();
        }

        public void Changed(object sender, RecordChangedEventArgs<Book> e)
        {
            dgvBook.BeginInvoke(new Action(() => 
            {
                string str = @"EXEC sp_select_all_books";

                dtBook = DataConnection.GetDataTable(str);
                dgvBook.DataSource = dtBook;
                dgvBook.Columns["MaSach"].Visible = false;
            }));
        }

        SqlTableDependency<Book> de;
        private void SetupSqlTableDependency()
        {
            var mapper = new ModelToTableMapper<Book>();
            mapper.AddMapping(c => c.MaSach, "MaSach");
            mapper.AddMapping(c => c.TenSach, "TenSach");
            mapper.AddMapping(c => c.NhaXB, "NhaXuatBan");
            mapper.AddMapping(c => c.MaTL, "MaTL");
            mapper.AddMapping(c => c.TacGia, "TacGia");
            mapper.AddMapping(c => c.TonTai, "TonTai");
            mapper.AddMapping(c => c.DaMuon, "DaMuon");

            de = new SqlTableDependency<Book>(DataConnection.ConnectionString, "SACH", mapper: mapper);
            de.OnChanged += Changed;
            de.Start();
        }

        private void LoadData_Book()
        {
            string str = @"EXEC sp_select_all_books";

            dtBook = DataConnection.GetDataTable(str);
            dgvBook.DataSource = dtBook;
            dgvBook.Columns["MaSach"].Visible = false;
        }

        private void LoadData_Genre()
        {
            DataTable dt = DataConnection.GetDataTable("sp_select_all_genres");
            DataRow dr = dt.NewRow();
            dr[0] = "Tất cả thể loại";
            dt.Rows.InsertAt(dr, 0);

            cbGenre.DisplayMember = "TÊN THỂ LOẠI";
            cbGenre.DataSource = dt;
        }

        private void dgvBook_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.dgvBook.ClearSelection();
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
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string cmd = @"EXEC sp_delete_book @MaSach = " + dgvBook.SelectedRows[0].Cells["MaSach"].Value.ToString();

            string msg = "Bạn thật sự muốn xóa những cuốn sách này?\n\n";

            for (int i = 0; i < dgvBook.SelectedRows.Count; i++)
            {
                msg += (i + 1).ToString() + ". " + dgvBook.SelectedRows[i].Cells["TenSach"].Value
                                    + " - " + dgvBook.SelectedRows[i].Cells["TacGia"].Value
                                    + " - " + dgvBook.SelectedRows[i].Cells["NhaXuatBan"].Value
                                    + "\n\n";
            }

            DialogResult rs = MessageBox.Show(msg, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rs == DialogResult.Yes)
            {
                if (DataConnection.ExecuteQuery(cmd))
                {
                    MessageBox.Show("Xóa thành công");
                }
                else
                {
                    MessageBox.Show("Thất bại");
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

        }
    }
}