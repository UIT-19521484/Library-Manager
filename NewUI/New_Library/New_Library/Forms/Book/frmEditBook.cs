using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New_Library.Forms.Book
{
    public partial class frmEditBook : Form
    {
        string errMsg;
        DataTable dt = DatabaseData.dtGenre.Copy();
        int bookID;

        public frmEditBook(LibraryEntity.Book selectedBook)
        {
            InitializeComponent();
            LoadData_Genre();

            txtBookName.Text = selectedBook.TenSach;
            txtAuthorName.Text = selectedBook.TacGia;
            txtPublisherName.Text = selectedBook.NhaXB;
            txtAvailable.Text = selectedBook.TonTai.ToString();
            cbGenre.Text = (from DataRow dr in dt.Rows
                           where (int)dr["MaTL"] == selectedBook.MaTL
                           select (string)dr["TÊN THỂ LOẠI"]).FirstOrDefault();
            bookID = selectedBook.MaSach;
        }

        private void CancelValidatedEvent(Control control, Label error, CancelEventArgs e)
        {
            System.Media.SystemSounds.Asterisk.Play();
            e.Cancel = true;
            errAddBook.SetError(control, errMsg);
            error.Text = errMsg;
        }

        private void LoadData_Genre()
        {
            cbGenre.DisplayMember = dt.Columns[1].ToString();
            cbGenre.DataSource = dt;
            cbGenre.SelectedIndex = -1;
        }

        //private bool IsBookExist()
        //{
        //    string cmd = @"Select TenSach, TacGia, NhaXuatBan, TenTL, TonTai from SACH left join THELOAI on SACH.MaTL = THELOAI.MaTL where "
        //                + "TenSach = N'" + txtBookName.Text + "' and "
        //                + "TacGia = N'" + txtAuthorName.Text + "' and "
        //                + "NhaXuatBan = N'" + txtPublisherName.Text + "' and "
        //                + "TenTL = N'" + cbGenre.Text + "' and"
        //                + "TonTai = " + txtAvailable;

        //    if (DataConnection.GetDataTable(cmd).Rows.Count == 0)
        //    {
        //        return false;
        //    }
        //    return true;
        //}

        private void frmAddBook_Load(object sender, EventArgs e)
        {
            lblBookNameError.Text = "";
            lblAuthorNameError.Text = "";
            lblPublisherNameError.Text = "";
            lblAvailableWarning.Text = "";
            txtBookName.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();

            GC.Collect();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren(ValidationConstraints.Enabled))
            {
                return;
            }

            string cmd = @"EXEC sp_update_book "
                        + "@MaSach = " + bookID.ToString() + ", "
                        + "@TenSach = N'" + txtBookName.Text + "', "
                        + "@TacGia = N'" + txtAuthorName.Text + "', "
                        + "@NhaXuatBan = N'" + txtPublisherName.Text + "', "
                        + "@TenTL = N'" + cbGenre.Text + "', "
                        + "@TonTai = " + txtAvailable.Text;

            if (DataConnection.ExecuteQuery(cmd))
            {
                MessageBox.Show("Thay đổi thông tin sách thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                return;
            }    
            this.Dispose();
        }

        #region Validate input data
        private void txtBookName_Validating(object sender, CancelEventArgs e)
        {
            if (ValidateInput.IsEmpty(txtBookName.Text, out errMsg))
            {
                CancelValidatedEvent(grpBookName, lblBookNameError, e);
            }
        }

        private void txtBookName_Validated(object sender, EventArgs e)
        {
            errAddBook.SetError(grpBookName, "");
            lblBookNameError.Text = errMsg;
        }

        private void txtAuthorName_Validating(object sender, CancelEventArgs e)
        {
            if (ValidateInput.IsEmpty(txtAuthorName.Text, out errMsg))
            {
                CancelValidatedEvent(grpAuthorName, lblAuthorNameError, e);
            }
        }

        private void txtAuthorName_Validated(object sender, EventArgs e)
        {
            errAddBook.SetError(grpAuthorName, "");
            lblAuthorNameError.Text = errMsg;
        }

        private void txtPublisherName_Validating(object sender, CancelEventArgs e)
        {
            if (ValidateInput.IsEmpty(txtPublisherName.Text, out errMsg))
            {
                CancelValidatedEvent(grpPublisher, lblPublisherNameError, e);
            }
        }

        private void txtPublisherName_Validated(object sender, EventArgs e)
        {
            errAddBook.SetError(grpPublisher, "");
            lblPublisherNameError.Text = errMsg;
        }

        private void txtAvailable_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblAvailableWarning.Text = "";
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                System.Media.SystemSounds.Asterisk.Play();
                e.Handled = true;
                lblAvailableWarning.Text = "Trường này chỉ nhập số";
            }
        }

        private void txtAvailable_Validating(object sender, CancelEventArgs e)
        {
            if (ValidateInput.IsEmpty(txtAvailable.Text, out errMsg))
            {
                CancelValidatedEvent(grpAvailable, lblAvailableWarning, e);
            }
        }

        private void txtAvailable_Validated(object sender, EventArgs e)
        {
            errAddBook.SetError(grpAvailable, "");
            lblAvailableWarning.Text = "";
        }
        #endregion
    }
}
