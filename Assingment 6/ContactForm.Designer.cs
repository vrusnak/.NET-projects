namespace Assingment_6
{
    partial class ContactForm
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
            this.groupBoxName = new System.Windows.Forms.GroupBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.groupBoxPhoneEmail = new System.Windows.Forms.GroupBox();
            this.textBoxEmailPersonal = new System.Windows.Forms.TextBox();
            this.textBoxEmailWork = new System.Windows.Forms.TextBox();
            this.textBoxCellPhone = new System.Windows.Forms.TextBox();
            this.textBoxHomePhone = new System.Windows.Forms.TextBox();
            this.lblCellPhone = new System.Windows.Forms.Label();
            this.lblEmailWork = new System.Windows.Forms.Label();
            this.lblEmailPersonal = new System.Windows.Forms.Label();
            this.lblHomePhone = new System.Windows.Forms.Label();
            this.groupBoxAddress = new System.Windows.Forms.GroupBox();
            this.comboBoxCountry = new System.Windows.Forms.ComboBox();
            this.textBoxZipCode = new System.Windows.Forms.TextBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.textBoxStreet = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblZipCode = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBoxName.SuspendLayout();
            this.groupBoxPhoneEmail.SuspendLayout();
            this.groupBoxAddress.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxName
            // 
            this.groupBoxName.Controls.Add(this.textBoxLastName);
            this.groupBoxName.Controls.Add(this.textBoxFirstName);
            this.groupBoxName.Controls.Add(this.lblLastName);
            this.groupBoxName.Controls.Add(this.lblFirstName);
            this.groupBoxName.Location = new System.Drawing.Point(53, 40);
            this.groupBoxName.Name = "groupBoxName";
            this.groupBoxName.Size = new System.Drawing.Size(987, 184);
            this.groupBoxName.TabIndex = 0;
            this.groupBoxName.TabStop = false;
            this.groupBoxName.Text = "Name";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(390, 110);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(559, 38);
            this.textBoxLastName.TabIndex = 3;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(390, 47);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(559, 38);
            this.textBoxFirstName.TabIndex = 2;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(51, 116);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(151, 32);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(51, 50);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(152, 32);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name";
            // 
            // groupBoxPhoneEmail
            // 
            this.groupBoxPhoneEmail.Controls.Add(this.textBoxEmailPersonal);
            this.groupBoxPhoneEmail.Controls.Add(this.textBoxEmailWork);
            this.groupBoxPhoneEmail.Controls.Add(this.textBoxCellPhone);
            this.groupBoxPhoneEmail.Controls.Add(this.textBoxHomePhone);
            this.groupBoxPhoneEmail.Controls.Add(this.lblCellPhone);
            this.groupBoxPhoneEmail.Controls.Add(this.lblEmailWork);
            this.groupBoxPhoneEmail.Controls.Add(this.lblEmailPersonal);
            this.groupBoxPhoneEmail.Controls.Add(this.lblHomePhone);
            this.groupBoxPhoneEmail.Location = new System.Drawing.Point(53, 263);
            this.groupBoxPhoneEmail.Name = "groupBoxPhoneEmail";
            this.groupBoxPhoneEmail.Size = new System.Drawing.Size(987, 310);
            this.groupBoxPhoneEmail.TabIndex = 1;
            this.groupBoxPhoneEmail.TabStop = false;
            this.groupBoxPhoneEmail.Text = "Phone and Email";
            // 
            // textBoxEmailPersonal
            // 
            this.textBoxEmailPersonal.Location = new System.Drawing.Point(390, 228);
            this.textBoxEmailPersonal.Name = "textBoxEmailPersonal";
            this.textBoxEmailPersonal.Size = new System.Drawing.Size(559, 38);
            this.textBoxEmailPersonal.TabIndex = 7;
            // 
            // textBoxEmailWork
            // 
            this.textBoxEmailWork.Location = new System.Drawing.Point(390, 173);
            this.textBoxEmailWork.Name = "textBoxEmailWork";
            this.textBoxEmailWork.Size = new System.Drawing.Size(559, 38);
            this.textBoxEmailWork.TabIndex = 6;
            // 
            // textBoxCellPhone
            // 
            this.textBoxCellPhone.Location = new System.Drawing.Point(390, 117);
            this.textBoxCellPhone.Name = "textBoxCellPhone";
            this.textBoxCellPhone.Size = new System.Drawing.Size(559, 38);
            this.textBoxCellPhone.TabIndex = 5;
            // 
            // textBoxHomePhone
            // 
            this.textBoxHomePhone.Location = new System.Drawing.Point(390, 55);
            this.textBoxHomePhone.Name = "textBoxHomePhone";
            this.textBoxHomePhone.Size = new System.Drawing.Size(559, 38);
            this.textBoxHomePhone.TabIndex = 4;
            // 
            // lblCellPhone
            // 
            this.lblCellPhone.AutoSize = true;
            this.lblCellPhone.Location = new System.Drawing.Point(57, 123);
            this.lblCellPhone.Name = "lblCellPhone";
            this.lblCellPhone.Size = new System.Drawing.Size(203, 32);
            this.lblCellPhone.TabIndex = 3;
            this.lblCellPhone.Text = "Cellular Phone";
            // 
            // lblEmailWork
            // 
            this.lblEmailWork.AutoSize = true;
            this.lblEmailWork.Location = new System.Drawing.Point(57, 179);
            this.lblEmailWork.Name = "lblEmailWork";
            this.lblEmailWork.Size = new System.Drawing.Size(162, 32);
            this.lblEmailWork.TabIndex = 2;
            this.lblEmailWork.Text = "E-Mail work";
            // 
            // lblEmailPersonal
            // 
            this.lblEmailPersonal.AutoSize = true;
            this.lblEmailPersonal.Location = new System.Drawing.Point(57, 234);
            this.lblEmailPersonal.Name = "lblEmailPersonal";
            this.lblEmailPersonal.Size = new System.Drawing.Size(189, 32);
            this.lblEmailPersonal.TabIndex = 1;
            this.lblEmailPersonal.Text = "E-Mail private";
            // 
            // lblHomePhone
            // 
            this.lblHomePhone.AutoSize = true;
            this.lblHomePhone.Location = new System.Drawing.Point(57, 62);
            this.lblHomePhone.Name = "lblHomePhone";
            this.lblHomePhone.Size = new System.Drawing.Size(180, 32);
            this.lblHomePhone.TabIndex = 0;
            this.lblHomePhone.Text = "Home Phone";
            // 
            // groupBoxAddress
            // 
            this.groupBoxAddress.Controls.Add(this.comboBoxCountry);
            this.groupBoxAddress.Controls.Add(this.textBoxZipCode);
            this.groupBoxAddress.Controls.Add(this.textBoxCity);
            this.groupBoxAddress.Controls.Add(this.textBoxStreet);
            this.groupBoxAddress.Controls.Add(this.lblCity);
            this.groupBoxAddress.Controls.Add(this.lblZipCode);
            this.groupBoxAddress.Controls.Add(this.lblCountry);
            this.groupBoxAddress.Controls.Add(this.lblStreet);
            this.groupBoxAddress.Location = new System.Drawing.Point(53, 629);
            this.groupBoxAddress.Name = "groupBoxAddress";
            this.groupBoxAddress.Size = new System.Drawing.Size(987, 306);
            this.groupBoxAddress.TabIndex = 8;
            this.groupBoxAddress.TabStop = false;
            this.groupBoxAddress.Text = "Address";
            // 
            // comboBoxCountry
            // 
            this.comboBoxCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCountry.FormattingEnabled = true;
            this.comboBoxCountry.Location = new System.Drawing.Point(390, 225);
            this.comboBoxCountry.Name = "comboBoxCountry";
            this.comboBoxCountry.Size = new System.Drawing.Size(559, 39);
            this.comboBoxCountry.TabIndex = 11;
            // 
            // textBoxZipCode
            // 
            this.textBoxZipCode.Location = new System.Drawing.Point(390, 173);
            this.textBoxZipCode.Name = "textBoxZipCode";
            this.textBoxZipCode.Size = new System.Drawing.Size(559, 38);
            this.textBoxZipCode.TabIndex = 10;
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(390, 117);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(559, 38);
            this.textBoxCity.TabIndex = 9;
            // 
            // textBoxStreet
            // 
            this.textBoxStreet.Location = new System.Drawing.Point(390, 56);
            this.textBoxStreet.Name = "textBoxStreet";
            this.textBoxStreet.Size = new System.Drawing.Size(559, 38);
            this.textBoxStreet.TabIndex = 8;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(57, 123);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(64, 32);
            this.lblCity.TabIndex = 3;
            this.lblCity.Text = "City";
            // 
            // lblZipCode
            // 
            this.lblZipCode.AutoSize = true;
            this.lblZipCode.Location = new System.Drawing.Point(57, 179);
            this.lblZipCode.Name = "lblZipCode";
            this.lblZipCode.Size = new System.Drawing.Size(130, 32);
            this.lblZipCode.TabIndex = 2;
            this.lblZipCode.Text = "Zip Code";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(57, 234);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(114, 32);
            this.lblCountry.TabIndex = 1;
            this.lblCountry.Text = "Country";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(57, 62);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(91, 32);
            this.lblStreet.TabIndex = 0;
            this.lblStreet.Text = "Street";
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(160, 974);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(343, 71);
            this.btnOK.TabIndex = 9;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(617, 974);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(343, 71);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1082, 1067);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.groupBoxAddress);
            this.Controls.Add(this.groupBoxPhoneEmail);
            this.Controls.Add(this.groupBoxName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ContactForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ContactForm_FormClosing);
            this.groupBoxName.ResumeLayout(false);
            this.groupBoxName.PerformLayout();
            this.groupBoxPhoneEmail.ResumeLayout(false);
            this.groupBoxPhoneEmail.PerformLayout();
            this.groupBoxAddress.ResumeLayout(false);
            this.groupBoxAddress.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.GroupBox groupBoxPhoneEmail;
        private System.Windows.Forms.Label lblCellPhone;
        private System.Windows.Forms.Label lblEmailWork;
        private System.Windows.Forms.Label lblEmailPersonal;
        private System.Windows.Forms.Label lblHomePhone;
        private System.Windows.Forms.GroupBox groupBoxAddress;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblZipCode;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox textBoxEmailPersonal;
        private System.Windows.Forms.TextBox textBoxEmailWork;
        private System.Windows.Forms.TextBox textBoxCellPhone;
        private System.Windows.Forms.TextBox textBoxHomePhone;
        private System.Windows.Forms.TextBox textBoxZipCode;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.TextBox textBoxStreet;
        private System.Windows.Forms.ComboBox comboBoxCountry;
    }
}

