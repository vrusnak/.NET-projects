namespace Assignment_4_lvl2
{
    partial class StaffForm
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
            this.gpQualifications = new System.Windows.Forms.GroupBox();
            this.btnAddQualifaication = new System.Windows.Forms.Button();
            this.lbQualifications = new System.Windows.Forms.ListBox();
            this.textBoxQualification = new System.Windows.Forms.TextBox();
            this.BtnCancel_IngredientsForm = new System.Windows.Forms.Button();
            this.btnOK_IngredientsForm = new System.Windows.Forms.Button();
            this.toolTipExample = new System.Windows.Forms.ToolTip(this.components);
            this.textBoxEmplayeName = new System.Windows.Forms.TextBox();
            this.lblEmployeName = new System.Windows.Forms.Label();
            this.gpQualifications.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpQualifications
            // 
            this.gpQualifications.Controls.Add(this.btnAddQualifaication);
            this.gpQualifications.Controls.Add(this.lbQualifications);
            this.gpQualifications.Controls.Add(this.textBoxQualification);
            this.gpQualifications.Location = new System.Drawing.Point(17, 59);
            this.gpQualifications.Margin = new System.Windows.Forms.Padding(1, 1, 19, 1);
            this.gpQualifications.Name = "gpQualifications";
            this.gpQualifications.Padding = new System.Windows.Forms.Padding(1);
            this.gpQualifications.Size = new System.Drawing.Size(344, 224);
            this.gpQualifications.TabIndex = 14;
            this.gpQualifications.TabStop = false;
            this.gpQualifications.Text = "Qualifications";
            // 
            // btnAddQualifaication
            // 
            this.btnAddQualifaication.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAddQualifaication.Location = new System.Drawing.Point(235, 23);
            this.btnAddQualifaication.Margin = new System.Windows.Forms.Padding(1);
            this.btnAddQualifaication.Name = "btnAddQualifaication";
            this.btnAddQualifaication.Size = new System.Drawing.Size(46, 19);
            this.btnAddQualifaication.TabIndex = 2;
            this.btnAddQualifaication.Text = "Add";
            this.btnAddQualifaication.UseVisualStyleBackColor = true;
            this.btnAddQualifaication.Click += new System.EventHandler(this.btnAddQualifaication_Click);
            // 
            // lbQualifications
            // 
            this.lbQualifications.FormattingEnabled = true;
            this.lbQualifications.Location = new System.Drawing.Point(10, 51);
            this.lbQualifications.Margin = new System.Windows.Forms.Padding(1);
            this.lbQualifications.Name = "lbQualifications";
            this.lbQualifications.Size = new System.Drawing.Size(191, 160);
            this.lbQualifications.TabIndex = 1;
            // 
            // textBoxQualification
            // 
            this.textBoxQualification.Location = new System.Drawing.Point(10, 23);
            this.textBoxQualification.Margin = new System.Windows.Forms.Padding(1);
            this.textBoxQualification.Name = "textBoxQualification";
            this.textBoxQualification.Size = new System.Drawing.Size(191, 20);
            this.textBoxQualification.TabIndex = 0;
            // 
            // BtnCancel_IngredientsForm
            // 
            this.BtnCancel_IngredientsForm.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel_IngredientsForm.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnCancel_IngredientsForm.Location = new System.Drawing.Point(202, 302);
            this.BtnCancel_IngredientsForm.Margin = new System.Windows.Forms.Padding(1, 1, 1, 21);
            this.BtnCancel_IngredientsForm.Name = "BtnCancel_IngredientsForm";
            this.BtnCancel_IngredientsForm.Size = new System.Drawing.Size(106, 26);
            this.BtnCancel_IngredientsForm.TabIndex = 16;
            this.BtnCancel_IngredientsForm.Text = "Cancel";
            this.BtnCancel_IngredientsForm.UseVisualStyleBackColor = true;
            // 
            // btnOK_IngredientsForm
            // 
            this.btnOK_IngredientsForm.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK_IngredientsForm.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnOK_IngredientsForm.Location = new System.Drawing.Point(40, 302);
            this.btnOK_IngredientsForm.Margin = new System.Windows.Forms.Padding(1, 1, 1, 21);
            this.btnOK_IngredientsForm.Name = "btnOK_IngredientsForm";
            this.btnOK_IngredientsForm.Size = new System.Drawing.Size(106, 26);
            this.btnOK_IngredientsForm.TabIndex = 15;
            this.btnOK_IngredientsForm.Text = "OK";
            this.btnOK_IngredientsForm.UseVisualStyleBackColor = true;
            this.btnOK_IngredientsForm.Click += new System.EventHandler(this.btnOK_IngredientsForm_Click);
            // 
            // toolTipExample
            // 
            this.toolTipExample.AutomaticDelay = 1000;
            this.toolTipExample.AutoPopDelay = 10000;
            this.toolTipExample.InitialDelay = 1000;
            this.toolTipExample.ReshowDelay = 200;
            this.toolTipExample.ShowAlways = true;
            // 
            // textBoxEmplayeName
            // 
            this.textBoxEmplayeName.Location = new System.Drawing.Point(120, 20);
            this.textBoxEmplayeName.Name = "textBoxEmplayeName";
            this.textBoxEmplayeName.Size = new System.Drawing.Size(97, 20);
            this.textBoxEmplayeName.TabIndex = 18;
            // 
            // lblEmployeName
            // 
            this.lblEmployeName.AutoSize = true;
            this.lblEmployeName.Location = new System.Drawing.Point(18, 23);
            this.lblEmployeName.Name = "lblEmployeName";
            this.lblEmployeName.Size = new System.Drawing.Size(38, 13);
            this.lblEmployeName.TabIndex = 17;
            this.lblEmployeName.Text = "Name:";
            // 
            // StaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 349);
            this.Controls.Add(this.gpQualifications);
            this.Controls.Add(this.BtnCancel_IngredientsForm);
            this.Controls.Add(this.btnOK_IngredientsForm);
            this.Controls.Add(this.textBoxEmplayeName);
            this.Controls.Add(this.lblEmployeName);
            this.Name = "StaffForm";
            this.Text = "StaffForm";
            this.gpQualifications.ResumeLayout(false);
            this.gpQualifications.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpQualifications;
        private System.Windows.Forms.Button btnAddQualifaication;
        private System.Windows.Forms.ListBox lbQualifications;
        private System.Windows.Forms.TextBox textBoxQualification;
        private System.Windows.Forms.Button BtnCancel_IngredientsForm;
        private System.Windows.Forms.Button btnOK_IngredientsForm;
        private System.Windows.Forms.ToolTip toolTipExample;
        private System.Windows.Forms.TextBox textBoxEmplayeName;
        private System.Windows.Forms.Label lblEmployeName;

    }
}