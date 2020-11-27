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
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            lblNoReader.Text = DataConnection.ExecuteScalar("sp_reader_count").ToString();
            lblNoAvailableCopies.Text = DataConnection.ExecuteScalar("sp_available_copies_count").ToString();
            lblNoTotalBook.Text = DataConnection.ExecuteScalar("sp_book_count").ToString();
            lblNoTotalCopies.Text = DataConnection.ExecuteScalar("sp_copies_count").ToString();
            lblNoBorrowed.Text = DataConnection.ExecuteScalar("sp_borrowed_count").ToString();
            lblNoOverdue.Text = DataConnection.ExecuteScalar("sp_overdue_count").ToString();
            lblNoBorrowing.Text = DataConnection.ExecuteScalar("sp_borrowing_count").ToString();
        }
    }
}
