
namespace New_Library.Forms.Receipt
{
    partial class frmEditReceipt
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpContactInfo = new System.Windows.Forms.GroupBox();
            this.dgvDetail = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpReceiptInfo = new System.Windows.Forms.GroupBox();
            this.lblBorrowDateError = new System.Windows.Forms.Label();
            this.lblStatusError = new System.Windows.Forms.Label();
            this.lblReturnDateError = new System.Windows.Forms.Label();
            this.grpReceiptCode = new System.Windows.Forms.GroupBox();
            this.txtReceiptCode = new System.Windows.Forms.TextBox();
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.errEditReceipt = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpContactInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).BeginInit();
            this.grpReceiptInfo.SuspendLayout();
            this.grpReceiptCode.SuspendLayout();
            this.grpFine.SuspendLayout();
            this.grpBorrowBookTotal.SuspendLayout();
            this.grpReturnDate.SuspendLayout();
            this.grpStatus.SuspendLayout();
            this.grpBorrowDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errEditReceipt)).BeginInit();
            this.SuspendLayout();
            // 
            // grpContactInfo
            // 
            this.grpContactInfo.Controls.Add(this.dgvDetail);
            this.grpContactInfo.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpContactInfo.Location = new System.Drawing.Point(264, 59);
            this.grpContactInfo.Name = "grpContactInfo";
            this.grpContactInfo.Size = new System.Drawing.Size(851, 270);
            this.grpContactInfo.TabIndex = 76;
            this.grpContactInfo.TabStop = false;
            this.grpContactInfo.Text = "Chi tiết phiếu";
            // 
            // dgvDetail
            // 
            this.dgvDetail.AllowUserToAddRows = false;
            this.dgvDetail.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDetail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetail.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDetail.BackgroundColor = System.Drawing.Color.White;
            this.dgvDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDetail.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDetail.ColumnHeadersHeight = 25;
            this.dgvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.SoLuong});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetail.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDetail.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDetail.DoubleBuffered = true;
            this.dgvDetail.EnableHeadersVisualStyles = false;
            this.dgvDetail.GridColor = System.Drawing.Color.White;
            this.dgvDetail.HeaderBgColor = System.Drawing.Color.MidnightBlue;
            this.dgvDetail.HeaderForeColor = System.Drawing.Color.White;
            this.dgvDetail.Location = new System.Drawing.Point(3, 46);
            this.dgvDetail.Name = "dgvDetail";
            this.dgvDetail.ReadOnly = true;
            this.dgvDetail.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetail.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDetail.RowHeadersVisible = false;
            this.dgvDetail.RowHeadersWidth = 20;
            this.dgvDetail.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDetail.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDetail.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDetail.RowTemplate.DividerHeight = 1;
            this.dgvDetail.RowTemplate.Height = 30;
            this.dgvDetail.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetail.ShowCellErrors = false;
            this.dgvDetail.ShowCellToolTips = false;
            this.dgvDetail.ShowEditingIcon = false;
            this.dgvDetail.ShowRowErrors = false;
            this.dgvDetail.Size = new System.Drawing.Size(845, 221);
            this.dgvDetail.TabIndex = 61;
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
            // SoLuong
            // 
            this.SoLuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SoLuong.HeaderText = "SỐ LƯỢNG";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            this.SoLuong.Width = 186;
            // 
            // grpReceiptInfo
            // 
            this.grpReceiptInfo.Controls.Add(this.lblBorrowDateError);
            this.grpReceiptInfo.Controls.Add(this.lblStatusError);
            this.grpReceiptInfo.Controls.Add(this.lblReturnDateError);
            this.grpReceiptInfo.Controls.Add(this.grpReceiptCode);
            this.grpReceiptInfo.Controls.Add(this.lblUnit);
            this.grpReceiptInfo.Controls.Add(this.grpFine);
            this.grpReceiptInfo.Controls.Add(this.grpBorrowBookTotal);
            this.grpReceiptInfo.Controls.Add(this.grpReturnDate);
            this.grpReceiptInfo.Controls.Add(this.grpStatus);
            this.grpReceiptInfo.Controls.Add(this.grpBorrowDate);
            this.grpReceiptInfo.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpReceiptInfo.Location = new System.Drawing.Point(12, 1);
            this.grpReceiptInfo.Name = "grpReceiptInfo";
            this.grpReceiptInfo.Size = new System.Drawing.Size(246, 428);
            this.grpReceiptInfo.TabIndex = 75;
            this.grpReceiptInfo.TabStop = false;
            this.grpReceiptInfo.Text = "Phiếu Mượn/Trả";
            // 
            // lblBorrowDateError
            // 
            this.lblBorrowDateError.AutoSize = true;
            this.lblBorrowDateError.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBorrowDateError.ForeColor = System.Drawing.Color.Red;
            this.lblBorrowDateError.Location = new System.Drawing.Point(0, 145);
            this.lblBorrowDateError.Name = "lblBorrowDateError";
            this.lblBorrowDateError.Size = new System.Drawing.Size(116, 13);
            this.lblBorrowDateError.TabIndex = 82;
            this.lblBorrowDateError.Text = "BorowDate Warning ";
            // 
            // lblStatusError
            // 
            this.lblStatusError.AutoSize = true;
            this.lblStatusError.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusError.ForeColor = System.Drawing.Color.Red;
            this.lblStatusError.Location = new System.Drawing.Point(0, 292);
            this.lblStatusError.Name = "lblStatusError";
            this.lblStatusError.Size = new System.Drawing.Size(90, 13);
            this.lblStatusError.TabIndex = 81;
            this.lblStatusError.Text = "Status Warning ";
            // 
            // lblReturnDateError
            // 
            this.lblReturnDateError.AutoSize = true;
            this.lblReturnDateError.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnDateError.ForeColor = System.Drawing.Color.Red;
            this.lblReturnDateError.Location = new System.Drawing.Point(0, 212);
            this.lblReturnDateError.Name = "lblReturnDateError";
            this.lblReturnDateError.Size = new System.Drawing.Size(93, 13);
            this.lblReturnDateError.TabIndex = 80;
            this.lblReturnDateError.Text = "Return Warning ";
            // 
            // grpReceiptCode
            // 
            this.grpReceiptCode.BackColor = System.Drawing.Color.White;
            this.grpReceiptCode.Controls.Add(this.txtReceiptCode);
            this.grpReceiptCode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpReceiptCode.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpReceiptCode.Location = new System.Drawing.Point(17, 39);
            this.grpReceiptCode.Name = "grpReceiptCode";
            this.grpReceiptCode.Size = new System.Drawing.Size(161, 49);
            this.grpReceiptCode.TabIndex = 79;
            this.grpReceiptCode.TabStop = false;
            this.grpReceiptCode.Text = "Mã mượn/trả";
            // 
            // txtReceiptCode
            // 
            this.txtReceiptCode.AcceptsTab = true;
            this.txtReceiptCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReceiptCode.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtReceiptCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtReceiptCode.Enabled = false;
            this.txtReceiptCode.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReceiptCode.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtReceiptCode.Location = new System.Drawing.Point(3, 19);
            this.txtReceiptCode.Margin = new System.Windows.Forms.Padding(0);
            this.txtReceiptCode.Name = "txtReceiptCode";
            this.txtReceiptCode.Size = new System.Drawing.Size(155, 26);
            this.txtReceiptCode.TabIndex = 3;
            this.txtReceiptCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtReceiptCode.WordWrap = false;
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnit.Location = new System.Drawing.Point(178, 389);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(52, 24);
            this.lblUnit.TabIndex = 78;
            this.lblUnit.Text = "VND";
            // 
            // grpFine
            // 
            this.grpFine.BackColor = System.Drawing.Color.White;
            this.grpFine.Controls.Add(this.txtFine);
            this.grpFine.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpFine.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFine.Location = new System.Drawing.Point(17, 362);
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
            this.grpBorrowBookTotal.Location = new System.Drawing.Point(17, 307);
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
            this.grpReturnDate.Location = new System.Drawing.Point(17, 161);
            this.grpReturnDate.Name = "grpReturnDate";
            this.grpReturnDate.Size = new System.Drawing.Size(183, 48);
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
            this.dtpReturnDate.Validating += new System.ComponentModel.CancelEventHandler(this.dtpReturnDate_Validating);
            this.dtpReturnDate.Validated += new System.EventHandler(this.dtpReturnDate_Validated);
            // 
            // grpStatus
            // 
            this.grpStatus.BackColor = System.Drawing.Color.White;
            this.grpStatus.Controls.Add(this.cboStatus);
            this.grpStatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpStatus.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpStatus.Location = new System.Drawing.Point(17, 235);
            this.grpStatus.Name = "grpStatus";
            this.grpStatus.Size = new System.Drawing.Size(183, 54);
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
            this.cboStatus.Size = new System.Drawing.Size(152, 33);
            this.cboStatus.Sorted = true;
            this.cboStatus.TabIndex = 2;
            this.cboStatus.TextChanged += new System.EventHandler(this.cboStatus_TextChanged);
            this.cboStatus.Validating += new System.ComponentModel.CancelEventHandler(this.cboStatus_Validating);
            this.cboStatus.Validated += new System.EventHandler(this.cboStatus_Validated);
            // 
            // grpBorrowDate
            // 
            this.grpBorrowDate.BackColor = System.Drawing.Color.White;
            this.grpBorrowDate.Controls.Add(this.dtpBorrowDate);
            this.grpBorrowDate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpBorrowDate.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBorrowDate.Location = new System.Drawing.Point(17, 94);
            this.grpBorrowDate.Name = "grpBorrowDate";
            this.grpBorrowDate.Size = new System.Drawing.Size(183, 48);
            this.grpBorrowDate.TabIndex = 70;
            this.grpBorrowDate.TabStop = false;
            this.grpBorrowDate.Text = "Ngày mượn";
            // 
            // dtpBorrowDate
            // 
            this.dtpBorrowDate.CustomFormat = "dmy";
            this.dtpBorrowDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBorrowDate.Location = new System.Drawing.Point(9, 19);
            this.dtpBorrowDate.Name = "dtpBorrowDate";
            this.dtpBorrowDate.Size = new System.Drawing.Size(146, 23);
            this.dtpBorrowDate.TabIndex = 0;
            this.dtpBorrowDate.Validating += new System.ComponentModel.CancelEventHandler(this.dtpBorrowDate_Validating);
            this.dtpBorrowDate.Validated += new System.EventHandler(this.dtpBorrowDate_Validated);
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
            this.btnCancel.Location = new System.Drawing.Point(976, 354);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(133, 36);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.ForestGreen;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEdit.Image = global::New_Library.Properties.Resources.update_24px;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.Location = new System.Drawing.Point(837, 354);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(133, 36);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // errEditReceipt
            // 
            this.errEditReceipt.BlinkRate = 0;
            this.errEditReceipt.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errEditReceipt.ContainerControl = this;
            // 
            // frmEditReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1124, 432);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.grpContactInfo);
            this.Controls.Add(this.grpReceiptInfo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEditReceipt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmEditReceipt_Load);
            this.grpContactInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).EndInit();
            this.grpReceiptInfo.ResumeLayout(false);
            this.grpReceiptInfo.PerformLayout();
            this.grpReceiptCode.ResumeLayout(false);
            this.grpReceiptCode.PerformLayout();
            this.grpFine.ResumeLayout(false);
            this.grpFine.PerformLayout();
            this.grpBorrowBookTotal.ResumeLayout(false);
            this.grpBorrowBookTotal.PerformLayout();
            this.grpReturnDate.ResumeLayout(false);
            this.grpStatus.ResumeLayout(false);
            this.grpBorrowDate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errEditReceipt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpContactInfo;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvDetail;
        private System.Windows.Forms.GroupBox grpReceiptInfo;
        private System.Windows.Forms.GroupBox grpFine;
        private System.Windows.Forms.TextBox txtFine;
        private System.Windows.Forms.GroupBox grpBorrowBookTotal;
        private System.Windows.Forms.TextBox txtBorrowBookTotal;
        private System.Windows.Forms.GroupBox grpReturnDate;
        private System.Windows.Forms.DateTimePicker dtpReturnDate;
        private System.Windows.Forms.GroupBox grpStatus;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.GroupBox grpBorrowDate;
        private System.Windows.Forms.DateTimePicker dtpBorrowDate;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.GroupBox grpReceiptCode;
        private System.Windows.Forms.TextBox txtReceiptCode;
        private System.Windows.Forms.Label lblBorrowDateError;
        private System.Windows.Forms.Label lblStatusError;
        private System.Windows.Forms.Label lblReturnDateError;
        private System.Windows.Forms.ErrorProvider errEditReceipt;
    }
}