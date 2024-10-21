namespace NoteTakingApp
{
    partial class Register
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
            lblName = new Label();
            lblUsername = new Label();
            lblPassword = new Label();
            lblCPassword = new Label();
            lblEmail = new Label();
            txtName = new TextBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            txtEmail = new TextBox();
            btnRegister = new Button();
            btnLogin = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(32, 37);
            lblName.Name = "lblName";
            lblName.Size = new Size(45, 15);
            lblName.TabIndex = 0;
            lblName.Text = "Name :";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(32, 84);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(66, 15);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username :";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(32, 137);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(63, 15);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password :";
            // 
            // lblCPassword
            // 
            lblCPassword.AutoSize = true;
            lblCPassword.Location = new Point(32, 186);
            lblCPassword.Name = "lblCPassword";
            lblCPassword.Size = new Size(110, 15);
            lblCPassword.TabIndex = 3;
            lblCPassword.Text = "Confirm Password :";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(32, 228);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(42, 15);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email :";
            // 
            // txtName
            // 
            txtName.Location = new Point(158, 37);
            txtName.Name = "txtName";
            txtName.Size = new Size(133, 23);
            txtName.TabIndex = 5;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(158, 84);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(133, 23);
            txtUsername.TabIndex = 6;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(158, 134);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(133, 23);
            txtPassword.TabIndex = 7;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(158, 178);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.Size = new Size(133, 23);
            txtConfirmPassword.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(158, 228);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(133, 23);
            txtEmail.TabIndex = 9;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.Lime;
            btnRegister.FlatStyle = FlatStyle.Popup;
            btnRegister.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.Location = new Point(102, 281);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(106, 23);
            btnRegister.TabIndex = 10;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Lime;
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(200, 334);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 11;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 338);
            label1.Name = "label1";
            label1.Size = new Size(130, 15);
            label1.TabIndex = 12;
            label1.Text = "Already Have Account?";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(328, 405);
            Controls.Add(label1);
            Controls.Add(btnLogin);
            Controls.Add(btnRegister);
            Controls.Add(txtEmail);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(txtName);
            Controls.Add(lblEmail);
            Controls.Add(lblCPassword);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(lblName);
            Name = "Register";
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblUsername;
        private Label lblPassword;
        private Label lblCPassword;
        private Label lblEmail;
        private TextBox txtName;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private TextBox txtConfirmPassword;
        private TextBox txtEmail;
        private Button btnRegister;
        private Button btnLogin;
        private Label label1;
    }
}