using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New_Library.Forms.Genre
{
    public partial class frmAddGenre : Form
    {
        public frmAddGenre()
        {
            InitializeComponent();
            txtGenreName.Focus();
            lblGenreNameError.Text = "";
        }

        string errMsg;
        private void CancelValidatedEvent(Label error, CancelEventArgs e)
        {
            System.Media.SystemSounds.Asterisk.Play();
            e.Cancel = true;
            error.Text = errMsg;
        }

        private void txtGenreName_Validating(object sender, CancelEventArgs e)
        {
            if (txtGenreName.Text.Length == 0)
            {
                errMsg = "Trường này không được trống";
                CancelValidatedEvent(lblGenreNameError, e);
            }
            else if (!ValidateInput.ValidNoneSpecialChar(txtGenreName.Text, out errMsg))
            {
                CancelValidatedEvent(lblGenreNameError, e);
            }
        }

        private void txtGenreName_Validated(object sender, EventArgs e)
        {
            lblGenreNameError.Text = "";
        }

        private void btnCancelAdd_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAddGenre_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren(ValidationConstraints.Enabled))
            {
                return;
            }

            DataTable dt = DataConnection.GetDataTable(@"SELECT * FROM THELOAI WHERE TenTL = N'" + txtGenreName.Text + "'");
            switch (dt.Rows.Count)
            {
                case 0:
                    string command = @"INSERT INTO THELOAI (TenTL) VALUES (N'" + txtGenreName.Text + "')";
                    DataConnection.ExecuteQuery(command);
                    MessageBox.Show("Thêm thể loại thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                default:
                    MessageBox.Show("Đã tồn tại thể loại này!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }
        }
    }
}
