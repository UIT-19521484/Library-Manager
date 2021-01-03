namespace New_Library.Forms
{
    partial class frmSetting
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
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
            this.grpLibraryInfo.SuspendLayout();
            this.grpBorrowReturnBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFineOfBook)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.Crimson;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = global::New_Library.Properties.Resources.delete;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(989, 12);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnCancel.Size = new System.Drawing.Size(116, 41);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "   Hủy";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = global::New_Library.Properties.Resources.update_24px;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(867, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnSave.Size = new System.Drawing.Size(116, 41);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "   Lưu";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // grpLibraryInfo
            // 
            this.grpLibraryInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.grpLibraryInfo.Location = new System.Drawing.Point(12, 59);
            this.grpLibraryInfo.Name = "grpLibraryInfo";
            this.grpLibraryInfo.Size = new System.Drawing.Size(1093, 216);
            this.grpLibraryInfo.TabIndex = 56;
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
            this.txtEmail.Size = new System.Drawing.Size(913, 31);
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
            this.txtPhoneNumber.Size = new System.Drawing.Size(913, 31);
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
            this.txtAddress.Size = new System.Drawing.Size(913, 31);
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
            this.txtLibraryName.Size = new System.Drawing.Size(913, 31);
            this.txtLibraryName.TabIndex = 1;
            // 
            // grpBorrowReturnBook
            // 
            this.grpBorrowReturnBook.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBorrowReturnBook.Controls.Add(this.nudFineOfBook);
            this.grpBorrowReturnBook.Controls.Add(this.lblUnit);
            this.grpBorrowReturnBook.Controls.Add(this.lblFineOfBook);
            this.grpBorrowReturnBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBorrowReturnBook.Location = new System.Drawing.Point(12, 281);
            this.grpBorrowReturnBook.Name = "grpBorrowReturnBook";
            this.grpBorrowReturnBook.Size = new System.Drawing.Size(1093, 85);
            this.grpBorrowReturnBook.TabIndex = 57;
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
            this.nudFineOfBook.Location = new System.Drawing.Point(472, 37);
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
            this.lblUnit.Location = new System.Drawing.Point(598, 38);
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
            // frmSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1117, 574);
            this.Controls.Add(this.grpBorrowReturnBook);
            this.Controls.Add(this.grpLibraryInfo);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSetting";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "THIẾT LẬP";
            this.Load += new System.EventHandler(this.frmSetting_Load);
            this.grpLibraryInfo.ResumeLayout(false);
            this.grpLibraryInfo.PerformLayout();
            this.grpBorrowReturnBook.ResumeLayout(false);
            this.grpBorrowReturnBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFineOfBook)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox grpLibraryInfo;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblPhoneTag;
        private System.Windows.Forms.Label lblEmailTag;
        private System.Windows.Forms.Label lblAddressTag;
        private System.Windows.Forms.Label lblLibraryNameTag;
        private System.Windows.Forms.TextBox txtLibraryName;
        private System.Windows.Forms.Label lblNumberError;
        private System.Windows.Forms.Label lblEmailError;
        private System.Windows.Forms.GroupBox grpBorrowReturnBook;
        private System.Windows.Forms.Label lblFineOfBook;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.NumericUpDown nudFineOfBook;
    }
}