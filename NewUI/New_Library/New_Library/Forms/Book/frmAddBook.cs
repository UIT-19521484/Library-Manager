using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace New_Library.Forms.Book
{
    public partial class frmAddBook : Form
    {
        private string errMsg;

        public frmAddBook()
        {
            InitializeComponent();

            LoadData_Genre();
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
            DataTable dt = DatabaseData.dtGenre.Copy();

            cboGenre.DisplayMember = dt.Columns[1].ToString();
            cboGenre.DataSource = dt;
            cboGenre.SelectedIndex = -1;
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

        private void cbGenre_Validating(object sender, CancelEventArgs e)
        {
            if (cboGenre.SelectedIndex == -1)
            {
                e.Cancel = true;
                errMsg = "Chưa chọn thể loại";
                CancelValidatedEvent(grpGenre, lblGenreError, e);
            }
        }

        private void cbGenre_Validated(object sender, EventArgs e)
        {
            lblGenreError.Text = "";
            errAddBook.SetError(grpGenre, "");
        }
        #endregion

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
            return true;
        }

        private void frmAddBook_Load(object sender, EventArgs e)
        {
            lblBookNameError.Text = "";
            lblAuthorNameError.Text = "";
            lblPublisherNameError.Text = "";
            lblAvailableWarning.Text = "";
            lblGenreError.Text = "";
            txtBookName.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();

            GC.Collect();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren(ValidationConstraints.Enabled))
            {
                return;
            }

            if (IsBookExist())
            {
                DialogResult rs = 
                    MessageBox.Show
                    ("Sách này đã tồn tại trong cơ sở dữ liệu.\n" +
                    "Cộng thêm số lượng vào sách đã có hiện tại hiện tại?",
                    "Thông báo", 
                    MessageBoxButtons.OKCancel, 
                    MessageBoxIcon.Question);

                if (rs == DialogResult.OK)
                {
                    string cmd = "EXEC sp_increase_book_quantity "
                        + "@TenSach = N'" + txtBookName.Text + "', "
                        + "@TacGia = N'" + txtAuthorName.Text + "', "
                        + "@NhaXuatBan = N'" + txtPublisherName.Text + "', "
                        + "@TenTL = N'" + cboGenre.Text + "', "
                        + "@SoLuong = " + txtAvailable.Text;
                    if (DataConnection.ExecuteQuery(cmd))
                    {
                        MessageBox.Show("Thêm số lượng sách có sẵn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        return;
                    }
                }
            }
            else
            {
                string cmd = @"EXEC sp_insert_book "
                        + "@TenSach = N'" + txtBookName.Text + "', "
                        + "@TacGia = N'" + txtAuthorName.Text + "', "
                        + "@NhaXuatBan = N'" + txtPublisherName.Text + "', "
                        + "@TenTL = N'" + cboGenre.Text + "', "
                        + "@TonTai = " + txtAvailable.Text;

                if (DataConnection.ExecuteQuery(cmd))
                {
                    MessageBox.Show("Thêm thông tin sách thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }    
            }

            this.Dispose();
        }
    }
}
