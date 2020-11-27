namespace WindowsFormsApp1
{
    partial class frmDashboard
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
            this.pnlLibraryInfo = new Guna.UI2.WinForms.Guna2Panel();
            this.flpLibraryInfo = new System.Windows.Forms.FlowLayoutPanel();
            this.lblLibraryName = new System.Windows.Forms.Label();
            this.lblLibraryAddress = new System.Windows.Forms.Label();
            this.lblLibraryEmail = new System.Windows.Forms.Label();
            this.lblLibraryPhone = new System.Windows.Forms.Label();
            this.picLibraryIcon = new Guna.UI2.WinForms.Guna2PictureBox();
            this.tlpAvailableCopies = new System.Windows.Forms.TableLayoutPanel();
            this.lblNoAvailableCopies = new System.Windows.Forms.Label();
            this.lblAvailableCopies = new System.Windows.Forms.Label();
            this.tlpTotalCopies = new System.Windows.Forms.TableLayoutPanel();
            this.lblNoTotalCopies = new System.Windows.Forms.Label();
            this.lblTotalCopies = new System.Windows.Forms.Label();
            this.tlpTotalBook = new System.Windows.Forms.TableLayoutPanel();
            this.lblNoTotalBook = new System.Windows.Forms.Label();
            this.lblTotalBook = new System.Windows.Forms.Label();
            this.tlpReader = new System.Windows.Forms.TableLayoutPanel();
            this.lblNoReader = new System.Windows.Forms.Label();
            this.lblReader = new System.Windows.Forms.Label();
            this.tlpOverdue = new System.Windows.Forms.TableLayoutPanel();
            this.lblNoOverdue = new System.Windows.Forms.Label();
            this.lblOverdue = new System.Windows.Forms.Label();
            this.tlpBorrowed = new System.Windows.Forms.TableLayoutPanel();
            this.lblNoBorrowed = new System.Windows.Forms.Label();
            this.lblBorrowed = new System.Windows.Forms.Label();
            this.tlpBorrowing = new System.Windows.Forms.TableLayoutPanel();
            this.lblNoBorrowing = new System.Windows.Forms.Label();
            this.lblBorrowing = new System.Windows.Forms.Label();
            this.pnlLibraryInfo.SuspendLayout();
            this.flpLibraryInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLibraryIcon)).BeginInit();
            this.tlpAvailableCopies.SuspendLayout();
            this.tlpTotalCopies.SuspendLayout();
            this.tlpTotalBook.SuspendLayout();
            this.tlpReader.SuspendLayout();
            this.tlpOverdue.SuspendLayout();
            this.tlpBorrowed.SuspendLayout();
            this.tlpBorrowing.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLibraryInfo
            // 
            this.pnlLibraryInfo.BackColor = System.Drawing.Color.Transparent;
            this.pnlLibraryInfo.BorderColor = System.Drawing.Color.Transparent;
            this.pnlLibraryInfo.Controls.Add(this.flpLibraryInfo);
            this.pnlLibraryInfo.Controls.Add(this.picLibraryIcon);
            this.pnlLibraryInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLibraryInfo.FillColor = System.Drawing.Color.Transparent;
            this.pnlLibraryInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlLibraryInfo.Name = "pnlLibraryInfo";
            this.pnlLibraryInfo.ShadowDecoration.Parent = this.pnlLibraryInfo;
            this.pnlLibraryInfo.Size = new System.Drawing.Size(831, 143);
            this.pnlLibraryInfo.TabIndex = 0;
            // 
            // flpLibraryInfo
            // 
            this.flpLibraryInfo.Controls.Add(this.lblLibraryName);
            this.flpLibraryInfo.Controls.Add(this.lblLibraryAddress);
            this.flpLibraryInfo.Controls.Add(this.lblLibraryEmail);
            this.flpLibraryInfo.Controls.Add(this.lblLibraryPhone);
            this.flpLibraryInfo.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpLibraryInfo.Location = new System.Drawing.Point(171, 13);
            this.flpLibraryInfo.Name = "flpLibraryInfo";
            this.flpLibraryInfo.Size = new System.Drawing.Size(621, 119);
            this.flpLibraryInfo.TabIndex = 1;
            // 
            // lblLibraryName
            // 
            this.lblLibraryName.BackColor = System.Drawing.Color.Transparent;
            this.lblLibraryName.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblLibraryName.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibraryName.Location = new System.Drawing.Point(3, 0);
            this.lblLibraryName.Name = "lblLibraryName";
            this.lblLibraryName.Size = new System.Drawing.Size(618, 37);
            this.lblLibraryName.TabIndex = 0;
            this.lblLibraryName.Text = "Tên thư viện";
            this.lblLibraryName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLibraryAddress
            // 
            this.lblLibraryAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblLibraryAddress.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblLibraryAddress.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibraryAddress.Location = new System.Drawing.Point(3, 37);
            this.lblLibraryAddress.Name = "lblLibraryAddress";
            this.lblLibraryAddress.Size = new System.Drawing.Size(618, 32);
            this.lblLibraryAddress.TabIndex = 2;
            this.lblLibraryAddress.Text = "Địa chỉ";
            // 
            // lblLibraryEmail
            // 
            this.lblLibraryEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblLibraryEmail.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblLibraryEmail.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibraryEmail.Location = new System.Drawing.Point(3, 69);
            this.lblLibraryEmail.Name = "lblLibraryEmail";
            this.lblLibraryEmail.Size = new System.Drawing.Size(618, 25);
            this.lblLibraryEmail.TabIndex = 3;
            this.lblLibraryEmail.Text = "Email";
            this.lblLibraryEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLibraryPhone
            // 
            this.lblLibraryPhone.BackColor = System.Drawing.Color.Transparent;
            this.lblLibraryPhone.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblLibraryPhone.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibraryPhone.Location = new System.Drawing.Point(3, 94);
            this.lblLibraryPhone.Name = "lblLibraryPhone";
            this.lblLibraryPhone.Size = new System.Drawing.Size(618, 25);
            this.lblLibraryPhone.TabIndex = 4;
            this.lblLibraryPhone.Text = "Số điện thoại";
            this.lblLibraryPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picLibraryIcon
            // 
            this.picLibraryIcon.BackColor = System.Drawing.Color.LightGray;
            this.picLibraryIcon.FillColor = System.Drawing.Color.Transparent;
            this.picLibraryIcon.Image = global::WindowsFormsApp1.Properties.Resources.icons8_book_stack_64px;
            this.picLibraryIcon.Location = new System.Drawing.Point(32, 12);
            this.picLibraryIcon.Name = "picLibraryIcon";
            this.picLibraryIcon.ShadowDecoration.Depth = 10;
            this.picLibraryIcon.ShadowDecoration.Enabled = true;
            this.picLibraryIcon.ShadowDecoration.Parent = this.picLibraryIcon;
            this.picLibraryIcon.Size = new System.Drawing.Size(120, 120);
            this.picLibraryIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLibraryIcon.TabIndex = 0;
            this.picLibraryIcon.TabStop = false;
            // 
            // tlpAvailableCopies
            // 
            this.tlpAvailableCopies.AutoSize = true;
            this.tlpAvailableCopies.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpAvailableCopies.ColumnCount = 1;
            this.tlpAvailableCopies.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAvailableCopies.Controls.Add(this.lblNoAvailableCopies, 0, 1);
            this.tlpAvailableCopies.Controls.Add(this.lblAvailableCopies, 0, 0);
            this.tlpAvailableCopies.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tlpAvailableCopies.Location = new System.Drawing.Point(641, 335);
            this.tlpAvailableCopies.Name = "tlpAvailableCopies";
            this.tlpAvailableCopies.RowCount = 2;
            this.tlpAvailableCopies.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpAvailableCopies.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlpAvailableCopies.Size = new System.Drawing.Size(151, 83);
            this.tlpAvailableCopies.TabIndex = 15;
            // 
            // lblNoAvailableCopies
            // 
            this.lblNoAvailableCopies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(82)))));
            this.lblNoAvailableCopies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNoAvailableCopies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNoAvailableCopies.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoAvailableCopies.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNoAvailableCopies.Location = new System.Drawing.Point(0, 33);
            this.lblNoAvailableCopies.Margin = new System.Windows.Forms.Padding(0);
            this.lblNoAvailableCopies.Name = "lblNoAvailableCopies";
            this.lblNoAvailableCopies.Size = new System.Drawing.Size(151, 50);
            this.lblNoAvailableCopies.TabIndex = 1;
            this.lblNoAvailableCopies.Text = "label11";
            this.lblNoAvailableCopies.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAvailableCopies
            // 
            this.lblAvailableCopies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(36)))));
            this.lblAvailableCopies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAvailableCopies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAvailableCopies.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailableCopies.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAvailableCopies.Location = new System.Drawing.Point(0, 0);
            this.lblAvailableCopies.Margin = new System.Windows.Forms.Padding(0);
            this.lblAvailableCopies.Name = "lblAvailableCopies";
            this.lblAvailableCopies.Size = new System.Drawing.Size(151, 33);
            this.lblAvailableCopies.TabIndex = 2;
            this.lblAvailableCopies.Text = "Có thể mượn";
            this.lblAvailableCopies.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpTotalCopies
            // 
            this.tlpTotalCopies.AutoSize = true;
            this.tlpTotalCopies.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpTotalCopies.ColumnCount = 1;
            this.tlpTotalCopies.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTotalCopies.Controls.Add(this.lblNoTotalCopies, 0, 1);
            this.tlpTotalCopies.Controls.Add(this.lblTotalCopies, 0, 0);
            this.tlpTotalCopies.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tlpTotalCopies.Location = new System.Drawing.Point(485, 336);
            this.tlpTotalCopies.Name = "tlpTotalCopies";
            this.tlpTotalCopies.RowCount = 2;
            this.tlpTotalCopies.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpTotalCopies.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlpTotalCopies.Size = new System.Drawing.Size(151, 83);
            this.tlpTotalCopies.TabIndex = 14;
            // 
            // lblNoTotalCopies
            // 
            this.lblNoTotalCopies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(118)))), ((int)(((byte)(22)))));
            this.lblNoTotalCopies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNoTotalCopies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNoTotalCopies.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoTotalCopies.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNoTotalCopies.Location = new System.Drawing.Point(0, 33);
            this.lblNoTotalCopies.Margin = new System.Windows.Forms.Padding(0);
            this.lblNoTotalCopies.Name = "lblNoTotalCopies";
            this.lblNoTotalCopies.Size = new System.Drawing.Size(151, 50);
            this.lblNoTotalCopies.TabIndex = 1;
            this.lblNoTotalCopies.Text = "label9";
            this.lblNoTotalCopies.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalCopies
            // 
            this.lblTotalCopies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(76)))), ((int)(((byte)(0)))));
            this.lblTotalCopies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalCopies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTotalCopies.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCopies.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTotalCopies.Location = new System.Drawing.Point(0, 0);
            this.lblTotalCopies.Margin = new System.Windows.Forms.Padding(0);
            this.lblTotalCopies.Name = "lblTotalCopies";
            this.lblTotalCopies.Size = new System.Drawing.Size(151, 33);
            this.lblTotalCopies.TabIndex = 2;
            this.lblTotalCopies.Text = "Số lượng bản";
            this.lblTotalCopies.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpTotalBook
            // 
            this.tlpTotalBook.AutoSize = true;
            this.tlpTotalBook.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpTotalBook.ColumnCount = 1;
            this.tlpTotalBook.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTotalBook.Controls.Add(this.lblNoTotalBook, 0, 1);
            this.tlpTotalBook.Controls.Add(this.lblTotalBook, 0, 0);
            this.tlpTotalBook.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tlpTotalBook.Location = new System.Drawing.Point(32, 335);
            this.tlpTotalBook.Name = "tlpTotalBook";
            this.tlpTotalBook.RowCount = 2;
            this.tlpTotalBook.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpTotalBook.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlpTotalBook.Size = new System.Drawing.Size(448, 83);
            this.tlpTotalBook.TabIndex = 13;
            // 
            // lblNoTotalBook
            // 
            this.lblNoTotalBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(87)))), ((int)(((byte)(194)))));
            this.lblNoTotalBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNoTotalBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNoTotalBook.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoTotalBook.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNoTotalBook.Location = new System.Drawing.Point(0, 33);
            this.lblNoTotalBook.Margin = new System.Windows.Forms.Padding(0);
            this.lblNoTotalBook.Name = "lblNoTotalBook";
            this.lblNoTotalBook.Size = new System.Drawing.Size(448, 50);
            this.lblNoTotalBook.TabIndex = 1;
            this.lblNoTotalBook.Text = "label7";
            this.lblNoTotalBook.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalBook
            // 
            this.lblTotalBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.lblTotalBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTotalBook.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBook.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTotalBook.Location = new System.Drawing.Point(0, 0);
            this.lblTotalBook.Margin = new System.Windows.Forms.Padding(0);
            this.lblTotalBook.Name = "lblTotalBook";
            this.lblTotalBook.Size = new System.Drawing.Size(448, 33);
            this.lblTotalBook.TabIndex = 2;
            this.lblTotalBook.Text = "Số lượng sách";
            this.lblTotalBook.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpReader
            // 
            this.tlpReader.AutoSize = true;
            this.tlpReader.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpReader.ColumnCount = 1;
            this.tlpReader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpReader.Controls.Add(this.lblNoReader, 0, 1);
            this.tlpReader.Controls.Add(this.lblReader, 0, 0);
            this.tlpReader.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tlpReader.Location = new System.Drawing.Point(32, 246);
            this.tlpReader.Name = "tlpReader";
            this.tlpReader.RowCount = 2;
            this.tlpReader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpReader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlpReader.Size = new System.Drawing.Size(292, 83);
            this.tlpReader.TabIndex = 12;
            // 
            // lblNoReader
            // 
            this.lblNoReader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(119)))), ((int)(((byte)(188)))));
            this.lblNoReader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNoReader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNoReader.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoReader.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNoReader.Location = new System.Drawing.Point(0, 33);
            this.lblNoReader.Margin = new System.Windows.Forms.Padding(0);
            this.lblNoReader.Name = "lblNoReader";
            this.lblNoReader.Size = new System.Drawing.Size(292, 50);
            this.lblNoReader.TabIndex = 1;
            this.lblNoReader.Text = "label5";
            this.lblNoReader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblReader
            // 
            this.lblReader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(140)))));
            this.lblReader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblReader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblReader.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReader.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblReader.Location = new System.Drawing.Point(0, 0);
            this.lblReader.Margin = new System.Windows.Forms.Padding(0);
            this.lblReader.Name = "lblReader";
            this.lblReader.Size = new System.Drawing.Size(292, 33);
            this.lblReader.TabIndex = 2;
            this.lblReader.Text = "Đọc giả";
            this.lblReader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpOverdue
            // 
            this.tlpOverdue.ColumnCount = 1;
            this.tlpOverdue.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpOverdue.Controls.Add(this.lblNoOverdue, 0, 1);
            this.tlpOverdue.Controls.Add(this.lblOverdue, 0, 0);
            this.tlpOverdue.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tlpOverdue.Location = new System.Drawing.Point(564, 159);
            this.tlpOverdue.Name = "tlpOverdue";
            this.tlpOverdue.RowCount = 2;
            this.tlpOverdue.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpOverdue.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlpOverdue.Size = new System.Drawing.Size(228, 170);
            this.tlpOverdue.TabIndex = 11;
            // 
            // lblNoOverdue
            // 
            this.lblNoOverdue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNoOverdue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNoOverdue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNoOverdue.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoOverdue.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNoOverdue.Location = new System.Drawing.Point(0, 68);
            this.lblNoOverdue.Margin = new System.Windows.Forms.Padding(0);
            this.lblNoOverdue.Name = "lblNoOverdue";
            this.lblNoOverdue.Size = new System.Drawing.Size(228, 102);
            this.lblNoOverdue.TabIndex = 1;
            this.lblNoOverdue.Text = "label3";
            this.lblNoOverdue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOverdue
            // 
            this.lblOverdue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.lblOverdue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOverdue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblOverdue.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOverdue.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblOverdue.Location = new System.Drawing.Point(0, 0);
            this.lblOverdue.Margin = new System.Windows.Forms.Padding(0);
            this.lblOverdue.Name = "lblOverdue";
            this.lblOverdue.Size = new System.Drawing.Size(228, 68);
            this.lblOverdue.TabIndex = 2;
            this.lblOverdue.Text = "Quá hạn";
            this.lblOverdue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpBorrowed
            // 
            this.tlpBorrowed.AutoSize = true;
            this.tlpBorrowed.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpBorrowed.ColumnCount = 1;
            this.tlpBorrowed.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBorrowed.Controls.Add(this.lblNoBorrowed, 0, 1);
            this.tlpBorrowed.Controls.Add(this.lblBorrowed, 0, 0);
            this.tlpBorrowed.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tlpBorrowed.Location = new System.Drawing.Point(32, 160);
            this.tlpBorrowed.Name = "tlpBorrowed";
            this.tlpBorrowed.RowCount = 2;
            this.tlpBorrowed.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpBorrowed.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlpBorrowed.Size = new System.Drawing.Size(292, 83);
            this.tlpBorrowed.TabIndex = 9;
            // 
            // lblNoBorrowed
            // 
            this.lblNoBorrowed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(123)))));
            this.lblNoBorrowed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNoBorrowed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNoBorrowed.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoBorrowed.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNoBorrowed.Location = new System.Drawing.Point(0, 33);
            this.lblNoBorrowed.Margin = new System.Windows.Forms.Padding(0);
            this.lblNoBorrowed.Name = "lblNoBorrowed";
            this.lblNoBorrowed.Size = new System.Drawing.Size(292, 50);
            this.lblNoBorrowed.TabIndex = 1;
            this.lblNoBorrowed.Text = "label3";
            this.lblNoBorrowed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBorrowed
            // 
            this.lblBorrowed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(91)))), ((int)(((byte)(79)))));
            this.lblBorrowed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBorrowed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBorrowed.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBorrowed.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblBorrowed.Location = new System.Drawing.Point(0, 0);
            this.lblBorrowed.Margin = new System.Windows.Forms.Padding(0);
            this.lblBorrowed.Name = "lblBorrowed";
            this.lblBorrowed.Size = new System.Drawing.Size(292, 33);
            this.lblBorrowed.TabIndex = 2;
            this.lblBorrowed.Text = "Lượt mượn sách";
            this.lblBorrowed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpBorrowing
            // 
            this.tlpBorrowing.ColumnCount = 1;
            this.tlpBorrowing.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBorrowing.Controls.Add(this.lblNoBorrowing, 0, 1);
            this.tlpBorrowing.Controls.Add(this.lblBorrowing, 0, 0);
            this.tlpBorrowing.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tlpBorrowing.Location = new System.Drawing.Point(330, 159);
            this.tlpBorrowing.Name = "tlpBorrowing";
            this.tlpBorrowing.RowCount = 2;
            this.tlpBorrowing.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpBorrowing.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlpBorrowing.Size = new System.Drawing.Size(228, 170);
            this.tlpBorrowing.TabIndex = 16;
            // 
            // lblNoBorrowing
            // 
            this.lblNoBorrowing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(109)))), ((int)(((byte)(0)))));
            this.lblNoBorrowing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNoBorrowing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNoBorrowing.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoBorrowing.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNoBorrowing.Location = new System.Drawing.Point(0, 68);
            this.lblNoBorrowing.Margin = new System.Windows.Forms.Padding(0);
            this.lblNoBorrowing.Name = "lblNoBorrowing";
            this.lblNoBorrowing.Size = new System.Drawing.Size(228, 102);
            this.lblNoBorrowing.TabIndex = 1;
            this.lblNoBorrowing.Text = "label3";
            this.lblNoBorrowing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBorrowing
            // 
            this.lblBorrowing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(60)))), ((int)(((byte)(0)))));
            this.lblBorrowing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBorrowing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBorrowing.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBorrowing.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblBorrowing.Location = new System.Drawing.Point(0, 0);
            this.lblBorrowing.Margin = new System.Windows.Forms.Padding(0);
            this.lblBorrowing.Name = "lblBorrowing";
            this.lblBorrowing.Size = new System.Drawing.Size(228, 68);
            this.lblBorrowing.TabIndex = 2;
            this.lblBorrowing.Text = "Đang mượn";
            this.lblBorrowing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(831, 460);
            this.ControlBox = false;
            this.Controls.Add(this.tlpBorrowing);
            this.Controls.Add(this.tlpAvailableCopies);
            this.Controls.Add(this.tlpReader);
            this.Controls.Add(this.tlpTotalCopies);
            this.Controls.Add(this.tlpBorrowed);
            this.Controls.Add(this.tlpTotalBook);
            this.Controls.Add(this.tlpOverdue);
            this.Controls.Add(this.pnlLibraryInfo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDashboard";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "frmDashboard";
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            this.pnlLibraryInfo.ResumeLayout(false);
            this.flpLibraryInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLibraryIcon)).EndInit();
            this.tlpAvailableCopies.ResumeLayout(false);
            this.tlpTotalCopies.ResumeLayout(false);
            this.tlpTotalBook.ResumeLayout(false);
            this.tlpReader.ResumeLayout(false);
            this.tlpOverdue.ResumeLayout(false);
            this.tlpBorrowed.ResumeLayout(false);
            this.tlpBorrowing.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlLibraryInfo;
        private Guna.UI2.WinForms.Guna2PictureBox picLibraryIcon;
        private System.Windows.Forms.TableLayoutPanel tlpAvailableCopies;
        private System.Windows.Forms.Label lblNoAvailableCopies;
        private System.Windows.Forms.Label lblAvailableCopies;
        private System.Windows.Forms.TableLayoutPanel tlpTotalCopies;
        private System.Windows.Forms.Label lblNoTotalCopies;
        private System.Windows.Forms.Label lblTotalCopies;
        private System.Windows.Forms.TableLayoutPanel tlpTotalBook;
        private System.Windows.Forms.Label lblNoTotalBook;
        private System.Windows.Forms.Label lblTotalBook;
        private System.Windows.Forms.TableLayoutPanel tlpReader;
        private System.Windows.Forms.Label lblNoReader;
        private System.Windows.Forms.Label lblReader;
        private System.Windows.Forms.TableLayoutPanel tlpOverdue;
        private System.Windows.Forms.Label lblNoOverdue;
        private System.Windows.Forms.Label lblOverdue;
        private System.Windows.Forms.TableLayoutPanel tlpBorrowed;
        private System.Windows.Forms.Label lblNoBorrowed;
        private System.Windows.Forms.Label lblBorrowed;
        private System.Windows.Forms.FlowLayoutPanel flpLibraryInfo;
        private System.Windows.Forms.Label lblLibraryName;
        private System.Windows.Forms.Label lblLibraryAddress;
        private System.Windows.Forms.Label lblLibraryEmail;
        private System.Windows.Forms.Label lblLibraryPhone;
        private System.Windows.Forms.TableLayoutPanel tlpBorrowing;
        private System.Windows.Forms.Label lblNoBorrowing;
        private System.Windows.Forms.Label lblBorrowing;
    }
}