using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New_Library
{
    public partial class frmLogin : Form
    {
        string username;
        string password;
        string role;
        string errMsg = "";

        public frmLogin()
        {
            InitializeComponent();

            this.Text = " ";
            this.ControlBox = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.AcceptButton = this.btnSignin;

            this.txtUsernameFP.Enabled = false;
            this.txtNewPasswordFP.Enabled = false;
            this.txtConfirmPassword.Enabled = false;

            ResetErrorMessage();
        }

        

        private void ResetErrorMessage()
        {
            lblUsernameError.Text = "";
            lblPasswordError.Text = "";
            lblUsernameFPError.Text = "";
            lblNewPasswordFPError.Text = "";
            lblConfirmPasswordError.Text = "";

            this.errLogin.Clear();
            GC.Collect();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình?", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) != DialogResult.OK)
            {
                e.Cancel = true;
            }
            else
            {
                //this.FormClosing -= frmLogin_FormClosing;
                Application.Exit();
            }    
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (this.txtPassword.Text == "Mật khẩu")
            {
                this.txtPassword.Text = "";
                this.txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (this.txtPassword.Text == "")
            {
                this.txtPassword.Text = "Mật khẩu";
                this.txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (this.txtUsername.Text == "Tên đăng nhập")
            {
                this.txtUsername.Text = "";
            }
        }
        
        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (this.txtUsername.Text == "")
            {
                this.txtUsername.Text = "Tên đăng nhập";
            }
        }

        #region Validate input data
        private void CancelValidatedEvent(Control control, Label error, CancelEventArgs e)
        {
            System.Media.SystemSounds.Asterisk.Play();
            e.Cancel = true;
            errLogin.SetError(control, errMsg);
            error.Text = errMsg;
        }

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            if (txtUsername.Text == "Tên đăng nhập")
            {
                errMsg = "Hãy điền tên đăng nhập";
                CancelValidatedEvent(txtUsername, lblUsernameError, e);
                return;
            }
            if (!ValidateInput.ValidNoneSpecialChar(txtUsername.Text, out errMsg))
            {
                CancelValidatedEvent(txtUsername, lblUsernameError, e);
            }
        }

        private void txtUsername_Validated(object sender, EventArgs e)
        {
            this.errLogin.SetError(txtUsername, "");
            this.lblUsernameError.Text = "";
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtPassword.Text == "Mật khẩu")
            {
                errMsg = "Hãy điền mật khẩu";
                CancelValidatedEvent(txtPassword, lblPasswordError, e);
                return;
            }
            if (!ValidateInput.ValidNoneSpecialChar(txtPassword.Text, out errMsg))
            {
                CancelValidatedEvent(txtPassword, lblPasswordError, e);
            }
        }

        private void txtPassword_Validated(object sender, EventArgs e)
        {
            this.errLogin.SetError(txtPassword, "");
            this.lblPasswordError.Text = "";
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

        private void ResetLogin()
        {
            this.AcceptButton = this.btnSignin;
  
            this.txtUsernameFP.Enabled = false;
            this.txtNewPasswordFP.Enabled = false;
            this.txtConfirmPassword.Enabled = false;

            this.txtUsername.Enabled = true;
            this.txtPassword.Enabled = true;

            txtUsername.Text = "Tên đăng nhập";
            txtPassword.Text = "Mật khẩu";
            txtPassword.UseSystemPasswordChar = false;
            txtUsername.Focus();

            ResetErrorMessage();
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren(ValidationConstraints.Enabled))
            {
                return;
            }

            DataTable dt = DataConnection.GetDataTable(@"EXEC sp_select_login_account @TenTaiKhoan = '" + txtUsername.Text + "', @MatKhau = '" + CreateMD5(txtPassword.Text) + "'");
            if (dt.Rows.Count > 0)
            {
                username = txtUsername.Text;
                password = txtPassword.Text;
                role = dt.Rows[0][2].ToString();

                MessageBox.Show("Xin chào " + txtUsername.Text + "! Bạn đã đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                frmMain frmMain = new frmMain(username, password, role);
                frmMain.Owner = this;
                frmMain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ResetLogin();
        }

        private void lblForgotPassword_Click(object sender, EventArgs e)
        {
            tmrForgotPassword.Start();
            this.AcceptButton = this.btnChangePassword;
            //this.btnChangePassword.Focus();

            this.txtUsernameFP.Enabled = true;
            this.txtNewPasswordFP.Enabled = true;
            this.txtConfirmPassword.Enabled = true;

            this.txtUsername.Enabled = false;
            this.txtPassword.Enabled = false;

            this.txtUsernameFP.Focus();
        }

        private void tmrForgotPassword_Tick(object sender, EventArgs e)
        {
            this.pnlSignin.Left -= 10;
            this.pnlForgotPassword.Left -= 10;
            if (this.pnlForgotPassword.Left <= 20)
            {
                tmrForgotPassword.Stop();
            }
        }

        private void ResetFogotPassword()
        {
            txtUsernameFP.Text = "Tên đăng nhập";
            txtNewPasswordFP.Text = "Mật khẩu mới";
            txtConfirmPassword.Text = "Xác nhận Mật khẩu";
            txtNewPasswordFP.UseSystemPasswordChar = false;
            txtConfirmPassword.UseSystemPasswordChar = false;
            txtUsernameFP.Focus();

            ResetErrorMessage();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            tmrLogin.Start();
            ResetFogotPassword();
            this.AcceptButton = this.btnSignin;
            //this.btnSignin.Focus();

            this.txtUsernameFP.Enabled = false;
            this.txtNewPasswordFP.Enabled = false;
            this.txtConfirmPassword.Enabled = false;

            this.txtUsername.Enabled = true;
            this.txtPassword.Enabled = true;

            this.txtUsername.Focus();
        }

        private void tmrLogin_Tick(object sender, EventArgs e)
        {
            this.pnlSignin.Left += 10;
            this.pnlForgotPassword.Left += 10;
            if (this.pnlSignin.Left >= 15)
            {
                tmrLogin.Stop();
            }
        }

        private void txtUsernameFP_Enter(object sender, EventArgs e)
        {
            if (this.txtUsernameFP.Text == "Tên đăng nhập")
            {
                this.txtUsernameFP.Text = "";
            }    
        }

        private void txtNewPasswordFP_Enter(object sender, EventArgs e)
        {
            if (this.txtNewPasswordFP.Text == "Mật khẩu mới")
            {
                this.txtNewPasswordFP.Text = "";
                this.txtNewPasswordFP.UseSystemPasswordChar = true;
            }
        }

        private void txtConfirmPassword_Enter(object sender, EventArgs e)
        {
            if (this.txtConfirmPassword.Text == "Xác nhận Mật khẩu")
            {
                this.txtConfirmPassword.Text = "";
                this.txtConfirmPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtUsernameFP_Leave(object sender, EventArgs e)
        {
            if (this.txtUsernameFP.Text == "")
            {
                this.txtUsernameFP.Text = "Tên đăng nhập";
            }
        }

        private void txtNewPasswordFP_Leave(object sender, EventArgs e)
        {
            if (this.txtNewPasswordFP.Text == "")
            {
                this.txtNewPasswordFP.Text = "Mật khẩu mới";
                this.txtNewPasswordFP.UseSystemPasswordChar = false;
            }
        }

        private void txtConfirmPassword_Leave(object sender, EventArgs e)
        {
            if (this.txtConfirmPassword.Text == "")
            {
                this.txtConfirmPassword.Text = "Xác nhận Mật khẩu";
                this.txtConfirmPassword.UseSystemPasswordChar = false;
            }
        }

        private void txtUsernameFP_Validating(object sender, CancelEventArgs e)
        {
            if (txtUsernameFP.Text == "Tên đăng nhập")
            {
                errMsg = "Hãy điền tên đăng nhập";
                CancelValidatedEvent(txtUsernameFP, lblUsernameFPError, e);
            }
            if (!ValidateInput.ValidNoneSpecialChar(txtUsernameFP.Text, out errMsg))
            {
                CancelValidatedEvent(txtUsernameFP, lblUsernameFPError, e);
            }    
        }

        private void txtUsernameFP_Validated(object sender, EventArgs e)
        {
            this.errLogin.SetError(txtUsernameFP, "");
            this.lblUsernameFPError.Text = "";
        }

        private void txtNewPasswordFP_Validating(object sender, CancelEventArgs e)
        {
            if (txtNewPasswordFP.Text == "Mật khẩu mới")
            {
                errMsg = "Hãy điền mật khẩu mới";
                CancelValidatedEvent(txtNewPasswordFP, lblNewPasswordFPError, e);
            }
            if (!ValidateInput.ValidNoneSpecialChar(txtNewPasswordFP.Text, out errMsg))
            {
                CancelValidatedEvent(txtNewPasswordFP, lblNewPasswordFPError, e);
            }
        }

        private void txtNewPasswordFP_Validated(object sender, EventArgs e)
        {
            this.errLogin.SetError(txtNewPasswordFP, "");
            this.lblNewPasswordFPError.Text = "";
        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {           
            if (txtConfirmPassword.Text == "Xác nhận Mật khẩu") 
            {
                errMsg = "Hãy xác nhận mật khẩu";
                CancelValidatedEvent(txtConfirmPassword, lblConfirmPasswordError, e);
            }
            if (!ValidateInput.ValidNoneSpecialChar(txtConfirmPassword.Text, out errMsg))
            {
                CancelValidatedEvent(txtConfirmPassword, lblConfirmPasswordError, e);
            }
            if (txtNewPasswordFP.Text != txtConfirmPassword.Text)
            {
                errMsg = "Mật khẩu xác nhận không trùng khớp";
                CancelValidatedEvent(txtConfirmPassword, lblConfirmPasswordError, e);
            }
        }

        private void txtConfirmPassword_Validated(object sender, EventArgs e)
        {
            this.errLogin.SetError(txtConfirmPassword, "");
            this.lblConfirmPasswordError.Text = "";
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        { 
            if (!ValidateChildren(ValidationConstraints.Enabled))
            {
                return;
            }

            DataTable dt = DataConnection.GetDataTable(@"EXEC sp_select_forgot_password_account @TenTaiKhoan = '" + txtUsernameFP.Text + "'");
            if (dt.Rows.Count > 0)
            {
                string update = @"EXEC sp_update_password @TenTaiKhoan = '" + txtUsernameFP.Text + "', @MatKhau = '" + CreateMD5(txtNewPasswordFP.Text) + "'";
                if (DataConnection.ExecuteQuery(update))
                {
                    MessageBox.Show("Đổi mật khẩu thành công! Hãy đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Đổi mật khẩu thất bại! Hãy đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                tmrLogin.Start();
                ResetLogin();
            }
            else
            {
                MessageBox.Show("Tài khoản không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ResetFogotPassword();
        }
    }
}