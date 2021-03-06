﻿namespace New_Library.Forms.Management.Account
{
    partial class frmEditStaff
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
            this.errEditStaff = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtStaffName = new System.Windows.Forms.TextBox();
            this.grpStaffName = new System.Windows.Forms.GroupBox();
            this.grpDOB = new System.Windows.Forms.GroupBox();
            this.nudMonth = new System.Windows.Forms.NumericUpDown();
            this.nudDay = new System.Windows.Forms.NumericUpDown();
            this.nudYear = new System.Windows.Forms.NumericUpDown();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblSexError = new System.Windows.Forms.Label();
            this.lblStaffNameError = new System.Windows.Forms.Label();
            this.grpSex = new System.Windows.Forms.GroupBox();
            this.cboSex = new System.Windows.Forms.ComboBox();
            this.grpStaffInfo = new System.Windows.Forms.GroupBox();
            this.grpContactInfo = new System.Windows.Forms.GroupBox();
            this.lblAddressError = new System.Windows.Forms.Label();
            this.grpAddress = new System.Windows.Forms.GroupBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblPhoneNumberWarning = new System.Windows.Forms.Label();
            this.grpPhoneNumber = new System.Windows.Forms.GroupBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errEditStaff)).BeginInit();
            this.grpStaffName.SuspendLayout();
            this.grpDOB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).BeginInit();
            this.grpSex.SuspendLayout();
            this.grpStaffInfo.SuspendLayout();
            this.grpContactInfo.SuspendLayout();
            this.grpAddress.SuspendLayout();
            this.grpPhoneNumber.SuspendLayout();
            this.SuspendLayout();
            // 
            // errEditStaff
            // 
            this.errEditStaff.BlinkRate = 0;
            this.errEditStaff.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errEditStaff.ContainerControl = this;
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
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
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
            // grpSex
            // 
            this.grpSex.BackColor = System.Drawing.Color.White;
            this.grpSex.Controls.Add(this.cboSex);
            this.grpSex.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpSex.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSex.Location = new System.Drawing.Point(13, 169);
            this.grpSex.Name = "grpSex";
            this.grpSex.Size = new System.Drawing.Size(349, 54);
            this.grpSex.TabIndex = 71;
            this.grpSex.TabStop = false;
            this.grpSex.Text = "Giới tính";
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
            // grpStaffInfo
            // 
            this.grpStaffInfo.Controls.Add(this.lblSexError);
            this.grpStaffInfo.Controls.Add(this.lblStaffNameError);
            this.grpStaffInfo.Controls.Add(this.grpSex);
            this.grpStaffInfo.Controls.Add(this.grpDOB);
            this.grpStaffInfo.Controls.Add(this.grpStaffName);
            this.grpStaffInfo.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpStaffInfo.Location = new System.Drawing.Point(12, 12);
            this.grpStaffInfo.Name = "grpStaffInfo";
            this.grpStaffInfo.Size = new System.Drawing.Size(391, 331);
            this.grpStaffInfo.TabIndex = 76;
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
            this.grpContactInfo.TabIndex = 77;
            this.grpContactInfo.TabStop = false;
            this.grpContactInfo.Text = "Thông tin liên lạc";
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
            this.txtPhoneNumber.Validating += new System.ComponentModel.CancelEventHandler(this.txtPhoneNumber_Validating);
            this.txtPhoneNumber.Validated += new System.EventHandler(this.txtPhoneNumber_Validated);
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
            this.btnEdit.Location = new System.Drawing.Point(409, 307);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(133, 36);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // frmEditStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(694, 361);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.grpStaffInfo);
            this.Controls.Add(this.grpContactInfo);
            this.Controls.Add(this.btnEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEditStaff";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)(this.errEditStaff)).EndInit();
            this.grpStaffName.ResumeLayout(false);
            this.grpStaffName.PerformLayout();
            this.grpDOB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).EndInit();
            this.grpSex.ResumeLayout(false);
            this.grpStaffInfo.ResumeLayout(false);
            this.grpStaffInfo.PerformLayout();
            this.grpContactInfo.ResumeLayout(false);
            this.grpContactInfo.PerformLayout();
            this.grpAddress.ResumeLayout(false);
            this.grpAddress.PerformLayout();
            this.grpPhoneNumber.ResumeLayout(false);
            this.grpPhoneNumber.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errEditStaff;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox grpStaffInfo;
        private System.Windows.Forms.Label lblSexError;
        private System.Windows.Forms.Label lblStaffNameError;
        private System.Windows.Forms.GroupBox grpSex;
        private System.Windows.Forms.ComboBox cboSex;
        private System.Windows.Forms.GroupBox grpDOB;
        private System.Windows.Forms.NumericUpDown nudMonth;
        private System.Windows.Forms.NumericUpDown nudDay;
        private System.Windows.Forms.NumericUpDown nudYear;
        private System.Windows.Forms.GroupBox grpStaffName;
        private System.Windows.Forms.TextBox txtStaffName;
        private System.Windows.Forms.GroupBox grpContactInfo;
        private System.Windows.Forms.Label lblAddressError;
        private System.Windows.Forms.GroupBox grpAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblPhoneNumberWarning;
        private System.Windows.Forms.GroupBox grpPhoneNumber;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Button btnEdit;
    }
}