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
    public partial class frmChangePassword : Form
    {
        string username;
        string password;
        public frmChangePassword()
        {
            InitializeComponent();
        }
        public frmChangePassword(string user, string pass)
        {
            username = user;
            password = pass;
            InitializeComponent();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string update = "update Users set Password='" + CreateMD5(txtNewPassword.Text) + "' where(Username=N'" + txtUsername.Text + "' and Password='" + CreateMD5(txtPassword.Text) + "')";
            string ten = txtUsername.Text;
            if (ten == "")
            {
                MessageBox.Show("Bạn chưa nhập tên truy cập");
            }
            else
            {
                if (txtPassword.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập mật khẩu");
                }
                else
                {
                    if (txtNewPassword.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhập mật khẩu mới");
                    }
                    else
                    {
                        if (txtConfirmPassword.Text == "")
                        {
                            MessageBox.Show("Bạn chưa nhập lại mật khẩu");
                        }
                        else
                        {
                            if ((txtNewPassword.Text == txtConfirmPassword.Text))
                            {
                                DataTable dt = DataConnection.GetDataTable("Select * from Users where Username = '" + txtUsername.Text + "' and Password='" + CreateMD5(txtPassword.Text) + "'");
                                if (dt.Rows.Count > 0)
                                {
                                    DataConnection.ExecuteQuery(update);
                                    MessageBox.Show("Thay đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK);
                                    this.Owner.Show();
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Mật khẩu cũ không đúng");
                                }    
                            }
                            else
                            {
                                MessageBox.Show("Hai mật khẩu không khớp");
                            }
                        }
                    }
                }
            }
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

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            txtUsername.Text = username;
        }
    }
}
