namespace New_Library.Forms
{
    partial class frmHelp
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
            this.pnlHelpMenu = new System.Windows.Forms.Panel();
            this.btnInfoApp = new System.Windows.Forms.Button();
            this.pnlHelpChildForm = new System.Windows.Forms.Panel();
            this.pnlHelpMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHelpMenu
            // 
            this.pnlHelpMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.pnlHelpMenu.Controls.Add(this.btnInfoApp);
            this.pnlHelpMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlHelpMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlHelpMenu.Name = "pnlHelpMenu";
            this.pnlHelpMenu.Size = new System.Drawing.Size(141, 537);
            this.pnlHelpMenu.TabIndex = 1;
            // 
            // btnInfoApp
            // 
            this.btnInfoApp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInfoApp.FlatAppearance.BorderSize = 0;
            this.btnInfoApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfoApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfoApp.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnInfoApp.Image = global::New_Library.Properties.Resources.info_26px;
            this.btnInfoApp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfoApp.Location = new System.Drawing.Point(0, 0);
            this.btnInfoApp.Name = "btnInfoApp";
            this.btnInfoApp.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.btnInfoApp.Size = new System.Drawing.Size(141, 60);
            this.btnInfoApp.TabIndex = 6;
            this.btnInfoApp.Text = "   Thông tin\r\n   Phần mềm";
            this.btnInfoApp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfoApp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInfoApp.UseVisualStyleBackColor = true;
            this.btnInfoApp.Click += new System.EventHandler(this.btnInfoApp_Click);
            // 
            // pnlHelpChildForm
            // 
            this.pnlHelpChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHelpChildForm.Location = new System.Drawing.Point(141, 0);
            this.pnlHelpChildForm.Name = "pnlHelpChildForm";
            this.pnlHelpChildForm.Size = new System.Drawing.Size(874, 537);
            this.pnlHelpChildForm.TabIndex = 2;
            // 
            // frmHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1015, 537);
            this.ControlBox = false;
            this.Controls.Add(this.pnlHelpChildForm);
            this.Controls.Add(this.pnlHelpMenu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHelp";
            this.Text = "TRỢ GIÚP";
            this.Load += new System.EventHandler(this.frmHelp_Load);
            this.pnlHelpMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHelpMenu;
        private System.Windows.Forms.Button btnInfoApp;
        private System.Windows.Forms.Panel pnlHelpChildForm;
    }
}