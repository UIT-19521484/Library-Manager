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
            this.BorderlessForm = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.tmrSideMenuAnimation = new System.Windows.Forms.Timer(this.components);
            this.DragControl_pnlMenu = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.pnlMenu = new Guna.UI2.WinForms.Guna2Panel();
            this.btnEmployee = new Guna.UI2.WinForms.Guna2Button();
            this.btnReader = new Guna.UI2.WinForms.Guna2Button();
            this.btnBooks = new Guna.UI2.WinForms.Guna2Button();
            this.btnInfo = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnMenu = new Guna.UI2.WinForms.Guna2Button();
            this.ctrboxMinimize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.pnlChildForm = new Guna.UI2.WinForms.Guna2Panel();
            this.rsboxBottom = new Guna.UI2.WinForms.Guna2ResizeBox();
            this.rsboxRight = new Guna.UI2.WinForms.Guna2ResizeBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.ctrboxMaximize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.ctrboxExit = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ResizeBox1 = new Guna.UI2.WinForms.Guna2ResizeBox();
            this.pnlMenu.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BorderlessForm
            // 
            this.BorderlessForm.BorderRadius = 20;
            this.BorderlessForm.ContainerControl = this;
            this.BorderlessForm.DockIndicatorColor = System.Drawing.Color.Gainsboro;
            this.BorderlessForm.TransparentWhileDrag = true;
            // 
            // tmrSideMenuAnimation
            // 
            this.tmrSideMenuAnimation.Interval = 10;
            this.tmrSideMenuAnimation.Tick += new System.EventHandler(this.tmrSideMenuAnimation_Tick);
            // 
            // DragControl_pnlMenu
            // 
            this.DragControl_pnlMenu.ContainerControl = this;
            this.DragControl_pnlMenu.TargetControl = this.pnlMenu;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.pnlMenu.BorderColor = System.Drawing.Color.Black;
            this.pnlMenu.Controls.Add(this.btnEmployee);
            this.pnlMenu.Controls.Add(this.btnReader);
            this.pnlMenu.Controls.Add(this.btnBooks);
            this.pnlMenu.Controls.Add(this.btnInfo);
            this.pnlMenu.Controls.Add(this.guna2Separator1);
            this.pnlMenu.Controls.Add(this.btnLogout);
            this.pnlMenu.Controls.Add(this.guna2Panel2);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.MaximumSize = new System.Drawing.Size(220, 0);
            this.pnlMenu.MinimumSize = new System.Drawing.Size(60, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.ShadowDecoration.Parent = this.pnlMenu;
            this.pnlMenu.Size = new System.Drawing.Size(220, 700);
            this.pnlMenu.TabIndex = 5;
            // 
            // btnEmployee
            // 
            this.btnEmployee.BackColor = System.Drawing.Color.Transparent;
            this.btnEmployee.CheckedState.Parent = this.btnEmployee;
            this.btnEmployee.CustomImages.Parent = this.btnEmployee;
            this.btnEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmployee.FillColor = System.Drawing.Color.Transparent;
            this.btnEmployee.Font = new System.Drawing.Font("Arial", 14.25F);
            this.btnEmployee.ForeColor = System.Drawing.Color.White;
            this.btnEmployee.HoverState.FillColor = System.Drawing.Color.LightSkyBlue;
            this.btnEmployee.HoverState.Parent = this.btnEmployee;
            this.btnEmployee.Image = global::WindowsFormsApp1.Properties.Resources.icons8_employee_64px;
            this.btnEmployee.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnEmployee.ImageSize = new System.Drawing.Size(40, 40);
            this.btnEmployee.Location = new System.Drawing.Point(0, 339);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.PressedColor = System.Drawing.Color.DeepSkyBlue;
            this.btnEmployee.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnEmployee.ShadowDecoration.Parent = this.btnEmployee;
            this.btnEmployee.Size = new System.Drawing.Size(220, 69);
            this.btnEmployee.TabIndex = 4;
            this.btnEmployee.Text = "Nhân viên";
            this.btnEmployee.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnEmployee.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // btnReader
            // 
            this.btnReader.BackColor = System.Drawing.Color.Transparent;
            this.btnReader.CheckedState.Parent = this.btnReader;
            this.btnReader.CustomImages.Parent = this.btnReader;
            this.btnReader.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReader.FillColor = System.Drawing.Color.Transparent;
            this.btnReader.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReader.ForeColor = System.Drawing.Color.White;
            this.btnReader.HoverState.FillColor = System.Drawing.Color.LightSkyBlue;
            this.btnReader.HoverState.Parent = this.btnReader;
            this.btnReader.Image = global::WindowsFormsApp1.Properties.Resources.icons8_reading_64px;
            this.btnReader.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnReader.ImageSize = new System.Drawing.Size(40, 40);
            this.btnReader.Location = new System.Drawing.Point(0, 270);
            this.btnReader.Name = "btnReader";
            this.btnReader.PressedColor = System.Drawing.Color.DeepSkyBlue;
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
            this.btnBooks.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBooks.ForeColor = System.Drawing.Color.White;
            this.btnBooks.HoverState.FillColor = System.Drawing.Color.LightSkyBlue;
            this.btnBooks.HoverState.Parent = this.btnBooks;
            this.btnBooks.Image = global::WindowsFormsApp1.Properties.Resources.icons8_book_stack_64px;
            this.btnBooks.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBooks.ImageSize = new System.Drawing.Size(40, 40);
            this.btnBooks.Location = new System.Drawing.Point(0, 201);
            this.btnBooks.Name = "btnBooks";
            this.btnBooks.PressedColor = System.Drawing.Color.DeepSkyBlue;
            this.btnBooks.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnBooks.ShadowDecoration.Parent = this.btnBooks;
            this.btnBooks.Size = new System.Drawing.Size(220, 69);
            this.btnBooks.TabIndex = 1;
            this.btnBooks.Text = "Sách";
            this.btnBooks.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBooks.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.Color.Transparent;
            this.btnInfo.CheckedState.Parent = this.btnInfo;
            this.btnInfo.CustomImages.Parent = this.btnInfo;
            this.btnInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInfo.FillColor = System.Drawing.Color.Transparent;
            this.btnInfo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo.ForeColor = System.Drawing.Color.White;
            this.btnInfo.HoverState.FillColor = System.Drawing.Color.LightSkyBlue;
            this.btnInfo.HoverState.Parent = this.btnInfo;
            this.btnInfo.Image = global::WindowsFormsApp1.Properties.Resources.icons8_top_menu_64px;
            this.btnInfo.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnInfo.ImageSize = new System.Drawing.Size(40, 40);
            this.btnInfo.Location = new System.Drawing.Point(0, 132);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.PressedColor = System.Drawing.Color.DeepSkyBlue;
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
            this.btnLogout.HoverState.FillColor = System.Drawing.Color.LightSkyBlue;
            this.btnLogout.HoverState.Parent = this.btnLogout;
            this.btnLogout.Image = global::WindowsFormsApp1.Properties.Resources.icons8_sign_out_64px;
            this.btnLogout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogout.ImageSize = new System.Drawing.Size(40, 40);
            this.btnLogout.Location = new System.Drawing.Point(0, 631);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.PressedColor = System.Drawing.Color.DeepSkyBlue;
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
            // ctrboxMinimize
            // 
            this.ctrboxMinimize.BackColor = System.Drawing.Color.Transparent;
            this.ctrboxMinimize.BorderColor = System.Drawing.Color.Transparent;
            this.ctrboxMinimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.ctrboxMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.ctrboxMinimize.FillColor = System.Drawing.Color.Transparent;
            this.ctrboxMinimize.HoverState.Parent = this.ctrboxMinimize;
            this.ctrboxMinimize.IconColor = System.Drawing.Color.Black;
            this.ctrboxMinimize.Location = new System.Drawing.Point(845, 0);
            this.ctrboxMinimize.Name = "ctrboxMinimize";
            this.ctrboxMinimize.ShadowDecoration.Parent = this.ctrboxMinimize;
            this.ctrboxMinimize.Size = new System.Drawing.Size(45, 30);
            this.ctrboxMinimize.TabIndex = 1;
            // 
            // pnlChildForm
            // 
            this.pnlChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChildForm.Location = new System.Drawing.Point(220, 30);
            this.pnlChildForm.Name = "pnlChildForm";
            this.pnlChildForm.ShadowDecoration.Parent = this.pnlChildForm;
            this.pnlChildForm.Size = new System.Drawing.Size(980, 660);
            this.pnlChildForm.TabIndex = 4;
            // 
            // rsboxBottom
            // 
            this.rsboxBottom.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.rsboxBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rsboxBottom.FillColor = System.Drawing.Color.Transparent;
            this.rsboxBottom.ForeColor = System.Drawing.Color.Empty;
            this.rsboxBottom.Location = new System.Drawing.Point(220, 690);
            this.rsboxBottom.Name = "rsboxBottom";
            this.rsboxBottom.Size = new System.Drawing.Size(980, 10);
            this.rsboxBottom.TabIndex = 0;
            this.rsboxBottom.TargetControl = this;
            // 
            // rsboxRight
            // 
            this.rsboxRight.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.rsboxRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.rsboxRight.FillColor = System.Drawing.Color.Transparent;
            this.rsboxRight.ForeColor = System.Drawing.Color.Empty;
            this.rsboxRight.Location = new System.Drawing.Point(1195, 30);
            this.rsboxRight.Name = "rsboxRight";
            this.rsboxRight.Size = new System.Drawing.Size(5, 660);
            this.rsboxRight.TabIndex = 1;
            this.rsboxRight.TargetControl = this;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.ctrboxMinimize);
            this.guna2Panel1.Controls.Add(this.ctrboxMaximize);
            this.guna2Panel1.Controls.Add(this.ctrboxExit);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(220, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(980, 30);
            this.guna2Panel1.TabIndex = 6;
            // 
            // ctrboxMaximize
            // 
            this.ctrboxMaximize.BackColor = System.Drawing.Color.Transparent;
            this.ctrboxMaximize.BorderColor = System.Drawing.Color.Transparent;
            this.ctrboxMaximize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.ctrboxMaximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.ctrboxMaximize.FillColor = System.Drawing.Color.Transparent;
            this.ctrboxMaximize.HoverState.Parent = this.ctrboxMaximize;
            this.ctrboxMaximize.IconColor = System.Drawing.Color.Black;
            this.ctrboxMaximize.Location = new System.Drawing.Point(890, 0);
            this.ctrboxMaximize.Name = "ctrboxMaximize";
            this.ctrboxMaximize.ShadowDecoration.Parent = this.ctrboxMaximize;
            this.ctrboxMaximize.Size = new System.Drawing.Size(45, 30);
            this.ctrboxMaximize.TabIndex = 8;
            // 
            // ctrboxExit
            // 
            this.ctrboxExit.BackColor = System.Drawing.Color.Transparent;
            this.ctrboxExit.BorderColor = System.Drawing.Color.Transparent;
            this.ctrboxExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.ctrboxExit.FillColor = System.Drawing.Color.Transparent;
            this.ctrboxExit.HoverState.FillColor = System.Drawing.Color.Red;
            this.ctrboxExit.HoverState.Parent = this.ctrboxExit;
            this.ctrboxExit.IconColor = System.Drawing.Color.Black;
            this.ctrboxExit.Location = new System.Drawing.Point(935, 0);
            this.ctrboxExit.Name = "ctrboxExit";
            this.ctrboxExit.ShadowDecoration.Parent = this.ctrboxExit;
            this.ctrboxExit.Size = new System.Drawing.Size(45, 30);
            this.ctrboxExit.TabIndex = 9;
            // 
            // guna2ResizeBox1
            // 
            this.guna2ResizeBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ResizeBox1.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.guna2ResizeBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ResizeBox1.ForeColor = System.Drawing.Color.Empty;
            this.guna2ResizeBox1.Location = new System.Drawing.Point(1190, 689);
            this.guna2ResizeBox1.Name = "guna2ResizeBox1";
            this.guna2ResizeBox1.Size = new System.Drawing.Size(10, 10);
            this.guna2ResizeBox1.TabIndex = 0;
            this.guna2ResizeBox1.TargetControl = this;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.guna2ResizeBox1);
            this.Controls.Add(this.rsboxRight);
            this.Controls.Add(this.pnlChildForm);
            this.Controls.Add(this.rsboxBottom);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.pnlMenu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnlMenu.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm BorderlessForm;
        private System.Windows.Forms.Timer tmrSideMenuAnimation;
        private Guna.UI2.WinForms.Guna2DragControl DragControl_pnlMenu;
        private Guna.UI2.WinForms.Guna2ControlBox ctrboxMinimize;
        private Guna.UI2.WinForms.Guna2Panel pnlChildForm;
        private Guna.UI2.WinForms.Guna2Panel pnlMenu;
        private Guna.UI2.WinForms.Guna2Button btnEmployee;
        private Guna.UI2.WinForms.Guna2Button btnReader;
        private Guna.UI2.WinForms.Guna2Button btnBooks;
        private Guna.UI2.WinForms.Guna2Button btnInfo;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button btnMenu;
        private Guna.UI2.WinForms.Guna2ResizeBox rsboxRight;
        private Guna.UI2.WinForms.Guna2ResizeBox rsboxBottom;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ControlBox ctrboxMaximize;
        private Guna.UI2.WinForms.Guna2ControlBox ctrboxExit;
        private Guna.UI2.WinForms.Guna2ResizeBox guna2ResizeBox1;
    }
}