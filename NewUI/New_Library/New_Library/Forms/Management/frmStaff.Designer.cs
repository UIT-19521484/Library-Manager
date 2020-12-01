namespace New_Library.Forms
{
    partial class frmStaff
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvStaff = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlBookInfo = new System.Windows.Forms.Panel();
            this.chkUsernamePermission = new System.Windows.Forms.CheckBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cboAccountName = new System.Windows.Forms.ComboBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblAccountName = new System.Windows.Forms.Label();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.cboSex = new System.Windows.Forms.ComboBox();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtStaffName = new System.Windows.Forms.TextBox();
            this.lblStaffName = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).BeginInit();
            this.pnlBookInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.dgvStaff, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pnlBookInfo, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.29148F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.70852F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(844, 446);
            this.tableLayoutPanel1.TabIndex = 54;
            // 
            // dgvStaff
            // 
            this.dgvStaff.AllowUserToAddRows = false;
            this.dgvStaff.AllowUserToDeleteRows = false;
            dataGridViewCellStyle33.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvStaff.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle33;
            this.dgvStaff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStaff.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvStaff.BackgroundColor = System.Drawing.Color.White;
            this.dgvStaff.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStaff.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle34.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle34.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle34.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle34.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle34.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle34.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStaff.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle34;
            this.dgvStaff.ColumnHeadersHeight = 32;
            this.dgvStaff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle35.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle35.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle35.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle35.SelectionBackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle35.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle35.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStaff.DefaultCellStyle = dataGridViewCellStyle35;
            this.dgvStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStaff.DoubleBuffered = true;
            this.dgvStaff.EnableHeadersVisualStyles = false;
            this.dgvStaff.GridColor = System.Drawing.Color.White;
            this.dgvStaff.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dgvStaff.HeaderForeColor = System.Drawing.Color.White;
            this.dgvStaff.Location = new System.Drawing.Point(3, 205);
            this.dgvStaff.Name = "dgvStaff";
            this.dgvStaff.ReadOnly = true;
            this.dgvStaff.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle36.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle36.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle36.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle36.SelectionBackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle36.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle36.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStaff.RowHeadersDefaultCellStyle = dataGridViewCellStyle36;
            this.dgvStaff.RowHeadersVisible = false;
            this.dgvStaff.RowHeadersWidth = 20;
            this.dgvStaff.RowTemplate.DividerHeight = 1;
            this.dgvStaff.RowTemplate.Height = 30;
            this.dgvStaff.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStaff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStaff.Size = new System.Drawing.Size(838, 238);
            this.dgvStaff.TabIndex = 45;
            this.dgvStaff.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvStaff_CellMouseDown);
            this.dgvStaff.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvReader_DataBindingComplete);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "HỌ TÊN";
            this.Column1.HeaderText = "HỌ TÊN";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column2.DataPropertyName = "GIỚI TÍNH";
            this.Column2.HeaderText = "GIỚI TÍNH";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.Width = 126;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column3.DataPropertyName = "NGÀY SINH";
            this.Column3.HeaderText = "NGÀY SINH";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.Width = 137;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "ĐỊA CHỈ";
            this.Column4.HeaderText = "ĐỊA CHỈ";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column5.DataPropertyName = "SĐT";
            this.Column5.HeaderText = "SĐT";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column5.Width = 70;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column6.DataPropertyName = "TÀI KHOẢN";
            this.Column6.HeaderText = "TÀI KHOẢN";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column6.Width = 137;
            // 
            // pnlBookInfo
            // 
            this.pnlBookInfo.Controls.Add(this.chkUsernamePermission);
            this.pnlBookInfo.Controls.Add(this.btnSearch);
            this.pnlBookInfo.Controls.Add(this.cboAccountName);
            this.pnlBookInfo.Controls.Add(this.btnEdit);
            this.pnlBookInfo.Controls.Add(this.dtpDateOfBirth);
            this.pnlBookInfo.Controls.Add(this.txtPhone);
            this.pnlBookInfo.Controls.Add(this.lblAccountName);
            this.pnlBookInfo.Controls.Add(this.lblDateOfBirth);
            this.pnlBookInfo.Controls.Add(this.cboSex);
            this.pnlBookInfo.Controls.Add(this.lblSex);
            this.pnlBookInfo.Controls.Add(this.lblPhone);
            this.pnlBookInfo.Controls.Add(this.txtAddress);
            this.pnlBookInfo.Controls.Add(this.lblAddress);
            this.pnlBookInfo.Controls.Add(this.txtStaffName);
            this.pnlBookInfo.Controls.Add(this.lblStaffName);
            this.pnlBookInfo.Controls.Add(this.txtSearch);
            this.pnlBookInfo.Controls.Add(this.lblSearch);
            this.pnlBookInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBookInfo.Location = new System.Drawing.Point(3, 3);
            this.pnlBookInfo.Name = "pnlBookInfo";
            this.pnlBookInfo.Size = new System.Drawing.Size(838, 196);
            this.pnlBookInfo.TabIndex = 46;
            // 
            // chkUsernamePermission
            // 
            this.chkUsernamePermission.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkUsernamePermission.AutoSize = true;
            this.chkUsernamePermission.Enabled = false;
            this.chkUsernamePermission.Location = new System.Drawing.Point(441, 155);
            this.chkUsernamePermission.Name = "chkUsernamePermission";
            this.chkUsernamePermission.Size = new System.Drawing.Size(15, 14);
            this.chkUsernamePermission.TabIndex = 55;
            this.chkUsernamePermission.UseVisualStyleBackColor = true;
            this.chkUsernamePermission.CheckedChanged += new System.EventHandler(this.chkUsernamePermission_CheckedChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.Black;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Image = global::New_Library.Properties.Resources.right_24px;
            this.btnSearch.Location = new System.Drawing.Point(597, 10);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(37, 27);
            this.btnSearch.TabIndex = 54;
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cboAccountName
            // 
            this.cboAccountName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboAccountName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAccountName.Enabled = false;
            this.cboAccountName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboAccountName.Font = new System.Drawing.Font("Verdana", 12F);
            this.cboAccountName.FormattingEnabled = true;
            this.cboAccountName.Location = new System.Drawing.Point(140, 148);
            this.cboAccountName.Name = "cboAccountName";
            this.cboAccountName.Size = new System.Drawing.Size(285, 26);
            this.cboAccountName.Sorted = true;
            this.cboAccountName.TabIndex = 51;
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.BackColor = System.Drawing.Color.Black;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Image = global::New_Library.Properties.Resources.update;
            this.btnEdit.Location = new System.Drawing.Point(789, 5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(37, 35);
            this.btnEdit.TabIndex = 50;
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDateOfBirth.CustomFormat = "ddmmyyyy";
            this.dtpDateOfBirth.Enabled = false;
            this.dtpDateOfBirth.Font = new System.Drawing.Font("Verdana", 12F);
            this.dtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateOfBirth.Location = new System.Drawing.Point(620, 105);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpDateOfBirth.Size = new System.Drawing.Size(143, 27);
            this.dtpDateOfBirth.TabIndex = 34;
            // 
            // txtPhone
            // 
            this.txtPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhone.Font = new System.Drawing.Font("Verdana", 12F);
            this.txtPhone.Location = new System.Drawing.Point(620, 148);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.Size = new System.Drawing.Size(171, 27);
            this.txtPhone.TabIndex = 33;
            this.txtPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblAccountName
            // 
            this.lblAccountName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAccountName.AutoSize = true;
            this.lblAccountName.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountName.Location = new System.Drawing.Point(39, 147);
            this.lblAccountName.Name = "lblAccountName";
            this.lblAccountName.Size = new System.Drawing.Size(95, 24);
            this.lblAccountName.TabIndex = 31;
            this.lblAccountName.Text = "Tài khoản:";
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateOfBirth.Location = new System.Drawing.Point(503, 107);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(95, 24);
            this.lblDateOfBirth.TabIndex = 30;
            this.lblDateOfBirth.Text = "Ngày sinh:";
            // 
            // cboSex
            // 
            this.cboSex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSex.Enabled = false;
            this.cboSex.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboSex.Font = new System.Drawing.Font("Verdana", 12F);
            this.cboSex.FormattingEnabled = true;
            this.cboSex.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cboSex.Location = new System.Drawing.Point(620, 63);
            this.cboSex.Name = "cboSex";
            this.cboSex.Size = new System.Drawing.Size(122, 26);
            this.cboSex.Sorted = true;
            this.cboSex.TabIndex = 29;
            // 
            // lblSex
            // 
            this.lblSex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSex.AutoSize = true;
            this.lblSex.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSex.Location = new System.Drawing.Point(503, 62);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(89, 24);
            this.lblSex.TabIndex = 28;
            this.lblSex.Text = "Giới tính:";
            // 
            // lblPhone
            // 
            this.lblPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(503, 147);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(49, 24);
            this.lblPhone.TabIndex = 26;
            this.lblPhone.Text = "SĐT:";
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddress.Font = new System.Drawing.Font("Verdana", 12F);
            this.txtAddress.Location = new System.Drawing.Point(140, 108);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(315, 27);
            this.txtAddress.TabIndex = 25;
            // 
            // lblAddress
            // 
            this.lblAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(39, 107);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(72, 24);
            this.lblAddress.TabIndex = 24;
            this.lblAddress.Text = "Địa chỉ:";
            // 
            // txtStaffName
            // 
            this.txtStaffName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStaffName.Font = new System.Drawing.Font("Verdana", 12F);
            this.txtStaffName.Location = new System.Drawing.Point(140, 63);
            this.txtStaffName.Name = "txtStaffName";
            this.txtStaffName.ReadOnly = true;
            this.txtStaffName.Size = new System.Drawing.Size(315, 27);
            this.txtStaffName.TabIndex = 23;
            // 
            // lblStaffName
            // 
            this.lblStaffName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStaffName.AutoSize = true;
            this.lblStaffName.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffName.Location = new System.Drawing.Point(39, 62);
            this.lblStaffName.Name = "lblStaffName";
            this.lblStaffName.Size = new System.Drawing.Size(70, 24);
            this.lblStaffName.TabIndex = 22;
            this.lblStaffName.Text = "Họ tên:";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("Verdana", 12F);
            this.txtSearch.Location = new System.Drawing.Point(251, 10);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(340, 27);
            this.txtSearch.TabIndex = 21;
            // 
            // lblSearch
            // 
            this.lblSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(152, 10);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(93, 24);
            this.lblSearch.TabIndex = 20;
            this.lblSearch.Text = "Tìm kiếm:";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Image = global::New_Library.Properties.Resources.delete;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(522, 455);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnDelete.Size = new System.Drawing.Size(116, 41);
            this.btnDelete.TabIndex = 56;
            this.btnDelete.Text = "   Xóa";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Image = global::New_Library.Properties.Resources.update_24px;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(690, 455);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnUpdate.Size = new System.Drawing.Size(116, 41);
            this.btnUpdate.TabIndex = 55;
            this.btnUpdate.Text = "   Sửa";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Image = global::New_Library.Properties.Resources.add1;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(344, 455);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnAdd.Size = new System.Drawing.Size(116, 41);
            this.btnAdd.TabIndex = 53;
            this.btnAdd.Text = "   Thêm";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 498);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Name = "frmStaff";
            this.Text = "frmStaff";
            this.Load += new System.EventHandler(this.frmStaff_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).EndInit();
            this.pnlBookInfo.ResumeLayout(false);
            this.pnlBookInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvStaff;
        private System.Windows.Forms.Panel pnlBookInfo;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblAccountName;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.ComboBox cboSex;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtStaffName;
        private System.Windows.Forms.Label lblStaffName;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ComboBox cboAccountName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.CheckBox chkUsernamePermission;
    }
}