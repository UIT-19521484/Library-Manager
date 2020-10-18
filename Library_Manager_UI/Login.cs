using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Manager_UI
{
    public partial class frmLogin : Form
    {
        string username;
        string password;
        public frmLogin()
        {
            InitializeComponent();
            txtUsername.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên đăng nhập hoặc mật khẩu!", "Thông báo");
                return;
            }
            DataTable dt = DataConnection.GetDataTable("Select * from Users where Username = '" + txtUsername.Text + "' and Password = '" + CreateMD5(txtPassword.Text) + "'");
            if (dt.Rows.Count > 0)
            {
                username = txtUsername.Text;
                password = txtPassword.Text;
                MessageBox.Show("Xin chào " + txtUsername.Text + "! Bạn đã đăng nhập thành công!", "Thông báo");
                txtUsername.Text = "";
                txtPassword.Text = "";
                txtUsername.Focus();
                frmMain frmMain = new frmMain(username, password);
                frmMain.Owner = this;
                frmMain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!", "Thông báo");
                txtUsername.Text = "";
                txtPassword.Text = "";
                txtUsername.Focus();
            }
        }
        
        private void lblSignup_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtUsername.Focus();
            frmSignup frmSignup = new frmSignup();
            frmSignup.Owner = this;
            frmSignup.Show();
            this.Hide();
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình ?", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void lblResetPassword_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtUsername.Focus();
            frmResetPassword frmResetPW= new frmResetPassword();
            frmResetPW.Owner = this;
            frmResetPW.Show();
            this.Hide();
        }
    }
}
