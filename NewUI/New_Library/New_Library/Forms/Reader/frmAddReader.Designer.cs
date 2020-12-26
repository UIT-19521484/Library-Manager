namespace New_Library.Forms.Reader
{
    partial class frmAddReader
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.errAddReader = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblPhoneNumberWarning = new System.Windows.Forms.Label();
            this.grpPhoneNumber = new System.Windows.Forms.GroupBox();
            this.grpContactInfo = new System.Windows.Forms.GroupBox();
            this.lblAddressError = new System.Windows.Forms.Label();
            this.grpAddress = new System.Windows.Forms.GroupBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblEmailError = new System.Windows.Forms.Label();
            this.grpEmail = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtReaderName = new System.Windows.Forms.TextBox();
            this.grpReaderName = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpDOB = new System.Windows.Forms.GroupBox();
            this.nudMonth = new System.Windows.Forms.NumericUpDown();
            this.nudDay = new System.Windows.Forms.NumericUpDown();
            this.nudYear = new System.Windows.Forms.NumericUpDown();
            this.cbSex = new System.Windows.Forms.ComboBox();
            this.lblReaderNameError = new System.Windows.Forms.Label();
            this.grpSex = new System.Windows.Forms.GroupBox();
            this.grpReaderInfo = new System.Windows.Forms.GroupBox();
            this.lblSexError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errAddReader)).BeginInit();
            this.grpPhoneNumber.SuspendLayout();
            this.grpContactInfo.SuspendLayout();
            this.grpAddress.SuspendLayout();
            this.grpEmail.SuspendLayout();
            this.grpReaderName.SuspendLayout();
            this.grpDOB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).BeginInit();
            this.grpSex.SuspendLayout();
            this.grpReaderInfo.SuspendLayout();
            this.SuspendLayout();
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
            this.btnAdd.Location = new System.Drawing.Point(409, 307);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(133, 36);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // errAddReader
            // 
            this.errAddReader.BlinkRate = 0;
            this.errAddReader.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errAddReader.ContainerControl = this;
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
            // grpContactInfo
            // 
            this.grpContactInfo.Controls.Add(this.lblAddressError);
            this.grpContactInfo.Controls.Add(this.lblPhoneNumberWarning);
            this.grpContactInfo.Controls.Add(this.grpPhoneNumber);
            this.grpContactInfo.Controls.Add(this.grpAddress);
            this.grpContactInfo.Controls.Add(this.lblEmailError);
            this.grpContactInfo.Controls.Add(this.grpEmail);
            this.grpContactInfo.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpContactInfo.Location = new System.Drawing.Point(409, 12);
            this.grpContactInfo.Name = "grpContactInfo";
            this.grpContactInfo.Size = new System.Drawing.Size(268, 263);
            this.grpContactInfo.TabIndex = 65;
            this.grpContactInfo.TabStop = false;
            this.grpContactInfo.Text = "Thông tin liên lạc";
            // 
            // lblAddressError
            // 
            this.lblAddressError.AutoSize = true;
            this.lblAddressError.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressError.ForeColor = System.Drawing.Color.Red;
            this.lblAddressError.Location = new System.Drawing.Point(3, 224);
            this.lblAddressError.Name = "lblAddressError";
            this.lblAddressError.Size = new System.Drawing.Size(76, 13);
            this.lblAddressError.TabIndex = 77;
            this.lblAddressError.Text = "Address Error";
            // 
            // grpAddress
            // 
            this.grpAddress.BackColor = System.Drawing.Color.White;
            this.grpAddress.Controls.Add(this.txtAddress);
            this.grpAddress.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpAddress.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAddress.Location = new System.Drawing.Point(6, 175);
            this.grpAddress.Name = "grpAddress";
            this.grpAddress.Size = new System.Drawing.Size(234, 48);
            this.grpAddress.TabIndex = 76;
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
            this.txtAddress.Size = new System.Drawing.Size(225, 26);
            this.txtAddress.TabIndex = 8;
            this.txtAddress.Validating += new System.ComponentModel.CancelEventHandler(this.txtAddress_Validating);
            this.txtAddress.Validated += new System.EventHandler(this.txtAddress_Validated);
            // 
            // lblEmailError
            // 
            this.lblEmailError.AutoSize = true;
            this.lblEmailError.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailError.ForeColor = System.Drawing.Color.Red;
            this.lblEmailError.Location = new System.Drawing.Point(3, 159);
            this.lblEmailError.Name = "lblEmailError";
            this.lblEmailError.Size = new System.Drawing.Size(62, 13);
            this.lblEmailError.TabIndex = 73;
            this.lblEmailError.Text = "Email Error";
            // 
            // grpEmail
            // 
            this.grpEmail.BackColor = System.Drawing.Color.White;
            this.grpEmail.Controls.Add(this.txtEmail);
            this.grpEmail.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpEmail.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEmail.Location = new System.Drawing.Point(6, 110);
            this.grpEmail.Name = "grpEmail";
            this.grpEmail.Size = new System.Drawing.Size(234, 48);
            this.grpEmail.TabIndex = 69;
            this.grpEmail.TabStop = false;
            this.grpEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtEmail.Location = new System.Drawing.Point(9, 19);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(0);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(222, 26);
            this.txtEmail.TabIndex = 7;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            this.txtEmail.Validated += new System.EventHandler(this.txtEmail_Validated);
            // 
            // txtReaderName
            // 
            this.txtReaderName.AcceptsTab = true;
            this.txtReaderName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReaderName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtReaderName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtReaderName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReaderName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtReaderName.Location = new System.Drawing.Point(9, 19);
            this.txtReaderName.Margin = new System.Windows.Forms.Padding(0);
            this.txtReaderName.Name = "txtReaderName";
            this.txtReaderName.Size = new System.Drawing.Size(337, 26);
            this.txtReaderName.TabIndex = 1;
            this.txtReaderName.WordWrap = false;
            this.txtReaderName.Validating += new System.ComponentModel.CancelEventHandler(this.txtReaderName_Validating);
            this.txtReaderName.Validated += new System.EventHandler(this.txtReaderName_Validated);
            // 
            // grpReaderName
            // 
            this.grpReaderName.BackColor = System.Drawing.Color.White;
            this.grpReaderName.Controls.Add(this.txtReaderName);
            this.grpReaderName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpReaderName.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpReaderName.Location = new System.Drawing.Point(13, 45);
            this.grpReaderName.Name = "grpReaderName";
            this.grpReaderName.Size = new System.Drawing.Size(349, 48);
            this.grpReaderName.TabIndex = 68;
            this.grpReaderName.TabStop = false;
            this.grpReaderName.Text = "Tên người đọc";
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
            this.btnCancel.Location = new System.Drawing.Point(544, 307);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(133, 36);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
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
            // nudYear
            // 
            this.nudYear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudYear.Font = new System.Drawing.Font("MS Reference Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudYear.Location = new System.Drawing.Point(225, 17);
            this.nudYear.Maximum = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.nudYear.Minimum = new decimal(new int[] {
            1920,
            0,
            0,
            0});
            this.nudYear.Name = "nudYear";
            this.nudYear.Size = new System.Drawing.Size(121, 28);
            this.nudYear.TabIndex = 4;
            this.nudYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudYear.Value = new decimal(new int[] {
            1920,
            0,
            0,
            0});
            this.nudYear.ValueChanged += new System.EventHandler(this.nudYear_ValueChanged);
            // 
            // cbSex
            // 
            this.cbSex.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSex.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSex.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbSex.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSex.FormattingEnabled = true;
            this.cbSex.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbSex.Location = new System.Drawing.Point(9, 19);
            this.cbSex.Margin = new System.Windows.Forms.Padding(0);
            this.cbSex.Name = "cbSex";
            this.cbSex.Size = new System.Drawing.Size(337, 33);
            this.cbSex.Sorted = true;
            this.cbSex.TabIndex = 5;
            this.cbSex.Validating += new System.ComponentModel.CancelEventHandler(this.cbSex_Validating);
            this.cbSex.Validated += new System.EventHandler(this.cbSex_Validated);
            // 
            // lblReaderNameError
            // 
            this.lblReaderNameError.AutoSize = true;
            this.lblReaderNameError.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReaderNameError.ForeColor = System.Drawing.Color.Red;
            this.lblReaderNameError.Location = new System.Drawing.Point(10, 94);
            this.lblReaderNameError.Name = "lblReaderNameError";
            this.lblReaderNameError.Size = new System.Drawing.Size(100, 13);
            this.lblReaderNameError.TabIndex = 72;
            this.lblReaderNameError.Text = "ReaderName Error";
            // 
            // grpSex
            // 
            this.grpSex.BackColor = System.Drawing.Color.White;
            this.grpSex.Controls.Add(this.cbSex);
            this.grpSex.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpSex.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSex.Location = new System.Drawing.Point(13, 169);
            this.grpSex.Name = "grpSex";
            this.grpSex.Size = new System.Drawing.Size(349, 54);
            this.grpSex.TabIndex = 71;
            this.grpSex.TabStop = false;
            this.grpSex.Text = "Giới tính";
            // 
            // grpReaderInfo
            // 
            this.grpReaderInfo.Controls.Add(this.lblSexError);
            this.grpReaderInfo.Controls.Add(this.lblReaderNameError);
            this.grpReaderInfo.Controls.Add(this.grpSex);
            this.grpReaderInfo.Controls.Add(this.grpDOB);
            this.grpReaderInfo.Controls.Add(this.grpReaderName);
            this.grpReaderInfo.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpReaderInfo.Location = new System.Drawing.Point(12, 12);
            this.grpReaderInfo.Name = "grpReaderInfo";
            this.grpReaderInfo.Size = new System.Drawing.Size(391, 331);
            this.grpReaderInfo.TabIndex = 64;
            this.grpReaderInfo.TabStop = false;
            this.grpReaderInfo.Text = "Thông tin người đọc";
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
            // frmAddReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(690, 352);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grpContactInfo);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.grpReaderInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddReader";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmAddReader_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errAddReader)).EndInit();
            this.grpPhoneNumber.ResumeLayout(false);
            this.grpPhoneNumber.PerformLayout();
            this.grpContactInfo.ResumeLayout(false);
            this.grpContactInfo.PerformLayout();
            this.grpAddress.ResumeLayout(false);
            this.grpAddress.PerformLayout();
            this.grpEmail.ResumeLayout(false);
            this.grpEmail.PerformLayout();
            this.grpReaderName.ResumeLayout(false);
            this.grpReaderName.PerformLayout();
            this.grpDOB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).EndInit();
            this.grpSex.ResumeLayout(false);
            this.grpReaderInfo.ResumeLayout(false);
            this.grpReaderInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ErrorProvider errAddReader;
        private System.Windows.Forms.GroupBox grpContactInfo;
        private System.Windows.Forms.Label lblPhoneNumberWarning;
        private System.Windows.Forms.GroupBox grpPhoneNumber;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lblEmailError;
        private System.Windows.Forms.GroupBox grpEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox grpReaderInfo;
        private System.Windows.Forms.Label lblReaderNameError;
        private System.Windows.Forms.GroupBox grpSex;
        private System.Windows.Forms.ComboBox cbSex;
        private System.Windows.Forms.GroupBox grpDOB;
        private System.Windows.Forms.GroupBox grpReaderName;
        private System.Windows.Forms.TextBox txtReaderName;
        private System.Windows.Forms.Label lblSexError;
        private System.Windows.Forms.NumericUpDown nudMonth;
        private System.Windows.Forms.NumericUpDown nudDay;
        private System.Windows.Forms.NumericUpDown nudYear;
        private System.Windows.Forms.Label lblAddressError;
        private System.Windows.Forms.GroupBox grpAddress;
        private System.Windows.Forms.TextBox txtAddress;
    }
}