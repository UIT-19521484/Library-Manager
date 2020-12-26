namespace New_Library.Forms
{
    partial class frmSetting
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
            this.pnlSettingChildForm = new System.Windows.Forms.Panel();
            this.pnlSettingMenu = new System.Windows.Forms.Panel();
            this.btnInfoLibrary = new System.Windows.Forms.Button();
            this.pnlSettingMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSettingChildForm
            // 
            this.pnlSettingChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSettingChildForm.Location = new System.Drawing.Point(141, 0);
            this.pnlSettingChildForm.Name = "pnlSettingChildForm";
            this.pnlSettingChildForm.Size = new System.Drawing.Size(874, 537);
            this.pnlSettingChildForm.TabIndex = 4;
            // 
            // pnlSettingMenu
            // 
            this.pnlSettingMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.pnlSettingMenu.Controls.Add(this.btnInfoLibrary);
            this.pnlSettingMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSettingMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlSettingMenu.Name = "pnlSettingMenu";
            this.pnlSettingMenu.Size = new System.Drawing.Size(141, 537);
            this.pnlSettingMenu.TabIndex = 3;
            // 
            // btnInfoLibrary
            // 
            this.btnInfoLibrary.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInfoLibrary.FlatAppearance.BorderSize = 0;
            this.btnInfoLibrary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfoLibrary.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfoLibrary.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnInfoLibrary.Image = global::New_Library.Properties.Resources.info_26px;
            this.btnInfoLibrary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfoLibrary.Location = new System.Drawing.Point(0, 0);
            this.btnInfoLibrary.Name = "btnInfoLibrary";
            this.btnInfoLibrary.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.btnInfoLibrary.Size = new System.Drawing.Size(141, 60);
            this.btnInfoLibrary.TabIndex = 6;
            this.btnInfoLibrary.Text = "   Thông tin\r\n   Thư viện";
            this.btnInfoLibrary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfoLibrary.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInfoLibrary.UseVisualStyleBackColor = true;
            this.btnInfoLibrary.Click += new System.EventHandler(this.btnInfoLibrary_Click);
            // 
            // frmSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1015, 537);
            this.Controls.Add(this.pnlSettingChildForm);
            this.Controls.Add(this.pnlSettingMenu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSetting";
            this.Text = "THIẾT LẬP";
            this.Load += new System.EventHandler(this.frmSetting_Load);
            this.pnlSettingMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSettingChildForm;
        private System.Windows.Forms.Panel pnlSettingMenu;
        private System.Windows.Forms.Button btnInfoLibrary;
    }
}