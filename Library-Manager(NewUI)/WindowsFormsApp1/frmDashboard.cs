﻿using System;
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
            lblNoReader.Text = DataConnection.ExecuteScalar(new System.Data.SqlClient.SqlCommand("sp_count_all_readers")).ToString();
            lblNoAvailableCopies.Text = DataConnection.ExecuteScalar(new System.Data.SqlClient.SqlCommand("sp_count_all_available_books")).ToString();
            lblNoTotalBook.Text = DataConnection.ExecuteScalar(new System.Data.SqlClient.SqlCommand("sp_book_count")).ToString();
            lblNoTotalCopies.Text = DataConnection.ExecuteScalar(new System.Data.SqlClient.SqlCommand("sp_count_all_books")).ToString();
            lblNoBorrowed.Text = DataConnection.ExecuteScalar(new System.Data.SqlClient.SqlCommand("sp_borrowed_count")).ToString();
            lblNoOverdue.Text = DataConnection.ExecuteScalar(new System.Data.SqlClient.SqlCommand("sp_overdue_count")).ToString();
            lblNoBorrowing.Text = DataConnection.ExecuteScalar(new System.Data.SqlClient.SqlCommand("sp_borrowing_count")).ToString();
        }
    }
}