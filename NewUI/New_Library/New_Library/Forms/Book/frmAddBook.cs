﻿using System;
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

            cbGenre.DisplayMember = dt.Columns[1].ToString();
            cbGenre.DataSource = dt;
            cbGenre.SelectedIndex = -1;
        }

        #region Validate input data
        private void txtBookName_Validating(object sender, CancelEventArgs e)
        {
            if (ValidateInput.IsEmpty(txtBookName.Text, out errMsg))
            {
                CancelValidatedEvent(gbBookName, lblBookNameError, e);
            }
        }

        private void txtBookName_Validated(object sender, EventArgs e)
        {
            errAddBook.SetError(gbBookName, "");
            lblBookNameError.Text = errMsg;
        }

        private void txtAuthorName_Validating(object sender, CancelEventArgs e)
        {
            if (ValidateInput.IsEmpty(txtAuthorName.Text, out errMsg))
            {
                CancelValidatedEvent(gbAuthorName, lblAuthorNameError, e);
            }
        }

        private void txtAuthorName_Validated(object sender, EventArgs e)
        {
            errAddBook.SetError(gbAuthorName, "");
            lblAuthorNameError.Text = errMsg;
        }

        private void txtPublisherName_Validating(object sender, CancelEventArgs e)
        {
            if (ValidateInput.IsEmpty(txtPublisherName.Text, out errMsg))
            {
                CancelValidatedEvent(gbPublisher, lblPublisherNameError, e);
            }
        }

        private void txtPublisherName_Validated(object sender, EventArgs e)
        {
            errAddBook.SetError(gbPublisher, "");
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
                CancelValidatedEvent(gbAvailable, lblAvailableWarning, e);
            }
        }

        private void txtAvailable_Validated(object sender, EventArgs e)
        {
            errAddBook.SetError(gbAvailable, "");
            lblAvailableWarning.Text = "";
        }

        private void cbGenre_Validating(object sender, CancelEventArgs e)
        {
            if (cbGenre.SelectedIndex == -1)
            {
                e.Cancel = true;
                errMsg = "Chưa chọn thể loại";
                CancelValidatedEvent(gbGenre, lblGenreError, e);
            }
        }

        private void cbGenre_Validated(object sender, EventArgs e)
        {
            lblGenreError.Text = "";
            errAddBook.SetError(gbGenre, "");
        }
        #endregion

        private bool IsBookExist()
        {
            string cmd = @"Select TenSach, TacGia, NhaXuatBan, TenTL from SACH left join THELOAI on SACH.MaTL = THELOAI.MaTL where "
                        + "TenSach = N'" + txtBookName.Text + "' and "
                        + "TacGia = N'" + txtAuthorName.Text + "' and "
                        + "NhaXuatBan = N'" + txtPublisherName.Text + "' and "
                        + "TenTL = N'" + cbGenre.Text + "'";

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
                        + "@TenTL = N'" + cbGenre.Text + "', "
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
                        + "@TenTL = N'" + cbGenre.Text + "', "
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
