using System;
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
    public partial class frmReceipt : Form
    {
        public frmReceipt()
        {
            InitializeComponent();
        }

        private void frmReceipt_Load(object sender, EventArgs e)
        {
            LoadData_Receipt();
        }

        void LoadData_Receipt()
        {
            dgvReceipt.DataSource = DatabaseData.dtReceipt;
            dgvReceipt.Columns["MaHD"].Visible = false;
            dgvReceipt.Columns["MaDG"].Visible = false;
        }

        private void dgvReceipt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (dgvReceipt.SelectedRows.Count)
            {
                case 0:
                    btnDelete.Enabled = false;
                    btnUpdate.Enabled = false;
                    break;
                default:
                    btnDelete.Enabled = true;
                    btnUpdate.Enabled = true;
                    break;
            }
        }

        private void dgvReceipt_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.dgvReceipt.ClearSelection();
            this.BeginInvoke(new Action(() => { btnDelete.Enabled = false; btnUpdate.Enabled = false; }));
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "" || txtSearch.Text == null)
            {
                LoadData_Receipt();
                return;
            }

            string command = @"EXEC sp_search_receipts @TuKhoa = N'" + txtSearch.Text + "'";
            DataTable dt = DataConnection.GetDataTable(command);
            this.dgvReceipt.DataSource = dt;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string msg = "Bạn thật sự muốn xóa những phiếu mượn/trả này?\n\n";
            for (int i = 0; i < dgvReceipt.SelectedRows.Count; i++)
            {
                int ma = 100000000 + (int)dgvReceipt.SelectedRows[i].Cells["MaHD"].Value;
                msg += (i + 1).ToString() + ". " + ma.ToString()  + "\n";
            }

            DialogResult rs = MessageBox.Show(msg, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rs == DialogResult.Yes)
            {
                while (dgvReceipt.SelectedRows.Count != 0)
                {
                    string command = @"EXEC sp_delete_receipt @MaHD = '" + dgvReceipt.SelectedRows[0].Cells["MaHD"].Value + "'";

                    if (!DataConnection.ExecuteQuery(command))
                    {
                        MessageBox.Show("Thất bại khi xoá phiếu mượn/trả có mã " + dgvReceipt.SelectedRows[0].Cells["MÃ MƯỢN/TRẢ"].Value, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                MessageBox.Show("Hoàn thành xóa dữ liệu Phiếu mượn/trả sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            dgvReceipt.Refresh();
            //GC.Collect();
        }
    }
}
