using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New_Library.Forms.Management.Account
{
    public partial class frmAddStaff : Form
    {
        private string errMsg;

        public frmAddStaff()
        {
            InitializeComponent();

        }

        private void frmAddStaff_Load(object sender, EventArgs e)
        {
            lblAccountNameError.Text = "";
            lblAddressError.Text = "";
            lblPasswordError.Text = "";
            lblPhoneNumberWarning.Text = "";
            lblSexError.Text = "";
            lblStaffNameError.Text = "";

            nudYear.Maximum = DateTime.Now.Year;
            nudYear.Minimum = nudYear.Maximum - 100;
            nudDay.Maximum = DateTime.DaysInMonth(Convert.ToInt32(nudYear.Value), Convert.ToInt32(nudMonth.Value));

            nudYear.Value = DateTime.Now.Year;
            nudMonth.Value = DateTime.Now.Month;
            nudDay.Value = DateTime.Now.Day;
        }
        private void nudMonth_ValueChanged(object sender, EventArgs e)
        {
            nudDay.Maximum = DateTime.DaysInMonth(Convert.ToInt32(nudYear.Value), Convert.ToInt32(nudMonth.Value));
        }

        private void nudYear_ValueChanged(object sender, EventArgs e)
        {
            nudDay.Maximum = DateTime.DaysInMonth(Convert.ToInt32(nudYear.Value), Convert.ToInt32(nudMonth.Value));
        }

        private void chkShowPassword_CheckStateChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;
        }


        #region Validate input data
        private void CancelValidatedEvent(Control control, Label error, CancelEventArgs e)
        {
            System.Media.SystemSounds.Asterisk.Play();
            e.Cancel = true;
            errAddStaff.SetError(control, errMsg);
            error.Text = errMsg;
        }

        private void txtStaffName_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidateInput.ValidOnlyLetter(txtStaffName.Text, out errMsg))
            {
                CancelValidatedEvent(grpStaffName, lblStaffNameError, e);
            }
        }

        private void txtStaffName_Validated(object sender, EventArgs e)
        {
            errAddStaff.SetError(grpStaffName, "");
            lblStaffNameError.Text = "";
        }

        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblPhoneNumberWarning.Text = "";
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                errMsg = "Trường này chỉ nhập số";
                lblPhoneNumberWarning.Text = errMsg;
                System.Media.SystemSounds.Asterisk.Play();
                errAddStaff.SetError(grpPhoneNumber, errMsg);
            }
        }

        private void txtPhoneNumber_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidateInput.ValidVietnamesePhone(txtPhoneNumber.Text, out errMsg))
            {
                CancelValidatedEvent(grpPhoneNumber, lblPhoneNumberWarning, e);
            }
        }

        private void txtPhoneNumber_Validated(object sender, EventArgs e)
        {
            lblPhoneNumberWarning.Text = "";
            errAddStaff.SetError(grpPhoneNumber, "");
        }

        private void txtAddress_Validating(object sender, CancelEventArgs e)
        {
            if (ValidateInput.IsEmpty(txtAddress.Text, out errMsg))
            {
                CancelValidatedEvent(grpAddress, lblAddressError, e);
            }
        }

        private void txtAddress_Validated(object sender, EventArgs e)
        {
            errAddStaff.SetError(grpAddress, "");
            lblAddressError.Text = "";
        }

        private void cbSex_Validating(object sender, CancelEventArgs e)
        {
            if (cboSex.Text.Length == 0)
            {
                errMsg = "Chưa chọn giới tính";
                CancelValidatedEvent(gbSex, lblSexError, e);
            }
        }

        private void cbSex_Validated(object sender, EventArgs e)
        {
            lblSexError.Text = "";
            errAddStaff.SetError(gbSex, "");
        }

        private void txtAccountName_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidateInput.ValidNoneSpecialChar(txtAccountName.Text, out errMsg))
            {
                CancelValidatedEvent(grpAccountName, lblAccountNameError, e);
            }    
        }

        private void txtAccountName_Validated(object sender, EventArgs e)
        {
            lblAccountNameError.Text = "";
            errAddStaff.SetError(grpAccountName, "");
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidateInput.ValidNoneSpecialChar(txtPassword.Text, out errMsg))
            {
                CancelValidatedEvent(grpPassword, lblPasswordError, e);
            }    
            if (txtPassword.Text.Any(c => c > 255))
            {
                errMsg = "Mật khẩu chứa kí tự tiếng Việt.\nHãy tắt bộ gõ tiếng Việt và nhập lại.";
                CancelValidatedEvent(grpPassword, lblPasswordError, e);
            }    
        }

        private void txtPassword_Validated(object sender, EventArgs e)
        {
            lblPasswordError.Text = "";
            errAddStaff.SetError(grpPassword, "");
        }
        #endregion

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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren(ValidationConstraints.Enabled))
            {
                return;
            }

            DateTime dob = new DateTime(Convert.ToInt32(nudYear.Value), Convert.ToInt32(nudMonth.Value), Convert.ToInt32(nudDay.Value));
            if (dob >= DateTime.Now)
            {
                MessageBox.Show("Ngày sinh không hợp lệ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataTable dtPhone = DataConnection.GetDataTable(@"EXEC sp_select_staff @SDT = '" + txtPhoneNumber.Text + "'");
            DataTable dtAccountName = DataConnection.GetDataTable(@"select TenTaiKhoan from TAIKHOAN where TenTaiKhoan = '" + txtAccountName.Text + "'");

            if (dtPhone.Rows.Count == 0 && dtAccountName.Rows.Count == 0)
            {
                string date = dob.ToString("yyyy'-'MM'-'dd");
                string command = @"EXEC sp_insert_staff @HoTen = N'" + txtStaffName.Text
                                                  + "', @GioiTinh = N'" + cboSex.Text
                                                  + "', @NgaySinh = N'" + date
                                                  + "', @DiaChi = N'" + txtAddress.Text
                                                  + "', @SDT = '" + txtPhoneNumber.Text
                                                  + "', @TenTaiKhoan = '" + txtAccountName.Text 
                                                  + "', @MatKhau = '" + CreateMD5(txtPassword.Text) + "'";
                if (DataConnection.ExecuteQuery(command))
                {
                    MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Thêm nhân viên thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }    
            }
            else
            {
                if (dtAccountName.Rows.Count > 0)
                {
                    MessageBox.Show("Đã tồn tại tên tài khoản trên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (dtPhone.Rows.Count > 0)
                {
                    MessageBox.Show("Đã tồn tại số điện thoại trên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}
