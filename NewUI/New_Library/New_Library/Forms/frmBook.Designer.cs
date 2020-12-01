namespace New_Library.Forms
{
    partial class frmBook
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvBook = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlBookInfo = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtBorrowed = new System.Windows.Forms.TextBox();
            this.txtAvailable = new System.Windows.Forms.TextBox();
            this.lblBorrowed = new System.Windows.Forms.Label();
            this.lblAvailable = new System.Windows.Forms.Label();
            this.cboGenreName = new System.Windows.Forms.ComboBox();
            this.lblGenre = new System.Windows.Forms.Label();
            this.txtPublisherName = new System.Windows.Forms.TextBox();
            this.lblPublisherName = new System.Windows.Forms.Label();
            this.txtAuthorName = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.lblBookName = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlBookInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBook
            // 
            this.dgvBook.AllowUserToAddRows = false;
            this.dgvBook.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvBook.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBook.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvBook.BackgroundColor = System.Drawing.Color.White;
            this.dgvBook.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBook.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBook.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvBook.ColumnHeadersHeight = 32;
            this.dgvBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBook.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBook.DoubleBuffered = true;
            this.dgvBook.EnableHeadersVisualStyles = false;
            this.dgvBook.GridColor = System.Drawing.Color.White;
            this.dgvBook.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dgvBook.HeaderForeColor = System.Drawing.Color.White;
            this.dgvBook.Location = new System.Drawing.Point(3, 234);
            this.dgvBook.MultiSelect = false;
            this.dgvBook.Name = "dgvBook";
            this.dgvBook.ReadOnly = true;
            this.dgvBook.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBook.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvBook.RowHeadersVisible = false;
            this.dgvBook.RowHeadersWidth = 20;
            this.dgvBook.RowTemplate.DividerHeight = 1;
            this.dgvBook.RowTemplate.Height = 30;
            this.dgvBook.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBook.Size = new System.Drawing.Size(985, 247);
            this.dgvBook.TabIndex = 45;
            this.dgvBook.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvBook_CellMouseDown);
            this.dgvBook.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvBook_DataBindingComplete);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "TÊN SÁCH";
            this.Column1.HeaderText = "TÊN SÁCH";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "TÁC GIẢ";
            this.Column2.HeaderText = "TÁC GIẢ";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.DataPropertyName = "THỂ LOẠI";
            this.Column3.HeaderText = "THỂ LOẠI";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 116;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.DataPropertyName = "NHÀ XUẤT BẢN";
            this.Column4.HeaderText = "NHÀ XUẤT BẢN";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 175;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column5.DataPropertyName = "CÓ SẴN";
            this.Column5.HeaderText = "CÓ SẴN";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 105;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column6.DataPropertyName = "ĐÃ MƯỢN";
            this.Column6.HeaderText = "ĐÃ MƯỢN";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 130;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.dgvBook, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pnlBookInfo, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.93388F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.06612F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(991, 484);
            this.tableLayoutPanel1.TabIndex = 46;
            // 
            // pnlBookInfo
            // 
            this.pnlBookInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBookInfo.Controls.Add(this.btnSearch);
            this.pnlBookInfo.Controls.Add(this.btnEdit);
            this.pnlBookInfo.Controls.Add(this.txtBorrowed);
            this.pnlBookInfo.Controls.Add(this.txtAvailable);
            this.pnlBookInfo.Controls.Add(this.lblBorrowed);
            this.pnlBookInfo.Controls.Add(this.lblAvailable);
            this.pnlBookInfo.Controls.Add(this.cboGenreName);
            this.pnlBookInfo.Controls.Add(this.lblGenre);
            this.pnlBookInfo.Controls.Add(this.txtPublisherName);
            this.pnlBookInfo.Controls.Add(this.lblPublisherName);
            this.pnlBookInfo.Controls.Add(this.txtAuthorName);
            this.pnlBookInfo.Controls.Add(this.lblAuthor);
            this.pnlBookInfo.Controls.Add(this.txtBookName);
            this.pnlBookInfo.Controls.Add(this.lblBookName);
            this.pnlBookInfo.Controls.Add(this.txtSearch);
            this.pnlBookInfo.Controls.Add(this.lblSearch);
            this.pnlBookInfo.Location = new System.Drawing.Point(3, 3);
            this.pnlBookInfo.Name = "pnlBookInfo";
            this.pnlBookInfo.Size = new System.Drawing.Size(985, 225);
            this.pnlBookInfo.TabIndex = 46;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.Black;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Image = global::New_Library.Properties.Resources.right_24px;
            this.btnSearch.Location = new System.Drawing.Point(700, 18);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(37, 27);
            this.btnSearch.TabIndex = 53;
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.BackColor = System.Drawing.Color.Black;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Image = global::New_Library.Properties.Resources.update;
            this.btnEdit.Location = new System.Drawing.Point(936, 7);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(37, 35);
            this.btnEdit.TabIndex = 52;
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtBorrowed
            // 
            this.txtBorrowed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBorrowed.Font = new System.Drawing.Font("Verdana", 12F);
            this.txtBorrowed.Location = new System.Drawing.Point(701, 168);
            this.txtBorrowed.Name = "txtBorrowed";
            this.txtBorrowed.ReadOnly = true;
            this.txtBorrowed.Size = new System.Drawing.Size(72, 27);
            this.txtBorrowed.TabIndex = 19;
            this.txtBorrowed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtAvailable
            // 
            this.txtAvailable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAvailable.Font = new System.Drawing.Font("Verdana", 12F);
            this.txtAvailable.Location = new System.Drawing.Point(701, 127);
            this.txtAvailable.Name = "txtAvailable";
            this.txtAvailable.ReadOnly = true;
            this.txtAvailable.Size = new System.Drawing.Size(72, 27);
            this.txtAvailable.TabIndex = 18;
            this.txtAvailable.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblBorrowed
            // 
            this.lblBorrowed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBorrowed.AutoSize = true;
            this.lblBorrowed.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBorrowed.Location = new System.Drawing.Point(606, 171);
            this.lblBorrowed.Name = "lblBorrowed";
            this.lblBorrowed.Size = new System.Drawing.Size(89, 24);
            this.lblBorrowed.TabIndex = 17;
            this.lblBorrowed.Text = "Đã mượn:";
            // 
            // lblAvailable
            // 
            this.lblAvailable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAvailable.AutoSize = true;
            this.lblAvailable.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailable.Location = new System.Drawing.Point(606, 130);
            this.lblAvailable.Name = "lblAvailable";
            this.lblAvailable.Size = new System.Drawing.Size(69, 24);
            this.lblAvailable.TabIndex = 16;
            this.lblAvailable.Text = "Có sẵn:";
            // 
            // cboGenreName
            // 
            this.cboGenreName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboGenreName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGenreName.Enabled = false;
            this.cboGenreName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboGenreName.Font = new System.Drawing.Font("Verdana", 12F);
            this.cboGenreName.FormattingEnabled = true;
            this.cboGenreName.Location = new System.Drawing.Point(701, 82);
            this.cboGenreName.Name = "cboGenreName";
            this.cboGenreName.Size = new System.Drawing.Size(243, 26);
            this.cboGenreName.Sorted = true;
            this.cboGenreName.TabIndex = 15;
            // 
            // lblGenre
            // 
            this.lblGenre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGenre.AutoSize = true;
            this.lblGenre.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenre.Location = new System.Drawing.Point(606, 85);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(82, 24);
            this.lblGenre.TabIndex = 14;
            this.lblGenre.Text = "Thể loại:";
            // 
            // txtPublisherName
            // 
            this.txtPublisherName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPublisherName.Font = new System.Drawing.Font("Verdana", 12F);
            this.txtPublisherName.Location = new System.Drawing.Point(137, 171);
            this.txtPublisherName.Name = "txtPublisherName";
            this.txtPublisherName.ReadOnly = true;
            this.txtPublisherName.Size = new System.Drawing.Size(392, 27);
            this.txtPublisherName.TabIndex = 13;
            // 
            // lblPublisherName
            // 
            this.lblPublisherName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPublisherName.AutoSize = true;
            this.lblPublisherName.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPublisherName.Location = new System.Drawing.Point(46, 171);
            this.lblPublisherName.Name = "lblPublisherName";
            this.lblPublisherName.Size = new System.Drawing.Size(51, 24);
            this.lblPublisherName.TabIndex = 12;
            this.lblPublisherName.Text = "NXB:";
            // 
            // txtAuthorName
            // 
            this.txtAuthorName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAuthorName.Font = new System.Drawing.Font("Verdana", 12F);
            this.txtAuthorName.Location = new System.Drawing.Point(137, 127);
            this.txtAuthorName.Name = "txtAuthorName";
            this.txtAuthorName.ReadOnly = true;
            this.txtAuthorName.Size = new System.Drawing.Size(392, 27);
            this.txtAuthorName.TabIndex = 11;
            // 
            // lblAuthor
            // 
            this.lblAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.Location = new System.Drawing.Point(46, 130);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(72, 24);
            this.lblAuthor.TabIndex = 10;
            this.lblAuthor.Text = "Tác giả:";
            // 
            // txtBookName
            // 
            this.txtBookName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBookName.Font = new System.Drawing.Font("Verdana", 12F);
            this.txtBookName.Location = new System.Drawing.Point(137, 82);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.ReadOnly = true;
            this.txtBookName.Size = new System.Drawing.Size(392, 27);
            this.txtBookName.TabIndex = 9;
            // 
            // lblBookName
            // 
            this.lblBookName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBookName.AutoSize = true;
            this.lblBookName.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookName.Location = new System.Drawing.Point(46, 85);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(85, 24);
            this.lblBookName.TabIndex = 8;
            this.lblBookName.Text = "Tên sách:";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("Verdana", 12F);
            this.txtSearch.Location = new System.Drawing.Point(244, 18);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(450, 27);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // lblSearch
            // 
            this.lblSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(145, 18);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(93, 24);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Tìm kiếm:";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Image = global::New_Library.Properties.Resources.delete;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(669, 492);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnDelete.Size = new System.Drawing.Size(116, 41);
            this.btnDelete.TabIndex = 48;
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
            this.btnUpdate.Location = new System.Drawing.Point(837, 492);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnUpdate.Size = new System.Drawing.Size(116, 41);
            this.btnUpdate.TabIndex = 47;
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
            this.btnAdd.Location = new System.Drawing.Point(491, 492);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnAdd.Size = new System.Drawing.Size(116, 41);
            this.btnAdd.TabIndex = 39;
            this.btnAdd.Text = "   Thêm";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 537);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Name = "frmBook";
            this.Text = " SÁCH";
            this.Load += new System.EventHandler(this.frmBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlBookInfo.ResumeLayout(false);
            this.pnlBookInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAdd;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvBook;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnlBookInfo;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.ComboBox cboGenreName;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.TextBox txtPublisherName;
        private System.Windows.Forms.Label lblPublisherName;
        private System.Windows.Forms.TextBox txtAuthorName;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.TextBox txtAvailable;
        private System.Windows.Forms.Label lblBorrowed;
        private System.Windows.Forms.Label lblAvailable;
        private System.Windows.Forms.TextBox txtBorrowed;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSearch;
    }
}