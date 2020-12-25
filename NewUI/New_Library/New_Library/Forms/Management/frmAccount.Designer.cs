namespace New_Library.Forms
{
    partial class frmAccount
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.dgvAccount = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.TenTaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhanQuyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.pnlEditAccount = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.gbPermission = new System.Windows.Forms.GroupBox();
            this.cbPermission = new System.Windows.Forms.ComboBox();
            this.lblAccountNameError = new System.Windows.Forms.Label();
            this.gbAccountName = new System.Windows.Forms.GroupBox();
            this.txtAccountName = new System.Windows.Forms.TextBox();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.errAccount = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlChangePassword = new System.Windows.Forms.Panel();
            this.btnCancelChange = new System.Windows.Forms.Button();
            this.btnAcceptChange = new System.Windows.Forms.Button();
            this.lblNewPasswordError = new System.Windows.Forms.Label();
            this.gbNewPassword = new System.Windows.Forms.GroupBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmPasswordError = new System.Windows.Forms.Label();
            this.gbConfirmPassword = new System.Windows.Forms.GroupBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
            this.pnlEditAccount.SuspendLayout();
            this.gbPermission.SuspendLayout();
            this.gbAccountName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errAccount)).BeginInit();
            this.pnlChangePassword.SuspendLayout();
            this.gbNewPassword.SuspendLayout();
            this.gbConfirmPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Image = global::New_Library.Properties.Resources.right_24px;
            this.btnSearch.Location = new System.Drawing.Point(560, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(37, 27);
            this.btnSearch.TabIndex = 74;
            this.btnSearch.TabStop = false;
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("Verdana", 12F);
            this.txtSearch.Location = new System.Drawing.Point(111, 6);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(443, 27);
            this.txtSearch.TabIndex = 68;
            this.txtSearch.TabStop = false;
            // 
            // lblSearch
            // 
            this.lblSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(12, 9);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(93, 24);
            this.lblSearch.TabIndex = 67;
            this.lblSearch.Text = "Tìm kiếm:";
            // 
            // dgvAccount
            // 
            this.dgvAccount.AllowUserToAddRows = false;
            this.dgvAccount.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvAccount.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAccount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAccount.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAccount.BackgroundColor = System.Drawing.Color.White;
            this.dgvAccount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAccount.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAccount.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAccount.ColumnHeadersHeight = 32;
            this.dgvAccount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenTaiKhoan,
            this.PhanQuyen});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAccount.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAccount.DoubleBuffered = true;
            this.dgvAccount.EnableHeadersVisualStyles = false;
            this.dgvAccount.GridColor = System.Drawing.Color.White;
            this.dgvAccount.HeaderBgColor = System.Drawing.Color.MidnightBlue;
            this.dgvAccount.HeaderForeColor = System.Drawing.Color.White;
            this.dgvAccount.Location = new System.Drawing.Point(12, 53);
            this.dgvAccount.Name = "dgvAccount";
            this.dgvAccount.ReadOnly = true;
            this.dgvAccount.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAccount.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAccount.RowHeadersVisible = false;
            this.dgvAccount.RowHeadersWidth = 20;
            this.dgvAccount.RowTemplate.DividerHeight = 1;
            this.dgvAccount.RowTemplate.Height = 30;
            this.dgvAccount.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAccount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAccount.Size = new System.Drawing.Size(974, 433);
            this.dgvAccount.TabIndex = 45;
            this.dgvAccount.TabStop = false;
            this.dgvAccount.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAccount_CellClick);
            this.dgvAccount.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvStaff_DataBindingComplete);
            // 
            // TenTaiKhoan
            // 
            this.TenTaiKhoan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TenTaiKhoan.DataPropertyName = "TÊN TÀI KHOẢN";
            this.TenTaiKhoan.HeaderText = "TÊN TÀI KHOẢN";
            this.TenTaiKhoan.Name = "TenTaiKhoan";
            this.TenTaiKhoan.ReadOnly = true;
            this.TenTaiKhoan.Width = 177;
            // 
            // PhanQuyen
            // 
            this.PhanQuyen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PhanQuyen.DataPropertyName = "PHÂN QUYỀN";
            this.PhanQuyen.HeaderText = "PHÂN QUYỀN";
            this.PhanQuyen.Name = "PhanQuyen";
            this.PhanQuyen.ReadOnly = true;
            this.PhanQuyen.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PhanQuyen.Width = 157;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.BackColor = System.Drawing.Color.Goldenrod;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Olive;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Image = global::New_Library.Properties.Resources.update_24px;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(870, 6);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnUpdate.Size = new System.Drawing.Size(116, 41);
            this.btnUpdate.TabIndex = 76;
            this.btnUpdate.TabStop = false;
            this.btnUpdate.Text = "   Sửa";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pnlEditAccount
            // 
            this.pnlEditAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlEditAccount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEditAccount.Controls.Add(this.btnCancel);
            this.pnlEditAccount.Controls.Add(this.btnEdit);
            this.pnlEditAccount.Controls.Add(this.gbPermission);
            this.pnlEditAccount.Controls.Add(this.lblAccountNameError);
            this.pnlEditAccount.Controls.Add(this.gbAccountName);
            this.pnlEditAccount.Location = new System.Drawing.Point(748, 49);
            this.pnlEditAccount.Name = "pnlEditAccount";
            this.pnlEditAccount.Size = new System.Drawing.Size(238, 197);
            this.pnlEditAccount.TabIndex = 78;
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
            this.btnCancel.Location = new System.Drawing.Point(122, 158);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(114, 36);
            this.btnCancel.TabIndex = 78;
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
            this.btnEdit.Location = new System.Drawing.Point(3, 158);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(114, 36);
            this.btnEdit.TabIndex = 77;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // gbPermission
            // 
            this.gbPermission.BackColor = System.Drawing.Color.White;
            this.gbPermission.Controls.Add(this.cbPermission);
            this.gbPermission.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbPermission.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPermission.Location = new System.Drawing.Point(3, 71);
            this.gbPermission.Name = "gbPermission";
            this.gbPermission.Size = new System.Drawing.Size(216, 54);
            this.gbPermission.TabIndex = 75;
            this.gbPermission.TabStop = false;
            this.gbPermission.Text = "Phân quyền";
            // 
            // cbPermission
            // 
            this.cbPermission.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbPermission.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbPermission.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPermission.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbPermission.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPermission.FormattingEnabled = true;
            this.cbPermission.Items.AddRange(new object[] {
            "Admin",
            "Member"});
            this.cbPermission.Location = new System.Drawing.Point(9, 19);
            this.cbPermission.Margin = new System.Windows.Forms.Padding(0);
            this.cbPermission.Name = "cbPermission";
            this.cbPermission.Size = new System.Drawing.Size(204, 33);
            this.cbPermission.Sorted = true;
            this.cbPermission.TabIndex = 2;
            // 
            // lblAccountNameError
            // 
            this.lblAccountNameError.AutoSize = true;
            this.lblAccountNameError.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountNameError.ForeColor = System.Drawing.Color.Red;
            this.lblAccountNameError.Location = new System.Drawing.Point(3, 55);
            this.lblAccountNameError.Name = "lblAccountNameError";
            this.lblAccountNameError.Size = new System.Drawing.Size(106, 13);
            this.lblAccountNameError.TabIndex = 74;
            this.lblAccountNameError.Text = "AccountName Error";
            // 
            // gbAccountName
            // 
            this.gbAccountName.BackColor = System.Drawing.Color.White;
            this.gbAccountName.Controls.Add(this.txtAccountName);
            this.gbAccountName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbAccountName.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAccountName.Location = new System.Drawing.Point(3, 4);
            this.gbAccountName.Name = "gbAccountName";
            this.gbAccountName.Size = new System.Drawing.Size(216, 48);
            this.gbAccountName.TabIndex = 73;
            this.gbAccountName.TabStop = false;
            this.gbAccountName.Text = "Tên tài khoản";
            // 
            // txtAccountName
            // 
            this.txtAccountName.AcceptsTab = true;
            this.txtAccountName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAccountName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtAccountName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAccountName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtAccountName.Location = new System.Drawing.Point(9, 19);
            this.txtAccountName.Margin = new System.Windows.Forms.Padding(0);
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.Size = new System.Drawing.Size(204, 26);
            this.txtAccountName.TabIndex = 1;
            this.txtAccountName.WordWrap = false;
            this.txtAccountName.Validating += new System.ComponentModel.CancelEventHandler(this.txtAccountName_Validating);
            this.txtAccountName.Validated += new System.EventHandler(this.txtAccountName_Validated);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChangePassword.BackColor = System.Drawing.Color.LightPink;
            this.btnChangePassword.FlatAppearance.BorderSize = 0;
            this.btnChangePassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Pink;
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.ForeColor = System.Drawing.Color.White;
            this.btnChangePassword.Location = new System.Drawing.Point(734, 6);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnChangePassword.Size = new System.Drawing.Size(130, 41);
            this.btnChangePassword.TabIndex = 78;
            this.btnChangePassword.TabStop = false;
            this.btnChangePassword.Text = "Đổi mật khẩu";
            this.btnChangePassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangePassword.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // errAccount
            // 
            this.errAccount.BlinkRate = 0;
            this.errAccount.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errAccount.ContainerControl = this;
            // 
            // pnlChangePassword
            // 
            this.pnlChangePassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlChangePassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlChangePassword.Controls.Add(this.lblConfirmPasswordError);
            this.pnlChangePassword.Controls.Add(this.gbConfirmPassword);
            this.pnlChangePassword.Controls.Add(this.btnCancelChange);
            this.pnlChangePassword.Controls.Add(this.btnAcceptChange);
            this.pnlChangePassword.Controls.Add(this.lblNewPasswordError);
            this.pnlChangePassword.Controls.Add(this.gbNewPassword);
            this.pnlChangePassword.Location = new System.Drawing.Point(679, 49);
            this.pnlChangePassword.Name = "pnlChangePassword";
            this.pnlChangePassword.Size = new System.Drawing.Size(238, 197);
            this.pnlChangePassword.TabIndex = 79;
            // 
            // btnCancelChange
            // 
            this.btnCancelChange.BackColor = System.Drawing.Color.Red;
            this.btnCancelChange.FlatAppearance.BorderSize = 0;
            this.btnCancelChange.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btnCancelChange.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btnCancelChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelChange.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelChange.Image = global::New_Library.Properties.Resources.delete;
            this.btnCancelChange.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelChange.Location = new System.Drawing.Point(122, 158);
            this.btnCancelChange.Name = "btnCancelChange";
            this.btnCancelChange.Size = new System.Drawing.Size(114, 36);
            this.btnCancelChange.TabIndex = 78;
            this.btnCancelChange.Text = "Hủy";
            this.btnCancelChange.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelChange.UseVisualStyleBackColor = false;
            this.btnCancelChange.Click += new System.EventHandler(this.btnCancelChange_Click);
            // 
            // btnAcceptChange
            // 
            this.btnAcceptChange.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAcceptChange.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAcceptChange.FlatAppearance.BorderSize = 0;
            this.btnAcceptChange.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.btnAcceptChange.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnAcceptChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcceptChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcceptChange.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAcceptChange.Image = global::New_Library.Properties.Resources.update_24px;
            this.btnAcceptChange.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnAcceptChange.Location = new System.Drawing.Point(3, 158);
            this.btnAcceptChange.Name = "btnAcceptChange";
            this.btnAcceptChange.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAcceptChange.Size = new System.Drawing.Size(114, 36);
            this.btnAcceptChange.TabIndex = 77;
            this.btnAcceptChange.Text = "Đổi mật khẩu";
            this.btnAcceptChange.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAcceptChange.UseVisualStyleBackColor = false;
            this.btnAcceptChange.Click += new System.EventHandler(this.btnAcceptChange_Click);
            // 
            // lblNewPasswordError
            // 
            this.lblNewPasswordError.AutoSize = true;
            this.lblNewPasswordError.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPasswordError.ForeColor = System.Drawing.Color.Red;
            this.lblNewPasswordError.Location = new System.Drawing.Point(3, 55);
            this.lblNewPasswordError.Name = "lblNewPasswordError";
            this.lblNewPasswordError.Size = new System.Drawing.Size(107, 13);
            this.lblNewPasswordError.TabIndex = 74;
            this.lblNewPasswordError.Text = "NewPassword Error";
            // 
            // gbNewPassword
            // 
            this.gbNewPassword.BackColor = System.Drawing.Color.White;
            this.gbNewPassword.Controls.Add(this.txtNewPassword);
            this.gbNewPassword.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbNewPassword.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbNewPassword.Location = new System.Drawing.Point(3, 4);
            this.gbNewPassword.Name = "gbNewPassword";
            this.gbNewPassword.Size = new System.Drawing.Size(216, 48);
            this.gbNewPassword.TabIndex = 73;
            this.gbNewPassword.TabStop = false;
            this.gbNewPassword.Text = "Mật khẩu mới";
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.AcceptsTab = true;
            this.txtNewPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNewPassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNewPassword.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNewPassword.Location = new System.Drawing.Point(9, 19);
            this.txtNewPassword.Margin = new System.Windows.Forms.Padding(0);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(204, 26);
            this.txtNewPassword.TabIndex = 1;
            this.txtNewPassword.UseSystemPasswordChar = true;
            this.txtNewPassword.WordWrap = false;
            this.txtNewPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtNewPassword_Validating);
            this.txtNewPassword.Validated += new System.EventHandler(this.txtNewPassword_Validated);
            // 
            // lblConfirmPasswordError
            // 
            this.lblConfirmPasswordError.AutoSize = true;
            this.lblConfirmPasswordError.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPasswordError.ForeColor = System.Drawing.Color.Red;
            this.lblConfirmPasswordError.Location = new System.Drawing.Point(3, 128);
            this.lblConfirmPasswordError.Name = "lblConfirmPasswordError";
            this.lblConfirmPasswordError.Size = new System.Drawing.Size(125, 13);
            this.lblConfirmPasswordError.TabIndex = 80;
            this.lblConfirmPasswordError.Text = "ConfirmPasswrod Error";
            // 
            // gbConfirmPassword
            // 
            this.gbConfirmPassword.BackColor = System.Drawing.Color.White;
            this.gbConfirmPassword.Controls.Add(this.txtConfirmPassword);
            this.gbConfirmPassword.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbConfirmPassword.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbConfirmPassword.Location = new System.Drawing.Point(3, 77);
            this.gbConfirmPassword.Name = "gbConfirmPassword";
            this.gbConfirmPassword.Size = new System.Drawing.Size(216, 48);
            this.gbConfirmPassword.TabIndex = 79;
            this.gbConfirmPassword.TabStop = false;
            this.gbConfirmPassword.Text = "Xác nhận mật khẩu";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.AcceptsTab = true;
            this.txtConfirmPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConfirmPassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtConfirmPassword.Location = new System.Drawing.Point(9, 19);
            this.txtConfirmPassword.Margin = new System.Windows.Forms.Padding(0);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(204, 26);
            this.txtConfirmPassword.TabIndex = 2;
            this.txtConfirmPassword.UseSystemPasswordChar = true;
            this.txtConfirmPassword.WordWrap = false;
            this.txtConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtConfirmPassword_Validating);
            this.txtConfirmPassword.Validated += new System.EventHandler(this.txtConfirmPassword_Validated);
            // 
            // frmAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(998, 498);
            this.ControlBox = false;
            this.Controls.Add(this.pnlChangePassword);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.pnlEditAccount);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.dgvAccount);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAccount";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "frmAccount";
            this.Load += new System.EventHandler(this.frmAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
            this.pnlEditAccount.ResumeLayout(false);
            this.pnlEditAccount.PerformLayout();
            this.gbPermission.ResumeLayout(false);
            this.gbAccountName.ResumeLayout(false);
            this.gbAccountName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errAccount)).EndInit();
            this.pnlChangePassword.ResumeLayout(false);
            this.pnlChangePassword.PerformLayout();
            this.gbNewPassword.ResumeLayout(false);
            this.gbNewPassword.PerformLayout();
            this.gbConfirmPassword.ResumeLayout(false);
            this.gbConfirmPassword.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvAccount;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel pnlEditAccount;
        private System.Windows.Forms.Label lblAccountNameError;
        private System.Windows.Forms.GroupBox gbAccountName;
        private System.Windows.Forms.TextBox txtAccountName;
        private System.Windows.Forms.GroupBox gbPermission;
        private System.Windows.Forms.ComboBox cbPermission;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ErrorProvider errAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhanQuyen;
        private System.Windows.Forms.Panel pnlChangePassword;
        private System.Windows.Forms.Label lblConfirmPasswordError;
        private System.Windows.Forms.GroupBox gbConfirmPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Button btnCancelChange;
        private System.Windows.Forms.Button btnAcceptChange;
        private System.Windows.Forms.Label lblNewPasswordError;
        private System.Windows.Forms.GroupBox gbNewPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
    }
}