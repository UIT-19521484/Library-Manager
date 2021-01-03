namespace New_Library.Forms.Management.Account
{
    partial class frmAddStaff
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
            this.lblSexError = new System.Windows.Forms.Label();
            this.lblStaffNameError = new System.Windows.Forms.Label();
            this.gbSex = new System.Windows.Forms.GroupBox();
            this.cboSex = new System.Windows.Forms.ComboBox();
            this.grpSex = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.nudYear = new System.Windows.Forms.NumericUpDown();
            this.lblPhoneNumberWarning = new System.Windows.Forms.Label();
            this.grpPhoneNumber = new System.Windows.Forms.GroupBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.nudDay = new System.Windows.Forms.NumericUpDown();
            this.lblAddressError = new System.Windows.Forms.Label();
            this.grpAddress = new System.Windows.Forms.GroupBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.nudMonth = new System.Windows.Forms.NumericUpDown();
            this.grpDOB = new System.Windows.Forms.GroupBox();
            this.grpStaffName = new System.Windows.Forms.GroupBox();
            this.txtStaffName = new System.Windows.Forms.TextBox();
            this.grpStaffInfo = new System.Windows.Forms.GroupBox();
            this.grpContactInfo = new System.Windows.Forms.GroupBox();
            this.errAddStaff = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpPassword = new System.Windows.Forms.GroupBox();
            this.chkShowPassword = new System.Windows.Forms.CheckBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.grpAccountName = new System.Windows.Forms.GroupBox();
            this.txtAccountName = new System.Windows.Forms.TextBox();
            this.lblAccountNameError = new System.Windows.Forms.Label();
            this.grpAccount = new System.Windows.Forms.GroupBox();
            this.lblPasswordError = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gbSex.SuspendLayout();
            this.grpSex.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).BeginInit();
            this.grpPhoneNumber.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDay)).BeginInit();
            this.grpAddress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonth)).BeginInit();
            this.grpDOB.SuspendLayout();
            this.grpStaffName.SuspendLayout();
            this.grpStaffInfo.SuspendLayout();
            this.grpContactInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errAddStaff)).BeginInit();
            this.grpPassword.SuspendLayout();
            this.grpAccountName.SuspendLayout();
            this.grpAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSexError
            // 
            this.lblSexError.AutoSize = true;
            this.lblSexError.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexError.ForeColor = System.Drawing.Color.Red;
            this.lblSexError.Location = new System.Drawing.Point(10, 226);
            this.lblSexError.Name = "lblSexError";
            this.lblSexError.Size = new System.Drawing.Size(52, 13);
            this.lblSexError.TabIndex = 73;
            this.lblSexError.Text = "Sex Error";
            // 
            // lblStaffNameError
            // 
            this.lblStaffNameError.AutoSize = true;
            this.lblStaffNameError.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffNameError.ForeColor = System.Drawing.Color.Red;
            this.lblStaffNameError.Location = new System.Drawing.Point(10, 94);
            this.lblStaffNameError.Name = "lblStaffNameError";
            this.lblStaffNameError.Size = new System.Drawing.Size(88, 13);
            this.lblStaffNameError.TabIndex = 72;
            this.lblStaffNameError.Text = "StaffName Error";
            // 
            // gbSex
            // 
            this.gbSex.BackColor = System.Drawing.Color.White;
            this.gbSex.Controls.Add(this.cboSex);
            this.gbSex.Controls.Add(this.grpSex);
            this.gbSex.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbSex.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSex.Location = new System.Drawing.Point(13, 169);
            this.gbSex.Name = "gbSex";
            this.gbSex.Size = new System.Drawing.Size(349, 54);
            this.gbSex.TabIndex = 71;
            this.gbSex.TabStop = false;
            this.gbSex.Text = "Giới tính";
            // 
            // cboSex
            // 
            this.cboSex.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboSex.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cboSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSex.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboSex.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSex.FormattingEnabled = true;
            this.cboSex.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cboSex.Location = new System.Drawing.Point(9, 19);
            this.cboSex.Margin = new System.Windows.Forms.Padding(0);
            this.cboSex.Name = "cboSex";
            this.cboSex.Size = new System.Drawing.Size(337, 33);
            this.cboSex.Sorted = true;
            this.cboSex.TabIndex = 5;
            this.cboSex.Validating += new System.ComponentModel.CancelEventHandler(this.cbSex_Validating);
            this.cboSex.Validated += new System.EventHandler(this.cbSex_Validated);
            // 
            // grpSex
            // 
            this.grpSex.BackColor = System.Drawing.Color.White;
            this.grpSex.Controls.Add(this.comboBox2);
            this.grpSex.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpSex.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSex.Location = new System.Drawing.Point(0, 0);
            this.grpSex.Name = "grpSex";
            this.grpSex.Size = new System.Drawing.Size(349, 54);
            this.grpSex.TabIndex = 71;
            this.grpSex.TabStop = false;
            this.grpSex.Text = "Giới tính";
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.comboBox2.Location = new System.Drawing.Point(9, 19);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(0);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(337, 33);
            this.comboBox2.Sorted = true;
            this.comboBox2.TabIndex = 2;
            this.comboBox2.Validating += new System.ComponentModel.CancelEventHandler(this.cbSex_Validating);
            this.comboBox2.Validated += new System.EventHandler(this.cbSex_Validated);
            // 
            // nudYear
            // 
            this.nudYear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudYear.Font = new System.Drawing.Font("MS Reference Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudYear.Location = new System.Drawing.Point(225, 17);
            this.nudYear.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudYear.Name = "nudYear";
            this.nudYear.Size = new System.Drawing.Size(121, 28);
            this.nudYear.TabIndex = 4;
            this.nudYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudYear.ValueChanged += new System.EventHandler(this.nudYear_ValueChanged);
            // 
            // lblPhoneNumberWarning
            // 
            this.lblPhoneNumberWarning.AutoSize = true;
            this.lblPhoneNumberWarning.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumberWarning.ForeColor = System.Drawing.Color.Red;
            this.lblPhoneNumberWarning.Location = new System.Drawing.Point(3, 94);
            this.lblPhoneNumberWarning.Name = "lblPhoneNumberWarning";
            this.lblPhoneNumberWarning.Size = new System.Drawing.Size(132, 13);
            this.lblPhoneNumberWarning.TabIndex = 73;
            this.lblPhoneNumberWarning.Text = "PhoneNumber Warning ";
            // 
            // grpPhoneNumber
            // 
            this.grpPhoneNumber.BackColor = System.Drawing.Color.White;
            this.grpPhoneNumber.Controls.Add(this.txtPhoneNumber);
            this.grpPhoneNumber.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpPhoneNumber.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPhoneNumber.Location = new System.Drawing.Point(6, 45);
            this.grpPhoneNumber.Name = "grpPhoneNumber";
            this.grpPhoneNumber.Size = new System.Drawing.Size(234, 48);
            this.grpPhoneNumber.TabIndex = 69;
            this.grpPhoneNumber.TabStop = false;
            this.grpPhoneNumber.Text = "Số điện thoại";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhoneNumber.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(9, 16);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(0);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(222, 26);
            this.txtPhoneNumber.TabIndex = 6;
            this.txtPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhoneNumber_KeyPress);
            this.txtPhoneNumber.Validating += new System.ComponentModel.CancelEventHandler(this.txtPhoneNumber_Validating);
            this.txtPhoneNumber.Validated += new System.EventHandler(this.txtPhoneNumber_Validated);
            // 
            // nudDay
            // 
            this.nudDay.Font = new System.Drawing.Font("MS Reference Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudDay.Location = new System.Drawing.Point(9, 17);
            this.nudDay.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDay.Name = "nudDay";
            this.nudDay.Size = new System.Drawing.Size(102, 28);
            this.nudDay.TabIndex = 2;
            this.nudDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudDay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblAddressError
            // 
            this.lblAddressError.AutoSize = true;
            this.lblAddressError.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressError.ForeColor = System.Drawing.Color.Red;
            this.lblAddressError.Location = new System.Drawing.Point(3, 159);
            this.lblAddressError.Name = "lblAddressError";
            this.lblAddressError.Size = new System.Drawing.Size(76, 13);
            this.lblAddressError.TabIndex = 75;
            this.lblAddressError.Text = "Address Error";
            // 
            // grpAddress
            // 
            this.grpAddress.BackColor = System.Drawing.Color.White;
            this.grpAddress.Controls.Add(this.txtAddress);
            this.grpAddress.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpAddress.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAddress.Location = new System.Drawing.Point(6, 110);
            this.grpAddress.Name = "grpAddress";
            this.grpAddress.Size = new System.Drawing.Size(234, 48);
            this.grpAddress.TabIndex = 74;
            this.grpAddress.TabStop = false;
            this.grpAddress.Text = "Địa chỉ";
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddress.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtAddress.Location = new System.Drawing.Point(9, 19);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(0);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(222, 26);
            this.txtAddress.TabIndex = 7;
            this.txtAddress.Validating += new System.ComponentModel.CancelEventHandler(this.txtAddress_Validating);
            this.txtAddress.Validated += new System.EventHandler(this.txtAddress_Validated);
            // 
            // nudMonth
            // 
            this.nudMonth.Font = new System.Drawing.Font("MS Reference Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMonth.Location = new System.Drawing.Point(115, 17);
            this.nudMonth.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudMonth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMonth.Name = "nudMonth";
            this.nudMonth.Size = new System.Drawing.Size(106, 28);
            this.nudMonth.TabIndex = 3;
            this.nudMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudMonth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMonth.ValueChanged += new System.EventHandler(this.nudMonth_ValueChanged);
            // 
            // grpDOB
            // 
            this.grpDOB.BackColor = System.Drawing.Color.White;
            this.grpDOB.Controls.Add(this.nudMonth);
            this.grpDOB.Controls.Add(this.nudDay);
            this.grpDOB.Controls.Add(this.nudYear);
            this.grpDOB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpDOB.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDOB.Location = new System.Drawing.Point(13, 110);
            this.grpDOB.Name = "grpDOB";
            this.grpDOB.Size = new System.Drawing.Size(349, 48);
            this.grpDOB.TabIndex = 70;
            this.grpDOB.TabStop = false;
            this.grpDOB.Text = "Ngày sinh";
            // 
            // grpStaffName
            // 
            this.grpStaffName.BackColor = System.Drawing.Color.White;
            this.grpStaffName.Controls.Add(this.txtStaffName);
            this.grpStaffName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpStaffName.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpStaffName.Location = new System.Drawing.Point(13, 45);
            this.grpStaffName.Name = "grpStaffName";
            this.grpStaffName.Size = new System.Drawing.Size(349, 48);
            this.grpStaffName.TabIndex = 68;
            this.grpStaffName.TabStop = false;
            this.grpStaffName.Text = "Tên nhân viên";
            // 
            // txtStaffName
            // 
            this.txtStaffName.AcceptsTab = true;
            this.txtStaffName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStaffName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtStaffName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStaffName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtStaffName.Location = new System.Drawing.Point(9, 19);
            this.txtStaffName.Margin = new System.Windows.Forms.Padding(0);
            this.txtStaffName.Name = "txtStaffName";
            this.txtStaffName.Size = new System.Drawing.Size(337, 26);
            this.txtStaffName.TabIndex = 1;
            this.txtStaffName.WordWrap = false;
            this.txtStaffName.Validating += new System.ComponentModel.CancelEventHandler(this.txtStaffName_Validating);
            this.txtStaffName.Validated += new System.EventHandler(this.txtStaffName_Validated);
            // 
            // grpStaffInfo
            // 
            this.grpStaffInfo.Controls.Add(this.lblSexError);
            this.grpStaffInfo.Controls.Add(this.lblStaffNameError);
            this.grpStaffInfo.Controls.Add(this.gbSex);
            this.grpStaffInfo.Controls.Add(this.grpDOB);
            this.grpStaffInfo.Controls.Add(this.grpStaffName);
            this.grpStaffInfo.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpStaffInfo.Location = new System.Drawing.Point(12, 12);
            this.grpStaffInfo.Name = "grpStaffInfo";
            this.grpStaffInfo.Size = new System.Drawing.Size(391, 331);
            this.grpStaffInfo.TabIndex = 71;
            this.grpStaffInfo.TabStop = false;
            this.grpStaffInfo.Text = "Thông tin nhân viên";
            // 
            // grpContactInfo
            // 
            this.grpContactInfo.Controls.Add(this.lblAddressError);
            this.grpContactInfo.Controls.Add(this.grpAddress);
            this.grpContactInfo.Controls.Add(this.lblPhoneNumberWarning);
            this.grpContactInfo.Controls.Add(this.grpPhoneNumber);
            this.grpContactInfo.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpContactInfo.Location = new System.Drawing.Point(409, 12);
            this.grpContactInfo.Name = "grpContactInfo";
            this.grpContactInfo.Size = new System.Drawing.Size(268, 263);
            this.grpContactInfo.TabIndex = 72;
            this.grpContactInfo.TabStop = false;
            this.grpContactInfo.Text = "Thông tin liên lạc";
            // 
            // errAddStaff
            // 
            this.errAddStaff.BlinkRate = 0;
            this.errAddStaff.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errAddStaff.ContainerControl = this;
            // 
            // grpPassword
            // 
            this.grpPassword.BackColor = System.Drawing.Color.White;
            this.grpPassword.Controls.Add(this.chkShowPassword);
            this.grpPassword.Controls.Add(this.txtPassword);
            this.grpPassword.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpPassword.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPassword.Location = new System.Drawing.Point(6, 110);
            this.grpPassword.Name = "grpPassword";
            this.grpPassword.Size = new System.Drawing.Size(234, 75);
            this.grpPassword.TabIndex = 69;
            this.grpPassword.TabStop = false;
            this.grpPassword.Text = "Mật khẩu";
            // 
            // chkShowPassword
            // 
            this.chkShowPassword.AutoSize = true;
            this.chkShowPassword.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShowPassword.Location = new System.Drawing.Point(9, 49);
            this.chkShowPassword.Name = "chkShowPassword";
            this.chkShowPassword.Size = new System.Drawing.Size(121, 20);
            this.chkShowPassword.TabIndex = 10;
            this.chkShowPassword.TabStop = false;
            this.chkShowPassword.Text = "Hiện mật khẩu";
            this.chkShowPassword.UseVisualStyleBackColor = true;
            this.chkShowPassword.CheckStateChanged += new System.EventHandler(this.chkShowPassword_CheckStateChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPassword.Location = new System.Drawing.Point(9, 19);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(0);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(222, 26);
            this.txtPassword.TabIndex = 9;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassword_Validating);
            this.txtPassword.Validated += new System.EventHandler(this.txtPassword_Validated);
            // 
            // grpAccountName
            // 
            this.grpAccountName.BackColor = System.Drawing.Color.White;
            this.grpAccountName.Controls.Add(this.txtAccountName);
            this.grpAccountName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpAccountName.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAccountName.Location = new System.Drawing.Point(6, 45);
            this.grpAccountName.Name = "grpAccountName";
            this.grpAccountName.Size = new System.Drawing.Size(234, 48);
            this.grpAccountName.TabIndex = 69;
            this.grpAccountName.TabStop = false;
            this.grpAccountName.Text = "Tên tài khoản";
            // 
            // txtAccountName
            // 
            this.txtAccountName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAccountName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtAccountName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAccountName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountName.Location = new System.Drawing.Point(9, 16);
            this.txtAccountName.Margin = new System.Windows.Forms.Padding(0);
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.Size = new System.Drawing.Size(222, 26);
            this.txtAccountName.TabIndex = 8;
            this.txtAccountName.Validating += new System.ComponentModel.CancelEventHandler(this.txtAccountName_Validating);
            this.txtAccountName.Validated += new System.EventHandler(this.txtAccountName_Validated);
            // 
            // lblAccountNameError
            // 
            this.lblAccountNameError.AutoSize = true;
            this.lblAccountNameError.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountNameError.ForeColor = System.Drawing.Color.Red;
            this.lblAccountNameError.Location = new System.Drawing.Point(3, 94);
            this.lblAccountNameError.Name = "lblAccountNameError";
            this.lblAccountNameError.Size = new System.Drawing.Size(129, 13);
            this.lblAccountNameError.TabIndex = 73;
            this.lblAccountNameError.Text = "AccountName Warning ";
            // 
            // grpAccount
            // 
            this.grpAccount.Controls.Add(this.lblPasswordError);
            this.grpAccount.Controls.Add(this.lblAccountNameError);
            this.grpAccount.Controls.Add(this.grpAccountName);
            this.grpAccount.Controls.Add(this.grpPassword);
            this.grpAccount.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAccount.Location = new System.Drawing.Point(683, 12);
            this.grpAccount.Name = "grpAccount";
            this.grpAccount.Size = new System.Drawing.Size(268, 263);
            this.grpAccount.TabIndex = 73;
            this.grpAccount.TabStop = false;
            this.grpAccount.Text = "Tài khoản";
            // 
            // lblPasswordError
            // 
            this.lblPasswordError.AutoSize = true;
            this.lblPasswordError.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordError.ForeColor = System.Drawing.Color.Red;
            this.lblPasswordError.Location = new System.Drawing.Point(3, 188);
            this.lblPasswordError.Name = "lblPasswordError";
            this.lblPasswordError.Size = new System.Drawing.Size(107, 13);
            this.lblPasswordError.TabIndex = 74;
            this.lblPasswordError.Text = "Password Warning ";
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
            this.btnCancel.Location = new System.Drawing.Point(818, 307);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(133, 36);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
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
            this.btnAdd.Location = new System.Drawing.Point(683, 307);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(133, 36);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmAddStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(962, 353);
            this.Controls.Add(this.grpAccount);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.grpStaffInfo);
            this.Controls.Add(this.grpContactInfo);
            this.Controls.Add(this.btnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddStaff";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmAddStaff_Load);
            this.gbSex.ResumeLayout(false);
            this.grpSex.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).EndInit();
            this.grpPhoneNumber.ResumeLayout(false);
            this.grpPhoneNumber.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDay)).EndInit();
            this.grpAddress.ResumeLayout(false);
            this.grpAddress.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonth)).EndInit();
            this.grpDOB.ResumeLayout(false);
            this.grpStaffName.ResumeLayout(false);
            this.grpStaffName.PerformLayout();
            this.grpStaffInfo.ResumeLayout(false);
            this.grpStaffInfo.PerformLayout();
            this.grpContactInfo.ResumeLayout(false);
            this.grpContactInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errAddStaff)).EndInit();
            this.grpPassword.ResumeLayout(false);
            this.grpPassword.PerformLayout();
            this.grpAccountName.ResumeLayout(false);
            this.grpAccountName.PerformLayout();
            this.grpAccount.ResumeLayout(false);
            this.grpAccount.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblSexError;
        private System.Windows.Forms.Label lblStaffNameError;
        private System.Windows.Forms.GroupBox gbSex;
        private System.Windows.Forms.ComboBox cboSex;
        private System.Windows.Forms.NumericUpDown nudYear;
        private System.Windows.Forms.Label lblPhoneNumberWarning;
        private System.Windows.Forms.GroupBox grpPhoneNumber;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.NumericUpDown nudDay;
        private System.Windows.Forms.Label lblAddressError;
        private System.Windows.Forms.GroupBox grpAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.NumericUpDown nudMonth;
        private System.Windows.Forms.GroupBox grpDOB;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox grpStaffName;
        private System.Windows.Forms.TextBox txtStaffName;
        private System.Windows.Forms.GroupBox grpStaffInfo;
        private System.Windows.Forms.GroupBox grpContactInfo;
        private System.Windows.Forms.ErrorProvider errAddStaff;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox grpAccount;
        private System.Windows.Forms.Label lblPasswordError;
        private System.Windows.Forms.Label lblAccountNameError;
        private System.Windows.Forms.GroupBox grpAccountName;
        private System.Windows.Forms.TextBox txtAccountName;
        private System.Windows.Forms.GroupBox grpPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox chkShowPassword;
        private System.Windows.Forms.GroupBox grpSex;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}