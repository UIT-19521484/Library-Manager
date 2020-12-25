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
        private string errMsg;

        public frmAccount()
        {
            InitializeComponent();

            btnChangePassword.Enabled = false;
            btnUpdate.Enabled = false;

            pnlEditAccount.Visible = false;
            pnlChangePassword.Visible = false;
        }

        private void frmAccount_Load(object sender, EventArgs e)
        {
            
            LoadData_Account();
        }

        void LoadData_Account()
        {
            dgvAccount.DataSource = DatabaseData.dtAccount;
            
        }

        private void dgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnChangePassword.Enabled = true;
            btnUpdate.Enabled = true;

            txtAccountName.Text = dgvAccount.SelectedRows[0].Cells["TenTaiKhoan"].Value.ToString();
            cbPermission.Text = dgvAccount.SelectedRows[0].Cells["PhanQuyen"].Value.ToString();
        }

        private void dgvStaff_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.dgvAccount.ClearSelection();

            dgvAccount.BeginInvoke(new Action(() =>
            {
                btnChangePassword.Enabled = false;
                btnUpdate.Enabled = false;
            }));
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
            dgvAccount.HeaderBgColor = ThemeColor.PrimaryColor;
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

        private void CancelValidatedEvent(Control control, Label error, CancelEventArgs e)
        {
            System.Media.SystemSounds.Asterisk.Play();
            e.Cancel = true;
            errAccount.SetError(control, errMsg);
            error.Text = errMsg;
        }

        #region Edit account
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            lblAccountNameError.Text = "";
            pnlEditAccount.Visible = true;
            pnlChangePassword.Visible = false;

            errAccount.SetError(gbNewPassword, "");
            errAccount.SetError(gbConfirmPassword, "");
        }

        private void txtAccountName_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidateInput.ValidNoneSpecialChar(txtAccountName.Text, out errMsg))
            {
                CancelValidatedEvent(gbAccountName, lblAccountNameError, e);
            }
        }

        private void txtAccountName_Validated(object sender, EventArgs e)
        {
            lblAccountNameError.Text = "";
            errAccount.SetError(gbAccountName, "");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lblAccountNameError.Text.Length != 0)
            {
                return;
            }

            if (DatabaseData.dtAccount.Select(String.Format("[TÊN TÀI KHOẢN] = '{0}'", txtAccountName.Text)).FirstOrDefault() == null)
            {
                string cmdSta = @"update NHANVIEN set TenTaiKhoan = '" + txtAccountName.Text + "' " + "where HoTen = N'" + dgvAccount.SelectedRows[0].Cells[0].Value.ToString() + "'";
                string cmdAcc = @"update TAIKHOAN set TenTaiKhoan = '" + txtAccountName.Text + "', PhanQuyen = '" + cbPermission.Text + "' " + "where TenTaiKhoan = '" + dgvAccount.SelectedRows[0].Cells["TenTaiKhoan"].Value.ToString() + "'";

                if (DataConnection.ExecuteQuery(cmdAcc + ";\n" + cmdSta))
                {
                    MessageBox.Show("Thay đổi thông tin tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pnlEditAccount.Visible = false;
                }    
            }
            else
            {
                MessageBox.Show("Tên tài khoản đã tồn tại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dgvAccount.Refresh();

            pnlEditAccount.Visible = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlEditAccount.Visible = false;
        }
        #endregion

        #region Change password
        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            lblNewPasswordError.Text = "";
            lblConfirmPasswordError.Text = "";
            pnlEditAccount.Visible = false;
            pnlChangePassword.Visible = true;
        }

        private void txtNewPassword_Validating(object sender, CancelEventArgs e)
        {
            if (ValidateInput.IsEmpty(txtNewPassword.Text, out errMsg))
            {
                CancelValidatedEvent(gbNewPassword, lblNewPasswordError, e);
            }    
        }

        private void txtNewPassword_Validated(object sender, EventArgs e)
        {
            lblNewPasswordError.Text = "";
            errAccount.SetError(gbNewPassword, "");
        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtNewPassword.Text != txtConfirmPassword.Text)
            {
                errMsg = "Mật khẩu xác nhận không trùng khớp";
                CancelValidatedEvent(gbConfirmPassword, lblConfirmPasswordError, e);
            }
        }

        private void txtConfirmPassword_Validated(object sender, EventArgs e)
        {
            lblConfirmPasswordError.Text = "";
            errAccount.SetError(gbConfirmPassword, "");
        }

        private void btnAcceptChange_Click(object sender, EventArgs e)
        {
            ValidateChildren(ValidationConstraints.Visible);

            if (lblNewPasswordError.Text.Length != 0 || lblConfirmPasswordError.Text.Length != 0)
            {
                return;
            }  
            
            DataTable dt = DataConnection.GetDataTable("SELECT TenTaiKhoan FROM TAIKHOAN WHERE TenTaiKhoan = '" + txtAccountName.Text + "'");
            if (dt.Rows.Count == 1)
            {
                string command = @"UPDATE TAIKHOAN SET MatKhau = '" + CreateMD5(txtNewPassword.Text) + "' WHERE TenTaiKhoan = '" + dgvAccount.SelectedRows[0].Cells["TenTaiKhoan"].Value.ToString() + "'";
                if (DataConnection.ExecuteQuery(command))
                {
                    MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else 
                {
                    MessageBox.Show("Đổi mật khẩu thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Tài khoản này không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            pnlChangePassword.Visible = false;

            txtNewPassword.Text = "";
            txtConfirmPassword.Text = "";
        }

        private void btnCancelChange_Click(object sender, EventArgs e)
        {
            pnlChangePassword.Visible = false;

            txtNewPassword.Text = "";
            txtConfirmPassword.Text = "";
        }
        #endregion
    }
}