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
        }

        private void frmAccount_Load(object sender, EventArgs e)
        {
            this.btnSearch.BackColor = ThemeColor.PrimaryColor;
            LoadData_Account();
        }

        void LoadData_Account()
        {
            dgvAccount.DataSource = DatabaseData.dtAccount;
            dgvAccount.HeaderBgColor = ThemeColor.PrimaryColor;
        }

        private void dgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnChangePassword.Enabled = true;
            btnUpdate.Enabled = true;
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

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            //if (txtAccountName.Text == "")
            //{
            //    MessageBox.Show("Chưa chọn tài khoản hoặc Không tồn tại tài khoản này!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            //if (txtPassword.Text == "")
            //{
            //    MessageBox.Show("Vui lòng nhập mật khẩu!");
            //    return;
            //}
            //else if (txtPassword.Text != txtConfirmPassword.Text)
            //{
            //    MessageBox.Show("Hai mật khẩu không khớp!");
            //    return;
            //}
            //else
            //{
            //    DataTable dt = DataConnection.GetDataTable("SELECT TenTaiKhoan FROM TAIKHOAN WHERE TenTaiKhoan = '" + txtAccountName.Text + "'");
            //    if (dt.Rows.Count == 1)
            //    {
            //        string command = @"UPDATE TAIKHOAN SET MatKhau = '" + CreateMD5(txtPassword.Text) + "' WHERE TenTaiKhoan = '" +txtAccountName.Text+ "'";
            //        DataConnection.ExecuteQuery(command);
            //        MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK);
            //    }
            //    else
            //    {
            //        MessageBox.Show("Tài khoản này không tồn tại!", "Thông báo", MessageBoxButtons.OK);
            //    }
            //}
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            lblAccountNameError.Text = "";
            txtAccountName.Text = dgvAccount.SelectedRows[0].Cells["TenTaiKhoan"].Value.ToString();
            cbPermission.Text = dgvAccount.SelectedRows[0].Cells["PhanQuyen"].Value.ToString();
            pnlEditAccount.Visible = true;
        }

        private void txtAccountName_Validating(object sender, CancelEventArgs e)
        {
            if (ValidateInput.IsEmpty(txtAccountName.Text, out errMsg)) ;
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
                string cmd = @"update TAIKHOAN 
                               set TenTaiKhoan = '" + txtAccountName.Text + "', PhanQuyen = '" + cbPermission.Text + 
                            "' where TenTaiKhoan = '" + dgvAccount.SelectedRows[0].Cells["TenTaiKhoan"].Value.ToString() + "'";

                if (DataConnection.ExecuteQuery(cmd))
                {
                    MessageBox.Show("Thay đổi thông tin tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pnlEditAccount.Visible = false;
                }    
            }
            else
            {
                MessageBox.Show("Tên tài khoản đã tồn tại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlEditAccount.Visible = false;
        }
    }
}