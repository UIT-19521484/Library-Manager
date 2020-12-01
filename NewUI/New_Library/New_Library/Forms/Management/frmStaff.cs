using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New_Library.Forms
{
    public partial class frmStaff : Form
    {
        private string curPhone;
        public frmStaff()
        {
            InitializeComponent();
        }

        private void frmStaff_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            this.btnEdit.BackColor = ThemeColor.PrimaryColor;
            this.btnEdit.ForeColor = Color.White;
            this.btnSearch.BackColor = ThemeColor.PrimaryColor;
            this.btnSearch.ForeColor = Color.White;
            LoadTheme();
            LoadData_Staff();
            LoadData_AccountName();
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
            lblStaffName.ForeColor = ThemeColor.SecondaryColor;
            lblAddress.ForeColor = ThemeColor.SecondaryColor;
            lblPhone.ForeColor = ThemeColor.SecondaryColor;
            lblSex.ForeColor = ThemeColor.SecondaryColor;
            lblDateOfBirth.ForeColor = ThemeColor.SecondaryColor;
            lblAccountName.ForeColor = ThemeColor.SecondaryColor;
        }

        void LoadData_Staff()
        {
            string str = @"EXEC sp_select_all_staff";
            DataTable dt = DataConnection.GetDataTable(str);
            dgvStaff.DataSource = dt;
            dgvStaff.BackgroundColor = Color.White;
            dgvStaff.HeaderBgColor = ThemeColor.PrimaryColor;
            dgvStaff.HeaderForeColor = Color.White;
            dgvStaff.GridColor = Color.White;
        }

        void LoadData_AccountName()
        {
            string sqlGenreName = "EXEC sp_select_all_account_name";
            DataTable dt = DataConnection.GetDataTable(sqlGenreName);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cboAccountName.Items.Add(dt.Rows[i]["TÊN TÀI KHOẢN"]);
            }
        }

        private void dgvReader_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.dgvStaff.ClearSelection();
        }

        private void dgvStaff_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = this.dgvStaff.Rows[e.RowIndex];
                txtStaffName.Text = row.Cells[0].Value.ToString();
                cboSex.Text = row.Cells[1].Value.ToString();
                dtpDateOfBirth.Text = row.Cells[2].Value.ToString();
                txtAddress.Text = row.Cells[3].Value.ToString();
                txtPhone.Text = row.Cells[4].Value.ToString();
                cboAccountName.Text = row.Cells[5].Value.ToString();

                curPhone = txtPhone.Text;
            }
            catch (Exception)
            { }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtStaffName.ReadOnly = !txtStaffName.ReadOnly;
            cboSex.Enabled = !cboSex.Enabled;
            dtpDateOfBirth.Enabled = !dtpDateOfBirth.Enabled;
            txtAddress.ReadOnly = !txtAddress.ReadOnly;
            txtPhone.ReadOnly = !txtPhone.ReadOnly;
            chkUsernamePermission.Enabled = !chkUsernamePermission.Enabled;
        }
        private void chkUsernamePermission_CheckedChanged(object sender, EventArgs e)
        {
                cboAccountName.Enabled = !cboAccountName.Enabled;
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
            dgvStaff.BackgroundColor = Color.White;
            dgvStaff.HeaderBgColor = ThemeColor.PrimaryColor;
            dgvStaff.HeaderForeColor = Color.White;
            dgvStaff.GridColor = Color.White;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtStaffName.ReadOnly == true)
            {
                DataTable dt = DataConnection.GetDataTable(@"EXEC sp_select_staff @SDT = '" + txtPhone.Text + "'");
                if (dt.Rows.Count == 1)
                {
                    string command = @"EXEC sp_delete_staff @SDT = '" + txtPhone.Text + "'";

                    DataConnection.ExecuteQuery(command);
                    MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData_Staff();
                }
                else
                {
                    MessageBox.Show("Không tồn tại nhân viên này!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Đang trong chế độ edit! Vui lòng tắt trước khi xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public bool IsVietnamPhoneNumber(string number)
        {
            return Regex.Match(number, @"^(0|\+84)[35789]\d{8}$").Success;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtStaffName.ReadOnly == false)
            {
                if (txtStaffName.Text == "" || txtPhone.Text == "" || cboSex.Text == "")
                {
                    MessageBox.Show("Thông tin nhân viên chưa đầy đủ! Hãy nhập lại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (IsVietnamPhoneNumber(txtPhone.Text) == false || DateTime.Now < dtpDateOfBirth.Value)
                {
                    MessageBox.Show("SĐT hoặc Ngày sinh không hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DataTable dt = DataConnection.GetDataTable(@"EXEC sp_select_staff @SDT = '" + txtPhone.Text + "'");

                if (dt.Rows.Count == 0)
                {
                    string command = "";
                    if (chkUsernamePermission.Checked == true)
                        command = (@"EXEC sp_insert_staff @HoTen = N'" + txtStaffName.Text + "', @GioiTinh = N'" + cboSex.Text + "', @NgaySinh = N'"
                                    + dtpDateOfBirth.Value.ToShortDateString() + "', @DiaChi = N'" + txtAddress.Text + "', @SDT = '" + txtPhone.Text + "', @TenTaiKhoan = '" + cboAccountName.Text + "'");
                    else
                        command = (@"EXEC sp_insert_staff @HoTen = N'" + txtStaffName.Text + "', @GioiTinh = N'" + cboSex.Text + "', @NgaySinh = N'"
                                    + dtpDateOfBirth.Value.ToShortDateString() + "', @DiaChi = N'" + txtAddress.Text + "', @SDT = '" + txtPhone.Text + "', @TenTaiKhoan = '.'");
                    DataConnection.ExecuteQuery(command);
                    MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData_Staff();
                }
                else
                {
                    MessageBox.Show("Đã tồn tại SĐT trên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Hãy bật chế độ edit! Điền thông tin nhân viên trước khi thêm!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtStaffName.ReadOnly == false && this.dgvStaff.SelectedRows.Count > 0)
            {
                if (txtStaffName.Text == "" || txtPhone.Text == "" || cboSex.Text == "")
                {
                    MessageBox.Show("Thông tin nhân viên chưa đầy đủ! Hãy nhập lại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (IsVietnamPhoneNumber(txtPhone.Text) == false || DateTime.Now < dtpDateOfBirth.Value)
                {
                    MessageBox.Show("SĐT hoặc Ngày sinh không hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                DataTable dt1 = DataConnection.GetDataTable(@"EXEC sp_select_staff @SDT = '" + txtPhone.Text + "'");
                if (dt1.Rows.Count == 0 || curPhone == txtPhone.Text)
                {

                    DataTable dt = DataConnection.GetDataTable(@"EXEC sp_select_staff @SDT = '" + curPhone + "'");

                    int MaNV = Int32.Parse(dt.Rows[0][0].ToString());

                    string command = "";
                    if (chkUsernamePermission.Checked == true)
                        command = (@"EXEC sp_update_staff @MaNV = " + MaNV + ", @HoTen = N'" + txtStaffName.Text + "', @GioiTinh = N'" + cboSex.Text + "', @NgaySinh = N'"
                                        + dtpDateOfBirth.Value.ToShortDateString() + "', @DiaChi = N'" + txtAddress.Text + "', @SDT = '" + txtPhone.Text + "', @TenTaiKhoan = '" + cboAccountName.Text + "'");
                    else
                        command = (@"EXEC sp_update_staff @MaNV = " + MaNV + ", @HoTen = N'" + txtStaffName.Text + "', @GioiTinh = N'" + cboSex.Text + "', @NgaySinh = N'"
                                        + dtpDateOfBirth.Value.ToShortDateString() + "', @DiaChi = N'" + txtAddress.Text + "', @SDT = '" + txtPhone.Text + "', @TenTaiKhoan = '.'");

                    DataConnection.ExecuteQuery(command);
                    MessageBox.Show("Cập nhật nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData_Staff();
                }
                else
                {
                    MessageBox.Show("Đã tồn tại SĐT trên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }    
            }
            else
            {
                MessageBox.Show("Chưa bật chế độ edit hoặc Chưa chọn nhân viên cần sửa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
