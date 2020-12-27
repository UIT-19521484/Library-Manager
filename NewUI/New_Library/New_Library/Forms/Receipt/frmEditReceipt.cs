using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New_Library.Forms.Receipt
{
    public partial class frmEditReceipt : Form
    {
        int mahd;
        int madg;
        private string errMsg = "";
        public frmEditReceipt(LibraryEntity.Receipt receipt)
        {
            InitializeComponent();

            lblBorrowDateError.Text = "";
            lblReturnDateError.Text = "";
            lblStatusError.Text = "";

            mahd = receipt.MaHD;
            madg = receipt.MaDG;
            txtReceiptCode.Text = (receipt.MaHD + 10000000).ToString();
            dtpBorrowDate.Value = receipt.NgayMuon;
            dtpReturnDate.Value = receipt.NgayTra;
            cboStatus.Text = receipt.TinhTrang;
            txtBorrowBookTotal.Text = receipt.TongSL.ToString();
            txtFine.Text = receipt.ChiPhi.ToString();
        }
        private void frmEditReceipt_Load(object sender, EventArgs e)
        {
            LoadData_Detail();
        }
        private void LoadData_Detail()
        {
            string command = @"EXEC sp_select_all_details_1_receipt @MaHD = " + mahd;
            DataTable dt = DataConnection.GetDataTable(command);
            dgvDetail.DataSource = dt;
            dgvDetail.Columns["MaHD"].Visible = false;
            dgvDetail.Columns["MaSach"].Visible = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void CancelValidatedEvent(Control control, Label error, CancelEventArgs e)
        {
            System.Media.SystemSounds.Asterisk.Play();
            e.Cancel = true;
            errEditReceipt.SetError(control, errMsg);
            error.Text = errMsg;
        }

        private void dtpBorrowDate_Validating(object sender, CancelEventArgs e)
        {
            if (dtpBorrowDate.Value >= dtpReturnDate.Value)
            {
                errMsg = "Ngày mượn không hợp lệ";
                CancelValidatedEvent(dtpBorrowDate, lblBorrowDateError, e);
            }
            if (dtpBorrowDate.Value >= dtpReturnDate.Value)
            {
                errMsg = "Ngày trả không hợp lệ";
                CancelValidatedEvent(dtpReturnDate, lblReturnDateError, e);
            }
            FineByStatus();
        }

        private void dtpBorrowDate_Validated(object sender, EventArgs e)
        {
            lblBorrowDateError.Text = "";
            errEditReceipt.SetError(dtpBorrowDate, "");

            lblReturnDateError.Text = "";
            errEditReceipt.SetError(dtpReturnDate, "");
        }

        private void dtpReturnDate_Validating(object sender, CancelEventArgs e)
        {
            if (dtpBorrowDate.Value >= dtpReturnDate.Value)
            {
                errMsg = "Ngày mượn không hợp lệ";
                CancelValidatedEvent(dtpBorrowDate, lblBorrowDateError, e);
            }
            if (dtpBorrowDate.Value >= dtpReturnDate.Value)
            {
                errMsg = "Ngày trả không hợp lệ";
                CancelValidatedEvent(dtpReturnDate, lblReturnDateError, e);
            }
            FineByStatus();
        }

        private void dtpReturnDate_Validated(object sender, EventArgs e)
        {
            lblBorrowDateError.Text = "";
            errEditReceipt.SetError(dtpBorrowDate, "");

            lblReturnDateError.Text = "";
            errEditReceipt.SetError(dtpReturnDate, "");
        }

        private void cboStatus_Validating(object sender, CancelEventArgs e)
        {
            if (dtpReturnDate.Value < DateTime.Now.Date && cboStatus.Text == "Cho mượn")
            {
                errMsg = "Tình trạng đã quá hạn";
                CancelValidatedEvent(cboStatus, lblStatusError, e);
            }
            if (dtpReturnDate.Value >= DateTime.Now.Date && cboStatus.Text == "Quá hạn")
            {
                errMsg = "Tình trạng chưa quá hạn";
                CancelValidatedEvent(cboStatus, lblStatusError, e);
            }
        }

        private void cboStatus_Validated(object sender, EventArgs e)
        {
            lblStatusError.Text = "";
            errEditReceipt.SetError(cboStatus, "");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren(ValidationConstraints.Enabled))
            {
                return;
            }
            string command = @"EXEC sp_update_receipt @MaHD = " + mahd
                                                  + ", @MaDG = " + madg
                                                  + ", @NgayMuon = '" + dtpBorrowDate.Value.ToString("yyyy' - 'MM' - 'dd")
                                                  + "', @NgayTra = '" + dtpReturnDate.Value.ToString("yyyy' - 'MM' - 'dd")
                                                  + "', @TongSL = " + txtBorrowBookTotal.Text
                                                  + ", @TinhTrang = N'" + cboStatus.Text
                                                  + "', @ChiPhi = " + txtFine.Text;
            if (DataConnection.ExecuteQuery(command))
            {
                MessageBox.Show("Chỉnh sửa mượn/trả sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Chỉnh sửa mượn/trả sách thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboStatus_TextChanged(object sender, EventArgs e)
        {
            FineByStatus();
        }

        void FineByStatus()
        {
            int fine = Convert.ToInt32(txtBorrowBookTotal.Text) * Properties.Settings.Default.FineOfBook;
            switch (cboStatus.Text)
            {
                case "Quá hạn":

                    txtFine.Text = fine.ToString();
                    break;
                case "Thu hồi":
                    if (dtpReturnDate.Value < DateTime.Now.Date)
                    {
                        txtFine.Text = fine.ToString();
                    }
                    else
                    {
                        txtFine.Text = "0";
                    }
                    break;
                case "Cho mượn":
                    txtFine.Text = "0";
                    break;
                default:
                    break;
            }
        }

        
    }
}
