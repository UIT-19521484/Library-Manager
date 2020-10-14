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
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult box = MessageBox.Show("Do you really want to exit?", "Exit", MessageBoxButtons.YesNo);

            if (box == DialogResult.Yes)
                Application.Exit();
            else if (box == DialogResult.No)
                e.Cancel = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain();
            frmMain.Owner = this;
            frmMain.ShowDialog();
            this.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            frmResetPassword frmResetPassword = new frmResetPassword();
            frmResetPassword.Owner = this;
            frmResetPassword.Show();
            this.Hide();
        }
    }
}
