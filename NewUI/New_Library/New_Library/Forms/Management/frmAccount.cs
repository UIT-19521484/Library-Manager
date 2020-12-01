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
    public partial class frmAccount : Form
    {
        public frmAccount()
        {
            InitializeComponent();
        }

        private void frmAccount_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            this.btnEdit.BackColor = ThemeColor.PrimaryColor;
            this.btnEdit.ForeColor = Color.White;
            this.btnSearch.BackColor = ThemeColor.PrimaryColor;
            this.btnSearch.ForeColor = Color.White;
            this.btnChangePassword.BackColor = ThemeColor.PrimaryColor;
            this.btnChangePassword.ForeColor = Color.White;
            LoadTheme();
            LoadData_Account();
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
            lblAccountName.ForeColor = ThemeColor.SecondaryColor;
            lblRole.ForeColor = ThemeColor.SecondaryColor;
            lblPassword.ForeColor = ThemeColor.SecondaryColor;
            lblConfirmPassword.ForeColor = ThemeColor.SecondaryColor;
        }

        void LoadData_Account()
        {
            string str = @"EXEC sp_select_all_accounts";
            DataTable dt = DataConnection.GetDataTable(str);
            dgvAccount.DataSource = dt;
            dgvAccount.BackgroundColor = Color.White;
            dgvAccount.HeaderBgColor = ThemeColor.PrimaryColor;
            dgvAccount.HeaderForeColor = Color.White;
            dgvAccount.GridColor = Color.White;
        }

        private void dgvStaff_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = this.dgvAccount.Rows[e.RowIndex];
                txtAccountName.Text = row.Cells[0].Value.ToString();
                cboRole.Text = row.Cells[2].Value.ToString();
            }
            catch (Exception)
            { }
        }

        private void dgvStaff_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.dgvAccount.ClearSelection();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtAccountName.ReadOnly = !txtAccountName.ReadOnly;
            chkAdminPermission.Enabled = !chkAdminPermission.Enabled;
            ShowHidePassword();
        }

        private void ShowHidePassword()
        {
            txtPassword.Visible = !txtPassword.Visible;
            txtConfirmPassword.Visible = !txtConfirmPassword.Visible;
            lblPassword.Visible = !lblPassword.Visible;
            lblConfirmPassword.Visible = !lblConfirmPassword.Visible;
        }
        
        
        private void chkAdminPermission_CheckedChanged(object sender, EventArgs e)
        {
            cboRole.Enabled = !cboRole.Enabled;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "" || txtSearch.Text == null)
            {
                LoadData_Account();
                return;
            }
            string command = @"EXEC sp_search_accounts @TuKhoa = N'" + txtSearch.Text + "'";
            DataTable dt = DataConnection.GetDataTable(command);
            this.dgvAccount.DataSource = dt;
            dgvAccount.BackgroundColor = Color.White;
            dgvAccount.HeaderBgColor = ThemeColor.PrimaryColor;
            dgvAccount.HeaderForeColor = Color.White;
            dgvAccount.GridColor = Color.White;
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (txtAccountName.Text == "")
            {
                MessageBox.Show("Chưa chọn tài khoản hoặc Không tồn tại tài khoản này!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtPassword.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!");
                return;
            }
            else if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Hai mật khẩu không khớp!");
                return;
            }
            else
            {
                DataTable dt = DataConnection.GetDataTable("SELECT TenTaiKhoan FROM TAIKHOAN WHERE TenTaiKhoan = '" + txtAccountName.Text + "'");
                if (dt.Rows.Count == 1)
                {
                    string command = @"UPDATE TAIKHOAN SET MatKhau = '" + CreateMD5(txtPassword.Text) + "' WHERE TenTaiKhoan = '" +txtAccountName.Text+ "'";
                    DataConnection.ExecuteQuery(command);
                    MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Tài khoản này không tồn tại!", "Thông báo", MessageBoxButtons.OK);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtAccountName.Focus();
            if (txtAccountName.Text == "")
            {
                MessageBox.Show("Hãy điền tên tài khoản!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtPassword.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!");
                return;
            }
            else if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Hai mật khẩu không khớp!");
                return;
            }
            else
            {
                DataTable dt = DataConnection.GetDataTable("SELECT TenTaiKhoan FROM TAIKHOAN WHERE TenTaiKhoan = '" + txtAccountName.Text + "'");
                if (dt.Rows.Count == 0)
                {
                    string command = "";
                    if (chkAdminPermission.Checked == true)
                    {
                        command = @"INSERT INTO TAIKHOAN VALUES('" + txtAccountName.Text + "','" + CreateMD5(txtPassword.Text) + "', '" + cboRole.Text + "')";
                    }    
                    else
                    {
                        command = @"INSERT INTO TAIKHOAN VALUES('" + txtAccountName.Text + "','" + CreateMD5(txtPassword.Text) + "', 'Member')";
                    }    

                    DataConnection.ExecuteQuery(command);
                    MessageBox.Show("Thêm tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData_Account();
                }
                else
                {
                    MessageBox.Show("Tài khoản đã tồn tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtAccountName.ReadOnly == true)
            {
                if (txtAccountName.Text == "")
                {
                    MessageBox.Show("Không tồn tại tài khoản này!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DataTable dt1 = DataConnection.GetDataTable(@"SELECT TenTaiKhoan FROM TAIKHOAN WHERE TenTaiKhoan = '" + txtAccountName.Text + "'");
                if (dt1.Rows.Count == 0)
                {
                    MessageBox.Show("Không tồn tại tài khoản này!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DataTable dt = DataConnection.GetDataTable(@"EXEC sp_select_account @TenTaiKhoan = '" + txtAccountName.Text + "'");
                if (dt.Rows.Count == 0)
                {
                    string command = @"EXEC sp_delete_account @TenTaiKhoan = '" + txtAccountName.Text + "'";
                    DataConnection.ExecuteQuery(command);
                    MessageBox.Show("Xóa tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData_Account();
                }
                else
                {
                    MessageBox.Show("Có nhân viên đang dùng tài khoản này!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Đang trong chế độ edit! Vui lòng tắt trước khi xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string CreateMD5(string passWord)
        {
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(passWord);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }
    }
}
