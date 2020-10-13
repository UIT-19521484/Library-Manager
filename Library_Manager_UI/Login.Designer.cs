namespace Library_Manager_UI
{
    partial class Login_Menu
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
            this.Login_Button = new System.Windows.Forms.Button();
            this.Exit_Button = new System.Windows.Forms.Button();
            this.Username_Text = new System.Windows.Forms.TextBox();
            this.Password_Text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Reset_Password = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Login_Button
            // 
            this.Login_Button.Location = new System.Drawing.Point(22, 223);
            this.Login_Button.Name = "Login_Button";
            this.Login_Button.Size = new System.Drawing.Size(87, 36);
            this.Login_Button.TabIndex = 0;
            this.Login_Button.Text = "Login";
            this.Login_Button.UseVisualStyleBackColor = true;
            this.Login_Button.UseWaitCursor = true;
            this.Login_Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // Exit_Button
            // 
            this.Exit_Button.Location = new System.Drawing.Point(144, 223);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(85, 36);
            this.Exit_Button.TabIndex = 1;
            this.Exit_Button.Text = "Exit";
            this.Exit_Button.UseVisualStyleBackColor = true;
            this.Exit_Button.UseWaitCursor = true;
            this.Exit_Button.Click += new System.EventHandler(this.button2_Click);
            // 
            // Username_Text
            // 
            this.Username_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username_Text.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.Username_Text.Location = new System.Drawing.Point(207, 67);
            this.Username_Text.Name = "Username_Text";
            this.Username_Text.Size = new System.Drawing.Size(187, 30);
            this.Username_Text.TabIndex = 2;
            this.Username_Text.UseWaitCursor = true;
            this.Username_Text.TextChanged += new System.EventHandler(this.Username_Text_TextChanged);
            // 
            // Password_Text
            // 
            this.Password_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_Text.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.Password_Text.Location = new System.Drawing.Point(207, 127);
            this.Password_Text.Name = "Password_Text";
            this.Password_Text.PasswordChar = '*';
            this.Password_Text.Size = new System.Drawing.Size(187, 30);
            this.Password_Text.TabIndex = 3;
            this.Password_Text.Text = "password";
            this.Password_Text.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username:";
            this.label1.UseWaitCursor = true;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password:";
            this.label2.UseWaitCursor = true;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Reset_Password
            // 
            this.Reset_Password.Location = new System.Drawing.Point(261, 224);
            this.Reset_Password.Name = "Reset_Password";
            this.Reset_Password.Size = new System.Drawing.Size(158, 35);
            this.Reset_Password.TabIndex = 6;
            this.Reset_Password.Text = "Reset Password";
            this.Reset_Password.UseVisualStyleBackColor = true;
            this.Reset_Password.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Login_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 322);
            this.Controls.Add(this.Reset_Password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Password_Text);
            this.Controls.Add(this.Username_Text);
            this.Controls.Add(this.Exit_Button);
            this.Controls.Add(this.Login_Button);
            this.Name = "Login_Menu";
            this.Text = "Login Menu";
            this.UseWaitCursor = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_Menu_FormClosing);
            this.Load += new System.EventHandler(this.Login_Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Login_Button;
        private System.Windows.Forms.Button Exit_Button;
        private System.Windows.Forms.TextBox Username_Text;
        private System.Windows.Forms.TextBox Password_Text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Reset_Password;
    }
}

