namespace New_Library.Forms
{
    partial class frmManagement
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
            this.pnlManagementMenu = new System.Windows.Forms.Panel();
            this.pnlManagementCihildForm = new System.Windows.Forms.Panel();
            this.btnAccount = new System.Windows.Forms.Button();
            this.btnStaff = new System.Windows.Forms.Button();
            this.pnlManagementMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlManagementMenu
            // 
            this.pnlManagementMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.pnlManagementMenu.Controls.Add(this.btnAccount);
            this.pnlManagementMenu.Controls.Add(this.btnStaff);
            this.pnlManagementMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlManagementMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlManagementMenu.Name = "pnlManagementMenu";
            this.pnlManagementMenu.Size = new System.Drawing.Size(131, 537);
            this.pnlManagementMenu.TabIndex = 0;
            // 
            // pnlManagementCihildForm
            // 
            this.pnlManagementCihildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlManagementCihildForm.Location = new System.Drawing.Point(131, 0);
            this.pnlManagementCihildForm.Name = "pnlManagementCihildForm";
            this.pnlManagementCihildForm.Size = new System.Drawing.Size(884, 537);
            this.pnlManagementCihildForm.TabIndex = 1;
            // 
            // btnAccount
            // 
            this.btnAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAccount.FlatAppearance.BorderSize = 0;
            this.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccount.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAccount.Image = global::New_Library.Properties.Resources.account_26px;
            this.btnAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccount.Location = new System.Drawing.Point(0, 60);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.btnAccount.Size = new System.Drawing.Size(131, 60);
            this.btnAccount.TabIndex = 6;
            this.btnAccount.Text = "   Tài khoản";
            this.btnAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAccount.UseVisualStyleBackColor = true;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // btnStaff
            // 
            this.btnStaff.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStaff.FlatAppearance.BorderSize = 0;
            this.btnStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaff.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnStaff.Image = global::New_Library.Properties.Resources.management_26px;
            this.btnStaff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStaff.Location = new System.Drawing.Point(0, 0);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.btnStaff.Size = new System.Drawing.Size(131, 60);
            this.btnStaff.TabIndex = 5;
            this.btnStaff.Text = "   Nhân viên";
            this.btnStaff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStaff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStaff.UseVisualStyleBackColor = true;
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // frmManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 537);
            this.Controls.Add(this.pnlManagementCihildForm);
            this.Controls.Add(this.pnlManagementMenu);
            this.DoubleBuffered = true;
            this.Name = "frmManagement";
            this.Text = "QUẢN LÝ";
            this.Load += new System.EventHandler(this.frmManagement_Load);
            this.pnlManagementMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlManagementMenu;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.Button btnStaff;
        private System.Windows.Forms.Panel pnlManagementCihildForm;
    }
}