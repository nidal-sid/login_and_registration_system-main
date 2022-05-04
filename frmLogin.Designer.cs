namespace Login_System
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Clearlogin = new System.Windows.Forms.Button();
            this.loginBtn = new System.Windows.Forms.Button();
            this.Checkbx_show_password = new System.Windows.Forms.CheckBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(129)))), ((int)(((byte)(102)))));
            this.label6.Location = new System.Drawing.Point(87, 425);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "Back to REGISTER";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 408);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Dont have an Account";
            // 
            // Clearlogin
            // 
            this.Clearlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(226)))), ((int)(((byte)(221)))));
            this.Clearlogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Clearlogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(58)))), ((int)(((byte)(54)))));
            this.Clearlogin.FlatAppearance.BorderSize = 2;
            this.Clearlogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(58)))), ((int)(((byte)(54)))));
            this.Clearlogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(58)))), ((int)(((byte)(54)))));
            this.Clearlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clearlogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(129)))), ((int)(((byte)(102)))));
            this.Clearlogin.Location = new System.Drawing.Point(37, 355);
            this.Clearlogin.Name = "Clearlogin";
            this.Clearlogin.Size = new System.Drawing.Size(218, 35);
            this.Clearlogin.TabIndex = 21;
            this.Clearlogin.Text = "Clear";
            this.Clearlogin.UseVisualStyleBackColor = false;
            this.Clearlogin.Click += new System.EventHandler(this.Clearlogin_Click);
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(129)))), ((int)(((byte)(102)))));
            this.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBtn.FlatAppearance.BorderSize = 0;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(58)))), ((int)(((byte)(54)))));
            this.loginBtn.Location = new System.Drawing.Point(37, 303);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(218, 35);
            this.loginBtn.TabIndex = 20;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // Checkbx_show_password
            // 
            this.Checkbx_show_password.AutoSize = true;
            this.Checkbx_show_password.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Checkbx_show_password.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Checkbx_show_password.Location = new System.Drawing.Point(133, 252);
            this.Checkbx_show_password.Name = "Checkbx_show_password";
            this.Checkbx_show_password.Size = new System.Drawing.Size(119, 21);
            this.Checkbx_show_password.TabIndex = 19;
            this.Checkbx_show_password.Text = "Show Password";
            this.Checkbx_show_password.UseVisualStyleBackColor = true;
            this.Checkbx_show_password.CheckedChanged += new System.EventHandler(this.Checkbx_show_password_CheckedChanged);
            // 
            // textPassword
            // 
            this.textPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(129)))), ((int)(((byte)(102)))));
            this.textPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textPassword.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPassword.Location = new System.Drawing.Point(37, 208);
            this.textPassword.Multiline = true;
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '⌔';
            this.textPassword.Size = new System.Drawing.Size(218, 28);
            this.textPassword.TabIndex = 16;
            this.textPassword.TextChanged += new System.EventHandler(this.textPassword_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(58)))), ((int)(((byte)(54)))));
            this.label3.Location = new System.Drawing.Point(34, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Password";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(129)))), ((int)(((byte)(102)))));
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(37, 132);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(218, 28);
            this.txtUsername.TabIndex = 14;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(58)))), ((int)(((byte)(54)))));
            this.label2.Location = new System.Drawing.Point(34, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS PGothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 27);
            this.label1.TabIndex = 12;
            this.label1.Text = "Get Started";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(226)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(285, 489);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Clearlogin);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.Checkbx_show_password);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(58)))), ((int)(((byte)(54)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Clearlogin;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.CheckBox Checkbx_show_password;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}