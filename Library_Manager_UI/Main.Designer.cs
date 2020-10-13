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
            this.btnLogoff = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tabLibraryData = new System.Windows.Forms.TabControl();
            this.tp = new System.Windows.Forms.TabPage();
            this.tpMember = new System.Windows.Forms.TabPage();
            this.tabLibraryData.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogoff
            // 
            this.btnLogoff.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLogoff.Location = new System.Drawing.Point(9, 323);
            this.btnLogoff.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogoff.Name = "btnLogoff";
            this.btnLogoff.Size = new System.Drawing.Size(77, 32);
            this.btnLogoff.TabIndex = 0;
            this.btnLogoff.Text = "Logoff";
            this.btnLogoff.UseVisualStyleBackColor = true;
            this.btnLogoff.Click += new System.EventHandler(this.btnLogoff_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAdd.Location = new System.Drawing.Point(9, 16);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(77, 30);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRemove.Location = new System.Drawing.Point(9, 62);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(77, 30);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnUpdate.Location = new System.Drawing.Point(9, 108);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(77, 30);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tabLibraryData
            // 
            this.tabLibraryData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabLibraryData.Controls.Add(this.tp);
            this.tabLibraryData.Controls.Add(this.tpMember);
            this.tabLibraryData.Location = new System.Drawing.Point(113, 16);
            this.tabLibraryData.Margin = new System.Windows.Forms.Padding(2);
            this.tabLibraryData.Multiline = true;
            this.tabLibraryData.Name = "tabLibraryData";
            this.tabLibraryData.SelectedIndex = 0;
            this.tabLibraryData.Size = new System.Drawing.Size(478, 340);
            this.tabLibraryData.TabIndex = 4;
            // 
            // tp
            // 
            this.tp.Location = new System.Drawing.Point(4, 22);
            this.tp.Margin = new System.Windows.Forms.Padding(2);
            this.tp.Name = "tp";
            this.tp.Padding = new System.Windows.Forms.Padding(2);
            this.tp.Size = new System.Drawing.Size(470, 314);
            this.tp.TabIndex = 0;
            this.tp.Text = "Books";
            this.tp.UseVisualStyleBackColor = true;
            // 
            // tpMember
            // 
            this.tpMember.Location = new System.Drawing.Point(4, 22);
            this.tpMember.Margin = new System.Windows.Forms.Padding(2);
            this.tpMember.Name = "tpMember";
            this.tpMember.Padding = new System.Windows.Forms.Padding(2);
            this.tpMember.Size = new System.Drawing.Size(470, 314);
            this.tpMember.TabIndex = 1;
            this.tpMember.Text = "Members";
            this.tpMember.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.tabLibraryData);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnLogoff);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Libray Manager";
            this.tabLibraryData.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogoff;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TabControl tabLibraryData;
        private System.Windows.Forms.TabPage tp;
        private System.Windows.Forms.TabPage tpMember;
    }
}