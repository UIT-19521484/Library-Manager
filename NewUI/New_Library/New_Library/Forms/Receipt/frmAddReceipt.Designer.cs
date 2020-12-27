
namespace New_Library.Forms.Receipt
{
    partial class frmAddReceipt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpReceiptInfo = new System.Windows.Forms.GroupBox();
            this.grpReaderPhone = new System.Windows.Forms.GroupBox();
            this.cboReaderPhone = new System.Windows.Forms.ComboBox();
            this.lblUnit = new System.Windows.Forms.Label();
            this.grpFine = new System.Windows.Forms.GroupBox();
            this.txtFine = new System.Windows.Forms.TextBox();
            this.grpBorrowBookTotal = new System.Windows.Forms.GroupBox();
            this.txtBorrowBookTotal = new System.Windows.Forms.TextBox();
            this.grpReturnDate = new System.Windows.Forms.GroupBox();
            this.dtpReturnDate = new System.Windows.Forms.DateTimePicker();
            this.grpStatus = new System.Windows.Forms.GroupBox();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.grpBorrowDate = new System.Windows.Forms.GroupBox();
            this.dtpBorrowDate = new System.Windows.Forms.DateTimePicker();
            this.grpBookInfo = new System.Windows.Forms.GroupBox();
            this.dgvBook = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TheLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhaXuatBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CoSan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Chon = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.grpContactInfo = new System.Windows.Forms.GroupBox();
            this.lblErrAddReceipt = new System.Windows.Forms.Label();
            this.dgvDetail = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CoSanDetail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnMove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.errAddReceipt = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpReceiptInfo.SuspendLayout();
            this.grpReaderPhone.SuspendLayout();
            this.grpFine.SuspendLayout();
            this.grpBorrowBookTotal.SuspendLayout();
            this.grpReturnDate.SuspendLayout();
            this.grpStatus.SuspendLayout();
            this.grpBorrowDate.SuspendLayout();
            this.grpBookInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).BeginInit();
            this.grpContactInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errAddReceipt)).BeginInit();
            this.SuspendLayout();
            // 
            // grpReceiptInfo
            // 
            this.grpReceiptInfo.Controls.Add(this.grpReaderPhone);
            this.grpReceiptInfo.Controls.Add(this.lblUnit);
            this.grpReceiptInfo.Controls.Add(this.grpFine);
            this.grpReceiptInfo.Controls.Add(this.grpBorrowBookTotal);
            this.grpReceiptInfo.Controls.Add(this.grpReturnDate);
            this.grpReceiptInfo.Controls.Add(this.grpStatus);
            this.grpReceiptInfo.Controls.Add(this.grpBorrowDate);
            this.grpReceiptInfo.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpReceiptInfo.Location = new System.Drawing.Point(23, 52);
            this.grpReceiptInfo.Name = "grpReceiptInfo";
            this.grpReceiptInfo.Size = new System.Drawing.Size(225, 542);
            this.grpReceiptInfo.TabIndex = 68;
            this.grpReceiptInfo.TabStop = false;
            this.grpReceiptInfo.Text = "Mượn/Trả";
            // 
            // grpReaderPhone
            // 
            this.grpReaderPhone.BackColor = System.Drawing.Color.White;
            this.grpReaderPhone.Controls.Add(this.cboReaderPhone);
            this.grpReaderPhone.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpReaderPhone.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpReaderPhone.Location = new System.Drawing.Point(6, 64);
            this.grpReaderPhone.Name = "grpReaderPhone";
            this.grpReaderPhone.Size = new System.Drawing.Size(161, 54);
            this.grpReaderPhone.TabIndex = 73;
            this.grpReaderPhone.TabStop = false;
            this.grpReaderPhone.Text = "SĐT Độc giả";
            // 
            // cboReaderPhone
            // 
            this.cboReaderPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboReaderPhone.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cboReaderPhone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboReaderPhone.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboReaderPhone.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboReaderPhone.FormattingEnabled = true;
            this.cboReaderPhone.Items.AddRange(new object[] {
            "Cho Mượn",
            "Quá hạn",
            "Thu hồi"});
            this.cboReaderPhone.Location = new System.Drawing.Point(3, 19);
            this.cboReaderPhone.Margin = new System.Windows.Forms.Padding(0);
            this.cboReaderPhone.Name = "cboReaderPhone";
            this.cboReaderPhone.Size = new System.Drawing.Size(155, 33);
            this.cboReaderPhone.Sorted = true;
            this.cboReaderPhone.TabIndex = 5;
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnit.Location = new System.Drawing.Point(167, 464);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(52, 24);
            this.lblUnit.TabIndex = 77;
            this.lblUnit.Text = "VND";
            // 
            // grpFine
            // 
            this.grpFine.BackColor = System.Drawing.Color.White;
            this.grpFine.Controls.Add(this.txtFine);
            this.grpFine.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpFine.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFine.Location = new System.Drawing.Point(6, 437);
            this.grpFine.Name = "grpFine";
            this.grpFine.Size = new System.Drawing.Size(161, 54);
            this.grpFine.TabIndex = 76;
            this.grpFine.TabStop = false;
            this.grpFine.Text = "Chi Phí";
            // 
            // txtFine
            // 
            this.txtFine.AcceptsTab = true;
            this.txtFine.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFine.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtFine.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFine.Enabled = false;
            this.txtFine.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFine.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtFine.Location = new System.Drawing.Point(3, 25);
            this.txtFine.Margin = new System.Windows.Forms.Padding(0);
            this.txtFine.Name = "txtFine";
            this.txtFine.Size = new System.Drawing.Size(155, 26);
            this.txtFine.TabIndex = 2;
            this.txtFine.Text = "0";
            this.txtFine.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFine.WordWrap = false;
            // 
            // grpBorrowBookTotal
            // 
            this.grpBorrowBookTotal.BackColor = System.Drawing.Color.White;
            this.grpBorrowBookTotal.Controls.Add(this.txtBorrowBookTotal);
            this.grpBorrowBookTotal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpBorrowBookTotal.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBorrowBookTotal.Location = new System.Drawing.Point(6, 363);
            this.grpBorrowBookTotal.Name = "grpBorrowBookTotal";
            this.grpBorrowBookTotal.Size = new System.Drawing.Size(161, 54);
            this.grpBorrowBookTotal.TabIndex = 75;
            this.grpBorrowBookTotal.TabStop = false;
            this.grpBorrowBookTotal.Text = "Tổng số Sách";
            // 
            // txtBorrowBookTotal
            // 
            this.txtBorrowBookTotal.AcceptsTab = true;
            this.txtBorrowBookTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBorrowBookTotal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBorrowBookTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBorrowBookTotal.Enabled = false;
            this.txtBorrowBookTotal.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBorrowBookTotal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBorrowBookTotal.Location = new System.Drawing.Point(3, 25);
            this.txtBorrowBookTotal.Margin = new System.Windows.Forms.Padding(0);
            this.txtBorrowBookTotal.Name = "txtBorrowBookTotal";
            this.txtBorrowBookTotal.Size = new System.Drawing.Size(155, 26);
            this.txtBorrowBookTotal.TabIndex = 2;
            this.txtBorrowBookTotal.Text = "0";
            this.txtBorrowBookTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBorrowBookTotal.WordWrap = false;
            // 
            // grpReturnDate
            // 
            this.grpReturnDate.BackColor = System.Drawing.Color.White;
            this.grpReturnDate.Controls.Add(this.dtpReturnDate);
            this.grpReturnDate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpReturnDate.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpReturnDate.Location = new System.Drawing.Point(6, 219);
            this.grpReturnDate.Name = "grpReturnDate";
            this.grpReturnDate.Size = new System.Drawing.Size(161, 48);
            this.grpReturnDate.TabIndex = 74;
            this.grpReturnDate.TabStop = false;
            this.grpReturnDate.Text = "Ngày trả";
            // 
            // dtpReturnDate
            // 
            this.dtpReturnDate.CustomFormat = "dmy";
            this.dtpReturnDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReturnDate.Location = new System.Drawing.Point(9, 19);
            this.dtpReturnDate.MinDate = new System.DateTime(2020, 12, 26, 0, 0, 0, 0);
            this.dtpReturnDate.Name = "dtpReturnDate";
            this.dtpReturnDate.Size = new System.Drawing.Size(146, 23);
            this.dtpReturnDate.TabIndex = 1;
            // 
            // grpStatus
            // 
            this.grpStatus.BackColor = System.Drawing.Color.White;
            this.grpStatus.Controls.Add(this.cboStatus);
            this.grpStatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpStatus.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpStatus.Location = new System.Drawing.Point(6, 297);
            this.grpStatus.Name = "grpStatus";
            this.grpStatus.Size = new System.Drawing.Size(161, 54);
            this.grpStatus.TabIndex = 71;
            this.grpStatus.TabStop = false;
            this.grpStatus.Text = "Tình trạng";
            // 
            // cboStatus
            // 
            this.cboStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboStatus.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.Enabled = false;
            this.cboStatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboStatus.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "Cho mượn",
            "Quá hạn",
            "Thu hồi"});
            this.cboStatus.Location = new System.Drawing.Point(3, 19);
            this.cboStatus.Margin = new System.Windows.Forms.Padding(0);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(155, 33);
            this.cboStatus.Sorted = true;
            this.cboStatus.TabIndex = 5;
            // 
            // grpBorrowDate
            // 
            this.grpBorrowDate.BackColor = System.Drawing.Color.White;
            this.grpBorrowDate.Controls.Add(this.dtpBorrowDate);
            this.grpBorrowDate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpBorrowDate.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBorrowDate.Location = new System.Drawing.Point(6, 147);
            this.grpBorrowDate.Name = "grpBorrowDate";
            this.grpBorrowDate.Size = new System.Drawing.Size(161, 48);
            this.grpBorrowDate.TabIndex = 70;
            this.grpBorrowDate.TabStop = false;
            this.grpBorrowDate.Text = "Ngày mượn";
            // 
            // dtpBorrowDate
            // 
            this.dtpBorrowDate.CustomFormat = "dmy";
            this.dtpBorrowDate.Enabled = false;
            this.dtpBorrowDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBorrowDate.Location = new System.Drawing.Point(9, 19);
            this.dtpBorrowDate.Name = "dtpBorrowDate";
            this.dtpBorrowDate.Size = new System.Drawing.Size(146, 23);
            this.dtpBorrowDate.TabIndex = 0;
            // 
            // grpBookInfo
            // 
            this.grpBookInfo.Controls.Add(this.dgvBook);
            this.grpBookInfo.Controls.Add(this.btnSearch);
            this.grpBookInfo.Controls.Add(this.txtSearch);
            this.grpBookInfo.Controls.Add(this.lblSearch);
            this.grpBookInfo.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBookInfo.Location = new System.Drawing.Point(270, 10);
            this.grpBookInfo.Name = "grpBookInfo";
            this.grpBookInfo.Size = new System.Drawing.Size(905, 309);
            this.grpBookInfo.TabIndex = 70;
            this.grpBookInfo.TabStop = false;
            this.grpBookInfo.Text = "Thông tin Sách";
            // 
            // dgvBook
            // 
            this.dgvBook.AllowUserToAddRows = false;
            this.dgvBook.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvBook.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBook.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvBook.BackgroundColor = System.Drawing.Color.White;
            this.dgvBook.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBook.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvBook.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenSach,
            this.TacGia,
            this.TheLoai,
            this.NhaXuatBan,
            this.CoSan,
            this.Chon});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBook.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBook.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvBook.DoubleBuffered = true;
            this.dgvBook.EnableHeadersVisualStyles = false;
            this.dgvBook.GridColor = System.Drawing.Color.White;
            this.dgvBook.HeaderBgColor = System.Drawing.Color.MidnightBlue;
            this.dgvBook.HeaderForeColor = System.Drawing.Color.White;
            this.dgvBook.Location = new System.Drawing.Point(3, 83);
            this.dgvBook.Name = "dgvBook";
            this.dgvBook.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            this.dgvBook.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvBook.RowHeadersVisible = false;
            this.dgvBook.RowHeadersWidth = 20;
            this.dgvBook.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvBook.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBook.RowTemplate.DividerHeight = 1;
            this.dgvBook.RowTemplate.Height = 20;
            this.dgvBook.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBook.ShowCellErrors = false;
            this.dgvBook.ShowCellToolTips = false;
            this.dgvBook.ShowEditingIcon = false;
            this.dgvBook.ShowRowErrors = false;
            this.dgvBook.Size = new System.Drawing.Size(899, 223);
            this.dgvBook.TabIndex = 4;
            // 
            // TenSach
            // 
            this.TenSach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenSach.DataPropertyName = "TÊN SÁCH";
            this.TenSach.HeaderText = "TÊN SÁCH";
            this.TenSach.Name = "TenSach";
            this.TenSach.ReadOnly = true;
            // 
            // TacGia
            // 
            this.TacGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TacGia.DataPropertyName = "TÁC GIẢ";
            this.TacGia.HeaderText = "TÁC GIẢ";
            this.TacGia.Name = "TacGia";
            this.TacGia.ReadOnly = true;
            this.TacGia.Width = 153;
            // 
            // TheLoai
            // 
            this.TheLoai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TheLoai.DataPropertyName = "THỂ LOẠI";
            this.TheLoai.HeaderText = "THỂ LOẠI";
            this.TheLoai.Name = "TheLoai";
            this.TheLoai.ReadOnly = true;
            this.TheLoai.Width = 168;
            // 
            // NhaXuatBan
            // 
            this.NhaXuatBan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NhaXuatBan.DataPropertyName = "NHÀ XUẤT BẢN";
            this.NhaXuatBan.HeaderText = "NHÀ XUẤT BẢN";
            this.NhaXuatBan.Name = "NhaXuatBan";
            this.NhaXuatBan.ReadOnly = true;
            this.NhaXuatBan.Width = 248;
            // 
            // CoSan
            // 
            this.CoSan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.CoSan.DataPropertyName = "CÓ SẴN";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CoSan.DefaultCellStyle = dataGridViewCellStyle3;
            this.CoSan.HeaderText = "CÓ SẴN";
            this.CoSan.Name = "CoSan";
            this.CoSan.ReadOnly = true;
            this.CoSan.Width = 145;
            // 
            // Chon
            // 
            this.Chon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Chon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Chon.HeaderText = "CHỌN";
            this.Chon.Name = "Chon";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Image = global::New_Library.Properties.Resources.right_24px;
            this.btnSearch.Location = new System.Drawing.Point(769, 42);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(37, 27);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("Verdana", 12F);
            this.txtSearch.Location = new System.Drawing.Point(149, 42);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(604, 27);
            this.txtSearch.TabIndex = 2;
            // 
            // lblSearch
            // 
            this.lblSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(50, 43);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(93, 24);
            this.lblSearch.TabIndex = 57;
            this.lblSearch.Text = "Tìm kiếm:";
            // 
            // grpContactInfo
            // 
            this.grpContactInfo.Controls.Add(this.lblErrAddReceipt);
            this.grpContactInfo.Controls.Add(this.dgvDetail);
            this.grpContactInfo.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpContactInfo.Location = new System.Drawing.Point(270, 357);
            this.grpContactInfo.Name = "grpContactInfo";
            this.grpContactInfo.Size = new System.Drawing.Size(851, 260);
            this.grpContactInfo.TabIndex = 69;
            this.grpContactInfo.TabStop = false;
            this.grpContactInfo.Text = "Chi tiết phiếu";
            // 
            // lblErrAddReceipt
            // 
            this.lblErrAddReceipt.AutoSize = true;
            this.lblErrAddReceipt.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrAddReceipt.ForeColor = System.Drawing.Color.Red;
            this.lblErrAddReceipt.Location = new System.Drawing.Point(651, 21);
            this.lblErrAddReceipt.Name = "lblErrAddReceipt";
            this.lblErrAddReceipt.Size = new System.Drawing.Size(80, 13);
            this.lblErrAddReceipt.TabIndex = 75;
            this.lblErrAddReceipt.Text = "Error Warning";
            // 
            // dgvDetail
            // 
            this.dgvDetail.AllowUserToAddRows = false;
            this.dgvDetail.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvDetail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetail.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDetail.BackgroundColor = System.Drawing.Color.White;
            this.dgvDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDetail.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvDetail.ColumnHeadersHeight = 25;
            this.dgvDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSach,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.CoSanDetail,
            this.SoLuong});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetail.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvDetail.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDetail.DoubleBuffered = true;
            this.dgvDetail.EnableHeadersVisualStyles = false;
            this.dgvDetail.GridColor = System.Drawing.Color.White;
            this.dgvDetail.HeaderBgColor = System.Drawing.Color.MidnightBlue;
            this.dgvDetail.HeaderForeColor = System.Drawing.Color.White;
            this.dgvDetail.Location = new System.Drawing.Point(3, 39);
            this.dgvDetail.Name = "dgvDetail";
            this.dgvDetail.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            this.dgvDetail.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvDetail.RowHeadersVisible = false;
            this.dgvDetail.RowHeadersWidth = 20;
            this.dgvDetail.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvDetail.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDetail.RowTemplate.DividerHeight = 1;
            this.dgvDetail.RowTemplate.Height = 30;
            this.dgvDetail.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetail.ShowCellErrors = false;
            this.dgvDetail.ShowCellToolTips = false;
            this.dgvDetail.ShowEditingIcon = false;
            this.dgvDetail.ShowRowErrors = false;
            this.dgvDetail.Size = new System.Drawing.Size(845, 218);
            this.dgvDetail.TabIndex = 6;
            this.dgvDetail.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetail_CellEndEdit);
            this.dgvDetail.Validating += new System.ComponentModel.CancelEventHandler(this.dgvDetail_Validating);
            this.dgvDetail.Validated += new System.EventHandler(this.dgvDetail_Validated);
            // 
            // MaSach
            // 
            this.MaSach.HeaderText = "MÃ SÁCH";
            this.MaSach.Name = "MaSach";
            this.MaSach.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TÊN SÁCH";
            this.dataGridViewTextBoxColumn1.HeaderText = "TÊN SÁCH";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TÁC GIẢ";
            this.dataGridViewTextBoxColumn2.HeaderText = "TÁC GIẢ";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 153;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "THỂ LOẠI";
            this.dataGridViewTextBoxColumn3.HeaderText = "THỂ LOẠI";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 168;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "NHÀ XUẤT BẢN";
            this.dataGridViewTextBoxColumn4.HeaderText = "NHÀ XUẤT BẢN";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 248;
            // 
            // CoSanDetail
            // 
            this.CoSanDetail.HeaderText = "CÓ SẴN";
            this.CoSanDetail.Name = "CoSanDetail";
            this.CoSanDetail.Visible = false;
            // 
            // SoLuong
            // 
            this.SoLuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SoLuong.HeaderText = "SỐ LƯỢNG";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Width = 186;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Image = global::New_Library.Properties.Resources.double_up_24px;
            this.btnBack.Location = new System.Drawing.Point(699, 325);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(36, 40);
            this.btnBack.TabIndex = 72;
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnMove
            // 
            this.btnMove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMove.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnMove.FlatAppearance.BorderSize = 0;
            this.btnMove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMove.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMove.Image = global::New_Library.Properties.Resources.double_down_24px;
            this.btnMove.Location = new System.Drawing.Point(628, 325);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(36, 40);
            this.btnMove.TabIndex = 5;
            this.btnMove.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMove.UseVisualStyleBackColor = false;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdd.Image = global::New_Library.Properties.Resources.add1;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.Location = new System.Drawing.Point(1127, 459);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(87, 36);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancel.Image = global::New_Library.Properties.Resources.delete;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.Location = new System.Drawing.Point(1127, 507);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 36);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // errAddReceipt
            // 
            this.errAddReceipt.BlinkRate = 0;
            this.errAddReceipt.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errAddReceipt.ContainerControl = this;
            // 
            // frmAddReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1223, 628);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.grpBookInfo);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grpContactInfo);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.grpReceiptInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddReceipt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmAddReceipt_Load);
            this.grpReceiptInfo.ResumeLayout(false);
            this.grpReceiptInfo.PerformLayout();
            this.grpReaderPhone.ResumeLayout(false);
            this.grpFine.ResumeLayout(false);
            this.grpFine.PerformLayout();
            this.grpBorrowBookTotal.ResumeLayout(false);
            this.grpBorrowBookTotal.PerformLayout();
            this.grpReturnDate.ResumeLayout(false);
            this.grpStatus.ResumeLayout(false);
            this.grpBorrowDate.ResumeLayout(false);
            this.grpBookInfo.ResumeLayout(false);
            this.grpBookInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).EndInit();
            this.grpContactInfo.ResumeLayout(false);
            this.grpContactInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errAddReceipt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox grpReceiptInfo;
        private System.Windows.Forms.GroupBox grpStatus;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.GroupBox grpBorrowDate;
        private System.Windows.Forms.GroupBox grpReturnDate;
        private System.Windows.Forms.DateTimePicker dtpReturnDate;
        private System.Windows.Forms.DateTimePicker dtpBorrowDate;
        private System.Windows.Forms.GroupBox grpFine;
        private System.Windows.Forms.TextBox txtFine;
        private System.Windows.Forms.GroupBox grpBorrowBookTotal;
        private System.Windows.Forms.TextBox txtBorrowBookTotal;
        private System.Windows.Forms.GroupBox grpBookInfo;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.GroupBox grpContactInfo;
        private System.Windows.Forms.Button btnBack;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvBook;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvDetail;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn TheLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhaXuatBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn CoSan;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Chon;
        private System.Windows.Forms.ErrorProvider errAddReceipt;
        private System.Windows.Forms.Label lblErrAddReceipt;
        private System.Windows.Forms.GroupBox grpReaderPhone;
        private System.Windows.Forms.ComboBox cboReaderPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn CoSanDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
    }
}