namespace New_Library.Forms.Book
{
    partial class frmEditBook
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
            this.gbBookInfo = new System.Windows.Forms.GroupBox();
            this.lblPublisherNameError = new System.Windows.Forms.Label();
            this.lblAuthorNameError = new System.Windows.Forms.Label();
            this.lblBookNameError = new System.Windows.Forms.Label();
            this.gbGenre = new System.Windows.Forms.GroupBox();
            this.cbGenre = new System.Windows.Forms.ComboBox();
            this.gbPublisher = new System.Windows.Forms.GroupBox();
            this.txtPublisherName = new System.Windows.Forms.TextBox();
            this.gbAuthorName = new System.Windows.Forms.GroupBox();
            this.txtAuthorName = new System.Windows.Forms.TextBox();
            this.gbBookName = new System.Windows.Forms.GroupBox();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.gbQuantity = new System.Windows.Forms.GroupBox();
            this.lblAvailableWarning = new System.Windows.Forms.Label();
            this.lblBorrowed = new System.Windows.Forms.Label();
            this.gbAvailable = new System.Windows.Forms.GroupBox();
            this.txtAvailable = new System.Windows.Forms.TextBox();
            this.errAddBook = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.gbBookInfo.SuspendLayout();
            this.gbGenre.SuspendLayout();
            this.gbPublisher.SuspendLayout();
            this.gbAuthorName.SuspendLayout();
            this.gbBookName.SuspendLayout();
            this.gbQuantity.SuspendLayout();
            this.gbAvailable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errAddBook)).BeginInit();
            this.SuspendLayout();
            // 
            // gbBookInfo
            // 
            this.gbBookInfo.Controls.Add(this.lblPublisherNameError);
            this.gbBookInfo.Controls.Add(this.lblAuthorNameError);
            this.gbBookInfo.Controls.Add(this.lblBookNameError);
            this.gbBookInfo.Controls.Add(this.gbGenre);
            this.gbBookInfo.Controls.Add(this.gbPublisher);
            this.gbBookInfo.Controls.Add(this.gbAuthorName);
            this.gbBookInfo.Controls.Add(this.gbBookName);
            this.gbBookInfo.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBookInfo.Location = new System.Drawing.Point(12, 12);
            this.gbBookInfo.Name = "gbBookInfo";
            this.gbBookInfo.Size = new System.Drawing.Size(391, 331);
            this.gbBookInfo.TabIndex = 6;
            this.gbBookInfo.TabStop = false;
            this.gbBookInfo.Text = "Thông tin sách";
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
            this.lblBookNameError.Size = new System.Drawing.Size(91, 13);
            this.lblBookNameError.TabIndex = 72;
            this.lblBookNameError.Text = "BookName Error";
            // 
            // gbGenre
            // 
            this.gbGenre.BackColor = System.Drawing.Color.White;
            this.gbGenre.Controls.Add(this.cbGenre);
            this.gbGenre.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbGenre.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGenre.Location = new System.Drawing.Point(13, 240);
            this.gbGenre.Name = "gbGenre";
            this.gbGenre.Size = new System.Drawing.Size(349, 56);
            this.gbGenre.TabIndex = 71;
            this.gbGenre.TabStop = false;
            this.gbGenre.Text = "Thể loại";
            // 
            // cbGenre
            // 
            this.cbGenre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbGenre.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGenre.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbGenre.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGenre.FormattingEnabled = true;
            this.cbGenre.Location = new System.Drawing.Point(9, 19);
            this.cbGenre.Margin = new System.Windows.Forms.Padding(0);
            this.cbGenre.Name = "cbGenre";
            this.cbGenre.Size = new System.Drawing.Size(337, 33);
            this.cbGenre.Sorted = true;
            this.cbGenre.TabIndex = 4;
            // 
            // gbPublisher
            // 
            this.gbPublisher.BackColor = System.Drawing.Color.White;
            this.gbPublisher.Controls.Add(this.txtPublisherName);
            this.gbPublisher.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbPublisher.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPublisher.Location = new System.Drawing.Point(13, 175);
            this.gbPublisher.Name = "gbPublisher";
            this.gbPublisher.Size = new System.Drawing.Size(349, 48);
            this.gbPublisher.TabIndex = 70;
            this.gbPublisher.TabStop = false;
            this.gbPublisher.Text = "Nhà xuất bản";
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
            // gbAuthorName
            // 
            this.gbAuthorName.BackColor = System.Drawing.Color.White;
            this.gbAuthorName.Controls.Add(this.txtAuthorName);
            this.gbAuthorName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbAuthorName.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAuthorName.Location = new System.Drawing.Point(13, 110);
            this.gbAuthorName.Name = "gbAuthorName";
            this.gbAuthorName.Size = new System.Drawing.Size(349, 48);
            this.gbAuthorName.TabIndex = 69;
            this.gbAuthorName.TabStop = false;
            this.gbAuthorName.Text = "Tác giả";
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
            // gbBookName
            // 
            this.gbBookName.BackColor = System.Drawing.Color.White;
            this.gbBookName.Controls.Add(this.txtBookName);
            this.gbBookName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbBookName.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBookName.Location = new System.Drawing.Point(13, 45);
            this.gbBookName.Name = "gbBookName";
            this.gbBookName.Size = new System.Drawing.Size(349, 48);
            this.gbBookName.TabIndex = 68;
            this.gbBookName.TabStop = false;
            this.gbBookName.Text = "Tên sách";
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
            // gbQuantity
            // 
            this.gbQuantity.Controls.Add(this.lblAvailableWarning);
            this.gbQuantity.Controls.Add(this.lblBorrowed);
            this.gbQuantity.Controls.Add(this.gbAvailable);
            this.gbQuantity.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbQuantity.Location = new System.Drawing.Point(409, 12);
            this.gbQuantity.Name = "gbQuantity";
            this.gbQuantity.Size = new System.Drawing.Size(258, 169);
            this.gbQuantity.TabIndex = 7;
            this.gbQuantity.TabStop = false;
            this.gbQuantity.Text = "Số lượng";
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
            // gbAvailable
            // 
            this.gbAvailable.BackColor = System.Drawing.Color.White;
            this.gbAvailable.Controls.Add(this.txtAvailable);
            this.gbAvailable.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbAvailable.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAvailable.Location = new System.Drawing.Point(6, 45);
            this.gbAvailable.Name = "gbAvailable";
            this.gbAvailable.Size = new System.Drawing.Size(228, 48);
            this.gbAvailable.TabIndex = 69;
            this.gbAvailable.TabStop = false;
            this.gbAvailable.Text = "Có sẵn";
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
            this.btnEdit.Size = new System.Drawing.Size(125, 36);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Thay đổi";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // frmEditBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(679, 359);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.gbQuantity);
            this.Controls.Add(this.gbBookInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEditBook";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmAddBook_Load);
            this.gbBookInfo.ResumeLayout(false);
            this.gbBookInfo.PerformLayout();
            this.gbGenre.ResumeLayout(false);
            this.gbPublisher.ResumeLayout(false);
            this.gbPublisher.PerformLayout();
            this.gbAuthorName.ResumeLayout(false);
            this.gbAuthorName.PerformLayout();
            this.gbBookName.ResumeLayout(false);
            this.gbBookName.PerformLayout();
            this.gbQuantity.ResumeLayout(false);
            this.gbQuantity.PerformLayout();
            this.gbAvailable.ResumeLayout(false);
            this.gbAvailable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errAddBook)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbBookInfo;
        private System.Windows.Forms.ComboBox cbGenre;
        private System.Windows.Forms.TextBox txtPublisherName;
        private System.Windows.Forms.TextBox txtAuthorName;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.GroupBox gbQuantity;
        private System.Windows.Forms.GroupBox gbBookName;
        private System.Windows.Forms.GroupBox gbAuthorName;
        private System.Windows.Forms.GroupBox gbGenre;
        private System.Windows.Forms.GroupBox gbPublisher;
        private System.Windows.Forms.GroupBox gbAvailable;
        private System.Windows.Forms.TextBox txtAvailable;
        private System.Windows.Forms.Label lblBorrowed;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblPublisherNameError;
        private System.Windows.Forms.Label lblAuthorNameError;
        private System.Windows.Forms.Label lblBookNameError;
        private System.Windows.Forms.Label lblAvailableWarning;
        private System.Windows.Forms.ErrorProvider errAddBook;
    }
}