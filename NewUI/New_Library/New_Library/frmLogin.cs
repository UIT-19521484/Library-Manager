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

        public frmLogin()
        {
            InitializeComponent();

            this.Text = "Phần mềm quản lý thư viện";
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.AcceptButton = this.btnSignin;
            this.txtUsername.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void ResetLogin()
        {
            txtUsername.Text = "Tên đăng nhập";
            txtPassword.Text = "Mật khẩu";
            txtPassword.UseSystemPasswordChar = false;
            txtUsername.Focus();
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên đăng nhập hoặc mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ResetLogin();

                return;
            }
            DataTable dt = DataConnection.GetDataTable(@"EXEC sp_select_login_account @TenTaiKhoan = '" + txtUsername.Text + "', @MatKhau = '" + CreateMD5(txtPassword.Text) + "'");
            if (dt.Rows.Count > 0)
            {
                username = txtUsername.Text;
                password = txtPassword.Text;
                role = dt.Rows[0][2].ToString();

                MessageBox.Show("Xin chào " + txtUsername.Text + "! Bạn đã đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetLogin();

                frmMain frmMain = new frmMain(username, password, role);
                frmMain.Owner = this;
                frmMain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ResetLogin();
            }
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        { 
            if (MessageBox.Show("Bạn có muốn thoát chương trình ?", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) != DialogResult.OK)
            {
                e.Cancel = true;
                ResetLogin();
            }
        }
        
        private void lblForgotPassword_Click(object sender, EventArgs e)
        {
            tmrForgotPassword.Start();
            txtUsernameFP.Focus();
            
        }
        private void tmrForgotPassword_Tick(object sender, EventArgs e)
        {
            this.pnlSignin.Left -= 10;
            this.pnlForgotPassword.Left -= 10;
            if (this.pnlForgotPassword.Left <= 20)
            {
                tmrForgotPassword.Stop();
                this.AcceptButton = this.btnChangePassword;
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
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            tmrLogin.Start();
            ResetFogotPassword();
            txtUsername.Focus();
        }
        private void tmrLogin_Tick(object sender, EventArgs e)
        {

            this.pnlSignin.Left += 10;
            this.pnlForgotPassword.Left += 10;
            if (this.pnlSignin.Left >= 15)
            {
                tmrLogin.Stop();
                this.AcceptButton = this.btnSignin;
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (txtUsernameFP.Text == "" || txtNewPasswordFP.Text == "" || txtConfirmPassword.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên đăng nhập hoặc mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ResetFogotPassword();

                return;
            }
            DataTable dt = DataConnection.GetDataTable(@"EXEC sp_select_forgot_password_account @TenTaiKhoan = '" + txtUsernameFP.Text + "'");
            if (dt.Rows.Count > 0)
            {
                string update = @"EXEC sp_update_password @TenTaiKhoan = '" + txtUsernameFP.Text + "', @MatKhau = '" + CreateMD5(txtNewPasswordFP.Text) + "'";

                DataConnection.ExecuteQuery(update);
                
                MessageBox.Show("Đổi mật khẩu thành công! Hãy đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                tmrLogin.Start();

                ResetFogotPassword();

                txtUsername.Focus();
            }
            else
            {
                MessageBox.Show("Tài khoản không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ResetFogotPassword();
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            this.txtPassword.UseSystemPasswordChar = true;
        }

        private void txtNewPasswordFP_TextChanged(object sender, EventArgs e)
        {
            this.txtNewPasswordFP.UseSystemPasswordChar = true;
        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            this.txtConfirmPassword.UseSystemPasswordChar = true;
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

        
    }
}
