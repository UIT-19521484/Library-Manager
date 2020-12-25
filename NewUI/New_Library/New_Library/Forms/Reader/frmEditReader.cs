using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            txtReaderName.Text = reader.HoTen;
            cbSex.Text = reader.GioiTinh;
            nudDay.Value = reader.NgaySinh.Day;
            nudMonth.Value = reader.NgaySinh.Month;
            nudYear.Value = reader.NgaySinh.Year;
            txtAddress.Text = reader.DiaChi;
            txtPhoneNumber.Text = reader.SDT;
            txtEmail.Text = reader.Email;
            readerID = reader.MaDG;

            nudDay.Maximum = DateTime.DaysInMonth(Convert.ToInt32(nudYear.Value), Convert.ToInt32(nudMonth.Value));
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
            if (!ValidateInput.ValidOnlyLetter(txtReaderName.Text, out errMsg))
            {
                CancelValidatedEvent(gbReaderName, lblReaderNameError, e);
            }
        }

        private void txtReaderName_Validated(object sender, EventArgs e)
        {
            errEditReader.SetError(gbReaderName, errMsg);
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
                errEditReader.SetError(gbPhoneNumber, errMsg);
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
            errEditReader.SetError(gbPhoneNumber, "");
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidateInput.ValidEmail(txtEmail.Text, out errMsg))
            {
                CancelValidatedEvent(gbEmail, lblEmailError, e);
            }
        }

        private void txtEmail_Validated(object sender, EventArgs e)
        {
            errEditReader.SetError(gbEmail, "");
            lblEmailError.Text = "";
        }

        private void txtAddress_Validating(object sender, CancelEventArgs e)
        {
            if (ValidateInput.IsEmpty(txtEmail.Text, out errMsg))
            {
                CancelValidatedEvent(gbAddress, lblAddressError, e);
            }
        }

        private void txtAddress_Validated(object sender, EventArgs e)
        {
            errEditReader.SetError(gbAddress, "");
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
                                                     + "', @GioiTinh = N'" + cbSex.Text
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
                    MessageBox.Show("Cập nhật độc giả thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Đã tồn tại SĐT hoặc Email trên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
    }
    }
}
