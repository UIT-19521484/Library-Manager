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
    public partial class frmMain : Form
    {
        string username;
        string password;
        public frmMain()
        {
            InitializeComponent();
        }

        public frmMain(string user, string pass)
        {
            username = user;
            password = pass;
            InitializeComponent();
        }
        

        private void tsmiChangePassword_Click(object sender, EventArgs e)
        {
            frmChangePassword frmChangePW = new frmChangePassword(username, password);
            frmChangePW.Owner = this;
            frmChangePW.ShowDialog();
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsmiLogout_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void picBooks_Click(object sender, EventArgs e)
        {
            frmBooks frmBooks = new frmBooks();
            frmBooks.Owner = this;
            frmBooks.Show();
            this.Hide();
        }

        private void picGenres_Click(object sender, EventArgs e)
        {
            frmGenres frmGenres = new frmGenres();
            frmGenres.Owner = this;
            frmGenres.Show();
            this.Hide();
        }

        private void picReaders_Click(object sender, EventArgs e)
        {
            frmReaders frmReaders = new frmReaders();
            frmReaders.Owner = this;
            frmReaders.Show();
            this.Hide();
        }
    }
}
