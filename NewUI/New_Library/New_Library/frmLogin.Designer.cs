namespace New_Library
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlSignin = new System.Windows.Forms.Panel();
            this.lblPasswordError = new System.Windows.Forms.Label();
            this.lblUsernameError = new System.Windows.Forms.Label();
            this.lblSignin = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblForgotPassword = new System.Windows.Forms.Label();
            this.btnSignin = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlForgotPassword = new System.Windows.Forms.Panel();
            this.lblConfirmPasswordError = new System.Windows.Forms.Label();
            this.lblNewPasswordFPError = new System.Windows.Forms.Label();
            this.lblUsernameFPError = new System.Windows.Forms.Label();
            this.lblChangePassword = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.txtUsernameFP = new System.Windows.Forms.TextBox();
            this.txtNewPasswordFP = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tmrForgotPassword = new System.Windows.Forms.Timer(this.components);
            this.tmrLogin = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errLogin = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlSignin.SuspendLayout();
            this.pnlForgotPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(185)))), ((int)(((byte)(154)))));
            this.label1.Location = new System.Drawing.Point(25, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "QUẢN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(203)))), ((int)(((byte)(101)))));
            this.label2.Location = new System.Drawing.Point(117, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "LÝ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(186)))), ((int)(((byte)(22)))));
            this.label3.Location = new System.Drawing.Point(167, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "THƯ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(52)))), ((int)(((byte)(46)))));
            this.label4.Location = new System.Drawing.Point(239, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "VIỆN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 5;
            // 
            // pnlSignin
            // 
            this.pnlSignin.Controls.Add(this.lblPasswordError);
            this.pnlSignin.Controls.Add(this.lblUsernameError);
            this.pnlSignin.Controls.Add(this.lblSignin);
            this.pnlSignin.Controls.Add(this.btnExit);
            this.pnlSignin.Controls.Add(this.lblForgotPassword);
            this.pnlSignin.Controls.Add(this.btnSignin);
            this.pnlSignin.Controls.Add(this.txtUsername);
            this.pnlSignin.Controls.Add(this.txtPassword);
            this.pnlSignin.Controls.Add(this.panel3);
            this.pnlSignin.Controls.Add(this.panel2);
            this.pnlSignin.Location = new System.Drawing.Point(19, 325);
            this.pnlSignin.Name = "pnlSignin";
            this.pnlSignin.Size = new System.Drawing.Size(293, 268);
            this.pnlSignin.TabIndex = 6;
            // 
            // lblPasswordError
            // 
            this.lblPasswordError.AutoSize = true;
            this.lblPasswordError.ForeColor = System.Drawing.Color.Red;
            this.lblPasswordError.Location = new System.Drawing.Point(19, 132);
            this.lblPasswordError.Name = "lblPasswordError";
            this.lblPasswordError.Size = new System.Drawing.Size(78, 13);
            this.lblPasswordError.TabIndex = 10;
            this.lblPasswordError.Text = "Password Error";
            // 
            // lblUsernameError
            // 
            this.lblUsernameError.AutoSize = true;
            this.lblUsernameError.ForeColor = System.Drawing.Color.Red;
            this.lblUsernameError.Location = new System.Drawing.Point(19, 82);
            this.lblUsernameError.Name = "lblUsernameError";
            this.lblUsernameError.Size = new System.Drawing.Size(80, 13);
            this.lblUsernameError.TabIndex = 9;
            this.lblUsernameError.Text = "Username Error";
            // 
            // lblSignin
            // 
            this.lblSignin.AutoSize = true;
            this.lblSignin.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignin.Location = new System.Drawing.Point(95, 6);
            this.lblSignin.Name = "lblSignin";
            this.lblSignin.Size = new System.Drawing.Size(110, 25);
            this.lblSignin.TabIndex = 8;
            this.lblSignin.Text = "Đăng nhập";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(165, 202);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(109, 41);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblForgotPassword
            // 
            this.lblForgotPassword.AutoSize = true;
            this.lblForgotPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblForgotPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblForgotPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForgotPassword.ForeColor = System.Drawing.Color.LightSalmon;
            this.lblForgotPassword.Location = new System.Drawing.Point(87, 171);
            this.lblForgotPassword.Name = "lblForgotPassword";
            this.lblForgotPassword.Size = new System.Drawing.Size(118, 20);
            this.lblForgotPassword.TabIndex = 3;
            this.lblForgotPassword.Text = "Quên mật khẩu";
            this.lblForgotPassword.Click += new System.EventHandler(this.lblForgotPassword_Click);
            // 
            // btnSignin
            // 
            this.btnSignin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSignin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignin.FlatAppearance.BorderSize = 0;
            this.btnSignin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignin.ForeColor = System.Drawing.Color.White;
            this.btnSignin.Location = new System.Drawing.Point(21, 202);
            this.btnSignin.Name = "btnSignin";
            this.btnSignin.Size = new System.Drawing.Size(109, 41);
            this.btnSignin.TabIndex = 4;
            this.btnSignin.Text = "Đăng nhập";
            this.btnSignin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSignin.UseVisualStyleBackColor = false;
            this.btnSignin.Click += new System.EventHandler(this.btnSignin_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.White;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.DarkGray;
            this.txtUsername.Location = new System.Drawing.Point(21, 48);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(253, 19);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.Text = "Tên đăng nhập";
            this.txtUsername.Enter += new System.EventHandler(this.txtUsername_Enter);
            this.txtUsername.Leave += new System.EventHandler(this.txtUsername_Leave);
            this.txtUsername.Validating += new System.ComponentModel.CancelEventHandler(this.txtUsername_Validating);
            this.txtUsername.Validated += new System.EventHandler(this.txtUsername_Validated);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.DarkGray;
            this.txtPassword.Location = new System.Drawing.Point(21, 98);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(253, 19);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.Text = "Mật khẩu";
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassword_Validating);
            this.txtPassword.Validated += new System.EventHandler(this.txtPassword_Validated);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel3.Location = new System.Drawing.Point(22, 126);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(251, 3);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel2.Location = new System.Drawing.Point(22, 76);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(251, 3);
            this.panel2.TabIndex = 0;
            // 
            // pnlForgotPassword
            // 
            this.pnlForgotPassword.Controls.Add(this.lblConfirmPasswordError);
            this.pnlForgotPassword.Controls.Add(this.lblNewPasswordFPError);
            this.pnlForgotPassword.Controls.Add(this.lblUsernameFPError);
            this.pnlForgotPassword.Controls.Add(this.lblChangePassword);
            this.pnlForgotPassword.Controls.Add(this.txtConfirmPassword);
            this.pnlForgotPassword.Controls.Add(this.panel7);
            this.pnlForgotPassword.Controls.Add(this.btnReturn);
            this.pnlForgotPassword.Controls.Add(this.btnChangePassword);
            this.pnlForgotPassword.Controls.Add(this.txtUsernameFP);
            this.pnlForgotPassword.Controls.Add(this.txtNewPasswordFP);
            this.pnlForgotPassword.Controls.Add(this.panel5);
            this.pnlForgotPassword.Controls.Add(this.panel6);
            this.pnlForgotPassword.Location = new System.Drawing.Point(359, 325);
            this.pnlForgotPassword.Name = "pnlForgotPassword";
            this.pnlForgotPassword.Size = new System.Drawing.Size(293, 268);
            this.pnlForgotPassword.TabIndex = 7;
            // 
            // lblConfirmPasswordError
            // 
            this.lblConfirmPasswordError.AutoSize = true;
            this.lblConfirmPasswordError.ForeColor = System.Drawing.Color.Red;
            this.lblConfirmPasswordError.Location = new System.Drawing.Point(18, 180);
            this.lblConfirmPasswordError.Name = "lblConfirmPasswordError";
            this.lblConfirmPasswordError.Size = new System.Drawing.Size(116, 13);
            this.lblConfirmPasswordError.TabIndex = 12;
            this.lblConfirmPasswordError.Text = "Confirm Password Error";
            // 
            // lblNewPasswordFPError
            // 
            this.lblNewPasswordFPError.AutoSize = true;
            this.lblNewPasswordFPError.ForeColor = System.Drawing.Color.Red;
            this.lblNewPasswordFPError.Location = new System.Drawing.Point(18, 132);
            this.lblNewPasswordFPError.Name = "lblNewPasswordFPError";
            this.lblNewPasswordFPError.Size = new System.Drawing.Size(103, 13);
            this.lblNewPasswordFPError.TabIndex = 11;
            this.lblNewPasswordFPError.Text = "New Password Error";
            // 
            // lblUsernameFPError
            // 
            this.lblUsernameFPError.AutoSize = true;
            this.lblUsernameFPError.ForeColor = System.Drawing.Color.Red;
            this.lblUsernameFPError.Location = new System.Drawing.Point(17, 82);
            this.lblUsernameFPError.Name = "lblUsernameFPError";
            this.lblUsernameFPError.Size = new System.Drawing.Size(80, 13);
            this.lblUsernameFPError.TabIndex = 10;
            this.lblUsernameFPError.Text = "Username Error";
            // 
            // lblChangePassword
            // 
            this.lblChangePassword.AutoSize = true;
            this.lblChangePassword.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangePassword.Location = new System.Drawing.Point(87, 6);
            this.lblChangePassword.Name = "lblChangePassword";
            this.lblChangePassword.Size = new System.Drawing.Size(131, 25);
            this.lblChangePassword.TabIndex = 9;
            this.lblChangePassword.Text = "Đổi mật khẩu";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BackColor = System.Drawing.Color.White;
            this.txtConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.ForeColor = System.Drawing.Color.DarkGray;
            this.txtConfirmPassword.Location = new System.Drawing.Point(19, 146);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(253, 19);
            this.txtConfirmPassword.TabIndex = 3;
            this.txtConfirmPassword.Text = "Xác nhận Mật khẩu";
            this.txtConfirmPassword.Enter += new System.EventHandler(this.txtConfirmPassword_Enter);
            this.txtConfirmPassword.Leave += new System.EventHandler(this.txtConfirmPassword_Leave);
            this.txtConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtConfirmPassword_Validating);
            this.txtConfirmPassword.Validated += new System.EventHandler(this.txtConfirmPassword_Validated);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel7.Location = new System.Drawing.Point(20, 174);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(251, 3);
            this.panel7.TabIndex = 5;
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.Red;
            this.btnReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReturn.FlatAppearance.BorderSize = 0;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.Location = new System.Drawing.Point(164, 202);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(109, 41);
            this.btnReturn.TabIndex = 5;
            this.btnReturn.Text = "Hủy";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnChangePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangePassword.FlatAppearance.BorderSize = 0;
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.ForeColor = System.Drawing.Color.White;
            this.btnChangePassword.Location = new System.Drawing.Point(20, 202);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(109, 41);
            this.btnChangePassword.TabIndex = 4;
            this.btnChangePassword.Text = "Chấp nhận";
            this.btnChangePassword.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // txtUsernameFP
            // 
            this.txtUsernameFP.BackColor = System.Drawing.Color.White;
            this.txtUsernameFP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsernameFP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsernameFP.ForeColor = System.Drawing.Color.DarkGray;
            this.txtUsernameFP.Location = new System.Drawing.Point(20, 48);
            this.txtUsernameFP.Name = "txtUsernameFP";
            this.txtUsernameFP.Size = new System.Drawing.Size(253, 19);
            this.txtUsernameFP.TabIndex = 1;
            this.txtUsernameFP.Text = "Tên đăng nhập";
            this.txtUsernameFP.Enter += new System.EventHandler(this.txtUsernameFP_Enter);
            this.txtUsernameFP.Leave += new System.EventHandler(this.txtUsernameFP_Leave);
            this.txtUsernameFP.Validating += new System.ComponentModel.CancelEventHandler(this.txtUsernameFP_Validating);
            this.txtUsernameFP.Validated += new System.EventHandler(this.txtUsernameFP_Validated);
            // 
            // txtNewPasswordFP
            // 
            this.txtNewPasswordFP.BackColor = System.Drawing.Color.White;
            this.txtNewPasswordFP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNewPasswordFP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPasswordFP.ForeColor = System.Drawing.Color.DarkGray;
            this.txtNewPasswordFP.Location = new System.Drawing.Point(20, 98);
            this.txtNewPasswordFP.Name = "txtNewPasswordFP";
            this.txtNewPasswordFP.Size = new System.Drawing.Size(253, 19);
            this.txtNewPasswordFP.TabIndex = 2;
            this.txtNewPasswordFP.Text = "Mật khẩu mới";
            this.txtNewPasswordFP.Enter += new System.EventHandler(this.txtNewPasswordFP_Enter);
            this.txtNewPasswordFP.Leave += new System.EventHandler(this.txtNewPasswordFP_Leave);
            this.txtNewPasswordFP.Validating += new System.ComponentModel.CancelEventHandler(this.txtNewPasswordFP_Validating);
            this.txtNewPasswordFP.Validated += new System.EventHandler(this.txtNewPasswordFP_Validated);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel5.Location = new System.Drawing.Point(21, 126);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(251, 3);
            this.panel5.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel6.Location = new System.Drawing.Point(21, 76);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(251, 3);
            this.panel6.TabIndex = 0;
            // 
            // tmrForgotPassword
            // 
            this.tmrForgotPassword.Interval = 1;
            this.tmrForgotPassword.Tick += new System.EventHandler(this.tmrForgotPassword_Tick);
            // 
            // tmrLogin
            // 
            this.tmrLogin.Interval = 1;
            this.tmrLogin.Tick += new System.EventHandler(this.tmrLogin_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = global::New_Library.Properties.Resources.login;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(19, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(293, 271);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // errLogin
            // 
            this.errLogin.BlinkRate = 0;
            this.errLogin.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errLogin.ContainerControl = this;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(332, 596);
            this.Controls.Add(this.pnlForgotPassword);
            this.Controls.Add(this.pnlSignin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLogin_FormClosing);
            this.Shown += new System.EventHandler(this.frmLogin_Shown);
            this.pnlSignin.ResumeLayout(false);
            this.pnlSignin.PerformLayout();
            this.pnlForgotPassword.ResumeLayout(false);
            this.pnlForgotPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlSignin;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSignin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblForgotPassword;
        private System.Windows.Forms.Label lblSignin;
        private System.Windows.Forms.Panel pnlForgotPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.TextBox txtUsernameFP;
        private System.Windows.Forms.TextBox txtNewPasswordFP;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblChangePassword;
        private System.Windows.Forms.Timer tmrForgotPassword;
        private System.Windows.Forms.Timer tmrLogin;
        private System.Windows.Forms.Label lblPasswordError;
        private System.Windows.Forms.Label lblUsernameError;
        private System.Windows.Forms.ErrorProvider errLogin;
        private System.Windows.Forms.Label lblConfirmPasswordError;
        private System.Windows.Forms.Label lblNewPasswordFPError;
        private System.Windows.Forms.Label lblUsernameFPError;
    }
}

