namespace Login_System
{
    partial class frmRegister
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtConPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Checkbx_show_password = new System.Windows.Forms.CheckBox();
            this.btRegister = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS PGothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Get Started";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(58)))), ((int)(((byte)(54)))));
            this.label2.Location = new System.Drawing.Point(33, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(129)))), ((int)(((byte)(102)))));
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(36, 133);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(218, 28);
            this.txtUsername.TabIndex = 2;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // textPassword
            // 
            this.textPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(129)))), ((int)(((byte)(102)))));
            this.textPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textPassword.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPassword.Location = new System.Drawing.Point(36, 209);
            this.textPassword.Multiline = true;
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '⌔';
            this.textPassword.Size = new System.Drawing.Size(218, 28);
            this.textPassword.TabIndex = 4;
            this.textPassword.TextChanged += new System.EventHandler(this.textPassword_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(58)))), ((int)(((byte)(54)))));
            this.label3.Location = new System.Drawing.Point(33, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password";
            // 
            // txtConPassword
            // 
            this.txtConPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(129)))), ((int)(((byte)(102)))));
            this.txtConPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConPassword.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConPassword.Location = new System.Drawing.Point(36, 283);
            this.txtConPassword.Multiline = true;
            this.txtConPassword.Name = "txtConPassword";
            this.txtConPassword.PasswordChar = '⌔';
            this.txtConPassword.Size = new System.Drawing.Size(218, 28);
            this.txtConPassword.TabIndex = 6;
            this.txtConPassword.TextChanged += new System.EventHandler(this.txtConPassword_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(58)))), ((int)(((byte)(54)))));
            this.label4.Location = new System.Drawing.Point(33, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Confirn Password";
            // 
            // Checkbx_show_password
            // 
            this.Checkbx_show_password.AutoSize = true;
            this.Checkbx_show_password.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Checkbx_show_password.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Checkbx_show_password.Location = new System.Drawing.Point(132, 317);
            this.Checkbx_show_password.Name = "Checkbx_show_password";
            this.Checkbx_show_password.Size = new System.Drawing.Size(119, 21);
            this.Checkbx_show_password.TabIndex = 7;
            this.Checkbx_show_password.Text = "Show Password";
            this.Checkbx_show_password.UseVisualStyleBackColor = true;
            this.Checkbx_show_password.CheckedChanged += new System.EventHandler(this.Checkbx_show_password_CheckedChanged);
            // 
            // btRegister
            // 
            this.btRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(129)))), ((int)(((byte)(102)))));
            this.btRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btRegister.FlatAppearance.BorderSize = 0;
            this.btRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(58)))), ((int)(((byte)(54)))));
            this.btRegister.Location = new System.Drawing.Point(36, 368);
            this.btRegister.Name = "btRegister";
            this.btRegister.Size = new System.Drawing.Size(218, 35);
            this.btRegister.TabIndex = 8;
            this.btRegister.Text = "Register";
            this.btRegister.UseVisualStyleBackColor = false;
            this.btRegister.Click += new System.EventHandler(this.btRegister_Click);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(226)))), ((int)(((byte)(221)))));
            this.Clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Clear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(58)))), ((int)(((byte)(54)))));
            this.Clear.FlatAppearance.BorderSize = 2;
            this.Clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(58)))), ((int)(((byte)(54)))));
            this.Clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(58)))), ((int)(((byte)(54)))));
            this.Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(129)))), ((int)(((byte)(102)))));
            this.Clear.Location = new System.Drawing.Point(36, 420);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(218, 35);
            this.Clear.TabIndex = 9;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 475);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Already have an Account";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(129)))), ((int)(((byte)(102)))));
            this.label6.Location = new System.Drawing.Point(86, 492);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Back to LOGIN";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(226)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(285, 544);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.btRegister);
            this.Controls.Add(this.Checkbx_show_password);
            this.Controls.Add(this.txtConPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(58)))), ((int)(((byte)(54)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRgister";
            this.Load += new System.EventHandler(this.frmRegister_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtConPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox Checkbx_show_password;
        private System.Windows.Forms.Button btRegister;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

