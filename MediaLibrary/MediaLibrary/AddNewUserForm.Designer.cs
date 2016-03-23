namespace MediaLibrary
{
    partial class AddNewUserForm
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
            this.lblNewUsername = new System.Windows.Forms.Label();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.textBoxNewUsername = new System.Windows.Forms.TextBox();
            this.textBoxNewPassword = new System.Windows.Forms.TextBox();
            this.textBoxReenterNewPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreateNewUser = new System.Windows.Forms.Button();
            this.btnAbort = new System.Windows.Forms.Button();
            this.lblWarning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNewUsername
            // 
            this.lblNewUsername.AutoSize = true;
            this.lblNewUsername.Location = new System.Drawing.Point(123, 125);
            this.lblNewUsername.Name = "lblNewUsername";
            this.lblNewUsername.Size = new System.Drawing.Size(359, 32);
            this.lblNewUsername.TabIndex = 0;
            this.lblNewUsername.Text = "Skriv in ett användarnamn: ";
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Location = new System.Drawing.Point(123, 182);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(272, 32);
            this.lblNewPassword.TabIndex = 1;
            this.lblNewPassword.Text = "Skriv in ett lösenord:";
            // 
            // textBoxNewUsername
            // 
            this.textBoxNewUsername.Location = new System.Drawing.Point(500, 119);
            this.textBoxNewUsername.Name = "textBoxNewUsername";
            this.textBoxNewUsername.Size = new System.Drawing.Size(313, 38);
            this.textBoxNewUsername.TabIndex = 2;
            // 
            // textBoxNewPassword
            // 
            this.textBoxNewPassword.Location = new System.Drawing.Point(500, 176);
            this.textBoxNewPassword.Name = "textBoxNewPassword";
            this.textBoxNewPassword.PasswordChar = '*';
            this.textBoxNewPassword.Size = new System.Drawing.Size(313, 38);
            this.textBoxNewPassword.TabIndex = 3;
            // 
            // textBoxReenterNewPassword
            // 
            this.textBoxReenterNewPassword.Location = new System.Drawing.Point(500, 233);
            this.textBoxReenterNewPassword.Name = "textBoxReenterNewPassword";
            this.textBoxReenterNewPassword.PasswordChar = '*';
            this.textBoxReenterNewPassword.Size = new System.Drawing.Size(313, 38);
            this.textBoxReenterNewPassword.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Upprepa lösenord:";
            // 
            // btnCreateNewUser
            // 
            this.btnCreateNewUser.Location = new System.Drawing.Point(500, 301);
            this.btnCreateNewUser.Margin = new System.Windows.Forms.Padding(3, 3, 50, 0);
            this.btnCreateNewUser.Name = "btnCreateNewUser";
            this.btnCreateNewUser.Size = new System.Drawing.Size(313, 82);
            this.btnCreateNewUser.TabIndex = 6;
            this.btnCreateNewUser.Text = "Skapa användare";
            this.btnCreateNewUser.UseVisualStyleBackColor = true;
            this.btnCreateNewUser.Click += new System.EventHandler(this.btnCreateNewUser_Click);
            // 
            // btnAbort
            // 
            this.btnAbort.Location = new System.Drawing.Point(500, 399);
            this.btnAbort.Name = "btnAbort";
            this.btnAbort.Size = new System.Drawing.Size(313, 59);
            this.btnAbort.TabIndex = 7;
            this.btnAbort.Text = "Avbryt";
            this.btnAbort.UseVisualStyleBackColor = true;
            this.btnAbort.Click += new System.EventHandler(this.btnAbort_Click);
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Location = new System.Drawing.Point(123, 56);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(330, 32);
            this.lblWarning.TabIndex = 8;
            this.lblWarning.Text = "(Använd inte å, ä  eller ö)";
            // 
            // AddNewUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1047, 523);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.btnAbort);
            this.Controls.Add(this.btnCreateNewUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxReenterNewPassword);
            this.Controls.Add(this.textBoxNewPassword);
            this.Controls.Add(this.textBoxNewUsername);
            this.Controls.Add(this.lblNewPassword);
            this.Controls.Add(this.lblNewUsername);
            this.Name = "AddNewUserForm";
            this.Text = "AddNewUserForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNewUsername;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.TextBox textBoxNewUsername;
        private System.Windows.Forms.TextBox textBoxNewPassword;
        private System.Windows.Forms.TextBox textBoxReenterNewPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreateNewUser;
        private System.Windows.Forms.Button btnAbort;
        private System.Windows.Forms.Label lblWarning;
    }
}