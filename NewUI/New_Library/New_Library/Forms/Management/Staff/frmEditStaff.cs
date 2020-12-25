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
    public partial class frmEditStaff : Form
    {
        private int staffID;
        private string errMsg;

        public frmEditStaff(LibraryEntity.Staff staff)
        {
            InitializeComponent();

            nudYear.Maximum = DateTime.Now.Year;
            nudYear.Minimum = nudYear.Maximum - 100;
            nudDay.Maximum = DateTime.DaysInMonth(Convert.ToInt32(nudYear.Value), Convert.ToInt32(nudMonth.Value));
            lblAddressError.Text = "";
            lblPhoneNumberWarning.Text = "";
            lblSexError.Text = "";
            lblStaffNameError.Text = "";

            txtStaffName.Text = staff.HoTen;
            cbSex.Text = staff.GioiTinh;
            txtPhoneNumber.Text = staff.SDT;
            txtAddress.Text = staff.DiaChi;
            nudDay.Value = staff.NgaySinh.Day;
            nudMonth.Value = staff.NgaySinh.Month;
            nudYear.Value = staff.NgaySinh.Year;
            staffID = staff.MaNV;
        }

        private void nudMonth_ValueChanged(object sender, EventArgs e)
        {
            nudDay.Maximum = DateTime.DaysInMonth(Convert.ToInt32(nudYear.Value), Convert.ToInt32(nudMonth.Value));
        }

        private void nudYear_ValueChanged(object sender, EventArgs e)
        {
            nudDay.Maximum = DateTime.DaysInMonth(Convert.ToInt32(nudYear.Value), Convert.ToInt32(nudMonth.Value));
        }

        #region Validate input data
        private void CancelValidatedEvent(Control control, Label error, CancelEventArgs e)
        {
            System.Media.SystemSounds.Asterisk.Play();
            e.Cancel = true;
            errEditStaff.SetError(control, errMsg);
            error.Text = errMsg;
        }

        private void txtStaffName_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidateInput.ValidNoneSpecialChar(txtStaffName.Text, out errMsg))
            {
                CancelValidatedEvent(gbStaffName, lblStaffNameError, e);
            }
        }

        private void txtStaffName_Validated(object sender, EventArgs e)
        {
            errEditStaff.SetError(gbStaffName, "");
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
                errEditStaff.SetError(gbPhoneNumber, errMsg);
            }
        }

        private void txtPhoneNumber_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidateInput.ValidVietnamesePhone(txtPhoneNumber.Text, out errMsg))
            {
                CancelValidatedEvent(gbPhoneNumber, lblPhoneNumberWarning, e);
            }
        }

        private void txtPhoneNumber_Validated(object sender, EventArgs e)
        {
            lblPhoneNumberWarning.Text = "";
            errEditStaff.SetError(gbPhoneNumber, "");
        }

        private void txtAddress_Validating(object sender, CancelEventArgs e)
        {
            if (ValidateInput.IsEmpty(txtAddress.Text, out errMsg))
            {
                CancelValidatedEvent(gbAddress, lblAddressError, e);
            }
        }

        private void txtAddress_Validated(object sender, EventArgs e)
        {
            errEditStaff.SetError(gbAddress, "");
            lblAddressError.Text = "";
        }

        private void cbSex_Validating(object sender, CancelEventArgs e)
        {
            if (cbSex.Text.Length == 0)
            {
                errMsg = "Chưa chọn giới tính";
                CancelValidatedEvent(gbSex, lblSexError, e);
            }
        }

        private void cbSex_Validated(object sender, EventArgs e)
        {
            lblSexError.Text = "";
            errEditStaff.SetError(gbSex, "");
        }
        #endregion

        private void btnEdit_Click(object sender, EventArgs e)
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

            if (dtPhone.Rows.Count == 1)
            {
                string date = dob.ToString("yyyy'-'MM'-'dd");
                string command = @"EXEC sp_update_staff @MaNV = " + staffID
                                                  +  ", @HoTen = N'" + txtStaffName.Text
                                                  + "', @GioiTinh = N'" + cbSex.Text
                                                  + "', @NgaySinh = N'" + date
                                                  + "', @DiaChi = N'" + txtAddress.Text
                                                  + "', @SDT = '" + txtPhoneNumber.Text + "'";
                if (DataConnection.ExecuteQuery(command))
                {
                    MessageBox.Show("Chỉnh sửa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Chỉnh sửa nhân viên thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Đã tồn tại số điện thoại trên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}