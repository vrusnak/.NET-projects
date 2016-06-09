namespace Assignment_5
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBoxAddRecipe = new System.Windows.Forms.GroupBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.btnAddIngredients = new System.Windows.Forms.Button();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.textBoxNameOfRecipe = new System.Windows.Forms.TextBox();
            this.lblComboBoxCategory = new System.Windows.Forms.Label();
            this.lblNameOfRecipe = new System.Windows.Forms.Label();
            this.listBoxRecipes = new System.Windows.Forms.ListBox();
            this.btnAddRecipe = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblNumberOfIngredients = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnDelete_MainForm = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEdit_MainForm = new System.Windows.Forms.Button();
            this.btnUnselect = new System.Windows.Forms.Button();
            this.lblCurrentNumberOfRecipes = new System.Windows.Forms.Label();
            this.lblCount_MainForm = new System.Windows.Forms.Label();
            this.groupBoxAddRecipe.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxAddRecipe
            // 
            this.groupBoxAddRecipe.Controls.Add(this.textBoxDescription);
            this.groupBoxAddRecipe.Controls.Add(this.btnAddIngredients);
            this.groupBoxAddRecipe.Controls.Add(this.comboBoxCategory);
            this.groupBoxAddRecipe.Controls.Add(this.textBoxNameOfRecipe);
            this.groupBoxAddRecipe.Controls.Add(this.lblComboBoxCategory);
            this.groupBoxAddRecipe.Controls.Add(this.lblNameOfRecipe);
            resources.ApplyResources(this.groupBoxAddRecipe, "groupBoxAddRecipe");
            this.groupBoxAddRecipe.Name = "groupBoxAddRecipe";
            this.groupBoxAddRecipe.TabStop = false;
            // 
            // textBoxDescription
            // 
            resources.ApplyResources(this.textBoxDescription, "textBoxDescription");
            this.textBoxDescription.Name = "textBoxDescription";
            // 
            // btnAddIngredients
            // 
            resources.ApplyResources(this.btnAddIngredients, "btnAddIngredients");
            this.btnAddIngredients.Name = "btnAddIngredients";
            this.btnAddIngredients.UseVisualStyleBackColor = true;
            this.btnAddIngredients.Click += new System.EventHandler(this.btnAddIngredients_Click);
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategory.FormattingEnabled = true;
            resources.ApplyResources(this.comboBoxCategory, "comboBoxCategory");
            this.comboBoxCategory.Name = "comboBoxCategory";
            // 
            // textBoxNameOfRecipe
            // 
            resources.ApplyResources(this.textBoxNameOfRecipe, "textBoxNameOfRecipe");
            this.textBoxNameOfRecipe.Name = "textBoxNameOfRecipe";
            // 
            // lblComboBoxCategory
            // 
            resources.ApplyResources(this.lblComboBoxCategory, "lblComboBoxCategory");
            this.lblComboBoxCategory.Name = "lblComboBoxCategory";
            // 
            // lblNameOfRecipe
            // 
            resources.ApplyResources(this.lblNameOfRecipe, "lblNameOfRecipe");
            this.lblNameOfRecipe.Name = "lblNameOfRecipe";
            // 
            // listBoxRecipes
            // 
            resources.ApplyResources(this.listBoxRecipes, "listBoxRecipes");
            this.listBoxRecipes.FormattingEnabled = true;
            this.listBoxRecipes.Name = "listBoxRecipes";
            this.listBoxRecipes.SelectedIndexChanged += new System.EventHandler(this.listBoxRecipes_SelectedIndexChanged);
            // 
            // btnAddRecipe
            // 
            resources.ApplyResources(this.btnAddRecipe, "btnAddRecipe");
            this.btnAddRecipe.Name = "btnAddRecipe";
            this.btnAddRecipe.UseVisualStyleBackColor = true;
            this.btnAddRecipe.Click += new System.EventHandler(this.btnAddRecipe_Click);
            // 
            // lblName
            // 
            resources.ApplyResources(this.lblName, "lblName");
            this.lblName.Name = "lblName";
            // 
            // lblNumberOfIngredients
            // 
            resources.ApplyResources(this.lblNumberOfIngredients, "lblNumberOfIngredients");
            this.lblNumberOfIngredients.Name = "lblNumberOfIngredients";
            // 
            // lblCategory
            // 
            resources.ApplyResources(this.lblCategory, "lblCategory");
            this.lblCategory.Name = "lblCategory";
            // 
            // lblDescription
            // 
            resources.ApplyResources(this.lblDescription, "lblDescription");
            this.lblDescription.Name = "lblDescription";
            // 
            // btnDelete_MainForm
            // 
            resources.ApplyResources(this.btnDelete_MainForm, "btnDelete_MainForm");
            this.btnDelete_MainForm.Name = "btnDelete_MainForm";
            this.btnDelete_MainForm.UseVisualStyleBackColor = true;
            this.btnDelete_MainForm.Click += new System.EventHandler(this.btnDelete_MainForm_Click);
            // 
            // btnExit
            // 
            resources.ApplyResources(this.btnExit, "btnExit");
            this.btnExit.Name = "btnExit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            resources.ApplyResources(this.infoToolStripMenuItem, "infoToolStripMenuItem");
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // btnEdit_MainForm
            // 
            resources.ApplyResources(this.btnEdit_MainForm, "btnEdit_MainForm");
            this.btnEdit_MainForm.Name = "btnEdit_MainForm";
            this.btnEdit_MainForm.UseVisualStyleBackColor = true;
            this.btnEdit_MainForm.Click += new System.EventHandler(this.btnEdit_MainForm_Click);
            // 
            // btnUnselect
            // 
            resources.ApplyResources(this.btnUnselect, "btnUnselect");
            this.btnUnselect.Name = "btnUnselect";
            this.btnUnselect.UseVisualStyleBackColor = true;
            this.btnUnselect.Click += new System.EventHandler(this.btnUnselect_Click);
            // 
            // lblCurrentNumberOfRecipes
            // 
            resources.ApplyResources(this.lblCurrentNumberOfRecipes, "lblCurrentNumberOfRecipes");
            this.lblCurrentNumberOfRecipes.Name = "lblCurrentNumberOfRecipes";
            // 
            // lblCount_MainForm
            // 
            resources.ApplyResources(this.lblCount_MainForm, "lblCount_MainForm");
            this.lblCount_MainForm.Name = "lblCount_MainForm";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblCount_MainForm);
            this.Controls.Add(this.lblCurrentNumberOfRecipes);
            this.Controls.Add(this.btnUnselect);
            this.Controls.Add(this.btnEdit_MainForm);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete_MainForm);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblNumberOfIngredients);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnAddRecipe);
            this.Controls.Add(this.listBoxRecipes);
            this.Controls.Add(this.groupBoxAddRecipe);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.groupBoxAddRecipe.ResumeLayout(false);
            this.groupBoxAddRecipe.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAddRecipe;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.TextBox textBoxNameOfRecipe;
        private System.Windows.Forms.Label lblComboBoxCategory;
        private System.Windows.Forms.Label lblNameOfRecipe;
        private System.Windows.Forms.Button btnAddIngredients;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.ListBox listBoxRecipes;
        private System.Windows.Forms.Button btnAddRecipe;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNumberOfIngredients;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnDelete_MainForm;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.Button btnEdit_MainForm;
        private System.Windows.Forms.Button btnUnselect;
        private System.Windows.Forms.Label lblCurrentNumberOfRecipes;
        private System.Windows.Forms.Label lblCount_MainForm;
    }
}

