
namespace New_Library.Forms.Genre
{
    partial class frmAddGenre
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
            this.btnCancelAdd = new System.Windows.Forms.Button();
            this.btnAddGenre = new System.Windows.Forms.Button();
            this.lblGenreNameError = new System.Windows.Forms.Label();
            this.txtGenreName = new System.Windows.Forms.TextBox();
            this.grpGenreName = new System.Windows.Forms.GroupBox();
            this.grpGenreName.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelAdd
            // 
            this.btnCancelAdd.BackColor = System.Drawing.Color.Crimson;
            this.btnCancelAdd.FlatAppearance.BorderSize = 0;
            this.btnCancelAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelAdd.ForeColor = System.Drawing.Color.White;
            this.btnCancelAdd.Image = global::New_Library.Properties.Resources.delete;
            this.btnCancelAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelAdd.Location = new System.Drawing.Point(167, 79);
            this.btnCancelAdd.Name = "btnCancelAdd";
            this.btnCancelAdd.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnCancelAdd.Size = new System.Drawing.Size(156, 31);
            this.btnCancelAdd.TabIndex = 3;
            this.btnCancelAdd.Text = "   Huỷ";
            this.btnCancelAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelAdd.UseVisualStyleBackColor = false;
            this.btnCancelAdd.Click += new System.EventHandler(this.btnCancelAdd_Click);
            // 
            // btnAddGenre
            // 
            this.btnAddGenre.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAddGenre.FlatAppearance.BorderSize = 0;
            this.btnAddGenre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnAddGenre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddGenre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddGenre.ForeColor = System.Drawing.Color.White;
            this.btnAddGenre.Image = global::New_Library.Properties.Resources.add1;
            this.btnAddGenre.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddGenre.Location = new System.Drawing.Point(10, 79);
            this.btnAddGenre.Name = "btnAddGenre";
            this.btnAddGenre.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnAddGenre.Size = new System.Drawing.Size(156, 31);
            this.btnAddGenre.TabIndex = 2;
            this.btnAddGenre.Text = "   Thêm";
            this.btnAddGenre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddGenre.UseVisualStyleBackColor = false;
            this.btnAddGenre.Click += new System.EventHandler(this.btnAddGenre_Click);
            // 
            // lblGenreNameError
            // 
            this.lblGenreNameError.AutoSize = true;
            this.lblGenreNameError.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenreNameError.ForeColor = System.Drawing.Color.Red;
            this.lblGenreNameError.Location = new System.Drawing.Point(9, 63);
            this.lblGenreNameError.Name = "lblGenreNameError";
            this.lblGenreNameError.Size = new System.Drawing.Size(95, 13);
            this.lblGenreNameError.TabIndex = 78;
            this.lblGenreNameError.Text = "GenreName Error";
            // 
            // txtGenreName
            // 
            this.txtGenreName.AcceptsTab = true;
            this.txtGenreName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGenreName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtGenreName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtGenreName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtGenreName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGenreName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGenreName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtGenreName.Location = new System.Drawing.Point(9, 19);
            this.txtGenreName.Margin = new System.Windows.Forms.Padding(0);
            this.txtGenreName.Name = "txtGenreName";
            this.txtGenreName.Size = new System.Drawing.Size(301, 26);
            this.txtGenreName.TabIndex = 0;
            this.txtGenreName.WordWrap = false;
            this.txtGenreName.Validating += new System.ComponentModel.CancelEventHandler(this.txtGenreName_Validating);
            this.txtGenreName.Validated += new System.EventHandler(this.txtGenreName_Validated);
            // 
            // grpGenreName
            // 
            this.grpGenreName.BackColor = System.Drawing.Color.White;
            this.grpGenreName.Controls.Add(this.txtGenreName);
            this.grpGenreName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpGenreName.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpGenreName.Location = new System.Drawing.Point(12, 12);
            this.grpGenreName.Name = "grpGenreName";
            this.grpGenreName.Size = new System.Drawing.Size(313, 48);
            this.grpGenreName.TabIndex = 77;
            this.grpGenreName.TabStop = false;
            this.grpGenreName.Text = "Tên thể loại";
            // 
            // frmAddGenre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(335, 121);
            this.Controls.Add(this.btnCancelAdd);
            this.Controls.Add(this.btnAddGenre);
            this.Controls.Add(this.lblGenreNameError);
            this.Controls.Add(this.grpGenreName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddGenre";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.grpGenreName.ResumeLayout(false);
            this.grpGenreName.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelAdd;
        private System.Windows.Forms.Button btnAddGenre;
        private System.Windows.Forms.Label lblGenreNameError;
        private System.Windows.Forms.TextBox txtGenreName;
        private System.Windows.Forms.GroupBox grpGenreName;
    }
}