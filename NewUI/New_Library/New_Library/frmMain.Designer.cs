namespace New_Library
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnManagement = new System.Windows.Forms.Button();
            this.btnSignout = new System.Windows.Forms.Button();
            this.btnReceipt = new System.Windows.Forms.Button();
            this.btnReader = new System.Windows.Forms.Button();
            this.btnGenre = new System.Windows.Forms.Button();
            this.btnBook = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnTitle = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlChildForm = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.lblNoTotalBook = new System.Windows.Forms.Label();
            this.lblTotalBook = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.lblNoTotalAvailableCopies = new System.Windows.Forms.Label();
            this.lblNoTotalGenres = new System.Windows.Forms.Label();
            this.lblAvailableCopies = new System.Windows.Forms.Label();
            this.lblTotalGenres = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.lblNoOverdueReader = new System.Windows.Forms.Label();
            this.lblOverdueReader = new System.Windows.Forms.Label();
            this.lblBorrowingReader = new System.Windows.Forms.Label();
            this.lblNoBorrowingReader = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTotalReader = new System.Windows.Forms.Label();
            this.lblNoTotalReader = new System.Windows.Forms.Label();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.lblPhoneTag = new System.Windows.Forms.Label();
            this.lblEmailTag = new System.Windows.Forms.Label();
            this.lblAddressTag = new System.Windows.Forms.Label();
            this.lblLibraryNameTag = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtLibraryName = new System.Windows.Forms.TextBox();
            this.txtAddressName = new System.Windows.Forms.TextBox();
            this.txtEmailName = new System.Windows.Forms.TextBox();
            this.txtPhoneName = new System.Windows.Forms.TextBox();
            this.pnlMenu.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            this.pnlTitleBar.SuspendLayout();
            this.pnlChildForm.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.AutoScroll = true;
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.pnlMenu.Controls.Add(this.btnHelp);
            this.pnlMenu.Controls.Add(this.btnSetting);
            this.pnlMenu.Controls.Add(this.btnManagement);
            this.pnlMenu.Controls.Add(this.btnSignout);
            this.pnlMenu.Controls.Add(this.btnReceipt);
            this.pnlMenu.Controls.Add(this.btnReader);
            this.pnlMenu.Controls.Add(this.btnGenre);
            this.pnlMenu.Controls.Add(this.btnBook);
            this.pnlMenu.Controls.Add(this.pnlLogo);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(200, 656);
            this.pnlMenu.TabIndex = 0;
            // 
            // btnHelp
            // 
            this.btnHelp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnHelp.Image = global::New_Library.Properties.Resources.help;
            this.btnHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.Location = new System.Drawing.Point(0, 440);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnHelp.Size = new System.Drawing.Size(200, 60);
            this.btnHelp.TabIndex = 12;
            this.btnHelp.Text = "   Trợ giúp";
            this.btnHelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetting.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSetting.Image = global::New_Library.Properties.Resources.settings;
            this.btnSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.Location = new System.Drawing.Point(0, 380);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnSetting.Size = new System.Drawing.Size(200, 60);
            this.btnSetting.TabIndex = 11;
            this.btnSetting.Text = "   Thiết lập";
            this.btnSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnManagement
            // 
            this.btnManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManagement.FlatAppearance.BorderSize = 0;
            this.btnManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManagement.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnManagement.Image = global::New_Library.Properties.Resources.management_32px;
            this.btnManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManagement.Location = new System.Drawing.Point(0, 320);
            this.btnManagement.Name = "btnManagement";
            this.btnManagement.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnManagement.Size = new System.Drawing.Size(200, 60);
            this.btnManagement.TabIndex = 9;
            this.btnManagement.Text = "   Quản lý";
            this.btnManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManagement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnManagement.UseVisualStyleBackColor = true;
            this.btnManagement.Click += new System.EventHandler(this.btnManagement_Click);
            // 
            // btnSignout
            // 
            this.btnSignout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSignout.FlatAppearance.BorderSize = 0;
            this.btnSignout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignout.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignout.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSignout.Image = global::New_Library.Properties.Resources.signout;
            this.btnSignout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSignout.Location = new System.Drawing.Point(0, 596);
            this.btnSignout.Name = "btnSignout";
            this.btnSignout.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnSignout.Size = new System.Drawing.Size(200, 60);
            this.btnSignout.TabIndex = 8;
            this.btnSignout.Text = "   Đăng xuất";
            this.btnSignout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSignout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSignout.UseVisualStyleBackColor = true;
            this.btnSignout.Click += new System.EventHandler(this.btnSignout_Click);
            this.btnSignout.MouseLeave += new System.EventHandler(this.btnSignout_MouseLeave);
            this.btnSignout.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnSignout_MouseMove);
            // 
            // btnReceipt
            // 
            this.btnReceipt.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReceipt.FlatAppearance.BorderSize = 0;
            this.btnReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReceipt.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnReceipt.Image = global::New_Library.Properties.Resources.receipt;
            this.btnReceipt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReceipt.Location = new System.Drawing.Point(0, 260);
            this.btnReceipt.Name = "btnReceipt";
            this.btnReceipt.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnReceipt.Size = new System.Drawing.Size(200, 60);
            this.btnReceipt.TabIndex = 5;
            this.btnReceipt.Text = "   Hóa đơn";
            this.btnReceipt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReceipt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReceipt.UseVisualStyleBackColor = true;
            this.btnReceipt.Click += new System.EventHandler(this.btnReceipt_Click);
            // 
            // btnReader
            // 
            this.btnReader.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReader.FlatAppearance.BorderSize = 0;
            this.btnReader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReader.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReader.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnReader.Image = global::New_Library.Properties.Resources.reader;
            this.btnReader.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReader.Location = new System.Drawing.Point(0, 200);
            this.btnReader.Name = "btnReader";
            this.btnReader.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnReader.Size = new System.Drawing.Size(200, 60);
            this.btnReader.TabIndex = 4;
            this.btnReader.Text = "   Độc giả";
            this.btnReader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReader.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReader.UseVisualStyleBackColor = true;
            this.btnReader.Click += new System.EventHandler(this.btnReader_Click);
            // 
            // btnGenre
            // 
            this.btnGenre.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGenre.FlatAppearance.BorderSize = 0;
            this.btnGenre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenre.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnGenre.Image = global::New_Library.Properties.Resources.genre;
            this.btnGenre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenre.Location = new System.Drawing.Point(0, 140);
            this.btnGenre.Name = "btnGenre";
            this.btnGenre.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnGenre.Size = new System.Drawing.Size(200, 60);
            this.btnGenre.TabIndex = 3;
            this.btnGenre.Text = "   Thể loại";
            this.btnGenre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenre.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGenre.UseVisualStyleBackColor = true;
            this.btnGenre.Click += new System.EventHandler(this.btnGenre_Click);
            // 
            // btnBook
            // 
            this.btnBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBook.FlatAppearance.BorderSize = 0;
            this.btnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBook.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnBook.Image = global::New_Library.Properties.Resources.book;
            this.btnBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBook.Location = new System.Drawing.Point(0, 80);
            this.btnBook.Name = "btnBook";
            this.btnBook.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnBook.Size = new System.Drawing.Size(200, 60);
            this.btnBook.TabIndex = 2;
            this.btnBook.Text = "   Sách";
            this.btnBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.pnlLogo.Controls.Add(this.lblLogo);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(200, 80);
            this.pnlLogo.TabIndex = 0;
            // 
            // lblLogo
            // 
            this.lblLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Location = new System.Drawing.Point(0, 0);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(200, 80);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "Trang chính";
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLogo.Click += new System.EventHandler(this.lblLogo_Click);
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.pnlTitleBar.Controls.Add(this.btnMaximize);
            this.pnlTitleBar.Controls.Add(this.btnTitle);
            this.pnlTitleBar.Controls.Add(this.btnMinimize);
            this.pnlTitleBar.Controls.Add(this.btnExit);
            this.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleBar.Location = new System.Drawing.Point(200, 0);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(1031, 80);
            this.pnlTitleBar.TabIndex = 1;
            this.pnlTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitleBar_MouseDown);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Image = global::New_Library.Properties.Resources.maximize_button_16px1;
            this.btnMaximize.Location = new System.Drawing.Point(976, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(29, 24);
            this.btnMaximize.TabIndex = 4;
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnTitle
            // 
            this.btnTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTitle.FlatAppearance.BorderSize = 0;
            this.btnTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTitle.ForeColor = System.Drawing.Color.White;
            this.btnTitle.Location = new System.Drawing.Point(407, 23);
            this.btnTitle.Name = "btnTitle";
            this.btnTitle.Size = new System.Drawing.Size(262, 32);
            this.btnTitle.TabIndex = 0;
            this.btnTitle.Text = "QUẢN LÝ THƯ VIỆN";
            this.btnTitle.UseVisualStyleBackColor = true;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(950, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(29, 24);
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.Text = "___";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = global::New_Library.Properties.Resources.delete_16px1;
            this.btnExit.Location = new System.Drawing.Point(1002, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(29, 24);
            this.btnExit.TabIndex = 5;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlChildForm
            // 
            this.pnlChildForm.Controls.Add(this.btnEdit);
            this.pnlChildForm.Controls.Add(this.tableLayoutPanel1);
            this.pnlChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChildForm.Location = new System.Drawing.Point(200, 80);
            this.pnlChildForm.Name = "pnlChildForm";
            this.pnlChildForm.Size = new System.Drawing.Size(1031, 576);
            this.pnlChildForm.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel9, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(68, 40);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.84722F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.15278F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(908, 494);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 189);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 302F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(902, 302);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel8, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(454, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(445, 296);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 1;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel8.Controls.Add(this.lblNoTotalBook, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.lblTotalBook, 0, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 180);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 2;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(439, 113);
            this.tableLayoutPanel8.TabIndex = 3;
            // 
            // lblNoTotalBook
            // 
            this.lblNoTotalBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(87)))), ((int)(((byte)(194)))));
            this.lblNoTotalBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNoTotalBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNoTotalBook.Font = new System.Drawing.Font("Russo One", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoTotalBook.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNoTotalBook.Location = new System.Drawing.Point(0, 45);
            this.lblNoTotalBook.Margin = new System.Windows.Forms.Padding(0);
            this.lblNoTotalBook.Name = "lblNoTotalBook";
            this.lblNoTotalBook.Size = new System.Drawing.Size(439, 68);
            this.lblNoTotalBook.TabIndex = 1;
            this.lblNoTotalBook.Text = "0";
            this.lblNoTotalBook.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalBook
            // 
            this.lblTotalBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.lblTotalBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTotalBook.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBook.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTotalBook.Location = new System.Drawing.Point(0, 0);
            this.lblTotalBook.Margin = new System.Windows.Forms.Padding(0);
            this.lblTotalBook.Name = "lblTotalBook";
            this.lblTotalBook.Size = new System.Drawing.Size(439, 45);
            this.lblTotalBook.TabIndex = 2;
            this.lblTotalBook.Text = "Số lượng sách";
            this.lblTotalBook.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.lblNoTotalAvailableCopies, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.lblNoTotalGenres, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.lblAvailableCopies, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.lblTotalGenres, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(439, 171);
            this.tableLayoutPanel6.TabIndex = 2;
            // 
            // lblNoTotalAvailableCopies
            // 
            this.lblNoTotalAvailableCopies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(82)))));
            this.lblNoTotalAvailableCopies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNoTotalAvailableCopies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNoTotalAvailableCopies.Font = new System.Drawing.Font("Russo One", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoTotalAvailableCopies.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNoTotalAvailableCopies.Location = new System.Drawing.Point(219, 68);
            this.lblNoTotalAvailableCopies.Margin = new System.Windows.Forms.Padding(0);
            this.lblNoTotalAvailableCopies.Name = "lblNoTotalAvailableCopies";
            this.lblNoTotalAvailableCopies.Size = new System.Drawing.Size(220, 103);
            this.lblNoTotalAvailableCopies.TabIndex = 1;
            this.lblNoTotalAvailableCopies.Text = "0";
            this.lblNoTotalAvailableCopies.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNoTotalGenres
            // 
            this.lblNoTotalGenres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(118)))), ((int)(((byte)(22)))));
            this.lblNoTotalGenres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNoTotalGenres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNoTotalGenres.Font = new System.Drawing.Font("Russo One", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoTotalGenres.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNoTotalGenres.Location = new System.Drawing.Point(0, 68);
            this.lblNoTotalGenres.Margin = new System.Windows.Forms.Padding(0);
            this.lblNoTotalGenres.Name = "lblNoTotalGenres";
            this.lblNoTotalGenres.Size = new System.Drawing.Size(219, 103);
            this.lblNoTotalGenres.TabIndex = 1;
            this.lblNoTotalGenres.Text = "0";
            this.lblNoTotalGenres.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAvailableCopies
            // 
            this.lblAvailableCopies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(36)))));
            this.lblAvailableCopies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAvailableCopies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAvailableCopies.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailableCopies.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAvailableCopies.Location = new System.Drawing.Point(219, 0);
            this.lblAvailableCopies.Margin = new System.Windows.Forms.Padding(0);
            this.lblAvailableCopies.Name = "lblAvailableCopies";
            this.lblAvailableCopies.Size = new System.Drawing.Size(220, 68);
            this.lblAvailableCopies.TabIndex = 2;
            this.lblAvailableCopies.Text = "Có sẵn";
            this.lblAvailableCopies.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalGenres
            // 
            this.lblTotalGenres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(76)))), ((int)(((byte)(0)))));
            this.lblTotalGenres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalGenres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTotalGenres.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalGenres.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTotalGenres.Location = new System.Drawing.Point(0, 0);
            this.lblTotalGenres.Margin = new System.Windows.Forms.Padding(0);
            this.lblTotalGenres.Name = "lblTotalGenres";
            this.lblTotalGenres.Size = new System.Drawing.Size(219, 68);
            this.lblTotalGenres.TabIndex = 2;
            this.lblTotalGenres.Text = "Thể loại";
            this.lblTotalGenres.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel7, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(445, 296);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Controls.Add(this.lblNoOverdueReader, 1, 1);
            this.tableLayoutPanel7.Controls.Add(this.lblOverdueReader, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.lblBorrowingReader, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.lblNoBorrowingReader, 0, 1);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 121);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(439, 172);
            this.tableLayoutPanel7.TabIndex = 2;
            // 
            // lblNoOverdueReader
            // 
            this.lblNoOverdueReader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNoOverdueReader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNoOverdueReader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNoOverdueReader.Font = new System.Drawing.Font("Russo One", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoOverdueReader.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNoOverdueReader.Location = new System.Drawing.Point(219, 68);
            this.lblNoOverdueReader.Margin = new System.Windows.Forms.Padding(0);
            this.lblNoOverdueReader.Name = "lblNoOverdueReader";
            this.lblNoOverdueReader.Size = new System.Drawing.Size(220, 104);
            this.lblNoOverdueReader.TabIndex = 1;
            this.lblNoOverdueReader.Text = "0";
            this.lblNoOverdueReader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOverdueReader
            // 
            this.lblOverdueReader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.lblOverdueReader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOverdueReader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblOverdueReader.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOverdueReader.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblOverdueReader.Location = new System.Drawing.Point(219, 0);
            this.lblOverdueReader.Margin = new System.Windows.Forms.Padding(0);
            this.lblOverdueReader.Name = "lblOverdueReader";
            this.lblOverdueReader.Size = new System.Drawing.Size(220, 68);
            this.lblOverdueReader.TabIndex = 2;
            this.lblOverdueReader.Text = "Quá hạn";
            this.lblOverdueReader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBorrowingReader
            // 
            this.lblBorrowingReader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(60)))), ((int)(((byte)(0)))));
            this.lblBorrowingReader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBorrowingReader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBorrowingReader.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBorrowingReader.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblBorrowingReader.Location = new System.Drawing.Point(0, 0);
            this.lblBorrowingReader.Margin = new System.Windows.Forms.Padding(0);
            this.lblBorrowingReader.Name = "lblBorrowingReader";
            this.lblBorrowingReader.Size = new System.Drawing.Size(219, 68);
            this.lblBorrowingReader.TabIndex = 3;
            this.lblBorrowingReader.Text = "Đang mượn";
            this.lblBorrowingReader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNoBorrowingReader
            // 
            this.lblNoBorrowingReader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(109)))), ((int)(((byte)(0)))));
            this.lblNoBorrowingReader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNoBorrowingReader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNoBorrowingReader.Font = new System.Drawing.Font("Russo One", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoBorrowingReader.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNoBorrowingReader.Location = new System.Drawing.Point(0, 68);
            this.lblNoBorrowingReader.Margin = new System.Windows.Forms.Padding(0);
            this.lblNoBorrowingReader.Name = "lblNoBorrowingReader";
            this.lblNoBorrowingReader.Size = new System.Drawing.Size(219, 104);
            this.lblNoBorrowingReader.TabIndex = 4;
            this.lblNoBorrowingReader.Text = "0";
            this.lblNoBorrowingReader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Controls.Add(this.lblTotalReader, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.lblNoTotalReader, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(439, 112);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // lblTotalReader
            // 
            this.lblTotalReader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(140)))));
            this.lblTotalReader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalReader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTotalReader.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalReader.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTotalReader.Location = new System.Drawing.Point(0, 0);
            this.lblTotalReader.Margin = new System.Windows.Forms.Padding(0);
            this.lblTotalReader.Name = "lblTotalReader";
            this.lblTotalReader.Size = new System.Drawing.Size(439, 44);
            this.lblTotalReader.TabIndex = 13;
            this.lblTotalReader.Text = "Độc giả";
            this.lblTotalReader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNoTotalReader
            // 
            this.lblNoTotalReader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(119)))), ((int)(((byte)(188)))));
            this.lblNoTotalReader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNoTotalReader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNoTotalReader.Font = new System.Drawing.Font("Russo One", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoTotalReader.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNoTotalReader.Location = new System.Drawing.Point(0, 44);
            this.lblNoTotalReader.Margin = new System.Windows.Forms.Padding(0);
            this.lblNoTotalReader.Name = "lblNoTotalReader";
            this.lblNoTotalReader.Size = new System.Drawing.Size(439, 68);
            this.lblNoTotalReader.TabIndex = 12;
            this.lblNoTotalReader.Text = "0";
            this.lblNoTotalReader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 2;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.96009F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.03991F));
            this.tableLayoutPanel9.Controls.Add(this.txtPhoneName, 1, 3);
            this.tableLayoutPanel9.Controls.Add(this.txtEmailName, 1, 2);
            this.tableLayoutPanel9.Controls.Add(this.txtAddressName, 1, 1);
            this.tableLayoutPanel9.Controls.Add(this.lblPhoneTag, 0, 3);
            this.tableLayoutPanel9.Controls.Add(this.lblEmailTag, 0, 2);
            this.tableLayoutPanel9.Controls.Add(this.lblAddressTag, 0, 1);
            this.tableLayoutPanel9.Controls.Add(this.lblLibraryNameTag, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.txtLibraryName, 1, 0);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 4;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(902, 150);
            this.tableLayoutPanel9.TabIndex = 1;
            // 
            // lblPhoneTag
            // 
            this.lblPhoneTag.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPhoneTag.AutoEllipsis = true;
            this.lblPhoneTag.AutoSize = true;
            this.lblPhoneTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneTag.Location = new System.Drawing.Point(3, 111);
            this.lblPhoneTag.Name = "lblPhoneTag";
            this.lblPhoneTag.Size = new System.Drawing.Size(156, 39);
            this.lblPhoneTag.TabIndex = 6;
            this.lblPhoneTag.Text = "Số điện thoại:";
            this.lblPhoneTag.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEmailTag
            // 
            this.lblEmailTag.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmailTag.AutoEllipsis = true;
            this.lblEmailTag.AutoSize = true;
            this.lblEmailTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailTag.Location = new System.Drawing.Point(3, 74);
            this.lblEmailTag.Name = "lblEmailTag";
            this.lblEmailTag.Size = new System.Drawing.Size(156, 37);
            this.lblEmailTag.TabIndex = 4;
            this.lblEmailTag.Text = "Email:";
            this.lblEmailTag.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAddressTag
            // 
            this.lblAddressTag.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAddressTag.AutoEllipsis = true;
            this.lblAddressTag.AutoSize = true;
            this.lblAddressTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressTag.Location = new System.Drawing.Point(3, 37);
            this.lblAddressTag.Name = "lblAddressTag";
            this.lblAddressTag.Size = new System.Drawing.Size(156, 37);
            this.lblAddressTag.TabIndex = 2;
            this.lblAddressTag.Text = "Địa chỉ: ";
            this.lblAddressTag.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLibraryNameTag
            // 
            this.lblLibraryNameTag.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLibraryNameTag.AutoEllipsis = true;
            this.lblLibraryNameTag.AutoSize = true;
            this.lblLibraryNameTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibraryNameTag.Location = new System.Drawing.Point(3, 0);
            this.lblLibraryNameTag.Name = "lblLibraryNameTag";
            this.lblLibraryNameTag.Size = new System.Drawing.Size(156, 37);
            this.lblLibraryNameTag.TabIndex = 0;
            this.lblLibraryNameTag.Text = "Tên thư viện:";
            this.lblLibraryNameTag.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Image = global::New_Library.Properties.Resources.update;
            this.btnEdit.Location = new System.Drawing.Point(977, 40);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(37, 35);
            this.btnEdit.TabIndex = 51;
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtLibraryName
            // 
            this.txtLibraryName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLibraryName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLibraryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.txtLibraryName.Location = new System.Drawing.Point(165, 3);
            this.txtLibraryName.Name = "txtLibraryName";
            this.txtLibraryName.ReadOnly = true;
            this.txtLibraryName.Size = new System.Drawing.Size(734, 31);
            this.txtLibraryName.TabIndex = 7;
            this.txtLibraryName.Text = "THƯ VIỆN CỘNG ĐỒNG";
            // 
            // txtAddressName
            // 
            this.txtAddressName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddressName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAddressName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.txtAddressName.Location = new System.Drawing.Point(165, 40);
            this.txtAddressName.Name = "txtAddressName";
            this.txtAddressName.ReadOnly = true;
            this.txtAddressName.Size = new System.Drawing.Size(734, 31);
            this.txtAddressName.TabIndex = 8;
            this.txtAddressName.Text = "SOMEWHERE";
            // 
            // txtEmailName
            // 
            this.txtEmailName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmailName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEmailName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.txtEmailName.Location = new System.Drawing.Point(165, 77);
            this.txtEmailName.Name = "txtEmailName";
            this.txtEmailName.ReadOnly = true;
            this.txtEmailName.Size = new System.Drawing.Size(734, 31);
            this.txtEmailName.TabIndex = 9;
            this.txtEmailName.Text = "something@emailhost.com";
            // 
            // txtPhoneName
            // 
            this.txtPhoneName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhoneName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPhoneName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.txtPhoneName.Location = new System.Drawing.Point(165, 114);
            this.txtPhoneName.Name = "txtPhoneName";
            this.txtPhoneName.ReadOnly = true;
            this.txtPhoneName.Size = new System.Drawing.Size(734, 31);
            this.txtPhoneName.TabIndex = 10;
            this.txtPhoneName.Text = "19001000";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(1231, 656);
            this.Controls.Add(this.pnlChildForm);
            this.Controls.Add(this.pnlTitleBar);
            this.Controls.Add(this.pnlMenu);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý thư viện";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            this.pnlTitleBar.ResumeLayout(false);
            this.pnlChildForm.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Button btnReceipt;
        private System.Windows.Forms.Button btnReader;
        private System.Windows.Forms.Button btnGenre;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Button btnSignout;
        private System.Windows.Forms.Panel pnlTitleBar;
        private System.Windows.Forms.Panel pnlChildForm;
        private System.Windows.Forms.Button btnTitle;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label lblTotalReader;
        private System.Windows.Forms.Label lblNoTotalReader;
        private System.Windows.Forms.Label lblBorrowingReader;
        private System.Windows.Forms.Label lblNoBorrowingReader;
        private System.Windows.Forms.Label lblNoOverdueReader;
        private System.Windows.Forms.Label lblOverdueReader;
        private System.Windows.Forms.Label lblNoTotalBook;
        private System.Windows.Forms.Label lblTotalBook;
        private System.Windows.Forms.Label lblNoTotalAvailableCopies;
        private System.Windows.Forms.Label lblNoTotalGenres;
        private System.Windows.Forms.Label lblAvailableCopies;
        private System.Windows.Forms.Label lblTotalGenres;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.Label lblLibraryNameTag;
        private System.Windows.Forms.Label lblPhoneTag;
        private System.Windows.Forms.Label lblEmailTag;
        private System.Windows.Forms.Label lblAddressTag;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button btnManagement;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtPhoneName;
        private System.Windows.Forms.TextBox txtEmailName;
        private System.Windows.Forms.TextBox txtAddressName;
        private System.Windows.Forms.TextBox txtLibraryName;
    }
}