namespace Assignment_5
{
    partial class IngredientsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IngredientsForm));
            this.lblNumberOfIngredients_IngredientsForm = new System.Windows.Forms.Label();
            this.lblCount_IngredientsForm = new System.Windows.Forms.Label();
            this.groupBoxIngredient_IngredientsForm = new System.Windows.Forms.GroupBox();
            this.btnDelete_IngredientsForm = new System.Windows.Forms.Button();
            this.btnEdit_IngredientsForm = new System.Windows.Forms.Button();
            this.btnAdd_IngredientsForm = new System.Windows.Forms.Button();
            this.listBoxIngredients_IngredientsForm = new System.Windows.Forms.ListBox();
            this.textBoxIngredient_IngredientsForm = new System.Windows.Forms.TextBox();
            this.btnOK_IngredientsForm = new System.Windows.Forms.Button();
            this.BtnCancel_IngredientsForm = new System.Windows.Forms.Button();
            this.toolTipExample = new System.Windows.Forms.ToolTip(this.components);
            this.groupBoxIngredient_IngredientsForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNumberOfIngredients_IngredientsForm
            // 
            resources.ApplyResources(this.lblNumberOfIngredients_IngredientsForm, "lblNumberOfIngredients_IngredientsForm");
            this.lblNumberOfIngredients_IngredientsForm.Name = "lblNumberOfIngredients_IngredientsForm";
            // 
            // lblCount_IngredientsForm
            // 
            resources.ApplyResources(this.lblCount_IngredientsForm, "lblCount_IngredientsForm");
            this.lblCount_IngredientsForm.Name = "lblCount_IngredientsForm";
            // 
            // groupBoxIngredient_IngredientsForm
            // 
            this.groupBoxIngredient_IngredientsForm.Controls.Add(this.btnDelete_IngredientsForm);
            this.groupBoxIngredient_IngredientsForm.Controls.Add(this.btnEdit_IngredientsForm);
            this.groupBoxIngredient_IngredientsForm.Controls.Add(this.btnAdd_IngredientsForm);
            this.groupBoxIngredient_IngredientsForm.Controls.Add(this.listBoxIngredients_IngredientsForm);
            this.groupBoxIngredient_IngredientsForm.Controls.Add(this.textBoxIngredient_IngredientsForm);
            resources.ApplyResources(this.groupBoxIngredient_IngredientsForm, "groupBoxIngredient_IngredientsForm");
            this.groupBoxIngredient_IngredientsForm.Name = "groupBoxIngredient_IngredientsForm";
            this.groupBoxIngredient_IngredientsForm.TabStop = false;
            // 
            // btnDelete_IngredientsForm
            // 
            resources.ApplyResources(this.btnDelete_IngredientsForm, "btnDelete_IngredientsForm");
            this.btnDelete_IngredientsForm.Name = "btnDelete_IngredientsForm";
            this.btnDelete_IngredientsForm.UseVisualStyleBackColor = true;
            this.btnDelete_IngredientsForm.Click += new System.EventHandler(this.btnDelete_IngredientsForm_Click);
            // 
            // btnEdit_IngredientsForm
            // 
            resources.ApplyResources(this.btnEdit_IngredientsForm, "btnEdit_IngredientsForm");
            this.btnEdit_IngredientsForm.Name = "btnEdit_IngredientsForm";
            this.btnEdit_IngredientsForm.UseVisualStyleBackColor = true;
            this.btnEdit_IngredientsForm.Click += new System.EventHandler(this.btnEdit_IngredientsForm_Click);
            // 
            // btnAdd_IngredientsForm
            // 
            resources.ApplyResources(this.btnAdd_IngredientsForm, "btnAdd_IngredientsForm");
            this.btnAdd_IngredientsForm.Name = "btnAdd_IngredientsForm";
            this.btnAdd_IngredientsForm.UseVisualStyleBackColor = true;
            this.btnAdd_IngredientsForm.Click += new System.EventHandler(this.btnAdd_IngredientsForm_Click);
            // 
            // listBoxIngredients_IngredientsForm
            // 
            this.listBoxIngredients_IngredientsForm.FormattingEnabled = true;
            resources.ApplyResources(this.listBoxIngredients_IngredientsForm, "listBoxIngredients_IngredientsForm");
            this.listBoxIngredients_IngredientsForm.Name = "listBoxIngredients_IngredientsForm";
            this.listBoxIngredients_IngredientsForm.SelectedIndexChanged += new System.EventHandler(this.listBoxIngredients_IngredientsForm_SelectedIndexChanged);
            // 
            // textBoxIngredient_IngredientsForm
            // 
            resources.ApplyResources(this.textBoxIngredient_IngredientsForm, "textBoxIngredient_IngredientsForm");
            this.textBoxIngredient_IngredientsForm.Name = "textBoxIngredient_IngredientsForm";
            // 
            // btnOK_IngredientsForm
            // 
            this.btnOK_IngredientsForm.DialogResult = System.Windows.Forms.DialogResult.OK;
            resources.ApplyResources(this.btnOK_IngredientsForm, "btnOK_IngredientsForm");
            this.btnOK_IngredientsForm.Name = "btnOK_IngredientsForm";
            this.btnOK_IngredientsForm.UseVisualStyleBackColor = true;
            // 
            // BtnCancel_IngredientsForm
            // 
            this.BtnCancel_IngredientsForm.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.BtnCancel_IngredientsForm, "BtnCancel_IngredientsForm");
            this.BtnCancel_IngredientsForm.Name = "BtnCancel_IngredientsForm";
            this.BtnCancel_IngredientsForm.UseVisualStyleBackColor = true;
            // 
            // toolTipExample
            // 
            this.toolTipExample.AutomaticDelay = 1000;
            this.toolTipExample.AutoPopDelay = 10000;
            this.toolTipExample.InitialDelay = 1000;
            this.toolTipExample.ReshowDelay = 200;
            this.toolTipExample.ShowAlways = true;
            // 
            // IngredientsForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnCancel_IngredientsForm);
            this.Controls.Add(this.btnOK_IngredientsForm);
            this.Controls.Add(this.groupBoxIngredient_IngredientsForm);
            this.Controls.Add(this.lblCount_IngredientsForm);
            this.Controls.Add(this.lblNumberOfIngredients_IngredientsForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "IngredientsForm";
            this.Load += new System.EventHandler(this.IngredientsForm_Load);
            this.groupBoxIngredient_IngredientsForm.ResumeLayout(false);
            this.groupBoxIngredient_IngredientsForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumberOfIngredients_IngredientsForm;
        private System.Windows.Forms.Label lblCount_IngredientsForm;
        private System.Windows.Forms.GroupBox groupBoxIngredient_IngredientsForm;
        private System.Windows.Forms.Button btnDelete_IngredientsForm;
        private System.Windows.Forms.Button btnEdit_IngredientsForm;
        private System.Windows.Forms.Button btnAdd_IngredientsForm;
        private System.Windows.Forms.ListBox listBoxIngredients_IngredientsForm;
        private System.Windows.Forms.TextBox textBoxIngredient_IngredientsForm;
        private System.Windows.Forms.Button btnOK_IngredientsForm;
        private System.Windows.Forms.Button BtnCancel_IngredientsForm;
        private System.Windows.Forms.ToolTip toolTipExample;
    }
}