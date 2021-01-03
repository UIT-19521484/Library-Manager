using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace New_Library
{
    public partial class frmFirstTime : Form
    {
        private string errMsg;
        private string connectionString;
        private bool isComplete = false;

        public frmFirstTime()
        {
            InitializeComponent();

            lblAccountNameError.Text = string.Empty;
            lblEmailError.Text = string.Empty;
            lblNumberError.Text = string.Empty;
            lblServerError.Text = string.Empty;
            lblPasswordError.Text = string.Empty;
            lblConnectionStatus.Text = "Kiểm tra kết nối trước khi hoàn thành";

            btnAccept.Enabled = false;
        }

        private string GenerateConnectionString()
        {
            //@"Data Source=192.168.0.106,1433;Initial Catalog=QLThuVien;Persist Security Info=True;User ID=sa;Password=123456";
            string con = "";

            //con += @"Data Source=" + txtServerName.Text + ";Initial Catalog=QLThuVien;Persist Security Info=True;";
            con += @"Data Source=" + txtServerName.Text + ";Initial Catalog=QLTV;Persist Security Info=True;";
            con += @"User ID=" + txtAccountName.Text + ";";
            con += @"Password=" + txtPassword.Text + ";";

            return con;
        }

        private void btnCheckConnection_Click(object sender, EventArgs e)
        {
            ValidateChildren();
            if (lblServerError.Text.Length + lblPasswordError.Text.Length + lblAccountNameError.Text.Length != 0)
            {
                return;
            }    

            connectionString = GenerateConnectionString();
            btnCheckConnection.Text = "Đang kiểm tra...";
            if (DataConnection.TestConnection(connectionString))
            {
                lblConnectionStatus.Text = "Kết nối thành công";
                btnAccept.Enabled = true;
            }
            else 
            {
                lblConnectionStatus.Text = "Kết nối thất bại";
                btnAccept.Enabled = false;
            }
            btnCheckConnection.Text = "Kiểm tra kết nối";
        }

        #region Validate input data
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

        private void txtServerName_Validating(object sender, CancelEventArgs e)
        {
            if (ValidateInput.IsEmpty(txtServerName.Text, out errMsg))
            {
                CancelValidatedEvent(lblServerError, e);
            }    
        }

        private void txtServerName_Validated(object sender, EventArgs e)
        {
            lblServerError.Text = "";
        }

        private void txtAccountName_Validating(object sender, CancelEventArgs e)
        {
            if (ValidateInput.IsEmpty(txtAccountName.Text, out errMsg))
            {
                CancelValidatedEvent(lblAccountNameError, e);
            }
        }

        private void txtAccountName_Validated(object sender, EventArgs e)
        {
            lblAccountNameError.Text = "";
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidateInput.ValidNoneSpecialChar(txtPassword.Text, out errMsg))
            {
                CancelValidatedEvent(lblPasswordError, e);
            }
        }

        private void txtPassword_Validated(object sender, EventArgs e)
        {
            lblPasswordError.Text = "";
        }
        #endregion

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren(ValidationConstraints.Enabled))
            {
                return;
            }

            Properties.Settings.Default.LibraryName = txtLibraryName.Text;
            Properties.Settings.Default.LibraryAddress = txtAddress.Text;
            Properties.Settings.Default.LibraryEmail = txtEmail.Text;
            Properties.Settings.Default.LibraryPhoneNumber = txtPhoneNumber.Text;
            Properties.Settings.Default.FineOfBook = Convert.ToInt32(nudFineOfBook.Value);
            Properties.Settings.Default.ConnectionString = connectionString;

            Properties.Settings.Default.Save();
            isComplete = true;

            this.Owner.Show();
            this.Close();
        }

        private void txtServer_TextChanged(object sender, EventArgs e)
        {
            lblConnectionStatus.Text = "Kiểm tra kết nối trước khi hoàn thành";
            btnAccept.Enabled = false;   
        }

        private void frmFirstTime_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isComplete)
            {
                Application.Exit();
            }    
        }
    }
}
