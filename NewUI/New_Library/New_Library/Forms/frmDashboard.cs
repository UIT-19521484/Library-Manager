﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New_Library.Forms
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            txtLibraryName.Text = Properties.Settings.Default.LibraryName;
            txtAddress.Text = Properties.Settings.Default.LibraryAddress;
            txtEmail.Text = Properties.Settings.Default.LibraryEmail;
            txtPhoneNumber.Text = Properties.Settings.Default.LibraryPhoneNumber;

            this.lblNoTotalReader.Text = DataConnection.ExecuteScalar(@"EXEC sp_count_all_readers").ToString();
            this.lblNoBorrowingReader.Text = DataConnection.ExecuteScalar(@"EXEC sp_count_borrowing_readers").ToString();
            this.lblNoOverdueReader.Text = DataConnection.ExecuteScalar(@"EXEC sp_count_overdue_readers").ToString();
            this.lblNoTotalBook.Text = DataConnection.ExecuteScalar(@"EXEC sp_count_all_books").ToString();
            this.lblNoTotalGenres.Text = DataConnection.ExecuteScalar(@"EXEC sp_count_all_genres").ToString();
            this.lblNoTotalAvailableCopies.Text = DataConnection.ExecuteScalar(@"EXEC sp_count_all_available_books").ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtLibraryName.ReadOnly = !txtLibraryName.ReadOnly;
            txtAddress.ReadOnly = !txtAddress.ReadOnly;
            txtPhoneNumber.ReadOnly = !txtPhoneNumber.ReadOnly;
            txtEmail.ReadOnly = !txtEmail.ReadOnly;
        }
    }
}