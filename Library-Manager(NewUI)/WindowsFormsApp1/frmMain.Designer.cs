using System.Windows.Forms;

namespace WindowsFormsApp1
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
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED       
                return handleParam;
            }
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tmrSideMenuAnimation = new System.Windows.Forms.Timer(this.components);
            this.DragControl_pnlMenu = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.pnlMenu = new Guna.UI2.WinForms.Guna2Panel();
            this.btnGenre = new Guna.UI2.WinForms.Guna2Button();
            this.btnBill = new Guna.UI2.WinForms.Guna2Button();
            this.btnReader = new Guna.UI2.WinForms.Guna2Button();
            this.btnBooks = new Guna.UI2.WinForms.Guna2Button();
            this.btnInfo = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnMenu = new Guna.UI2.WinForms.Guna2Button();
            this.pnlChildForm = new Guna.UI2.WinForms.Guna2Panel();
            this.rsboxBottom = new Guna.UI2.WinForms.Guna2ResizeBox();
            this.rsboxRight = new Guna.UI2.WinForms.Guna2ResizeBox();
            this.rsboxBR = new Guna.UI2.WinForms.Guna2ResizeBox();
            this.ctrboxExit = new Guna.UI2.WinForms.Guna2ControlBox();
            this.ctrboxMaximize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.ctrboxMinimize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.DragControl_pnlTopBar = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.pnlTopBar = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.btnStaff = new Guna.UI2.WinForms.Guna2Button();
            this.pnlMenu.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.pnlTopBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrSideMenuAnimation
            // 
            this.tmrSideMenuAnimation.Interval = 5;
            this.tmrSideMenuAnimation.Tick += new System.EventHandler(this.tmrSideMenuAnimation_Tick);
            // 
            // DragControl_pnlMenu
            // 
            this.DragControl_pnlMenu.ContainerControl = this;
            this.DragControl_pnlMenu.TargetControl = this.pnlMenu;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(69)))), ((int)(((byte)(92)))));
            this.pnlMenu.BorderColor = System.Drawing.Color.Black;
            this.pnlMenu.Controls.Add(this.btnStaff);
            this.pnlMenu.Controls.Add(this.btnGenre);
            this.pnlMenu.Controls.Add(this.btnBill);
            this.pnlMenu.Controls.Add(this.btnReader);
            this.pnlMenu.Controls.Add(this.btnBooks);
            this.pnlMenu.Controls.Add(this.btnInfo);
            this.pnlMenu.Controls.Add(this.guna2Separator1);
            this.pnlMenu.Controls.Add(this.btnLogout);
            this.pnlMenu.Controls.Add(this.guna2Panel2);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(69)))), ((int)(((byte)(92)))));
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.MaximumSize = new System.Drawing.Size(220, 0);
            this.pnlMenu.MinimumSize = new System.Drawing.Size(60, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.ShadowDecoration.Parent = this.pnlMenu;
            this.pnlMenu.Size = new System.Drawing.Size(220, 700);
            this.pnlMenu.TabIndex = 5;
            // 
            // btnGenre
            // 
            this.btnGenre.BackColor = System.Drawing.Color.Transparent;
            this.btnGenre.CheckedState.Parent = this.btnGenre;
            this.btnGenre.CustomImages.Parent = this.btnGenre;
            this.btnGenre.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGenre.FillColor = System.Drawing.Color.Transparent;
            this.btnGenre.Font = new System.Drawing.Font("Arial", 14.25F);
            this.btnGenre.ForeColor = System.Drawing.Color.White;
            this.btnGenre.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.btnGenre.HoverState.Parent = this.btnGenre;
            this.btnGenre.Image = global::WindowsFormsApp1.Properties.Resources.icons8_books_64px;
            this.btnGenre.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnGenre.ImageSize = new System.Drawing.Size(40, 40);
            this.btnGenre.IndicateFocus = true;
            this.btnGenre.Location = new System.Drawing.Point(0, 408);
            this.btnGenre.Name = "btnGenre";
            this.btnGenre.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(124)))), ((int)(((byte)(145)))));
            this.btnGenre.PressedDepth = 50;
            this.btnGenre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnGenre.ShadowDecoration.Parent = this.btnGenre;
            this.btnGenre.Size = new System.Drawing.Size(220, 69);
            this.btnGenre.TabIndex = 7;
            this.btnGenre.Text = "Thể loại";
            this.btnGenre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnGenre.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // btnBill
            // 
            this.btnBill.BackColor = System.Drawing.Color.Transparent;
            this.btnBill.CheckedState.Parent = this.btnBill;
            this.btnBill.CustomImages.Parent = this.btnBill;
            this.btnBill.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBill.FillColor = System.Drawing.Color.Transparent;
            this.btnBill.Font = new System.Drawing.Font("Arial", 14.25F);
            this.btnBill.ForeColor = System.Drawing.Color.White;
            this.btnBill.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.btnBill.HoverState.Parent = this.btnBill;
            this.btnBill.Image = global::WindowsFormsApp1.Properties.Resources.icons8_bill_64px;
            this.btnBill.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBill.ImageSize = new System.Drawing.Size(40, 40);
            this.btnBill.IndicateFocus = true;
            this.btnBill.Location = new System.Drawing.Point(0, 339);
            this.btnBill.Name = "btnBill";
            this.btnBill.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(124)))), ((int)(((byte)(145)))));
            this.btnBill.PressedDepth = 50;
            this.btnBill.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnBill.ShadowDecoration.Parent = this.btnBill;
            this.btnBill.Size = new System.Drawing.Size(220, 69);
            this.btnBill.TabIndex = 6;
            this.btnBill.Text = "Mượn/trả sách";
            this.btnBill.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBill.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // btnReader
            // 
            this.btnReader.BackColor = System.Drawing.Color.Transparent;
            this.btnReader.CheckedState.Parent = this.btnReader;
            this.btnReader.CustomImages.Parent = this.btnReader;
            this.btnReader.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReader.FillColor = System.Drawing.Color.Transparent;
            this.btnReader.Font = new System.Drawing.Font("Arial", 14.25F);
            this.btnReader.ForeColor = System.Drawing.Color.White;
            this.btnReader.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.btnReader.HoverState.Parent = this.btnReader;
            this.btnReader.Image = global::WindowsFormsApp1.Properties.Resources.icons8_reading_64px;
            this.btnReader.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnReader.ImageSize = new System.Drawing.Size(40, 40);
            this.btnReader.IndicateFocus = true;
            this.btnReader.Location = new System.Drawing.Point(0, 270);
            this.btnReader.Name = "btnReader";
            this.btnReader.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(124)))), ((int)(((byte)(145)))));
            this.btnReader.PressedDepth = 50;
            this.btnReader.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnReader.ShadowDecoration.Parent = this.btnReader;
            this.btnReader.Size = new System.Drawing.Size(220, 69);
            this.btnReader.TabIndex = 2;
            this.btnReader.Text = "Đọc giả";
            this.btnReader.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnReader.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // btnBooks
            // 
            this.btnBooks.BackColor = System.Drawing.Color.Transparent;
            this.btnBooks.CheckedState.Parent = this.btnBooks;
            this.btnBooks.CustomImages.Parent = this.btnBooks;
            this.btnBooks.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBooks.FillColor = System.Drawing.Color.Transparent;
            this.btnBooks.Font = new System.Drawing.Font("Arial", 14.25F);
            this.btnBooks.ForeColor = System.Drawing.Color.White;
            this.btnBooks.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.btnBooks.HoverState.Parent = this.btnBooks;
            this.btnBooks.Image = global::WindowsFormsApp1.Properties.Resources.icons8_book_stack_64px;
            this.btnBooks.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBooks.ImageSize = new System.Drawing.Size(40, 40);
            this.btnBooks.IndicateFocus = true;
            this.btnBooks.Location = new System.Drawing.Point(0, 201);
            this.btnBooks.Name = "btnBooks";
            this.btnBooks.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(124)))), ((int)(((byte)(145)))));
            this.btnBooks.PressedDepth = 50;
            this.btnBooks.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnBooks.ShadowDecoration.Parent = this.btnBooks;
            this.btnBooks.Size = new System.Drawing.Size(220, 69);
            this.btnBooks.TabIndex = 1;
            this.btnBooks.Text = "Sách";
            this.btnBooks.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBooks.TextOffset = new System.Drawing.Point(10, 0);
            this.btnBooks.Click += new System.EventHandler(this.btnBooks_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.Color.Transparent;
            this.btnInfo.CheckedState.Parent = this.btnInfo;
            this.btnInfo.CustomImages.Parent = this.btnInfo;
            this.btnInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInfo.FillColor = System.Drawing.Color.Transparent;
            this.btnInfo.Font = new System.Drawing.Font("Arial", 14.25F);
            this.btnInfo.ForeColor = System.Drawing.Color.White;
            this.btnInfo.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.btnInfo.HoverState.Parent = this.btnInfo;
            this.btnInfo.Image = global::WindowsFormsApp1.Properties.Resources.icons8_top_menu_64px;
            this.btnInfo.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnInfo.ImageSize = new System.Drawing.Size(40, 40);
            this.btnInfo.IndicateFocus = true;
            this.btnInfo.Location = new System.Drawing.Point(0, 132);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(124)))), ((int)(((byte)(145)))));
            this.btnInfo.PressedDepth = 50;
            this.btnInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnInfo.ShadowDecoration.Parent = this.btnInfo;
            this.btnInfo.Size = new System.Drawing.Size(220, 69);
            this.btnInfo.TabIndex = 0;
            this.btnInfo.Text = "Thông tin";
            this.btnInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnInfo.TextOffset = new System.Drawing.Point(10, 0);
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Separator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Separator1.FillColor = System.Drawing.Color.White;
            this.guna2Separator1.FillThickness = 2;
            this.guna2Separator1.Location = new System.Drawing.Point(0, 621);
            this.guna2Separator1.Margin = new System.Windows.Forms.Padding(0);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(220, 10);
            this.guna2Separator1.TabIndex = 5;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.CheckedState.Parent = this.btnLogout;
            this.btnLogout.CustomImages.Parent = this.btnLogout;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FillColor = System.Drawing.Color.Transparent;
            this.btnLogout.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.btnLogout.HoverState.Parent = this.btnLogout;
            this.btnLogout.Image = global::WindowsFormsApp1.Properties.Resources.icons8_sign_out_64px;
            this.btnLogout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogout.ImageSize = new System.Drawing.Size(40, 40);
            this.btnLogout.Location = new System.Drawing.Point(0, 631);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(59)))), ((int)(((byte)(79)))));
            this.btnLogout.PressedDepth = 100;
            this.btnLogout.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnLogout.ShadowDecoration.Parent = this.btnLogout;
            this.btnLogout.Size = new System.Drawing.Size(220, 69);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogout.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.Controls.Add(this.btnMenu);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(220, 132);
            this.guna2Panel2.TabIndex = 0;
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnMenu.CheckedState.Parent = this.btnMenu;
            this.btnMenu.CustomImages.Parent = this.btnMenu;
            this.btnMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenu.FillColor = System.Drawing.Color.Transparent;
            this.btnMenu.Font = new System.Drawing.Font("Arial", 14.25F);
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.HoverState.FillColor = System.Drawing.Color.LightSkyBlue;
            this.btnMenu.HoverState.Parent = this.btnMenu;
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnMenu.ImageSize = new System.Drawing.Size(40, 40);
            this.btnMenu.Location = new System.Drawing.Point(0, 0);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.PressedColor = System.Drawing.Color.DeepSkyBlue;
            this.btnMenu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnMenu.ShadowDecoration.Parent = this.btnMenu;
            this.btnMenu.Size = new System.Drawing.Size(220, 45);
            this.btnMenu.TabIndex = 6;
            this.btnMenu.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // pnlChildForm
            // 
            this.pnlChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChildForm.Location = new System.Drawing.Point(230, 30);
            this.pnlChildForm.Name = "pnlChildForm";
            this.pnlChildForm.ShadowDecoration.Parent = this.pnlChildForm;
            this.pnlChildForm.Size = new System.Drawing.Size(1070, 665);
            this.pnlChildForm.TabIndex = 4;
            // 
            // rsboxBottom
            // 
            this.rsboxBottom.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.rsboxBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rsboxBottom.FillColor = System.Drawing.Color.Transparent;
            this.rsboxBottom.ForeColor = System.Drawing.Color.Empty;
            this.rsboxBottom.Location = new System.Drawing.Point(220, 695);
            this.rsboxBottom.Name = "rsboxBottom";
            this.rsboxBottom.Size = new System.Drawing.Size(1080, 5);
            this.rsboxBottom.TabIndex = 0;
            this.rsboxBottom.TargetControl = this;
            // 
            // rsboxRight
            // 
            this.rsboxRight.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.rsboxRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.rsboxRight.FillColor = System.Drawing.Color.Transparent;
            this.rsboxRight.ForeColor = System.Drawing.Color.Empty;
            this.rsboxRight.Location = new System.Drawing.Point(1295, 30);
            this.rsboxRight.Name = "rsboxRight";
            this.rsboxRight.Size = new System.Drawing.Size(5, 665);
            this.rsboxRight.TabIndex = 1;
            this.rsboxRight.TargetControl = this;
            // 
            // rsboxBR
            // 
            this.rsboxBR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rsboxBR.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.rsboxBR.FillColor = System.Drawing.Color.Transparent;
            this.rsboxBR.ForeColor = System.Drawing.Color.Empty;
            this.rsboxBR.Location = new System.Drawing.Point(1290, 689);
            this.rsboxBR.Name = "rsboxBR";
            this.rsboxBR.Size = new System.Drawing.Size(10, 10);
            this.rsboxBR.TabIndex = 0;
            this.rsboxBR.TargetControl = this;
            // 
            // ctrboxExit
            // 
            this.ctrboxExit.BackColor = System.Drawing.Color.White;
            this.ctrboxExit.BorderColor = System.Drawing.Color.White;
            this.ctrboxExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.ctrboxExit.FillColor = System.Drawing.Color.White;
            this.ctrboxExit.HoverState.FillColor = System.Drawing.Color.Red;
            this.ctrboxExit.HoverState.Parent = this.ctrboxExit;
            this.ctrboxExit.IconColor = System.Drawing.Color.Black;
            this.ctrboxExit.Location = new System.Drawing.Point(1025, 0);
            this.ctrboxExit.Name = "ctrboxExit";
            this.ctrboxExit.ShadowDecoration.Parent = this.ctrboxExit;
            this.ctrboxExit.Size = new System.Drawing.Size(45, 30);
            this.ctrboxExit.TabIndex = 9;
            // 
            // ctrboxMaximize
            // 
            this.ctrboxMaximize.BackColor = System.Drawing.Color.White;
            this.ctrboxMaximize.BorderColor = System.Drawing.Color.White;
            this.ctrboxMaximize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.ctrboxMaximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.ctrboxMaximize.FillColor = System.Drawing.Color.White;
            this.ctrboxMaximize.HoverState.Parent = this.ctrboxMaximize;
            this.ctrboxMaximize.IconColor = System.Drawing.Color.Black;
            this.ctrboxMaximize.Location = new System.Drawing.Point(980, 0);
            this.ctrboxMaximize.Name = "ctrboxMaximize";
            this.ctrboxMaximize.ShadowDecoration.Parent = this.ctrboxMaximize;
            this.ctrboxMaximize.Size = new System.Drawing.Size(45, 30);
            this.ctrboxMaximize.TabIndex = 8;
            // 
            // ctrboxMinimize
            // 
            this.ctrboxMinimize.BackColor = System.Drawing.Color.White;
            this.ctrboxMinimize.BorderColor = System.Drawing.Color.White;
            this.ctrboxMinimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.ctrboxMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.ctrboxMinimize.FillColor = System.Drawing.Color.White;
            this.ctrboxMinimize.HoverState.Parent = this.ctrboxMinimize;
            this.ctrboxMinimize.IconColor = System.Drawing.Color.Black;
            this.ctrboxMinimize.Location = new System.Drawing.Point(935, 0);
            this.ctrboxMinimize.Name = "ctrboxMinimize";
            this.ctrboxMinimize.ShadowDecoration.Parent = this.ctrboxMinimize;
            this.ctrboxMinimize.Size = new System.Drawing.Size(45, 30);
            this.ctrboxMinimize.TabIndex = 1;
            // 
            // DragControl_pnlTopBar
            // 
            this.DragControl_pnlTopBar.ContainerControl = this;
            this.DragControl_pnlTopBar.TargetControl = this.pnlTopBar;
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.Controls.Add(this.ctrboxMinimize);
            this.pnlTopBar.Controls.Add(this.ctrboxMaximize);
            this.pnlTopBar.Controls.Add(this.ctrboxExit);
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.Location = new System.Drawing.Point(230, 0);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.ShadowDecoration.Parent = this.pnlTopBar;
            this.pnlTopBar.Size = new System.Drawing.Size(1070, 30);
            this.pnlTopBar.TabIndex = 6;
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.guna2VSeparator1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2VSeparator1.FillColor = System.Drawing.Color.Transparent;
            this.guna2VSeparator1.Location = new System.Drawing.Point(220, 0);
            this.guna2VSeparator1.Margin = new System.Windows.Forms.Padding(0);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(10, 695);
            this.guna2VSeparator1.TabIndex = 7;
            // 
            // btnStaff
            // 
            this.btnStaff.BackColor = System.Drawing.Color.Transparent;
            this.btnStaff.CheckedState.Parent = this.btnStaff;
            this.btnStaff.CustomImages.Parent = this.btnStaff;
            this.btnStaff.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStaff.FillColor = System.Drawing.Color.Transparent;
            this.btnStaff.Font = new System.Drawing.Font("Arial", 14.25F);
            this.btnStaff.ForeColor = System.Drawing.Color.White;
            this.btnStaff.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(55)))), ((int)(((byte)(97)))));
            this.btnStaff.HoverState.Parent = this.btnStaff;
            this.btnStaff.Image = global::WindowsFormsApp1.Properties.Resources.icons8_employee_64px;
            this.btnStaff.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnStaff.ImageSize = new System.Drawing.Size(40, 40);
            this.btnStaff.IndicateFocus = true;
            this.btnStaff.Location = new System.Drawing.Point(0, 477);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(124)))), ((int)(((byte)(145)))));
            this.btnStaff.PressedDepth = 50;
            this.btnStaff.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnStaff.ShadowDecoration.Parent = this.btnStaff;
            this.btnStaff.Size = new System.Drawing.Size(220, 69);
            this.btnStaff.TabIndex = 8;
            this.btnStaff.Text = "Nhân viên";
            this.btnStaff.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnStaff.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.rsboxRight);
            this.Controls.Add(this.pnlChildForm);
            this.Controls.Add(this.pnlTopBar);
            this.Controls.Add(this.guna2VSeparator1);
            this.Controls.Add(this.rsboxBR);
            this.Controls.Add(this.rsboxBottom);
            this.Controls.Add(this.pnlMenu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnlMenu.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.pnlTopBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer tmrSideMenuAnimation;
        private Guna.UI2.WinForms.Guna2DragControl DragControl_pnlMenu;
        private Guna.UI2.WinForms.Guna2Panel pnlChildForm;
        private Guna.UI2.WinForms.Guna2Panel pnlMenu;
        private Guna.UI2.WinForms.Guna2Button btnReader;
        private Guna.UI2.WinForms.Guna2Button btnBooks;
        private Guna.UI2.WinForms.Guna2Button btnInfo;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button btnMenu;
        private Guna.UI2.WinForms.Guna2ResizeBox rsboxRight;
        private Guna.UI2.WinForms.Guna2ResizeBox rsboxBottom;
        private Guna.UI2.WinForms.Guna2ResizeBox rsboxBR;
        private Guna.UI2.WinForms.Guna2ControlBox ctrboxMinimize;
        private Guna.UI2.WinForms.Guna2ControlBox ctrboxMaximize;
        private Guna.UI2.WinForms.Guna2ControlBox ctrboxExit;
        private Guna.UI2.WinForms.Guna2DragControl DragControl_pnlTopBar;
        private Guna.UI2.WinForms.Guna2Panel pnlTopBar;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private Guna.UI2.WinForms.Guna2Button btnGenre;
        private Guna.UI2.WinForms.Guna2Button btnBill;
        private Guna.UI2.WinForms.Guna2Button btnStaff;
    }
}