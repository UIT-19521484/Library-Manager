using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TableDependency.SqlClient;
using TableDependency.SqlClient.Base;
using TableDependency.SqlClient.Base.EventArgs;

namespace New_Library.Forms
{
    public partial class frmGenre : Form
    {
        DataTable dtGenre;
        public frmGenre()
        {
            InitializeComponent();
            SetupSqlTableDependency();
        }

        #region SqlTableDependency
        SqlTableDependency<LibraryEntity.Genre> deGenre;
        private void SetupSqlTableDependency()
        {
            var mapperGenre = new ModelToTableMapper<LibraryEntity.Genre>();
            mapperGenre.AddMapping(c => c.MaTL, "MaTL");
            mapperGenre.AddMapping(c => c.TenTL, "TenTL");

            deGenre = new SqlTableDependency<LibraryEntity.Genre>(DataConnection.ConnectionString, "THELOAI", mapper: mapperGenre);
            deGenre.OnChanged += dbGenreChanged;
            deGenre.Start();
        }

        public void dbGenreChanged(object sender, RecordChangedEventArgs<LibraryEntity.Genre> e)
        {
            switch (e.ChangeType)
            {
                case TableDependency.SqlClient.Base.Enums.ChangeType.Insert:
                    DataRow row = dtGenre.NewRow();
                    row["MaTL"] = e.Entity.MaTL;
                    row["TÊN THỂ LOẠI"] = e.Entity.TenTL;
                    dtGenre.Rows.Add(row);
                    dgvGenre.BeginInvoke(new Action(() => { dgvGenre.Refresh(); }));
                    break;
                case TableDependency.SqlClient.Base.Enums.ChangeType.Delete:
                    while (dgvGenre.SelectedRows.Count != 0)
                    {
                        row = ((DataRowView)dgvGenre.SelectedRows[0].DataBoundItem).Row;
                        dtGenre.Rows.Remove(row);
                    }
                    dgvGenre.BeginInvoke(new Action(() => { dgvGenre.Refresh(); dgvGenre.ClearSelection(); }));
                    break;
                case TableDependency.SqlClient.Base.Enums.ChangeType.Update:
                    dgvGenre.SelectedRows[0].Cells["MaTL"].Value = e.Entity.MaTL;
                    dgvGenre.SelectedRows[0].Cells["TacGia"].Value = e.Entity.TenTL;
                    dgvGenre.BeginInvoke(new Action(() => { dgvGenre.Refresh(); }));
                    break;
            }
        }
        #endregion

        private void frmGenre_Load(object sender, EventArgs e)
        {
            this.btnSearch.BackColor = ThemeColor.PrimaryColor;
            dgvGenre.HeaderBgColor = ThemeColor.PrimaryColor;
            LoadData_Genre();
        }

        void LoadData_Genre()
        {
            string str = @"EXEC sp_select_all_genres";
            dtGenre = DataConnection.GetDataTable(str);
            dgvGenre.DataSource = dtGenre;
            dgvGenre.Columns["MaTL"].Visible = false;
        }

        private void dgvGenre_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.dgvGenre.ClearSelection();
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
        }

        private void dgvGenre_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (dgvGenre.SelectedRows.Count)
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
                dgvGenre.DataSource = dtGenre;
                return;
            }
            string command = @"EXEC sp_search_genres @TuKhoa = N'" + txtSearch.Text + "'";
            DataTable dt = DataConnection.GetDataTable(command);
            this.dgvGenre.DataSource = dt;
            dgvGenre.Columns["MaTL"].Visible = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
    {                
            DataTable dt = DataConnection.GetDataTable(@"EXEC sp_select_genre @TenTL = N'" + dgvGenre.SelectedRows + "'");

            switch (dt.Rows.Count)
            {
                case 0:
                    string command = @"EXEC sp_delete_genre @TenTL = N'" + dgvGenre.SelectedRows[0].Cells["TenTheLoai"].Value + "'";
                    DataConnection.ExecuteQuery(command);
                    MessageBox.Show("Xóa thể loại thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                default:
                    MessageBox.Show("Có sách đang thuộc thể loại này!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }    
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            (new Genre.frmAddGenre()).ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            LibraryEntity.Genre ge = new LibraryEntity.Genre();
            ge.MaTL = dgvGenre.SelectedRows[0].Cells[1].Value
            (new Genre.frmEditGenre()).ShowDialog();
        }
    }
}
