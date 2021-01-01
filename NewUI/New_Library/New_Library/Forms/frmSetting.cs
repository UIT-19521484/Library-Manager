using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace New_Library.Forms
{
    public partial class frmSetting : Form
    {
        private string errMsg;
        public frmSetting()
        {
            InitializeComponent();

            lblNumberError.Text = "";
            lblEmailError.Text = "";
        }
        private void frmSetting_Load(object sender, EventArgs e)
        {

            txtLibraryName.Text = Properties.Settings.Default.LibraryName;
            txtAddress.Text = Properties.Settings.Default.LibraryAddress;
            txtEmail.Text = Properties.Settings.Default.LibraryEmail;
            txtPhoneNumber.Text = Properties.Settings.Default.LibraryPhoneNumber;

            nudFineOfBook.Value = (decimal)Properties.Settings.Default.FineOfBook;
        }
        

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren(ValidationConstraints.Enabled))
            {
                return;
            }    

            Properties.Settings.Default.LibraryName = txtLibraryName.Text;
            Properties.Settings.Default.LibraryAddress = txtAddress.Text;
            Properties.Settings.Default.LibraryEmail = txtEmail.Text;
            Properties.Settings.Default.LibraryPhoneNumber = txtPhoneNumber.Text;
            Properties.Settings.Default.FineOfBook = (int)nudFineOfBook.Value;

            Properties.Settings.Default.Save();

            MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtLibraryName.Text = Properties.Settings.Default.LibraryName;
            txtAddress.Text = Properties.Settings.Default.LibraryAddress;
            txtPhoneNumber.Text = Properties.Settings.Default.LibraryPhoneNumber;
            txtEmail.Text = Properties.Settings.Default.LibraryEmail;

            nudFineOfBook.Value = (decimal)Properties.Settings.Default.FineOfBook;
        }

        private void CancelValidatedEvent(Label error, CancelEventArgs e)
        {
            System.Media.SystemSounds.Asterisk.Play();
            e.Cancel = true;
            error.Text = errMsg;
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidateInput.ValidEmail(txtEmail.Text, out errMsg))
            {
                CancelValidatedEvent(lblEmailError, e);
            }
        }

        private void txtEmail_Validated(object sender, EventArgs e)
        {
            lblEmailError.Text = "";
        }

        private void txtPhoneNumber_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidateInput.ValidVietnamesePhone(txtPhoneNumber.Text, out errMsg))
            {
                CancelValidatedEvent(lblNumberError, e);
            }
        }

        private void txtPhoneNumber_Validated(object sender, EventArgs e)
        {
            lblNumberError.Text = "";
        }

        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblNumberError.Text = "";
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                lblNumberError.Text = "Chỉ nhập kí tự số";
            }    
        }
    }
}
