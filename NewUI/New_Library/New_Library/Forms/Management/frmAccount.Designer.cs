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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvAccount = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlBookInfo = new System.Windows.Forms.Panel();
            this.chkAdminPermission = new System.Windows.Forms.CheckBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.cboRole = new System.Windows.Forms.ComboBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.txtAccountName = new System.Windows.Forms.TextBox();
            this.lblAccountName = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
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
            this.tableLayoutPanel1.Controls.Add(this.dgvAccount, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pnlBookInfo, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.29148F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.70852F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(844, 446);
            this.tableLayoutPanel1.TabIndex = 58;
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
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAccount.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAccount.ColumnHeadersHeight = 32;
            this.dgvAccount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
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
            this.dgvAccount.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dgvAccount.HeaderForeColor = System.Drawing.Color.White;
            this.dgvAccount.Location = new System.Drawing.Point(3, 205);
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
            this.dgvAccount.Size = new System.Drawing.Size(838, 238);
            this.dgvAccount.TabIndex = 45;
            this.dgvAccount.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvStaff_CellMouseDown);
            this.dgvAccount.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvStaff_DataBindingComplete);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "TÊN TÀI KHOẢN";
            this.Column1.HeaderText = "TÊN TÀI KHOẢN";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MẬT KHẨU";
            this.Column2.HeaderText = "MẬT KHẨU";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "PHÂN QUYỀN";
            this.Column3.HeaderText = "PHÂN QUYỀN";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // pnlBookInfo
            // 
            this.pnlBookInfo.Controls.Add(this.chkAdminPermission);
            this.pnlBookInfo.Controls.Add(this.txtConfirmPassword);
            this.pnlBookInfo.Controls.Add(this.lblConfirmPassword);
            this.pnlBookInfo.Controls.Add(this.txtPassword);
            this.pnlBookInfo.Controls.Add(this.lblPassword);
            this.pnlBookInfo.Controls.Add(this.btnChangePassword);
            this.pnlBookInfo.Controls.Add(this.btnSearch);
            this.pnlBookInfo.Controls.Add(this.btnEdit);
            this.pnlBookInfo.Controls.Add(this.cboRole);
            this.pnlBookInfo.Controls.Add(this.lblRole);
            this.pnlBookInfo.Controls.Add(this.txtAccountName);
            this.pnlBookInfo.Controls.Add(this.lblAccountName);
            this.pnlBookInfo.Controls.Add(this.txtSearch);
            this.pnlBookInfo.Controls.Add(this.lblSearch);
            this.pnlBookInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBookInfo.Location = new System.Drawing.Point(3, 3);
            this.pnlBookInfo.Name = "pnlBookInfo";
            this.pnlBookInfo.Size = new System.Drawing.Size(838, 196);
            this.pnlBookInfo.TabIndex = 46;
            // 
            // chkAdminPermission
            // 
            this.chkAdminPermission.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkAdminPermission.AutoSize = true;
            this.chkAdminPermission.Enabled = false;
            this.chkAdminPermission.Location = new System.Drawing.Point(427, 94);
            this.chkAdminPermission.Name = "chkAdminPermission";
            this.chkAdminPermission.Size = new System.Drawing.Size(15, 14);
            this.chkAdminPermission.TabIndex = 66;
            this.chkAdminPermission.UseVisualStyleBackColor = true;
            this.chkAdminPermission.CheckedChanged += new System.EventHandler(this.chkAdminPermission_CheckedChanged);
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConfirmPassword.Font = new System.Drawing.Font("Verdana", 12F);
            this.txtConfirmPassword.Location = new System.Drawing.Point(263, 162);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(315, 27);
            this.txtConfirmPassword.TabIndex = 65;
            this.txtConfirmPassword.UseSystemPasswordChar = true;
            this.txtConfirmPassword.Visible = false;
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPassword.Location = new System.Drawing.Point(95, 162);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(168, 24);
            this.lblConfirmPassword.TabIndex = 64;
            this.lblConfirmPassword.Text = "Xác nhận mật khẩu:";
            this.lblConfirmPassword.Visible = false;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Font = new System.Drawing.Font("Verdana", 12F);
            this.txtPassword.Location = new System.Drawing.Point(263, 126);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(315, 27);
            this.txtPassword.TabIndex = 63;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.Visible = false;
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(95, 125);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(129, 24);
            this.lblPassword.TabIndex = 62;
            this.lblPassword.Text = "Mật khẩu mới:";
            this.lblPassword.Visible = false;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangePassword.Location = new System.Drawing.Point(651, 47);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(120, 27);
            this.btnChangePassword.TabIndex = 60;
            this.btnChangePassword.Text = "Đổi mật khẩu";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.Black;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Image = global::New_Library.Properties.Resources.right_24px;
            this.btnSearch.Location = new System.Drawing.Point(623, 7);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(37, 27);
            this.btnSearch.TabIndex = 54;
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
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
            // cboRole
            // 
            this.cboRole.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRole.Enabled = false;
            this.cboRole.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboRole.Font = new System.Drawing.Font("Verdana", 12F);
            this.cboRole.FormattingEnabled = true;
            this.cboRole.Items.AddRange(new object[] {
            "Admin",
            "Member"});
            this.cboRole.Location = new System.Drawing.Point(227, 87);
            this.cboRole.Name = "cboRole";
            this.cboRole.Size = new System.Drawing.Size(178, 26);
            this.cboRole.Sorted = true;
            this.cboRole.TabIndex = 29;
            // 
            // lblRole
            // 
            this.lblRole.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.Location = new System.Drawing.Point(95, 86);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(108, 24);
            this.lblRole.TabIndex = 28;
            this.lblRole.Text = "Phân quyền:";
            // 
            // txtAccountName
            // 
            this.txtAccountName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAccountName.Font = new System.Drawing.Font("Verdana", 12F);
            this.txtAccountName.Location = new System.Drawing.Point(227, 47);
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.ReadOnly = true;
            this.txtAccountName.Size = new System.Drawing.Size(315, 27);
            this.txtAccountName.TabIndex = 23;
            // 
            // lblAccountName
            // 
            this.lblAccountName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAccountName.AutoSize = true;
            this.lblAccountName.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountName.Location = new System.Drawing.Point(95, 47);
            this.lblAccountName.Name = "lblAccountName";
            this.lblAccountName.Size = new System.Drawing.Size(126, 24);
            this.lblAccountName.TabIndex = 22;
            this.lblAccountName.Text = "Tên tài khoản:";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("Verdana", 12F);
            this.txtSearch.Location = new System.Drawing.Point(277, 7);
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
            this.lblSearch.Location = new System.Drawing.Point(178, 7);
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
            this.btnDelete.Location = new System.Drawing.Point(655, 455);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnDelete.Size = new System.Drawing.Size(116, 41);
            this.btnDelete.TabIndex = 60;
            this.btnDelete.Text = "   Xóa";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Image = global::New_Library.Properties.Resources.add1;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(477, 455);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnAdd.Size = new System.Drawing.Size(116, 41);
            this.btnAdd.TabIndex = 57;
            this.btnAdd.Text = "   Thêm";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 498);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Name = "frmAccount";
            this.Text = "frmAccount";
            this.Load += new System.EventHandler(this.frmAccount_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
            this.pnlBookInfo.ResumeLayout(false);
            this.pnlBookInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvAccount;
        private System.Windows.Forms.Panel pnlBookInfo;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ComboBox cboRole;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.TextBox txtAccountName;
        private System.Windows.Forms.Label lblAccountName;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.CheckBox chkAdminPermission;
    }
}