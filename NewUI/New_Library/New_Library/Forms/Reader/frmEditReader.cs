﻿using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace New_Library.Forms.Reader
{
    public partial class frmEditReader : Form
    {
        private string errMsg;
        private int readerID;

        public frmEditReader(LibraryEntity.Reader reader)
        {
            InitializeComponent();

            lblAddressError.Text = "";
            lblEmailError.Text = "";
            lblPhoneNumberWarning.Text = "";
            lblReaderNameError.Text = "";
            lblSexError.Text = "";

            nudYear.Maximum = DateTime.Now.Year;
            nudYear.Minimum = nudYear.Maximum - 100;
            nudDay.Maximum = DateTime.DaysInMonth(Convert.ToInt32(nudYear.Value), Convert.ToInt32(nudMonth.Value));

            txtReaderName.Text = reader.HoTen;
            cboSex.Text = reader.GioiTinh;
            nudDay.Value = reader.NgaySinh.Day;
            nudMonth.Value = reader.NgaySinh.Month;
            nudYear.Value = reader.NgaySinh.Year;
            txtAddress.Text = reader.DiaChi;
            txtPhoneNumber.Text = reader.SDT;
            txtEmail.Text = reader.Email;
            readerID = reader.MaDG;  
        }

        #region Validate input data
        private void CancelValidatedEvent(Control control, Label error, CancelEventArgs e)
        {
            System.Media.SystemSounds.Asterisk.Play();
            e.Cancel = true;
            errEditReader.SetError(control, errMsg);
            error.Text = errMsg;
        }

        private void txtReaderName_Validating(object sender, CancelEventArgs e)
        {
            if (ValidateInput.IsEmpty(txtReaderName.Text, out errMsg))
            {
                CancelValidatedEvent(grpReaderName, lblReaderNameError, e);
            }
            if (!ValidateInput.ValidOnlyLetter(txtReaderName.Text, out errMsg))
            {
                CancelValidatedEvent(grpReaderName, lblReaderNameError, e);
            }
        }

        private void txtReaderName_Validated(object sender, EventArgs e)
        {
            errEditReader.SetError(grpReaderName, errMsg);
            lblReaderNameError.Text = "";
        }

        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblPhoneNumberWarning.Text = "";
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                errMsg = "Trường này chỉ nhập số";
                e.Handled = true;
                System.Media.SystemSounds.Asterisk.Play();
                errEditReader.SetError(grpPhoneNumber, errMsg);
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
            errEditReader.SetError(grpPhoneNumber, "");
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidateInput.ValidEmail(txtEmail.Text, out errMsg))
            {
                CancelValidatedEvent(grpEmail, lblEmailError, e);
            }
        }

        private void txtEmail_Validated(object sender, EventArgs e)
        {
            errEditReader.SetError(grpEmail, "");
            lblEmailError.Text = "";
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
            errEditReader.SetError(grpAddress, "");
            lblAddressError.Text = "";
        }

        private void cbSex_Validating(object sender, CancelEventArgs e)
        {
            if (cboSex.Text.Length == 0)
            {
                errMsg = "Chưa chọn giới tính";
                CancelValidatedEvent(grpSex, lblSexError, e);
            }
        }

        private void cbSex_Validated(object sender, EventArgs e)
        {
            errEditReader.SetError(grpSex, "");
            lblSexError.Text = "";
        }
        #endregion

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void nudMonth_ValueChanged(object sender, EventArgs e)
        {
            nudDay.Maximum = DateTime.DaysInMonth(Convert.ToInt32(nudYear.Value), Convert.ToInt32(nudMonth.Value));
        }

        private void nudYear_ValueChanged(object sender, EventArgs e)
        {
            nudDay.Maximum = DateTime.DaysInMonth(Convert.ToInt32(nudYear.Value), Convert.ToInt32(nudMonth.Value));
        }

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

            DataTable dt = DataConnection.GetDataTable(@"EXEC sp_select_reader @SDT = '" + txtPhoneNumber.Text + "', @Email = '" + txtEmail.Text + "'");
            if (dt.Rows.Count == 1)
            {
                string date = dob.ToString("yyyy'-'MM'-'dd");
                string command = (@"EXEC sp_update_reader @MaDG = " + readerID 
                                                     + ", @HoTen = N'" + txtReaderName.Text 
                                                     + "', @GioiTinh = N'" + cboSex.Text
                                                     + "', @NgaySinh = N'" + date
                                                     + "', @DiaChi = N'" + txtAddress.Text 
                                                     + "', @SDT = '" + txtPhoneNumber.Text 
                                                     + "', @Email = '" + txtEmail.Text + "'");
                if (DataConnection.ExecuteQuery(command))
                {
                    MessageBox.Show("Cập nhật độc giả thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Cập nhật độc giả thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Đã tồn tại SĐT hoặc Email trên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
    }
    }
}
