using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace New_Library.Forms.Book
{
    public partial class frmEditBook : Form
    {
        string errMsg;
        DataTable dt = DatabaseData.dtGenre.Copy();
        int bookID;

        LibraryEntity.Book selectedBook;

        public frmEditBook(LibraryEntity.Book selectedBook)
        {
            InitializeComponent();
            LoadData_Genre();

            txtBookName.Text = selectedBook.TenSach;
            txtAuthorName.Text = selectedBook.TacGia;
            txtPublisherName.Text = selectedBook.NhaXB;
            txtAvailable.Text = selectedBook.TonTai.ToString();
            cboGenre.Text = (from DataRow dr in dt.Rows
                           where (int)dr["MaTL"] == selectedBook.MaTL
                           select (string)dr["THỂ LOẠI"]).FirstOrDefault();
            bookID = selectedBook.MaSach;

            this.selectedBook = selectedBook;
        }

        private void CancelValidatedEvent(Control control, Label error, CancelEventArgs e)
        {
            System.Media.SystemSounds.Asterisk.Play();
            e.Cancel = true;
            errEditBook.SetError(control, errMsg);
            error.Text = errMsg;
        }

        private void LoadData_Genre()
        {
            cboGenre.DisplayMember = dt.Columns[1].ToString();
            cboGenre.DataSource = dt;
            cboGenre.SelectedIndex = -1;
        }

        private bool IsBookExist()
        {
            string cmd = @"Select TenSach, TacGia, NhaXuatBan, TenTL from SACH, THELOAI where SACH.MaTL = THELOAI.MaTL and "
                        + "TenSach = N'" + txtBookName.Text + "' and "
                        + "TacGia = N'" + txtAuthorName.Text + "' and "
                        + "NhaXuatBan = N'" + txtPublisherName.Text + "' and "
                        + "TenTL = N'" + cboGenre.Text + "'";
            if (DataConnection.GetDataTable(cmd).Rows.Count == 0)
            {
                return false;
            }
            //sách sau khi sửa vẫn như cũ thì ko bị
            if (txtBookName.Text == this.selectedBook.TenSach && txtAuthorName.Text == this.selectedBook.TacGia && txtPublisherName.Text == this.selectedBook.NhaXB)
            {
                return false;
            }    
            return true;
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

            if (IsBookExist())
            {
                MessageBox.Show
                    ("Sách này đã tồn tại trong cơ sở dữ liệu.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                string cmd = @"EXEC sp_update_book "
                        + "@MaSach = " + bookID.ToString() + ", "
                        + "@TenSach = N'" + txtBookName.Text + "', "
                        + "@TacGia = N'" + txtAuthorName.Text + "', "
                        + "@NhaXuatBan = N'" + txtPublisherName.Text + "', "
                        + "@TenTL = N'" + cboGenre.Text + "', "
                        + "@TonTai = " + txtAvailable.Text;

                if (DataConnection.ExecuteQuery(cmd))
                {
                    MessageBox.Show("Thay đổi thông tin sách thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    return;
                }
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
            errEditBook.SetError(grpBookName, "");
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
            errEditBook.SetError(grpAuthorName, "");
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
            errEditBook.SetError(grpPublisher, "");
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
            errEditBook.SetError(grpAvailable, "");
            lblAvailableWarning.Text = "";
        }
        #endregion

        private void frmEditBook_Load(object sender, EventArgs e)
        {
            lblBookNameError.Text = "";
            lblAuthorNameError.Text = "";
            lblPublisherNameError.Text = "";
            lblAvailableWarning.Text = "";
            lblGenreError.Text = "";
            txtBookName.Focus();
        }

       
    }
}
