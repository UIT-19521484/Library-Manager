namespace New_Library.Forms.Book
{
    partial class frmAddBook
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
            this.grpBookInfo = new System.Windows.Forms.GroupBox();
            this.lblGenreError = new System.Windows.Forms.Label();
            this.lblPublisherNameError = new System.Windows.Forms.Label();
            this.lblAuthorNameError = new System.Windows.Forms.Label();
            this.lblBookNameError = new System.Windows.Forms.Label();
            this.grpGenre = new System.Windows.Forms.GroupBox();
            this.cboGenre = new System.Windows.Forms.ComboBox();
            this.grpPublisher = new System.Windows.Forms.GroupBox();
            this.txtPublisherName = new System.Windows.Forms.TextBox();
            this.grpAuthorName = new System.Windows.Forms.GroupBox();
            this.txtAuthorName = new System.Windows.Forms.TextBox();
            this.grpBookName = new System.Windows.Forms.GroupBox();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.grpQuantity = new System.Windows.Forms.GroupBox();
            this.lblAvailableWarning = new System.Windows.Forms.Label();
            this.lblBorrowed = new System.Windows.Forms.Label();
            this.grpAvailable = new System.Windows.Forms.GroupBox();
            this.txtAvailable = new System.Windows.Forms.TextBox();
            this.errAddBook = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpBookInfo.SuspendLayout();
            this.grpGenre.SuspendLayout();
            this.grpPublisher.SuspendLayout();
            this.grpAuthorName.SuspendLayout();
            this.grpBookName.SuspendLayout();
            this.grpQuantity.SuspendLayout();
            this.grpAvailable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errAddBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBookInfo
            // 
            this.grpBookInfo.Controls.Add(this.lblGenreError);
            this.grpBookInfo.Controls.Add(this.lblPublisherNameError);
            this.grpBookInfo.Controls.Add(this.lblAuthorNameError);
            this.grpBookInfo.Controls.Add(this.lblBookNameError);
            this.grpBookInfo.Controls.Add(this.grpGenre);
            this.grpBookInfo.Controls.Add(this.grpPublisher);
            this.grpBookInfo.Controls.Add(this.grpAuthorName);
            this.grpBookInfo.Controls.Add(this.grpBookName);
            this.grpBookInfo.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBookInfo.Location = new System.Drawing.Point(12, 12);
            this.grpBookInfo.Name = "grpBookInfo";
            this.grpBookInfo.Size = new System.Drawing.Size(391, 331);
            this.grpBookInfo.TabIndex = 6;
            this.grpBookInfo.TabStop = false;
            this.grpBookInfo.Text = "Thông tin sách";
            // 
            // lblGenreError
            // 
            this.lblGenreError.AutoSize = true;
            this.lblGenreError.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenreError.ForeColor = System.Drawing.Color.Red;
            this.lblGenreError.Location = new System.Drawing.Point(10, 297);
            this.lblGenreError.Name = "lblGenreError";
            this.lblGenreError.Size = new System.Drawing.Size(66, 13);
            this.lblGenreError.TabIndex = 75;
            this.lblGenreError.Text = "Genre Error";
            // 
            // lblPublisherNameError
            // 
            this.lblPublisherNameError.AutoSize = true;
            this.lblPublisherNameError.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPublisherNameError.ForeColor = System.Drawing.Color.Red;
            this.lblPublisherNameError.Location = new System.Drawing.Point(10, 224);
            this.lblPublisherNameError.Name = "lblPublisherNameError";
            this.lblPublisherNameError.Size = new System.Drawing.Size(112, 13);
            this.lblPublisherNameError.TabIndex = 74;
            this.lblPublisherNameError.Text = "PublisherName Error";
            // 
            // lblAuthorNameError
            // 
            this.lblAuthorNameError.AutoSize = true;
            this.lblAuthorNameError.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthorNameError.ForeColor = System.Drawing.Color.Red;
            this.lblAuthorNameError.Location = new System.Drawing.Point(10, 159);
            this.lblAuthorNameError.Name = "lblAuthorNameError";
            this.lblAuthorNameError.Size = new System.Drawing.Size(100, 13);
            this.lblAuthorNameError.TabIndex = 73;
            this.lblAuthorNameError.Text = "AuthorName Error";
            // 
            // lblBookNameError
            // 
            this.lblBookNameError.AutoSize = true;
            this.lblBookNameError.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookNameError.ForeColor = System.Drawing.Color.Red;
            this.lblBookNameError.Location = new System.Drawing.Point(10, 94);
            this.lblBookNameError.Name = "lblBookNameError";
            this.lblBookNameError.Size = new System.Drawing.Size(90, 13);
            this.lblBookNameError.TabIndex = 72;
            this.lblBookNameError.Text = "BookName Error";
            // 
            // grpGenre
            // 
            this.grpGenre.BackColor = System.Drawing.Color.White;
            this.grpGenre.Controls.Add(this.cboGenre);
            this.grpGenre.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpGenre.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpGenre.Location = new System.Drawing.Point(13, 240);
            this.grpGenre.Name = "grpGenre";
            this.grpGenre.Size = new System.Drawing.Size(349, 56);
            this.grpGenre.TabIndex = 71;
            this.grpGenre.TabStop = false;
            this.grpGenre.Text = "Thể loại";
            // 
            // cboGenre
            // 
            this.cboGenre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboGenre.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cboGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGenre.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboGenre.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGenre.FormattingEnabled = true;
            this.cboGenre.Location = new System.Drawing.Point(9, 19);
            this.cboGenre.Margin = new System.Windows.Forms.Padding(0);
            this.cboGenre.Name = "cboGenre";
            this.cboGenre.Size = new System.Drawing.Size(337, 33);
            this.cboGenre.Sorted = true;
            this.cboGenre.TabIndex = 4;
            this.cboGenre.Validating += new System.ComponentModel.CancelEventHandler(this.cbGenre_Validating);
            this.cboGenre.Validated += new System.EventHandler(this.cbGenre_Validated);
            // 
            // grpPublisher
            // 
            this.grpPublisher.BackColor = System.Drawing.Color.White;
            this.grpPublisher.Controls.Add(this.txtPublisherName);
            this.grpPublisher.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpPublisher.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPublisher.Location = new System.Drawing.Point(13, 175);
            this.grpPublisher.Name = "grpPublisher";
            this.grpPublisher.Size = new System.Drawing.Size(349, 48);
            this.grpPublisher.TabIndex = 70;
            this.grpPublisher.TabStop = false;
            this.grpPublisher.Text = "Nhà xuất bản";
            // 
            // txtPublisherName
            // 
            this.txtPublisherName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPublisherName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPublisherName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPublisherName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPublisherName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPublisherName.Location = new System.Drawing.Point(9, 19);
            this.txtPublisherName.Margin = new System.Windows.Forms.Padding(0);
            this.txtPublisherName.Name = "txtPublisherName";
            this.txtPublisherName.Size = new System.Drawing.Size(337, 26);
            this.txtPublisherName.TabIndex = 3;
            this.txtPublisherName.Validating += new System.ComponentModel.CancelEventHandler(this.txtPublisherName_Validating);
            this.txtPublisherName.Validated += new System.EventHandler(this.txtPublisherName_Validated);
            // 
            // grpAuthorName
            // 
            this.grpAuthorName.BackColor = System.Drawing.Color.White;
            this.grpAuthorName.Controls.Add(this.txtAuthorName);
            this.grpAuthorName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpAuthorName.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAuthorName.Location = new System.Drawing.Point(13, 110);
            this.grpAuthorName.Name = "grpAuthorName";
            this.grpAuthorName.Size = new System.Drawing.Size(349, 48);
            this.grpAuthorName.TabIndex = 69;
            this.grpAuthorName.TabStop = false;
            this.grpAuthorName.Text = "Tác giả";
            // 
            // txtAuthorName
            // 
            this.txtAuthorName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAuthorName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtAuthorName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAuthorName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuthorName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtAuthorName.Location = new System.Drawing.Point(9, 19);
            this.txtAuthorName.Margin = new System.Windows.Forms.Padding(0);
            this.txtAuthorName.Name = "txtAuthorName";
            this.txtAuthorName.Size = new System.Drawing.Size(337, 26);
            this.txtAuthorName.TabIndex = 2;
            this.txtAuthorName.Validating += new System.ComponentModel.CancelEventHandler(this.txtAuthorName_Validating);
            this.txtAuthorName.Validated += new System.EventHandler(this.txtAuthorName_Validated);
            // 
            // grpBookName
            // 
            this.grpBookName.BackColor = System.Drawing.Color.White;
            this.grpBookName.Controls.Add(this.txtBookName);
            this.grpBookName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpBookName.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBookName.Location = new System.Drawing.Point(13, 45);
            this.grpBookName.Name = "grpBookName";
            this.grpBookName.Size = new System.Drawing.Size(349, 48);
            this.grpBookName.TabIndex = 68;
            this.grpBookName.TabStop = false;
            this.grpBookName.Text = "Tên sách";
            // 
            // txtBookName
            // 
            this.txtBookName.AcceptsTab = true;
            this.txtBookName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBookName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBookName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBookName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBookName.Location = new System.Drawing.Point(9, 19);
            this.txtBookName.Margin = new System.Windows.Forms.Padding(0);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(337, 26);
            this.txtBookName.TabIndex = 1;
            this.txtBookName.WordWrap = false;
            this.txtBookName.Validating += new System.ComponentModel.CancelEventHandler(this.txtBookName_Validating);
            this.txtBookName.Validated += new System.EventHandler(this.txtBookName_Validated);
            // 
            // grpQuantity
            // 
            this.grpQuantity.Controls.Add(this.lblAvailableWarning);
            this.grpQuantity.Controls.Add(this.lblBorrowed);
            this.grpQuantity.Controls.Add(this.grpAvailable);
            this.grpQuantity.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpQuantity.Location = new System.Drawing.Point(409, 12);
            this.grpQuantity.Name = "grpQuantity";
            this.grpQuantity.Size = new System.Drawing.Size(258, 169);
            this.grpQuantity.TabIndex = 7;
            this.grpQuantity.TabStop = false;
            this.grpQuantity.Text = "Số lượng";
            // 
            // lblAvailableWarning
            // 
            this.lblAvailableWarning.AutoSize = true;
            this.lblAvailableWarning.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailableWarning.ForeColor = System.Drawing.Color.Red;
            this.lblAvailableWarning.Location = new System.Drawing.Point(12, 94);
            this.lblAvailableWarning.Name = "lblAvailableWarning";
            this.lblAvailableWarning.Size = new System.Drawing.Size(145, 13);
            this.lblAvailableWarning.TabIndex = 73;
            this.lblAvailableWarning.Text = "AvailableNumber Warning ";
            // 
            // lblBorrowed
            // 
            this.lblBorrowed.BackColor = System.Drawing.Color.White;
            this.lblBorrowed.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblBorrowed.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBorrowed.ForeColor = System.Drawing.Color.Red;
            this.lblBorrowed.Location = new System.Drawing.Point(6, 115);
            this.lblBorrowed.Name = "lblBorrowed";
            this.lblBorrowed.Size = new System.Drawing.Size(227, 43);
            this.lblBorrowed.TabIndex = 70;
            this.lblBorrowed.Text = "Số lượng đã mượn chỉ có thể thay đổi thông qua việc trả mượn sách\r\n\r\n";
            // 
            // grpAvailable
            // 
            this.grpAvailable.BackColor = System.Drawing.Color.White;
            this.grpAvailable.Controls.Add(this.txtAvailable);
            this.grpAvailable.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpAvailable.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAvailable.Location = new System.Drawing.Point(6, 45);
            this.grpAvailable.Name = "grpAvailable";
            this.grpAvailable.Size = new System.Drawing.Size(228, 48);
            this.grpAvailable.TabIndex = 69;
            this.grpAvailable.TabStop = false;
            this.grpAvailable.Text = "Có sẵn";
            // 
            // txtAvailable
            // 
            this.txtAvailable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAvailable.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtAvailable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAvailable.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAvailable.Location = new System.Drawing.Point(9, 16);
            this.txtAvailable.Margin = new System.Windows.Forms.Padding(0);
            this.txtAvailable.Name = "txtAvailable";
            this.txtAvailable.Size = new System.Drawing.Size(216, 26);
            this.txtAvailable.TabIndex = 5;
            this.txtAvailable.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAvailable_KeyPress);
            this.txtAvailable.Validating += new System.ComponentModel.CancelEventHandler(this.txtAvailable_Validating);
            this.txtAvailable.Validated += new System.EventHandler(this.txtAvailable_Validated);
            // 
            // errAddBook
            // 
            this.errAddBook.BlinkRate = 0;
            this.errAddBook.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errAddBook.ContainerControl = this;
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
            this.btnCancel.Location = new System.Drawing.Point(542, 307);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(125, 36);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdd.Image = global::New_Library.Properties.Resources.add1;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.Location = new System.Drawing.Point(409, 307);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(125, 36);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(679, 359);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grpQuantity);
            this.Controls.Add(this.grpBookInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddBook";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmAddBook_Load);
            this.grpBookInfo.ResumeLayout(false);
            this.grpBookInfo.PerformLayout();
            this.grpGenre.ResumeLayout(false);
            this.grpPublisher.ResumeLayout(false);
            this.grpPublisher.PerformLayout();
            this.grpAuthorName.ResumeLayout(false);
            this.grpAuthorName.PerformLayout();
            this.grpBookName.ResumeLayout(false);
            this.grpBookName.PerformLayout();
            this.grpQuantity.ResumeLayout(false);
            this.grpQuantity.PerformLayout();
            this.grpAvailable.ResumeLayout(false);
            this.grpAvailable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errAddBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBookInfo;
        private System.Windows.Forms.ComboBox cboGenre;
        private System.Windows.Forms.TextBox txtPublisherName;
        private System.Windows.Forms.TextBox txtAuthorName;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.GroupBox grpQuantity;
        private System.Windows.Forms.GroupBox grpBookName;
        private System.Windows.Forms.GroupBox grpAuthorName;
        private System.Windows.Forms.GroupBox grpGenre;
        private System.Windows.Forms.GroupBox grpPublisher;
        private System.Windows.Forms.GroupBox grpAvailable;
        private System.Windows.Forms.TextBox txtAvailable;
        private System.Windows.Forms.Label lblBorrowed;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblPublisherNameError;
        private System.Windows.Forms.Label lblAuthorNameError;
        private System.Windows.Forms.Label lblBookNameError;
        private System.Windows.Forms.Label lblAvailableWarning;
        private System.Windows.Forms.ErrorProvider errAddBook;
        private System.Windows.Forms.Label lblGenreError;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}