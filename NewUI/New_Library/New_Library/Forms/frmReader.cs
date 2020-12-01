using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New_Library.Forms
{
    public partial class frmReader : Form
    {
        private string curReaderName;
        private string curSex;
        private DateTime curDateOfBirth;
        private string curAddress;
        private string curPhone;
        private string curEmail;

        public frmReader()
        {
            InitializeComponent();
        }

        private void frmReader_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            this.btnEdit.BackColor = ThemeColor.PrimaryColor;
            this.btnEdit.ForeColor = Color.White;
            this.btnSearch.BackColor = ThemeColor.PrimaryColor;
            this.btnSearch.ForeColor = Color.White;
            LoadTheme();
            LoadData_Reader();
        }

        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }

            lblReaderName.ForeColor = ThemeColor.SecondaryColor;
            lblAddress.ForeColor = ThemeColor.SecondaryColor;
            lblEmail.ForeColor = ThemeColor.SecondaryColor;
            lblSex.ForeColor = ThemeColor.SecondaryColor;
            lblDateOfBirth.ForeColor = ThemeColor.SecondaryColor;
            lblPhone.ForeColor = ThemeColor.SecondaryColor;
        }

        void LoadData_Reader()
        {
            string str = @"EXEC sp_select_all_readers";
            DataTable dt = DataConnection.GetDataTable(str);
            dgvReader.DataSource = dt;
            dgvReader.BackgroundColor = Color.White;
            dgvReader.HeaderBgColor = ThemeColor.PrimaryColor;
            dgvReader.HeaderForeColor = Color.White;
            dgvReader.GridColor = Color.White;
        }

        private void dgvReader_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.dgvReader.ClearSelection();
        }

        private void dgvReader_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = this.dgvReader.Rows[e.RowIndex];
                txtReaderName.Text = row.Cells[0].Value.ToString();
                cboSex.Text = row.Cells[1].Value.ToString();
                dtpDateOfBirth.Text = row.Cells[2].Value.ToString();
                txtAddress.Text = row.Cells[3].Value.ToString();
                txtPhone.Text = row.Cells[4].Value.ToString();
                txtEmail.Text = row.Cells[5].Value.ToString();

                curReaderName = txtReaderName.Text;
                curSex = cboSex.Text;
                curDateOfBirth = dtpDateOfBirth.Value;
                curAddress = txtAddress.Text;
                curPhone = txtPhone.Text;
                curEmail = txtEmail.Text;

            }
            catch (Exception)
            { }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtReaderName.ReadOnly = !txtReaderName.ReadOnly;
            cboSex.Enabled = !cboSex.Enabled;
            dtpDateOfBirth.Enabled = !dtpDateOfBirth.Enabled;
            txtAddress.ReadOnly = !txtAddress.ReadOnly;
            txtPhone.ReadOnly = !txtPhone.ReadOnly;
            txtEmail.ReadOnly = !txtEmail.ReadOnly;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "" || txtSearch.Text == null)
            {
                LoadData_Reader();
                return;
            }
            string command = @"EXEC sp_search_readers @TuKhoa = N'" + txtSearch.Text + "'";
            DataTable dt = DataConnection.GetDataTable(command);
            this.dgvReader.DataSource = dt;
            dgvReader.BackgroundColor = Color.White;
            dgvReader.HeaderBgColor = ThemeColor.PrimaryColor;
            dgvReader.HeaderForeColor = Color.White;
            dgvReader.GridColor = Color.White;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtReaderName.ReadOnly == true)
            {
                DataTable dt = DataConnection.GetDataTable(@"EXEC sp_select_reader @SDT = '" + txtPhone.Text + "', @Email = '" + txtAddress.Text + "'");
                if (dt.Rows.Count == 1)
                {
                    string command = (@"EXEC sp_delete_reader @SDT = '" + txtPhone.Text + "', @Email = '" + txtEmail.Text + "'");
                            
                    DataConnection.ExecuteQuery(command);
                    MessageBox.Show("Xóa độc giả thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData_Reader();
                }
                else
                {
                    MessageBox.Show("Không tồn tại độc giả này!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Đang trong chế độ edit! Vui lòng tắt trước khi xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public bool IsValidEmail(string emailaddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailaddress);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
        public bool IsVietnamPhoneNumber(string number)
        {
            return Regex.Match(number, @"^(0|\+84)[35789]\d{8}$").Success;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtReaderName.ReadOnly == false)
            {
                if (txtReaderName.Text == "" || txtPhone.Text == "" || txtEmail.Text == "" || cboSex.Text == "")
                {
                    MessageBox.Show("Thông tin độc giả chưa đầy đủ! Hãy nhập lại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (IsVietnamPhoneNumber(txtPhone.Text) == false || IsValidEmail(txtEmail.Text) == false || DateTime.Now < dtpDateOfBirth.Value )
                {
                    MessageBox.Show("Email hoặc SĐT hoặc Ngày sinh không hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DataTable dt = DataConnection.GetDataTable(@"EXEC sp_select_reader @SDT = '" + txtPhone.Text + "', @Email = '" + txtEmail.Text + "'");

                if (dt.Rows.Count == 0)
                {
                    string command = (@"EXEC sp_insert_reader @HoTen = N'" + txtReaderName.Text + "', @GioiTinh = N'" + cboSex.Text + "', @NgaySinh = N'"
                                    + dtpDateOfBirth.Value.ToShortDateString() + "', @DiaChi = N'" + txtAddress.Text + "', @SDT = '" + txtPhone.Text + "', @Email = '" + txtEmail.Text +"'");
                    DataConnection.ExecuteQuery(command);
                    MessageBox.Show("Thêm độc giả thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData_Reader();
                }
                else
                {
                    MessageBox.Show("Đã tồn tại SĐT hoặc Email trên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Hãy bật chế độ edit! Điền thông tin độc giả trước khi thêm!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtReaderName.ReadOnly == false && this.dgvReader.SelectedRows.Count > 0)
            {
                if (txtReaderName.Text == "" || txtPhone.Text == "" || txtEmail.Text == "" || cboSex.Text == "")
                {
                    MessageBox.Show("Thông tin độc giả chưa đầy đủ! Hãy nhập lại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (IsVietnamPhoneNumber(txtPhone.Text) == false || IsValidEmail(txtEmail.Text) == false || DateTime.Now < dtpDateOfBirth.Value)
                {
                    MessageBox.Show("Email hoặc SĐT hoặc Ngày sinh không hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DataTable dt1 = DataConnection.GetDataTable(@"EXEC sp_select_reader @SDT = '" + txtPhone.Text + "', @Email = '" + txtEmail.Text + "'");
                if (dt1.Rows.Count == 0 || curPhone == txtPhone.Text || curEmail == txtAddress.Text)
                {

                    DataTable dt = DataConnection.GetDataTable(@"EXEC sp_select_reader @SDT = '" + curPhone + "', @Email = '" + curEmail + "'");

                    int MaDG = Int32.Parse(dt.Rows[0][0].ToString());

                    string command = (@"EXEC sp_update_reader @MaDG = " + MaDG + ", @HoTen = N'" + txtReaderName.Text + "', @GioiTinh = N'" + cboSex.Text
                                     + "', @NgaySinh = N'" + dtpDateOfBirth.Value.ToShortDateString() + "', @DiaChi = N'" + txtAddress.Text + "', @SDT = '" + txtPhone.Text + "', @Email = '" + txtEmail.Text + "'");
                    DataConnection.ExecuteQuery(command);
                    MessageBox.Show("Cập nhật độc giả thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData_Reader();
                }
                else
                {
                    MessageBox.Show("Đã tồn tại SĐT hoặc Email trên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Chưa bật chế độ edit hoặc Chưa chọn độc giả cần sửa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
