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
        public frmLogin()
        {
            InitializeComponent();
            txtUsername.Focus();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult box = MessageBox.Show("Bạn có muốn thoát chương trình ?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (box == DialogResult.Yes)
                Application.Exit();
            else if (box == DialogResult.No)
                e.Cancel = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên đăng nhập hoặc mật khẩu!", "Thông báo");
                return;
            }
            DataTable dt = data_testConnection.GetDataTable("Select * from Users where ID = '" + txtUsername.Text + "' and PassWord = '" + CreateMD5(txtPassword.Text) + "'");
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Xin chào " + txtUsername.Text + "! Bạn đã đăng nhập thành công!", "Thông báo");
                this.Hide();
                frmMain frmMain = new frmMain();
                frmMain.Owner = this;
                frmMain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Đăng nhập không thành công!", "Thông báo");
                txtUsername.Clear();
                txtPassword.Clear();
                txtUsername.Focus();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void lblResetPassword_Click(object sender, EventArgs e)
        {
            frmChangePassword frmResetPassword = new frmChangePassword();
            frmResetPassword.Owner = this;
            frmResetPassword.Show();
            this.Hide();
        }

        private void lblSignup_Click(object sender, EventArgs e)
        {
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
    }
}
