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
    public partial class frmInformation : Form
    {
        public frmInformation()
        {
            InitializeComponent();
            LoadDataTableReaders();
            LoadDataTableBooks();
            LoadDataTableGenres();
        }

        void LoadDataTableReaders()
        {
            string str = @"select * from DocGia";
            DataTable dt = DataConnection.GetDataTable(str);
            dgvReaders.DataSource = dt;
        }

        void LoadDataTableBooks()
        {
            string str = @"select * from Sach";
            DataTable dt = DataConnection.GetDataTable(str);
            dgvBooks.DataSource = dt;
        }

        void LoadDataTableGenres()
        {
            string str = @"select * from TheLoaiSach";
            DataTable dt = DataConnection.GetDataTable(str);
            dgvGenres.DataSource = dt;
        }

        private void frmInformation_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }
    }
}
