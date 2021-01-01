using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace New_Library.Forms.Receipt
{
    public partial class frmAddReceipt : Form
    {
        private string errMsg = "";
        public frmAddReceipt()
        {
            InitializeComponent();

            dtpBorrowDate.Value = DateTime.Now;

            dtpReturnDate.MinDate = DateTime.Now.AddDays(1);
            dtpReturnDate.Value = dtpReturnDate.MinDate;

            cboStatus.Text = "Cho Mượn";
            txtFine.Text = "0";

            lblErrAddReceipt.Text = "";
        }

        private void frmAddReceipt_Load(object sender, EventArgs e)
        {
            LoadData_Book();
            LoadData_ReaderPhone();
        }

        private void LoadData_Book()
        {
            dgvBook.DataSource = DatabaseData.dtBook;
            dgvBook.Columns["MaSach"].Visible = false;
            dgvBook.Columns["ĐÃ MƯỢN"].Visible = false;
            dgvBook.Columns["MaTL"].Visible = false;
        }

        private void LoadData_ReaderPhone()
        {

            string command = @"SELECT SDT FROM DOCGIA";
            DataTable dt = DataConnection.GetDataTable(command);

            cboReaderPhone.DataSource = dt.DefaultView;
            cboReaderPhone.DisplayMember = dt.Columns[0].ToString();
           
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "" || txtSearch.Text == null)
            {
                LoadData_Book();
                return;
            }
            string command = @"EXEC sp_search_books @TuKhoa = N'" + txtSearch.Text + "'";
            DataTable dt = DataConnection.GetDataTable(command);

            this.dgvBook.DataSource = dt;
            dgvBook.Columns["MaSach"].Visible = false;
            dgvBook.Columns["ĐÃ MƯỢN"].Visible = false;
            dgvBook.Columns["MaTL"].Visible = false;
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvBook.Rows.Count; i++)
            {
                bool rowAlreadyExist = false;

                if (dgvBook.Rows[i].Cells["Chon"].Value != null)
                {
                    DataGridViewRow row = dgvBook.Rows[i];

                    if (dgvDetail.Rows.Count != 0)
                    {
                        for (int j = 0; j < dgvDetail.Rows.Count; j++)
                        {
                            if (row.Cells["MaSach"].Value.ToString() == dgvDetail.Rows[j].Cells["MaSach"].Value.ToString())
                            {
                                rowAlreadyExist = true;
                                break;
                            }
                        }

                        if (rowAlreadyExist == false)
                        {
                            dgvDetail.Rows.Add( row.Cells["MaSach"].Value.ToString(),
                                                row.Cells["TenSach"].Value.ToString(),
                                                row.Cells["TacGia"].Value.ToString(),
                                                row.Cells["TheLoai"].Value.ToString(),
                                                row.Cells["NhaXuatBan"].Value.ToString(),
                                                row.Cells["CoSan"].Value.ToString()
                                                );
                        }

                    }
                    else
                    {
                        dgvDetail.Rows.Add(     row.Cells["MaSach"].Value.ToString(),
                                                row.Cells["TenSach"].Value.ToString(),
                                                row.Cells["TacGia"].Value.ToString(),
                                                row.Cells["TheLoai"].Value.ToString(),
                                                row.Cells["NhaXuatBan"].Value.ToString(),
                                                row.Cells["CoSan"].Value.ToString()
                                                );
                    }
                }
            }
            dgvDetail.Columns["MaSach"].Visible = false;
            dgvBook.Columns["ĐÃ MƯỢN"].Visible = false;
            dgvBook.Columns["MaTL"].Visible = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dgvDetail.SelectedRows)
            {
                dgvDetail.Rows.RemoveAt(item.Index);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void CancelValidatedEvent(Control control, Label error, CancelEventArgs e)
        {
            System.Media.SystemSounds.Asterisk.Play();
            e.Cancel = true;
            errAddReceipt.SetError(control, errMsg);
            error.Text = errMsg;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren(ValidationConstraints.Enabled))
            {
                return;
            }
            
            string command = @"EXEC sp_insert_receipt @SDT = " + cboReaderPhone.Text
                                              + ", @NgayMuon = '" + dtpBorrowDate.Value.ToString("yyyy' - 'MM' - 'dd")
                                              + "', @NgayTra = '" + dtpReturnDate.Value.ToString("yyyy' - 'MM' - 'dd")
                                              + "', @TongSL = " + txtBorrowBookTotal.Text;

            if (DataConnection.ExecuteQuery(command))
            {
                string command2 = @"SELECT MaHD FROM HOADON
	                        WHERE MaHD NOT IN (SELECT DISTINCT MaHD FROM CTHD)";
                DataTable dt = DataConnection.GetDataTable(command2);
                
                int mahd = dt.Rows[0].Field<int>("MaHD");

                for (int i = 0; i < dgvDetail.Rows.Count; i++)
                {
                    string cmd = @"EXEC sp_insert_detail @MaHD = " + mahd
                                              + ", @MaSach = " + dgvDetail.Rows[i].Cells["MaSach"].Value
                                              + ", @SoLuong = " + Convert.ToInt32(dgvDetail.Rows[i].Cells["SoLuong"].Value);

                    DataConnection.ExecuteQuery(cmd);
                    
                }
                MessageBox.Show("Thêm mượn/trả sách hoàn thành!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Thêm mượn/trả sách thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            GC.Collect();
            this.Dispose();
        }

        private void dgvDetail_Validating(object sender, CancelEventArgs e)
        {
            if (dgvDetail.Rows.Count <= 0)
            {
                errMsg = "Chi tiết phiếu còn trống";
                CancelValidatedEvent(dgvDetail, lblErrAddReceipt, e);
            }    
            else
            {
                for (int i = 0; i < dgvDetail.Rows.Count; i++)
                {
                    if (dgvDetail["SoLuong", i].Value == null || Convert.ToInt32(dgvDetail["CoSanDetail", i].Value) < Convert.ToInt32(dgvDetail["SoLuong", i].Value)) 
                    {
                        errMsg = "Số lượng sách không hợp lệ";
                        CancelValidatedEvent(dgvDetail, lblErrAddReceipt, e);
                    }    
                }    
            }    
        }

        private void dgvDetail_Validated(object sender, EventArgs e)
        {
            lblErrAddReceipt.Text = "";
            errAddReceipt.SetError(dgvDetail, "");
        }

        private void dgvDetail_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int total = 0;
            for (int i = 0; i < dgvDetail.Rows.Count; i++)
            {
                if (dgvDetail["SoLuong", i].Value != null)
                {
                    total += Convert.ToInt32(dgvDetail["SoLuong", i].Value);
                }
            }
            txtBorrowBookTotal.Text = total.ToString();
        }        
    }
}
