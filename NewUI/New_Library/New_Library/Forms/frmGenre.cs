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
        //DataTable dtGenre = DataConnection.GetDataTable(@"EXEC sp_select_all_genres");
        public frmGenre()
        {
            InitializeComponent();
            //SetupSqlTableDependency();
        }

        //#region SqlTableDependency
        //SqlTableDependency<LibraryEntity.Genre> deGenre;
        //private void SetupSqlTableDependency()
        //{
        //    var mapperGenre = new ModelToTableMapper<LibraryEntity.Genre>();
        //    mapperGenre.AddMapping(c => c.MaTL, "MaTL");
        //    mapperGenre.AddMapping(c => c.TenTL, "TenTL");

        //    deGenre = new SqlTableDependency<LibraryEntity.Genre>(DataConnection.ConnectionString, "THELOAI", mapper: mapperGenre);
        //    deGenre.OnChanged += dbGenreChanged;
        //    deGenre.Start();
        //}

        //public void dbGenreChanged(object sender, RecordChangedEventArgs<LibraryEntity.Genre> e)
        //{
        //    if (IsHandleCreated)
        //    {
        //        switch (e.ChangeType)
        //        {
        //            case TableDependency.SqlClient.Base.Enums.ChangeType.Insert:
        //                DataRow row = dtGenre.NewRow();
        //                row["MaTL"] = e.Entity.MaTL;
        //                row["TÊN THỂ LOẠI"] = e.Entity.TenTL;
        //                dtGenre.Rows.Add(row);

        //                dgvGenre.BeginInvoke(new Action(() => { dgvGenre.Refresh(); }));
        //                break;
        //            case TableDependency.SqlClient.Base.Enums.ChangeType.Delete:
        //                row = dtGenre.Select("MaTL=" + e.Entity.MaTL).FirstOrDefault();
        //                if (row != null)
        //                {
        //                    dtGenre.Rows.Remove(row);
        //                }    

        //                dgvGenre.BeginInvoke(new Action(() => { dgvGenre.Refresh(); dgvGenre.ClearSelection(); }));
        //                break;
        //            case TableDependency.SqlClient.Base.Enums.ChangeType.Update:
        //                row = dtGenre.Select("MaTL=" + e.Entity.MaTL).FirstOrDefault();
        //                if (row != null)
        //                {
        //                    row["TÊN THỂ LOẠI"] = e.Entity.TenTL;
        //                }    

        //                dgvGenre.BeginInvoke(new Action(() => { dgvGenre.Refresh(); }));
        //                break;
        //        }
        //    }    
        //}
        ////#endregion

        private void frmGenre_Load(object sender, EventArgs e)
        {
            LoadData_Genre();
        }

        void LoadData_Genre()
        {
            dgvGenre.DataSource = DatabaseData.dtGenre;
            dgvGenre.Columns["MaTL"].Visible = false;
        }

        private void dgvGenre_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.dgvGenre.ClearSelection();

            this.BeginInvoke(new Action(() => { btnDelete.Enabled = false; btnUpdate.Enabled = false; }));
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
                LoadData_Genre();
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
                    string msg = "Bạn thật sự muốn xóa những thể loại này?\n\n";
                    for (int i = 0; i < dgvGenre.SelectedRows.Count; i++)
                    {
                        msg += (i + 1).ToString() + ". " + dgvGenre.SelectedRows[i].Cells["TenTL"].Value + "\n";
                    }

                    DialogResult rs = MessageBox.Show(msg, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (rs == DialogResult.Yes)
                    {
                        while (dgvGenre.SelectedRows.Count != 0)
                        {
                            string cmd = @"EXEC sp_delete_genre @TenTL = N'" + dgvGenre.SelectedRows[0].Cells["TenTL"].Value + "'";
                            if (DataConnection.ExecuteQuery(cmd))
                            {
                                //MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Thất bại khi xoá" + dgvGenre.SelectedRows[0].Cells["TenTheLoai"].Value, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        MessageBox.Show("Hoàn thành xóa dữ liệu thể loại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    dgvGenre.Refresh();

                    GC.Collect();
                    break;
                default:
                    MessageBox.Show("Có sách đang thuộc thể loại này!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }    
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            (new Genre.frmAddGenre()).ShowDialog();
            dgvGenre.Refresh();
            //this.Enabled = true;
            //this.Owner.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            LibraryEntity.Genre ge = new LibraryEntity.Genre();
            ge.MaTL = (int)dgvGenre.SelectedRows[0].Cells["MaTL"].Value;
            ge.TenTL = dgvGenre.SelectedRows[0].Cells["TenTL"].Value.ToString();
            (new Genre.frmEditGenre(ge)).ShowDialog();
            dgvGenre.Refresh();
        }
    }
}
