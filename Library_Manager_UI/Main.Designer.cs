namespace Library_Manager_UI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiBackup = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRestore = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiInformation = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBooks = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGenres = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiReaders = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBorrowedBooks = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiReturnedBooks = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiPersonel = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiIntroduction = new System.Windows.Forms.ToolStripMenuItem();
            this.picGenres = new System.Windows.Forms.PictureBox();
            this.picReaders = new System.Windows.Forms.PictureBox();
            this.picBooks = new System.Windows.Forms.PictureBox();
            this.grpInformation = new System.Windows.Forms.GroupBox();
            this.lblReaders = new System.Windows.Forms.Label();
            this.lblGenres = new System.Windows.Forms.Label();
            this.lblBooks = new System.Windows.Forms.Label();
            this.grpManagement = new System.Windows.Forms.GroupBox();
            this.lblPersonel = new System.Windows.Forms.Label();
            this.picPersonel = new System.Windows.Forms.PictureBox();
            this.lblReturnedBooks = new System.Windows.Forms.Label();
            this.lblBorrowedBooks = new System.Windows.Forms.Label();
            this.picReturnedBooks = new System.Windows.Forms.PictureBox();
            this.picBorrowedBooks = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGenres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReaders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBooks)).BeginInit();
            this.grpInformation.SuspendLayout();
            this.grpManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPersonel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReturnedBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBorrowedBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSystem,
            this.tsmiInformation,
            this.tsmiManagement,
            this.tsmiHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(564, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiSystem
            // 
            this.tsmiSystem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiChangePassword,
            this.toolStripSeparator1,
            this.tsmiBackup,
            this.tsmiRestore,
            this.toolStripSeparator4,
            this.tsmiLogout,
            this.tsmiExit});
            this.tsmiSystem.Name = "tsmiSystem";
            this.tsmiSystem.Size = new System.Drawing.Size(71, 20);
            this.tsmiSystem.Text = "Hệ Thống";
            // 
            // tsmiChangePassword
            // 
            this.tsmiChangePassword.Name = "tsmiChangePassword";
            this.tsmiChangePassword.Size = new System.Drawing.Size(180, 22);
            this.tsmiChangePassword.Text = "Đổi Mật Khẩu";
            this.tsmiChangePassword.Click += new System.EventHandler(this.tsmiChangePassword_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // tsmiBackup
            // 
            this.tsmiBackup.Name = "tsmiBackup";
            this.tsmiBackup.Size = new System.Drawing.Size(180, 22);
            this.tsmiBackup.Text = "Backup";
            // 
            // tsmiRestore
            // 
            this.tsmiRestore.Name = "tsmiRestore";
            this.tsmiRestore.Size = new System.Drawing.Size(180, 22);
            this.tsmiRestore.Text = "Restore";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(177, 6);
            // 
            // tsmiLogout
            // 
            this.tsmiLogout.Name = "tsmiLogout";
            this.tsmiLogout.Size = new System.Drawing.Size(180, 22);
            this.tsmiLogout.Text = "Đăng Xuất";
            this.tsmiLogout.Click += new System.EventHandler(this.tsmiLogout_Click);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.tsmiExit.Size = new System.Drawing.Size(180, 22);
            this.tsmiExit.Text = "Thoát";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // tsmiInformation
            // 
            this.tsmiInformation.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiBooks,
            this.tsmiGenres,
            this.toolStripSeparator2,
            this.tsmiReaders});
            this.tsmiInformation.Name = "tsmiInformation";
            this.tsmiInformation.Size = new System.Drawing.Size(72, 20);
            this.tsmiInformation.Text = "Thông Tin";
            // 
            // tsmiBooks
            // 
            this.tsmiBooks.Name = "tsmiBooks";
            this.tsmiBooks.Size = new System.Drawing.Size(180, 22);
            this.tsmiBooks.Text = "Sách";
            this.tsmiBooks.Click += new System.EventHandler(this.tsmiBooks_Click);
            // 
            // tsmiGenres
            // 
            this.tsmiGenres.Name = "tsmiGenres";
            this.tsmiGenres.Size = new System.Drawing.Size(180, 22);
            this.tsmiGenres.Text = "Thể Loại Sách";
            this.tsmiGenres.Click += new System.EventHandler(this.tsmiGenres_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // tsmiReaders
            // 
            this.tsmiReaders.Name = "tsmiReaders";
            this.tsmiReaders.Size = new System.Drawing.Size(180, 22);
            this.tsmiReaders.Text = "Độc Giả";
            this.tsmiReaders.Click += new System.EventHandler(this.tsmiReaders_Click);
            // 
            // tsmiManagement
            // 
            this.tsmiManagement.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiBorrowedBooks,
            this.tsmiReturnedBooks,
            this.toolStripSeparator3,
            this.tsmiPersonel});
            this.tsmiManagement.Name = "tsmiManagement";
            this.tsmiManagement.Size = new System.Drawing.Size(62, 20);
            this.tsmiManagement.Text = "Quản Lý";
            // 
            // tsmiBorrowedBooks
            // 
            this.tsmiBorrowedBooks.Name = "tsmiBorrowedBooks";
            this.tsmiBorrowedBooks.Size = new System.Drawing.Size(134, 22);
            this.tsmiBorrowedBooks.Text = "Mượn Sách";
            // 
            // tsmiReturnedBooks
            // 
            this.tsmiReturnedBooks.Name = "tsmiReturnedBooks";
            this.tsmiReturnedBooks.Size = new System.Drawing.Size(134, 22);
            this.tsmiReturnedBooks.Text = "Trả Sách";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(131, 6);
            // 
            // tsmiPersonel
            // 
            this.tsmiPersonel.Name = "tsmiPersonel";
            this.tsmiPersonel.Size = new System.Drawing.Size(134, 22);
            this.tsmiPersonel.Text = "Nhân Viên";
            // 
            // tsmiHelp
            // 
            this.tsmiHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiIntroduction});
            this.tsmiHelp.Name = "tsmiHelp";
            this.tsmiHelp.Size = new System.Drawing.Size(63, 20);
            this.tsmiHelp.Text = "Trợ Giúp";
            // 
            // tsmiIntroduction
            // 
            this.tsmiIntroduction.Name = "tsmiIntroduction";
            this.tsmiIntroduction.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.tsmiIntroduction.Size = new System.Drawing.Size(173, 22);
            this.tsmiIntroduction.Text = "Giới Thiệu";
            // 
            // picGenres
            // 
            this.picGenres.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picGenres.Location = new System.Drawing.Point(183, 19);
            this.picGenres.Name = "picGenres";
            this.picGenres.Size = new System.Drawing.Size(155, 158);
            this.picGenres.TabIndex = 8;
            this.picGenres.TabStop = false;
            this.picGenres.Click += new System.EventHandler(this.picGenres_Click);
            // 
            // picReaders
            // 
            this.picReaders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picReaders.Location = new System.Drawing.Point(361, 19);
            this.picReaders.Name = "picReaders";
            this.picReaders.Size = new System.Drawing.Size(155, 158);
            this.picReaders.TabIndex = 9;
            this.picReaders.TabStop = false;
            this.picReaders.Click += new System.EventHandler(this.picReaders_Click);
            // 
            // picBooks
            // 
            this.picBooks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBooks.Location = new System.Drawing.Point(6, 19);
            this.picBooks.Name = "picBooks";
            this.picBooks.Size = new System.Drawing.Size(155, 158);
            this.picBooks.TabIndex = 10;
            this.picBooks.TabStop = false;
            this.picBooks.Click += new System.EventHandler(this.picBooks_Click);
            // 
            // grpInformation
            // 
            this.grpInformation.Controls.Add(this.lblReaders);
            this.grpInformation.Controls.Add(this.lblGenres);
            this.grpInformation.Controls.Add(this.lblBooks);
            this.grpInformation.Controls.Add(this.picReaders);
            this.grpInformation.Controls.Add(this.picBooks);
            this.grpInformation.Controls.Add(this.picGenres);
            this.grpInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInformation.Location = new System.Drawing.Point(12, 45);
            this.grpInformation.Name = "grpInformation";
            this.grpInformation.Size = new System.Drawing.Size(532, 183);
            this.grpInformation.TabIndex = 11;
            this.grpInformation.TabStop = false;
            this.grpInformation.Text = "THÔNG TIN";
            // 
            // lblReaders
            // 
            this.lblReaders.AutoSize = true;
            this.lblReaders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblReaders.Location = new System.Drawing.Point(437, 149);
            this.lblReaders.Name = "lblReaders";
            this.lblReaders.Size = new System.Drawing.Size(70, 18);
            this.lblReaders.TabIndex = 15;
            this.lblReaders.Text = "Độc Giả";
            // 
            // lblGenres
            // 
            this.lblGenres.AutoSize = true;
            this.lblGenres.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblGenres.Location = new System.Drawing.Point(255, 149);
            this.lblGenres.Name = "lblGenres";
            this.lblGenres.Size = new System.Drawing.Size(73, 18);
            this.lblGenres.TabIndex = 14;
            this.lblGenres.Text = "Thể Loại";
            // 
            // lblBooks
            // 
            this.lblBooks.AutoSize = true;
            this.lblBooks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBooks.Location = new System.Drawing.Point(106, 149);
            this.lblBooks.Name = "lblBooks";
            this.lblBooks.Size = new System.Drawing.Size(46, 18);
            this.lblBooks.TabIndex = 13;
            this.lblBooks.Text = "Sách";
            // 
            // grpManagement
            // 
            this.grpManagement.Controls.Add(this.lblPersonel);
            this.grpManagement.Controls.Add(this.picPersonel);
            this.grpManagement.Controls.Add(this.lblReturnedBooks);
            this.grpManagement.Controls.Add(this.lblBorrowedBooks);
            this.grpManagement.Controls.Add(this.picReturnedBooks);
            this.grpManagement.Controls.Add(this.picBorrowedBooks);
            this.grpManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpManagement.Location = new System.Drawing.Point(12, 276);
            this.grpManagement.Name = "grpManagement";
            this.grpManagement.Size = new System.Drawing.Size(532, 183);
            this.grpManagement.TabIndex = 12;
            this.grpManagement.TabStop = false;
            this.grpManagement.Text = "QUẢN LÝ";
            // 
            // lblPersonel
            // 
            this.lblPersonel.AutoSize = true;
            this.lblPersonel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPersonel.Enabled = false;
            this.lblPersonel.Location = new System.Drawing.Point(423, 147);
            this.lblPersonel.Name = "lblPersonel";
            this.lblPersonel.Size = new System.Drawing.Size(84, 18);
            this.lblPersonel.TabIndex = 18;
            this.lblPersonel.Text = "Nhân Viên";
            // 
            // picPersonel
            // 
            this.picPersonel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picPersonel.Enabled = false;
            this.picPersonel.Location = new System.Drawing.Point(361, 19);
            this.picPersonel.Name = "picPersonel";
            this.picPersonel.Size = new System.Drawing.Size(155, 158);
            this.picPersonel.TabIndex = 9;
            this.picPersonel.TabStop = false;
            // 
            // lblReturnedBooks
            // 
            this.lblReturnedBooks.AutoSize = true;
            this.lblReturnedBooks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblReturnedBooks.Location = new System.Drawing.Point(252, 147);
            this.lblReturnedBooks.Name = "lblReturnedBooks";
            this.lblReturnedBooks.Size = new System.Drawing.Size(76, 18);
            this.lblReturnedBooks.TabIndex = 17;
            this.lblReturnedBooks.Text = "Trả Sách";
            // 
            // lblBorrowedBooks
            // 
            this.lblBorrowedBooks.AutoSize = true;
            this.lblBorrowedBooks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBorrowedBooks.Location = new System.Drawing.Point(59, 147);
            this.lblBorrowedBooks.Name = "lblBorrowedBooks";
            this.lblBorrowedBooks.Size = new System.Drawing.Size(93, 18);
            this.lblBorrowedBooks.TabIndex = 16;
            this.lblBorrowedBooks.Text = "Mượn Sách";
            // 
            // picReturnedBooks
            // 
            this.picReturnedBooks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picReturnedBooks.Location = new System.Drawing.Point(183, 19);
            this.picReturnedBooks.Name = "picReturnedBooks";
            this.picReturnedBooks.Size = new System.Drawing.Size(155, 158);
            this.picReturnedBooks.TabIndex = 8;
            this.picReturnedBooks.TabStop = false;
            // 
            // picBorrowedBooks
            // 
            this.picBorrowedBooks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBorrowedBooks.Location = new System.Drawing.Point(6, 19);
            this.picBorrowedBooks.Name = "picBorrowedBooks";
            this.picBorrowedBooks.Size = new System.Drawing.Size(155, 158);
            this.picBorrowedBooks.TabIndex = 10;
            this.picBorrowedBooks.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 509);
            this.ControlBox = false;
            this.Controls.Add(this.grpManagement);
            this.Controls.Add(this.grpInformation);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Thư viện";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGenres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReaders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBooks)).EndInit();
            this.grpInformation.ResumeLayout(false);
            this.grpInformation.PerformLayout();
            this.grpManagement.ResumeLayout(false);
            this.grpManagement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPersonel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReturnedBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBorrowedBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiSystem;
        private System.Windows.Forms.ToolStripMenuItem tsmiChangePassword;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiLogout;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem tsmiManagement;
        private System.Windows.Forms.ToolStripMenuItem tsmiBorrowedBooks;
        private System.Windows.Forms.ToolStripMenuItem tsmiReturnedBooks;
        private System.Windows.Forms.ToolStripMenuItem tsmiInformation;
        private System.Windows.Forms.ToolStripMenuItem tsmiReaders;
        private System.Windows.Forms.ToolStripMenuItem tsmiBooks;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmiIntroduction;
        private System.Windows.Forms.ToolStripMenuItem tsmiGenres;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem tsmiPersonel;
        private System.Windows.Forms.PictureBox picGenres;
        private System.Windows.Forms.PictureBox picReaders;
        private System.Windows.Forms.PictureBox picBooks;
        private System.Windows.Forms.GroupBox grpInformation;
        private System.Windows.Forms.Label lblReaders;
        private System.Windows.Forms.Label lblGenres;
        private System.Windows.Forms.Label lblBooks;
        private System.Windows.Forms.GroupBox grpManagement;
        private System.Windows.Forms.Label lblPersonel;
        private System.Windows.Forms.PictureBox picPersonel;
        private System.Windows.Forms.Label lblReturnedBooks;
        private System.Windows.Forms.Label lblBorrowedBooks;
        private System.Windows.Forms.PictureBox picReturnedBooks;
        private System.Windows.Forms.PictureBox picBorrowedBooks;
        private System.Windows.Forms.ToolStripMenuItem tsmiBackup;
        private System.Windows.Forms.ToolStripMenuItem tsmiRestore;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    }
}