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
    public partial class frmAddBook : Form
    {
        string errMsg;
        public frmAddBook()
        {
            InitializeComponent();
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            if(!ValidateInput.ValidName(txtName.Text, out errMsg))
            {
                e.Cancel = true;
                errorProvider.SetError(txtName, errMsg);
                lblNameError.Text = errMsg;
                lblNameError.ForeColor = Color.Red;
            }
        }

        private void txtName_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(txtName, "");
            lblNameError.Text = "OK";
            lblNameError.ForeColor = Color.Green;
        }

        private void txtAuthor_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidateInput.ValidName(txtAuthor.Text, out errMsg))
            {
                e.Cancel = true;
                errorProvider.SetError(txtAuthor, errMsg);
                lblAuthorError.Text = errMsg;
                lblAuthorError.ForeColor = Color.Red;
            }
        }

        private void txtAuthor_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(txtAuthor, "");
            lblAuthorError.Text = "OK";
            lblAuthorError.ForeColor = Color.Green;
        }

        private void txtPulisher_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidateInput.ValidNoneSpCharacter(txtPublisher.Text, out errMsg))
            {
                e.Cancel = true;
                errorProvider.SetError(txtPublisher, errMsg);
                lblPulisherError.Text = errMsg;
                lblPulisherError.ForeColor = Color.Red;
            }
        }

        private void txtPulisher_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(txtPublisher, "");
            lblPulisherError.Text = "OK";
            lblPulisherError.ForeColor = Color.Green;
        }

        private void txtNumber_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidateInput.ValidNumber(txtNumber.Text, out errMsg))
            {
                e.Cancel = true;
                errorProvider.SetError(txtNumber, errMsg);
                lblStoredError.Text = errMsg;
                lblStoredError.ForeColor = Color.Red;
            }
        }

        private void txtNumber_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(txtNumber, "");
            lblStoredError.Text = "OK";
            lblStoredError.ForeColor = Color.Green;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren(ValidationConstraints.Enabled))
            {
                return;
            }

            using (System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand())
            {
                int ID_Genre = Convert.ToInt32
                    (DataConnection.ExecuteQuery(new System.Data.SqlClient.SqlCommand("select MaTL from THELOAI where TenTL = '" + cbGenre.Text + "'")));

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_check_book_is_exists";
                cmd.Parameters.AddWithValue("@TenSach", txtName.Text);
                cmd.Parameters.AddWithValue("@TacGia", txtAuthor.Text);
                cmd.Parameters.AddWithValue("@NhaXuatBan", txtPublisher.Text);
                cmd.Parameters.AddWithValue("@MaTL", ID_Genre);

                if (DataConnection.ExecuteScalar(cmd) < 1)
                {
                    cmd.CommandText = "sp_add_book";
                    cmd.Parameters.AddWithValue("@TonTai", Convert.ToInt32(txtNumber.Text));

                    if (DataConnection.ExecuteQuery(cmd))
                    {
                        MessageBox.Show("Thêm sách thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Dispose();
                    }    
                }
                else
                {
                    DialogResult re = MessageBox.Show
                    ("Sách này đã tồn tại. Cộng thêm số lượng vào số lượng đang lưu trữ?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (re == DialogResult.Yes)
                    {
                        cmd.CommandText = "update SACH set TonTai = TonTai + " + Convert.ToInt32(txtNumber.Text);
                        if (DataConnection.ExecuteQuery(cmd))
                        {
                            MessageBox.Show("Thêm số lượng sách thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else if (re == DialogResult.No)
                    {
                        this.Dispose();
                    }    
                    else if (re == DialogResult.Cancel)
                    {
                        return;
                    }    
                }    
            }    
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmAddBook_Load(object sender, EventArgs e)
        {
            cbGenre.DisplayMember = "TÊN THỂ LOẠI";
            cbGenre.DataSource = DataConnection.GetDataTable(new System.Data.SqlClient.SqlCommand("sp_select_all_genres"));
        }
    }
}
