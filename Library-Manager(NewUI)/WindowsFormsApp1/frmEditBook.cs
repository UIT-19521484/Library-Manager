using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmEditBook : Form
    {
        public frmEditBook(string name, string author, string genre, string publisher, string number)
        {
            InitializeComponent();

            cbGenre.DisplayMember = "TÊN THỂ LOẠI";
            cbGenre.DataSource = DataConnection.GetDataTable(new System.Data.SqlClient.SqlCommand("sp_select_all_genres"));

            txtName.Text = name;
            txtAuthor.Text = author;
            txtPublisher.Text = publisher;
            txtNumber.Text = number;
            cbGenre.Text = genre;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
