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
    public partial class frmAddReader : Form
    {
        string errMsg;
        public frmAddReader()
        {
            InitializeComponent();
        }

        private void frmAddReader_Load(object sender, EventArgs e)
        {
            lblAddressError.Text = "";
            lblEmailError.Text = "";
            lblPhoneNumberWarning.Text = "";
            lblReaderNameError.Text = "";
            lblSexError.Text = "";

            nudYear.Maximum = DateTime.Now.Year;
            nudYear.Minimum = nudYear.Maximum - 100;
            nudDay.Maximum = DateTime.DaysInMonth(Convert.ToInt32(nudYear.Value), Convert.ToInt32(nudMonth.Value));

            nudYear.Value = DateTime.Now.Year;
            nudMonth.Value = DateTime.Now.Month;
            nudDay.Value = DateTime.Now.Day;
        }

        #region Validate input data
        private void CancelValidatedEvent(Control control, Label error, CancelEventArgs e)
        {
            System.Media.SystemSounds.Asterisk.Play();
            e.Cancel = true;
            errAddReader.SetError(control, errMsg);
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
            errAddReader.SetError(grpReaderName, errMsg);
            lblReaderNameError.Text = "";
        }

        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblPhoneNumberWarning.Text = "";
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                errMsg = "Trường này chỉ nhập số";
                System.Media.SystemSounds.Asterisk.Play();
                e.Handled = true;
                errAddReader.SetError(grpPhoneNumber, errMsg);
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
            errAddReader.SetError(grpPhoneNumber, "");
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
            errAddReader.SetError(grpEmail, "");
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
            errAddReader.SetError(grpAddress, "");
            lblAddressError.Text = "";
        }

        private void cbSex_Validating(object sender, CancelEventArgs e)
        {
            if (cbSex.Text.Length == 0)
            {
                errMsg = "Chưa chọn giới tính";
                CancelValidatedEvent(grpSex, lblSexError, e);
            }    
        }

        private void cbSex_Validated(object sender, EventArgs e)
        {
            errAddReader.SetError(grpSex, "");
            lblSexError.Text = "";
        }
        #endregion

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

            DataTable dt = DataConnection.GetDataTable(@"EXEC sp_select_reader @SDT = '" + txtPhoneNumber.Text + "', @Email = '" + txtEmail.Text + "'");
            if (dt.Rows.Count == 0)
            {
                string date = dob.ToString("yyyy'-'MM'-'dd");
                string command = (@"EXEC sp_insert_reader @HoTen = N'" + txtReaderName.Text
                                                    + "', @GioiTinh = N'" + cbSex.Text
                                                    + "', @NgaySinh = '" + date
                                                    + "', @DiaChi = N'" + txtAddress.Text + "', @SDT = '" + txtPhoneNumber.Text
                                                    + "', @Email = '" + txtEmail.Text + "'");
                if (DataConnection.ExecuteQuery(command))
                {
                    MessageBox.Show("Thêm độc giả thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Thêm độc giả thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                GC.Collect();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("SĐT hoặc Email đã được sử dụng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

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

        
    }
}
