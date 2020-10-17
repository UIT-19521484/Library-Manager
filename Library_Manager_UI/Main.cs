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
        public frmMain()
        {
            InitializeComponent();
            LoadDataTableReaders();
            LoadDataTableBooks();
        }

        void LoadDataTableReaders()
        {
            string str = @"select * from DocGia";
            DataTable dt = data_testConnection.GetDataTable(str);
            dgvReaders.DataSource = dt;
        }

        void LoadDataTableBooks()
        {
            string str = @"select * from Sach";
            DataTable dt = data_testConnection.GetDataTable(str);
            dgvBooks.DataSource = dt;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        
    }
}
