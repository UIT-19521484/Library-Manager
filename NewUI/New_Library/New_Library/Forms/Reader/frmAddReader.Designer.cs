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
            this.gbPhoneNumber = new System.Windows.Forms.GroupBox();
            this.gbContactInfo = new System.Windows.Forms.GroupBox();
            this.lblAddressError = new System.Windows.Forms.Label();
            this.gbAddress = new System.Windows.Forms.GroupBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblEmailError = new System.Windows.Forms.Label();
            this.gbEmail = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtReaderName = new System.Windows.Forms.TextBox();
            this.gbReaderName = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbDOB = new System.Windows.Forms.GroupBox();
            this.nudMonth = new System.Windows.Forms.NumericUpDown();
            this.nudDay = new System.Windows.Forms.NumericUpDown();
            this.nudYear = new System.Windows.Forms.NumericUpDown();
            this.cbSex = new System.Windows.Forms.ComboBox();
            this.lblReaderNameError = new System.Windows.Forms.Label();
            this.gbSex = new System.Windows.Forms.GroupBox();
            this.gbReaderInfo = new System.Windows.Forms.GroupBox();
            this.lblSexError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errAddReader)).BeginInit();
            this.gbPhoneNumber.SuspendLayout();
            this.gbContactInfo.SuspendLayout();
            this.gbAddress.SuspendLayout();
            this.gbEmail.SuspendLayout();
            this.gbReaderName.SuspendLayout();
            this.gbDOB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).BeginInit();
            this.gbSex.SuspendLayout();
            this.gbReaderInfo.SuspendLayout();
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
            this.btnAdd.TabIndex = 7;
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
            // gbPhoneNumber
            // 
            this.gbPhoneNumber.BackColor = System.Drawing.Color.White;
            this.gbPhoneNumber.Controls.Add(this.txtPhoneNumber);
            this.gbPhoneNumber.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbPhoneNumber.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPhoneNumber.Location = new System.Drawing.Point(6, 45);
            this.gbPhoneNumber.Name = "gbPhoneNumber";
            this.gbPhoneNumber.Size = new System.Drawing.Size(234, 48);
            this.gbPhoneNumber.TabIndex = 69;
            this.gbPhoneNumber.TabStop = false;
            this.gbPhoneNumber.Text = "Số điện thoại";
            // 
            // gbContactInfo
            // 
            this.gbContactInfo.Controls.Add(this.lblAddressError);
            this.gbContactInfo.Controls.Add(this.gbAddress);
            this.gbContactInfo.Controls.Add(this.lblPhoneNumberWarning);
            this.gbContactInfo.Controls.Add(this.gbPhoneNumber);
            this.gbContactInfo.Controls.Add(this.lblEmailError);
            this.gbContactInfo.Controls.Add(this.gbEmail);
            this.gbContactInfo.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbContactInfo.Location = new System.Drawing.Point(409, 12);
            this.gbContactInfo.Name = "gbContactInfo";
            this.gbContactInfo.Size = new System.Drawing.Size(268, 263);
            this.gbContactInfo.TabIndex = 65;
            this.gbContactInfo.TabStop = false;
            this.gbContactInfo.Text = "Thông tin liên lạc";
            // 
            // lblAddressError
            // 
            this.lblAddressError.AutoSize = true;
            this.lblAddressError.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressError.ForeColor = System.Drawing.Color.Red;
            this.lblAddressError.Location = new System.Drawing.Point(3, 224);
            this.lblAddressError.Name = "lblAddressError";
            this.lblAddressError.Size = new System.Drawing.Size(76, 13);
            this.lblAddressError.TabIndex = 75;
            this.lblAddressError.Text = "Address Error";
            // 
            // gbAddress
            // 
            this.gbAddress.BackColor = System.Drawing.Color.White;
            this.gbAddress.Controls.Add(this.txtAddress);
            this.gbAddress.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbAddress.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAddress.Location = new System.Drawing.Point(6, 175);
            this.gbAddress.Name = "gbAddress";
            this.gbAddress.Size = new System.Drawing.Size(234, 48);
            this.gbAddress.TabIndex = 74;
            this.gbAddress.TabStop = false;
            this.gbAddress.Text = "Địa chỉ";
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
            // gbEmail
            // 
            this.gbEmail.BackColor = System.Drawing.Color.White;
            this.gbEmail.Controls.Add(this.txtEmail);
            this.gbEmail.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbEmail.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEmail.Location = new System.Drawing.Point(6, 110);
            this.gbEmail.Name = "gbEmail";
            this.gbEmail.Size = new System.Drawing.Size(234, 48);
            this.gbEmail.TabIndex = 69;
            this.gbEmail.TabStop = false;
            this.gbEmail.Text = "Email";
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
            // gbReaderName
            // 
            this.gbReaderName.BackColor = System.Drawing.Color.White;
            this.gbReaderName.Controls.Add(this.txtReaderName);
            this.gbReaderName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbReaderName.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbReaderName.Location = new System.Drawing.Point(13, 45);
            this.gbReaderName.Name = "gbReaderName";
            this.gbReaderName.Size = new System.Drawing.Size(349, 48);
            this.gbReaderName.TabIndex = 68;
            this.gbReaderName.TabStop = false;
            this.gbReaderName.Text = "Tên người đọc";
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
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // gbDOB
            // 
            this.gbDOB.BackColor = System.Drawing.Color.White;
            this.gbDOB.Controls.Add(this.nudMonth);
            this.gbDOB.Controls.Add(this.nudDay);
            this.gbDOB.Controls.Add(this.nudYear);
            this.gbDOB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbDOB.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDOB.Location = new System.Drawing.Point(13, 110);
            this.gbDOB.Name = "gbDOB";
            this.gbDOB.Size = new System.Drawing.Size(349, 48);
            this.gbDOB.TabIndex = 70;
            this.gbDOB.TabStop = false;
            this.gbDOB.Text = "Ngày sinh";
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
            this.nudMonth.TabIndex = 4;
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
            this.nudDay.TabIndex = 3;
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
            0,
            0,
            0,
            0});
            this.nudYear.Name = "nudYear";
            this.nudYear.Size = new System.Drawing.Size(121, 28);
            this.nudYear.TabIndex = 5;
            this.nudYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.cbSex.TabIndex = 2;
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
            // gbSex
            // 
            this.gbSex.BackColor = System.Drawing.Color.White;
            this.gbSex.Controls.Add(this.cbSex);
            this.gbSex.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbSex.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSex.Location = new System.Drawing.Point(13, 169);
            this.gbSex.Name = "gbSex";
            this.gbSex.Size = new System.Drawing.Size(349, 54);
            this.gbSex.TabIndex = 71;
            this.gbSex.TabStop = false;
            this.gbSex.Text = "Giới tính";
            // 
            // gbReaderInfo
            // 
            this.gbReaderInfo.Controls.Add(this.lblSexError);
            this.gbReaderInfo.Controls.Add(this.lblReaderNameError);
            this.gbReaderInfo.Controls.Add(this.gbSex);
            this.gbReaderInfo.Controls.Add(this.gbDOB);
            this.gbReaderInfo.Controls.Add(this.gbReaderName);
            this.gbReaderInfo.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbReaderInfo.Location = new System.Drawing.Point(12, 12);
            this.gbReaderInfo.Name = "gbReaderInfo";
            this.gbReaderInfo.Size = new System.Drawing.Size(391, 331);
            this.gbReaderInfo.TabIndex = 64;
            this.gbReaderInfo.TabStop = false;
            this.gbReaderInfo.Text = "Thông tin người đọc";
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
            this.Controls.Add(this.gbContactInfo);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.gbReaderInfo);
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
            this.gbPhoneNumber.ResumeLayout(false);
            this.gbPhoneNumber.PerformLayout();
            this.gbContactInfo.ResumeLayout(false);
            this.gbContactInfo.PerformLayout();
            this.gbAddress.ResumeLayout(false);
            this.gbAddress.PerformLayout();
            this.gbEmail.ResumeLayout(false);
            this.gbEmail.PerformLayout();
            this.gbReaderName.ResumeLayout(false);
            this.gbReaderName.PerformLayout();
            this.gbDOB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).EndInit();
            this.gbSex.ResumeLayout(false);
            this.gbReaderInfo.ResumeLayout(false);
            this.gbReaderInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ErrorProvider errAddReader;
        private System.Windows.Forms.GroupBox gbContactInfo;
        private System.Windows.Forms.Label lblAddressError;
        private System.Windows.Forms.GroupBox gbAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblPhoneNumberWarning;
        private System.Windows.Forms.GroupBox gbPhoneNumber;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lblEmailError;
        private System.Windows.Forms.GroupBox gbEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox gbReaderInfo;
        private System.Windows.Forms.Label lblReaderNameError;
        private System.Windows.Forms.GroupBox gbSex;
        private System.Windows.Forms.ComboBox cbSex;
        private System.Windows.Forms.GroupBox gbDOB;
        private System.Windows.Forms.GroupBox gbReaderName;
        private System.Windows.Forms.TextBox txtReaderName;
        private System.Windows.Forms.Label lblSexError;
        private System.Windows.Forms.NumericUpDown nudMonth;
        private System.Windows.Forms.NumericUpDown nudDay;
        private System.Windows.Forms.NumericUpDown nudYear;
    }
}