using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Manager_UI
{
    public partial class frmReaders : Form
    {
        public frmReaders()
        {
            InitializeComponent();
            LoadData_Readers();
        }
        void LoadData_Readers()
        {
            string str = @"select * from DocGia";
            DataTable dt = DataConnection.GetDataTable(str);
            dgvReaders.DataSource = dt;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (txtReaderCode.Text == "")
                MessageBox.Show("Mã sách không được trống!");
            else
            {
                DataTable dt = DataConnection.GetDataTable("Select * from Sach where MaSach = '" + txtReaderCode.Text + "'");
                if (dt.Rows.Count <= 0)
                {
                    try
                    {
                        string GioiTinh;
                        if (rdoMale.Checked == true)
                            GioiTinh = "Nam"; 
                        else
                            GioiTinh = "Nữ"; 

                        string them = @"insert into DocGia(MaDG, HoTen, GioiTinh, NgaySinh ,DiaChi, DienThoai, Email) values ('" + txtReaderCode.Text + "', N'" + txtFullName.Text + "',N'"
                            + GioiTinh + "',N'" + dtpBirthday.Text + "',N'" + txtAddress.Text + "','" + txtPhone.Text + "', '" + txtEmail.Text + "')";

                        DataConnection.ExecuteQuery(them);
                        MessageBox.Show("Thêm độc giả thành công!!");
                        LoadData_Readers();
                    }
                    catch (Exception) { }
                }
                else
                {
                    MessageBox.Show("Mã độc giả đã tồn tại!");
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string xoa = @"delete from DocGia where MaDG='" + txtReaderCode.Text + "'";
            if (txtReaderCode.Text == "")
                MessageBox.Show("Mã sách không được trống!");
            else
            {
                DataTable dt = DataConnection.GetDataTable("Select * from DocGia where MaDG = '" + txtReaderCode.Text + "'");
                if (dt.Rows.Count > 0)
                {
                    DialogResult dialog = MessageBox.Show("Bạn có muốn xóa Độc giả " + txtFullName.Text + " không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialog == DialogResult.Yes)
                    {
                        try
                        {
                            DataConnection.ExecuteQuery(xoa);
                            MessageBox.Show("Xóa độc giả thành công!!");
                            LoadData_Readers();
                        }
                        catch (Exception)
                        {
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Mã độc giả không tồn tại!");
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //mã độc giả luôn không đổi
            if (txtReaderCode.Text == "")
                MessageBox.Show("Mã độc giả không được trống!!");
            else
            {
                string GioiTinh;
                if (rdoMale.Checked == true)
                    GioiTinh = "Nam"; 
                else
                    GioiTinh = "Nữ"; 

                string capnhat = @"update DocGia set MaDG='" + txtReaderCode.Text + "',HoTen=N'" + txtFullName.Text + "',GioiTinh=N'" + GioiTinh + "',NgaySinh='" 
                                + dtpBirthday.Text + "',DiaChi=N'" + txtAddress.Text + "',DienThoai='" + txtPhone.Text + "',Email='" + txtEmail.Text + "' where MaDG='" + txtReaderCode.Text + "'";
                DataConnection.ExecuteQuery(capnhat);
                MessageBox.Show("Cập nhật độc giả thành công!!");
                LoadData_Readers();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void dgvReaders_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvReaders.Rows[e.RowIndex];
                if (row.Cells[2].Value.ToString() == "Nam")
                    rdoMale.Checked = true;
                else
                    rdoFemale.Checked = true;
                txtReaderCode.Text = row.Cells[0].Value.ToString();
                txtFullName.Text = row.Cells[1].Value.ToString();
                dtpBirthday.Text = row.Cells[3].Value.ToString();
                txtAddress.Text = row.Cells[4].Value.ToString();
                txtPhone.Text = row.Cells[5].Value.ToString();
                txtEmail.Text = row.Cells[6].Value.ToString();
            }
            catch (Exception)
            { }
        }

        private void frmReaders_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }
    }
}
