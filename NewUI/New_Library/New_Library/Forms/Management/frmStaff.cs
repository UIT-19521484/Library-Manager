using System;
using System.Data;
using System.Windows.Forms;

namespace New_Library.Forms
{
    public partial class frmStaff : Form
    {
        public frmStaff()
        {
            InitializeComponent();

            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void frmStaff_Load(object sender, EventArgs e)
        {
            LoadData_Staff();
        }

        void LoadData_Staff()
        {
            dgvStaff.DataSource = DatabaseData.dtStaff;
            dgvStaff.Columns["MaNV"].Visible = false;
        }

        private void dgvStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (dgvStaff.SelectedRows.Count)
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

        private void dgvStaff_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.dgvStaff.ClearSelection();

            dgvStaff.BeginInvoke(new Action(() =>
            {
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }));
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "" || txtSearch.Text == null)
            {
                LoadData_Staff();
                return;
            }
            string command = @"EXEC sp_search_staff @TuKhoa = N'" + txtSearch.Text + "'";
            DataTable dt = DataConnection.GetDataTable(command);
            this.dgvStaff.DataSource = dt;
            
            dgvStaff.Columns["MaNV"].Visible = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string msg = "Bạn thật sự muốn xóa những nhân viên này?\n\n";

            for (int i = 0; i < dgvStaff.SelectedRows.Count; i++)
            {
                msg += (i + 1).ToString() + ". " + dgvStaff.SelectedRows[i].Cells["HoTen"].Value + "\n";
            }

            DialogResult rs = MessageBox.Show(msg, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rs == DialogResult.Yes)
            {
                while (dgvStaff.SelectedRows.Count != 0)
                {
                    //string cmdDelAccount = @"delete from TAIKHOAN where TenTaiKhoan = '" + dgvStaff.SelectedRows[0].Cells["TaiKhoan"].Value.ToString() + "'";
                    string cmdDelStaff = @"EXEC sp_delete_staff @SDT = '" + dgvStaff.SelectedRows[0].Cells["SDT"].Value.ToString() + "'";
                    if (DataConnection.ExecuteQuery(cmdDelStaff) ) //&& DataConnection.ExecuteQuery(cmdDelAccount))
                    {
                        //MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thất bại khi xoá " + dgvStaff.SelectedRows[0].Cells["HoTen"].Value, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                MessageBox.Show("Hoàn thành xóa dữ liệu nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            dgvStaff.Refresh();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            (new Management.Account.frmAddStaff()).ShowDialog();
            dgvStaff.Refresh();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            LibraryEntity.Staff staff = new LibraryEntity.Staff();
            staff.MaNV = (int)dgvStaff.SelectedRows[0].Cells["MaNV"].Value;
            staff.HoTen = dgvStaff.SelectedRows[0].Cells["HoTen"].Value.ToString();
            staff.NgaySinh = (DateTime)dgvStaff.SelectedRows[0].Cells["NgaySinh"].Value;
            staff.GioiTinh = dgvStaff.SelectedRows[0].Cells["GioiTinh"].Value.ToString();
            staff.DiaChi = dgvStaff.SelectedRows[0].Cells["DiaChi"].Value.ToString();
            staff.SDT = dgvStaff.SelectedRows[0].Cells["SDT"].Value.ToString();

            (new Management.Account.frmEditStaff(staff)).ShowDialog();
            dgvStaff.Refresh();
        }
    }
}
