using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New_Library.Forms
{
    public partial class frmReader : Form
    {
        public frmReader()
        {
            InitializeComponent();
        }

        private void frmReader_Load(object sender, EventArgs e)
        {
            this.btnSearch.BackColor = ThemeColor.PrimaryColor;
            LoadData_Reader();
        }

        void LoadData_Reader()
        {
            dgvReader.HeaderBgColor = ThemeColor.PrimaryColor;
            dgvReader.DataSource = DatabaseData.dtReader;
            dgvReader.Columns["MaDG"].Visible = false;
        }

        private void dgvReader_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (dgvReader.SelectedRows.Count)
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

        private void dgvReader_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.dgvReader.ClearSelection();
            this.BeginInvoke(new Action(() => { btnDelete.Enabled = false; btnUpdate.Enabled = false; }));
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "" || txtSearch.Text == null)
            {
                LoadData_Reader();
                return;
            }
            string command = @"EXEC sp_search_readers @TuKhoa = N'" + txtSearch.Text + "'";
            DataTable dt = DataConnection.GetDataTable(command);
            this.dgvReader.DataSource = dt;
            dgvReader.HeaderBgColor = ThemeColor.PrimaryColor;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string msg = "Bạn thật sự muốn xóa những người đọc này?\n\n";
            for (int i = 0; i < dgvReader.SelectedRows.Count; i++)
            {
                msg += (i + 1).ToString() + ". " + dgvReader.SelectedRows[i].Cells["HoTen"].Value + "\n";
            }

            DialogResult rs = MessageBox.Show(msg, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rs == DialogResult.Yes)
            {
                while (dgvReader.SelectedRows.Count != 0)
                {
                    string command = (@"EXEC sp_delete_reader @SDT = '" + dgvReader.SelectedRows[0].Cells["SDT"].Value + "', @Email = '" + dgvReader.SelectedRows[0].Cells["Email"].Value + "'");

                    if (!DataConnection.ExecuteQuery(command))
                    {
                        MessageBox.Show("Thất bại khi xoá " + dgvReader.SelectedRows[0].Cells["HoTen"].Value, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                MessageBox.Show("Hoàn thành xóa dữ liệu người đọc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            dgvReader.Refresh();
            //GC.Collect();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            (new Reader.frmAddReader()).ShowDialog();
            dgvReader.Refresh();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            LibraryEntity.Reader reader = new LibraryEntity.Reader();
            reader.MaDG = (int)dgvReader.SelectedRows[0].Cells["MaDG"].Value;
            reader.HoTen = dgvReader.SelectedRows[0].Cells["HoTen"].Value.ToString();
            reader.GioiTinh = dgvReader.SelectedRows[0].Cells["GioiTinh"].Value.ToString();
            reader.NgaySinh = (DateTime)dgvReader.SelectedRows[0].Cells["NgaySinh"].Value;
            reader.SDT = dgvReader.SelectedRows[0].Cells["SDT"].Value.ToString();
            reader.Email = dgvReader.SelectedRows[0].Cells["Email"].Value.ToString();
            reader.DiaChi = dgvReader.SelectedRows[0].Cells["DiaChi"].Value.ToString();

            (new Forms.Reader.frmEditReader(reader)).ShowDialog();
            dgvReader.Refresh();
        }
    }
}
