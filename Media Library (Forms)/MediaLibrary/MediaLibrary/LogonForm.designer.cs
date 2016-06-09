namespace MediaLibrary
{
    partial class LogonForm
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
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.btnLoginLogonForm = new System.Windows.Forms.Button();
            this.btnNewUser = new System.Windows.Forms.Button();
            this.btnAbortLogonForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(94, 117);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(1000, 0, 3, 3);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(216, 32);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Användarnamn:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(94, 187);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(142, 32);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Lösenord:";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(353, 114);
            this.textBoxUsername.Margin = new System.Windows.Forms.Padding(3, 3, 600, 400);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(309, 38);
            this.textBoxUsername.TabIndex = 2;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(353, 181);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(309, 38);
            this.textBoxPassword.TabIndex = 3;
            // 
            // btnLoginLogonForm
            // 
            this.btnLoginLogonForm.Location = new System.Drawing.Point(353, 266);
            this.btnLoginLogonForm.Name = "btnLoginLogonForm";
            this.btnLoginLogonForm.Size = new System.Drawing.Size(309, 93);
            this.btnLoginLogonForm.TabIndex = 4;
            this.btnLoginLogonForm.Text = "Logga in";
            this.btnLoginLogonForm.UseVisualStyleBackColor = true;
            this.btnLoginLogonForm.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnNewUser
            // 
            this.btnNewUser.Location = new System.Drawing.Point(353, 365);
            this.btnNewUser.Name = "btnNewUser";
            this.btnNewUser.Size = new System.Drawing.Size(309, 89);
            this.btnNewUser.TabIndex = 5;
            this.btnNewUser.Text = "Ny användare";
            this.btnNewUser.UseVisualStyleBackColor = true;
            this.btnNewUser.Click += new System.EventHandler(this.btnNewUser_Click);
            // 
            // btnAbortLogonForm
            // 
            this.btnAbortLogonForm.Location = new System.Drawing.Point(353, 470);
            this.btnAbortLogonForm.Name = "btnAbortLogonForm";
            this.btnAbortLogonForm.Size = new System.Drawing.Size(309, 51);
            this.btnAbortLogonForm.TabIndex = 6;
            this.btnAbortLogonForm.Text = "Avbryt";
            this.btnAbortLogonForm.UseVisualStyleBackColor = true;
            this.btnAbortLogonForm.Click += new System.EventHandler(this.btnAbortLogonForm_Click);
            // 
            // LogonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 617);
            this.Controls.Add(this.btnAbortLogonForm);
            this.Controls.Add(this.btnNewUser);
            this.Controls.Add(this.btnLoginLogonForm);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Name = "LogonForm";
            this.Text = "LogonForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button btnLoginLogonForm;
        private System.Windows.Forms.Button btnNewUser;
        private System.Windows.Forms.Button btnAbortLogonForm;
    }
}