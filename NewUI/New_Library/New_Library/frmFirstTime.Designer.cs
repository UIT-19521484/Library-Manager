
namespace New_Library
{
    partial class frmFirstTime
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFirstTime));
            this.lblThanks = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.grpLibraryInfo = new System.Windows.Forms.GroupBox();
            this.lblNumberError = new System.Windows.Forms.Label();
            this.lblEmailError = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblPhoneTag = new System.Windows.Forms.Label();
            this.lblEmailTag = new System.Windows.Forms.Label();
            this.lblAddressTag = new System.Windows.Forms.Label();
            this.lblLibraryNameTag = new System.Windows.Forms.Label();
            this.txtLibraryName = new System.Windows.Forms.TextBox();
            this.grpBorrowReturnBook = new System.Windows.Forms.GroupBox();
            this.nudFineOfBook = new System.Windows.Forms.NumericUpDown();
            this.lblUnit = new System.Windows.Forms.Label();
            this.lblFineOfBook = new System.Windows.Forms.Label();
            this.gbConnection = new System.Windows.Forms.GroupBox();
            this.lblConnectionStatus = new System.Windows.Forms.Label();
            this.lblServerName = new System.Windows.Forms.Label();
            this.btnCheckConnection = new System.Windows.Forms.Button();
            this.lblServerError = new System.Windows.Forms.Label();
            this.lblPasswordError = new System.Windows.Forms.Label();
            this.lblAccountNameError = new System.Windows.Forms.Label();
            this.txtAccountName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblAccountName = new System.Windows.Forms.Label();
            this.txtServerName = new System.Windows.Forms.TextBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.grpLibraryInfo.SuspendLayout();
            this.grpBorrowReturnBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFineOfBook)).BeginInit();
            this.gbConnection.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblThanks
            // 
            this.lblThanks.AutoSize = true;
            this.lblThanks.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThanks.Location = new System.Drawing.Point(12, 9);
            this.lblThanks.Name = "lblThanks";
            this.lblThanks.Size = new System.Drawing.Size(324, 29);
            this.lblThanks.TabIndex = 0;
            this.lblThanks.Text = "Cảm ơn đã cài đặt phần mềm";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(12, 49);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(473, 29);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "Giờ chỉ cần nhập thêm vài thông tin nữa thôi";
            // 
            // grpLibraryInfo
            // 
            this.grpLibraryInfo.Controls.Add(this.lblNumberError);
            this.grpLibraryInfo.Controls.Add(this.lblEmailError);
            this.grpLibraryInfo.Controls.Add(this.txtEmail);
            this.grpLibraryInfo.Controls.Add(this.txtPhoneNumber);
            this.grpLibraryInfo.Controls.Add(this.txtAddress);
            this.grpLibraryInfo.Controls.Add(this.lblPhoneTag);
            this.grpLibraryInfo.Controls.Add(this.lblEmailTag);
            this.grpLibraryInfo.Controls.Add(this.lblAddressTag);
            this.grpLibraryInfo.Controls.Add(this.lblLibraryNameTag);
            this.grpLibraryInfo.Controls.Add(this.txtLibraryName);
            this.grpLibraryInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpLibraryInfo.Location = new System.Drawing.Point(16, 98);
            this.grpLibraryInfo.Name = "grpLibraryInfo";
            this.grpLibraryInfo.Size = new System.Drawing.Size(614, 216);
            this.grpLibraryInfo.TabIndex = 57;
            this.grpLibraryInfo.TabStop = false;
            this.grpLibraryInfo.Text = "Thông tin thư viện";
            // 
            // lblNumberError
            // 
            this.lblNumberError.AutoSize = true;
            this.lblNumberError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberError.ForeColor = System.Drawing.Color.Red;
            this.lblNumberError.Location = new System.Drawing.Point(171, 196);
            this.lblNumberError.Name = "lblNumberError";
            this.lblNumberError.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNumberError.Size = new System.Drawing.Size(82, 15);
            this.lblNumberError.TabIndex = 58;
            this.lblNumberError.Text = "Number Error";
            // 
            // lblEmailError
            // 
            this.lblEmailError.AutoSize = true;
            this.lblEmailError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailError.ForeColor = System.Drawing.Color.Red;
            this.lblEmailError.Location = new System.Drawing.Point(171, 144);
            this.lblEmailError.Name = "lblEmailError";
            this.lblEmailError.Size = new System.Drawing.Size(69, 15);
            this.lblEmailError.TabIndex = 57;
            this.lblEmailError.Text = "Email Error";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.txtEmail.Location = new System.Drawing.Point(174, 110);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(434, 31);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            this.txtEmail.Validated += new System.EventHandler(this.txtEmail_Validated);
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhoneNumber.BackColor = System.Drawing.Color.White;
            this.txtPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.txtPhoneNumber.Location = new System.Drawing.Point(174, 162);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(434, 31);
            this.txtPhoneNumber.TabIndex = 4;
            this.txtPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhoneNumber_KeyPress);
            this.txtPhoneNumber.Validating += new System.ComponentModel.CancelEventHandler(this.txtPhoneNumber_Validating);
            this.txtPhoneNumber.Validated += new System.EventHandler(this.txtPhoneNumber_Validated);
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddress.BackColor = System.Drawing.Color.White;
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.txtAddress.Location = new System.Drawing.Point(174, 73);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(434, 31);
            this.txtAddress.TabIndex = 2;
            // 
            // lblPhoneTag
            // 
            this.lblPhoneTag.AutoEllipsis = true;
            this.lblPhoneTag.AutoSize = true;
            this.lblPhoneTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneTag.Location = new System.Drawing.Point(24, 164);
            this.lblPhoneTag.Name = "lblPhoneTag";
            this.lblPhoneTag.Size = new System.Drawing.Size(144, 25);
            this.lblPhoneTag.TabIndex = 22;
            this.lblPhoneTag.Text = "Số điện thoại:";
            this.lblPhoneTag.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEmailTag
            // 
            this.lblEmailTag.AutoEllipsis = true;
            this.lblEmailTag.AutoSize = true;
            this.lblEmailTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailTag.Location = new System.Drawing.Point(24, 112);
            this.lblEmailTag.Name = "lblEmailTag";
            this.lblEmailTag.Size = new System.Drawing.Size(71, 25);
            this.lblEmailTag.TabIndex = 21;
            this.lblEmailTag.Text = "Email:";
            this.lblEmailTag.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAddressTag
            // 
            this.lblAddressTag.AutoEllipsis = true;
            this.lblAddressTag.AutoSize = true;
            this.lblAddressTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressTag.Location = new System.Drawing.Point(24, 75);
            this.lblAddressTag.Name = "lblAddressTag";
            this.lblAddressTag.Size = new System.Drawing.Size(90, 25);
            this.lblAddressTag.TabIndex = 20;
            this.lblAddressTag.Text = "Địa chỉ: ";
            this.lblAddressTag.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLibraryNameTag
            // 
            this.lblLibraryNameTag.AutoEllipsis = true;
            this.lblLibraryNameTag.AutoSize = true;
            this.lblLibraryNameTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibraryNameTag.Location = new System.Drawing.Point(24, 38);
            this.lblLibraryNameTag.Name = "lblLibraryNameTag";
            this.lblLibraryNameTag.Size = new System.Drawing.Size(137, 25);
            this.lblLibraryNameTag.TabIndex = 19;
            this.lblLibraryNameTag.Text = "Tên thư viện:";
            this.lblLibraryNameTag.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtLibraryName
            // 
            this.txtLibraryName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLibraryName.BackColor = System.Drawing.Color.White;
            this.txtLibraryName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLibraryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.txtLibraryName.Location = new System.Drawing.Point(174, 36);
            this.txtLibraryName.Name = "txtLibraryName";
            this.txtLibraryName.Size = new System.Drawing.Size(434, 31);
            this.txtLibraryName.TabIndex = 1;
            // 
            // grpBorrowReturnBook
            // 
            this.grpBorrowReturnBook.Controls.Add(this.nudFineOfBook);
            this.grpBorrowReturnBook.Controls.Add(this.lblUnit);
            this.grpBorrowReturnBook.Controls.Add(this.lblFineOfBook);
            this.grpBorrowReturnBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBorrowReturnBook.Location = new System.Drawing.Point(16, 339);
            this.grpBorrowReturnBook.Name = "grpBorrowReturnBook";
            this.grpBorrowReturnBook.Size = new System.Drawing.Size(614, 87);
            this.grpBorrowReturnBook.TabIndex = 58;
            this.grpBorrowReturnBook.TabStop = false;
            this.grpBorrowReturnBook.Text = "Mượn/Trả Sách";
            // 
            // nudFineOfBook
            // 
            this.nudFineOfBook.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudFineOfBook.Location = new System.Drawing.Point(425, 38);
            this.nudFineOfBook.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.nudFineOfBook.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudFineOfBook.Name = "nudFineOfBook";
            this.nudFineOfBook.Size = new System.Drawing.Size(120, 29);
            this.nudFineOfBook.TabIndex = 60;
            this.nudFineOfBook.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudFineOfBook.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // lblUnit
            // 
            this.lblUnit.AutoEllipsis = true;
            this.lblUnit.AutoSize = true;
            this.lblUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnit.Location = new System.Drawing.Point(551, 39);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(56, 25);
            this.lblUnit.TabIndex = 59;
            this.lblUnit.Text = "VND";
            this.lblUnit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFineOfBook
            // 
            this.lblFineOfBook.AutoEllipsis = true;
            this.lblFineOfBook.AutoSize = true;
            this.lblFineOfBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFineOfBook.Location = new System.Drawing.Point(24, 38);
            this.lblFineOfBook.Name = "lblFineOfBook";
            this.lblFineOfBook.Size = new System.Drawing.Size(412, 25);
            this.lblFineOfBook.TabIndex = 19;
            this.lblFineOfBook.Text = "Chi phí nộp phạt quá hạn / 1 quyển sách: ";
            this.lblFineOfBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gbConnection
            // 
            this.gbConnection.Controls.Add(this.lblConnectionStatus);
            this.gbConnection.Controls.Add(this.lblServerName);
            this.gbConnection.Controls.Add(this.btnCheckConnection);
            this.gbConnection.Controls.Add(this.lblServerError);
            this.gbConnection.Controls.Add(this.lblPasswordError);
            this.gbConnection.Controls.Add(this.lblAccountNameError);
            this.gbConnection.Controls.Add(this.txtAccountName);
            this.gbConnection.Controls.Add(this.txtPassword);
            this.gbConnection.Controls.Add(this.lblPassword);
            this.gbConnection.Controls.Add(this.lblAccountName);
            this.gbConnection.Controls.Add(this.txtServerName);
            this.gbConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbConnection.Location = new System.Drawing.Point(16, 451);
            this.gbConnection.Name = "gbConnection";
            this.gbConnection.Size = new System.Drawing.Size(614, 250);
            this.gbConnection.TabIndex = 59;
            this.gbConnection.TabStop = false;
            this.gbConnection.Text = "Kết nối server";
            // 
            // lblConnectionStatus
            // 
            this.lblConnectionStatus.AutoSize = true;
            this.lblConnectionStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnectionStatus.ForeColor = System.Drawing.Color.Red;
            this.lblConnectionStatus.Location = new System.Drawing.Point(190, 218);
            this.lblConnectionStatus.Name = "lblConnectionStatus";
            this.lblConnectionStatus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblConnectionStatus.Size = new System.Drawing.Size(106, 15);
            this.lblConnectionStatus.TabIndex = 62;
            this.lblConnectionStatus.Text = "Connection Status";
            // 
            // lblServerName
            // 
            this.lblServerName.AutoEllipsis = true;
            this.lblServerName.AutoSize = true;
            this.lblServerName.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblServerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServerName.Location = new System.Drawing.Point(24, 38);
            this.lblServerName.Name = "lblServerName";
            this.lblServerName.Size = new System.Drawing.Size(121, 25);
            this.lblServerName.TabIndex = 19;
            this.lblServerName.Text = "Tên server:";
            this.lblServerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCheckConnection
            // 
            this.btnCheckConnection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheckConnection.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCheckConnection.FlatAppearance.BorderSize = 0;
            this.btnCheckConnection.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCheckConnection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckConnection.Location = new System.Drawing.Point(447, 205);
            this.btnCheckConnection.Name = "btnCheckConnection";
            this.btnCheckConnection.Size = new System.Drawing.Size(161, 39);
            this.btnCheckConnection.TabIndex = 61;
            this.btnCheckConnection.Text = "Kiểm tra kết nối";
            this.btnCheckConnection.UseVisualStyleBackColor = false;
            this.btnCheckConnection.Click += new System.EventHandler(this.btnCheckConnection_Click);
            // 
            // lblServerError
            // 
            this.lblServerError.AutoSize = true;
            this.lblServerError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServerError.ForeColor = System.Drawing.Color.Red;
            this.lblServerError.Location = new System.Drawing.Point(190, 72);
            this.lblServerError.Name = "lblServerError";
            this.lblServerError.Size = new System.Drawing.Size(106, 15);
            this.lblServerError.TabIndex = 59;
            this.lblServerError.Text = "ServerName Error";
            // 
            // lblPasswordError
            // 
            this.lblPasswordError.AutoSize = true;
            this.lblPasswordError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordError.ForeColor = System.Drawing.Color.Red;
            this.lblPasswordError.Location = new System.Drawing.Point(190, 174);
            this.lblPasswordError.Name = "lblPasswordError";
            this.lblPasswordError.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPasswordError.Size = new System.Drawing.Size(91, 15);
            this.lblPasswordError.TabIndex = 58;
            this.lblPasswordError.Text = "Password Error";
            // 
            // lblAccountNameError
            // 
            this.lblAccountNameError.AutoSize = true;
            this.lblAccountNameError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountNameError.ForeColor = System.Drawing.Color.Red;
            this.lblAccountNameError.Location = new System.Drawing.Point(190, 122);
            this.lblAccountNameError.Name = "lblAccountNameError";
            this.lblAccountNameError.Size = new System.Drawing.Size(80, 15);
            this.lblAccountNameError.TabIndex = 57;
            this.lblAccountNameError.Text = "Account Error";
            // 
            // txtAccountName
            // 
            this.txtAccountName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAccountName.BackColor = System.Drawing.Color.White;
            this.txtAccountName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAccountName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.txtAccountName.Location = new System.Drawing.Point(193, 88);
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.Size = new System.Drawing.Size(414, 31);
            this.txtAccountName.TabIndex = 3;
            this.txtAccountName.TextChanged += new System.EventHandler(this.txtServer_TextChanged);
            this.txtAccountName.Validating += new System.ComponentModel.CancelEventHandler(this.txtAccountName_Validating);
            this.txtAccountName.Validated += new System.EventHandler(this.txtAccountName_Validated);
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.txtPassword.Location = new System.Drawing.Point(193, 140);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(414, 31);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtServer_TextChanged);
            this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassword_Validating);
            this.txtPassword.Validated += new System.EventHandler(this.txtPassword_Validated);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoEllipsis = true;
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(24, 142);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(107, 25);
            this.lblPassword.TabIndex = 22;
            this.lblPassword.Text = "Mật khẩu:";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAccountName
            // 
            this.lblAccountName.AutoEllipsis = true;
            this.lblAccountName.AutoSize = true;
            this.lblAccountName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountName.Location = new System.Drawing.Point(24, 90);
            this.lblAccountName.Name = "lblAccountName";
            this.lblAccountName.Size = new System.Drawing.Size(163, 25);
            this.lblAccountName.TabIndex = 21;
            this.lblAccountName.Text = "Tên đăng nhập:";
            this.lblAccountName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtServerName
            // 
            this.txtServerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtServerName.BackColor = System.Drawing.Color.White;
            this.txtServerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtServerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.txtServerName.Location = new System.Drawing.Point(193, 38);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(414, 31);
            this.txtServerName.TabIndex = 1;
            this.txtServerName.TextChanged += new System.EventHandler(this.txtServer_TextChanged);
            this.txtServerName.Validating += new System.ComponentModel.CancelEventHandler(this.txtServerName_Validating);
            this.txtServerName.Validated += new System.EventHandler(this.txtServerName_Validated);
            // 
            // btnAccept
            // 
            this.btnAccept.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAccept.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAccept.FlatAppearance.BorderSize = 0;
            this.btnAccept.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.btnAccept.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccept.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAccept.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccept.Location = new System.Drawing.Point(451, 719);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(179, 50);
            this.btnAccept.TabIndex = 60;
            this.btnAccept.Text = "Xác nhận";
            this.btnAccept.UseVisualStyleBackColor = false;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // frmFirstTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(649, 775);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.gbConnection);
            this.Controls.Add(this.grpBorrowReturnBook);
            this.Controls.Add(this.grpLibraryInfo);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.lblThanks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmFirstTime";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmFirstTime_FormClosing);
            this.grpLibraryInfo.ResumeLayout(false);
            this.grpLibraryInfo.PerformLayout();
            this.grpBorrowReturnBook.ResumeLayout(false);
            this.grpBorrowReturnBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFineOfBook)).EndInit();
            this.gbConnection.ResumeLayout(false);
            this.gbConnection.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblThanks;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.GroupBox grpLibraryInfo;
        private System.Windows.Forms.Label lblNumberError;
        private System.Windows.Forms.Label lblEmailError;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblPhoneTag;
        private System.Windows.Forms.Label lblEmailTag;
        private System.Windows.Forms.Label lblAddressTag;
        private System.Windows.Forms.Label lblLibraryNameTag;
        private System.Windows.Forms.TextBox txtLibraryName;
        private System.Windows.Forms.GroupBox grpBorrowReturnBook;
        private System.Windows.Forms.NumericUpDown nudFineOfBook;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.Label lblFineOfBook;
        private System.Windows.Forms.GroupBox gbConnection;
        private System.Windows.Forms.Button btnCheckConnection;
        private System.Windows.Forms.Label lblServerError;
        private System.Windows.Forms.Label lblPasswordError;
        private System.Windows.Forms.Label lblAccountNameError;
        private System.Windows.Forms.TextBox txtAccountName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblAccountName;
        private System.Windows.Forms.Label lblServerName;
        private System.Windows.Forms.TextBox txtServerName;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Label lblConnectionStatus;
    }
}