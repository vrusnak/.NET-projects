namespace MediaLibrary
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.listBoxChosenLoan = new System.Windows.Forms.ListBox();
            this.lblLoan = new System.Windows.Forms.Label();
            this.listBoxChooseLoan = new System.Windows.Forms.ListBox();
            this.btnLoan = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnLogon = new System.Windows.Forms.Button();
            this.lblMyLoans = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arkivToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.avslutaToolStripMenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.omToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.omMediabiblioteketToolStripMenuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.arkivToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avslutaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.omToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.omMediabiblioteketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblSearchResult = new System.Windows.Forms.Label();
            this.myPictureBox = new System.Windows.Forms.PictureBox();
            this.toolTipSearch = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxChosenLoan
            // 
            this.listBoxChosenLoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            this.listBoxChosenLoan.FormattingEnabled = true;
            this.listBoxChosenLoan.Location = new System.Drawing.Point(18, 302);
            this.listBoxChosenLoan.Margin = new System.Windows.Forms.Padding(1, 1, 11, 13);
            this.listBoxChosenLoan.Name = "listBoxChosenLoan";
            this.listBoxChosenLoan.Size = new System.Drawing.Size(943, 199);
            this.listBoxChosenLoan.TabIndex = 0;
            this.listBoxChosenLoan.SelectedIndexChanged += new System.EventHandler(this.listBoxChosenLoan_SelectedIndexChanged);
            this.listBoxChosenLoan.DoubleClick += new System.EventHandler(this.listBoxChosenLoan_DoubleClick);
            // 
            // lblLoan
            // 
            this.lblLoan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLoan.AutoSize = true;
            this.lblLoan.Image = ((System.Drawing.Image)(resources.GetObject("lblLoan.Image")));
            this.lblLoan.Location = new System.Drawing.Point(16, 33);
            this.lblLoan.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblLoan.Name = "lblLoan";
            this.lblLoan.Size = new System.Drawing.Size(0, 13);
            this.lblLoan.TabIndex = 1;
            // 
            // listBoxChooseLoan
            // 
            this.listBoxChooseLoan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listBoxChooseLoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            this.listBoxChooseLoan.FormattingEnabled = true;
            this.listBoxChooseLoan.Location = new System.Drawing.Point(18, 55);
            this.listBoxChooseLoan.Margin = new System.Windows.Forms.Padding(11, 1, 1, 13);
            this.listBoxChooseLoan.Name = "listBoxChooseLoan";
            this.listBoxChooseLoan.Size = new System.Drawing.Size(675, 173);
            this.listBoxChooseLoan.TabIndex = 2;
            this.listBoxChooseLoan.SelectedIndexChanged += new System.EventHandler(this.listBoxChooseLoan_SelectedIndexChanged);
            this.listBoxChooseLoan.DoubleClick += new System.EventHandler(this.listBoxChooseLoan_DoubleClick);
            // 
            // btnLoan
            // 
            this.btnLoan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLoan.Location = new System.Drawing.Point(234, 238);
            this.btnLoan.Margin = new System.Windows.Forms.Padding(1, 1, 11, 1);
            this.btnLoan.Name = "btnLoan";
            this.btnLoan.Size = new System.Drawing.Size(62, 39);
            this.btnLoan.TabIndex = 3;
            this.btnLoan.Text = "Låna";
            this.btnLoan.UseVisualStyleBackColor = true;
            this.btnLoan.Click += new System.EventHandler(this.btnLoan_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReturn.Location = new System.Drawing.Point(405, 238);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(1);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(70, 39);
            this.btnReturn.TabIndex = 4;
            this.btnReturn.Text = "Återlämning";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnLogon
            // 
            this.btnLogon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogon.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogon.Location = new System.Drawing.Point(604, 11);
            this.btnLogon.Margin = new System.Windows.Forms.Padding(1);
            this.btnLogon.Name = "btnLogon";
            this.btnLogon.Size = new System.Drawing.Size(87, 27);
            this.btnLogon.TabIndex = 5;
            this.btnLogon.UseVisualStyleBackColor = true;
            this.btnLogon.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // lblMyLoans
            // 
            this.lblMyLoans.AutoSize = true;
            this.lblMyLoans.Image = ((System.Drawing.Image)(resources.GetObject("lblMyLoans.Image")));
            this.lblMyLoans.Location = new System.Drawing.Point(16, 281);
            this.lblMyLoans.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblMyLoans.Name = "lblMyLoans";
            this.lblMyLoans.Size = new System.Drawing.Size(50, 13);
            this.lblMyLoans.TabIndex = 6;
            this.lblMyLoans.Text = "Mina lån:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuStrip1.BackgroundImage")));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arkivToolStripMenuItem1,
            this.omToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(996, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arkivToolStripMenuItem1
            // 
            this.arkivToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.avslutaToolStripMenuExit});
            this.arkivToolStripMenuItem1.Name = "arkivToolStripMenuItem1";
            this.arkivToolStripMenuItem1.Size = new System.Drawing.Size(46, 20);
            this.arkivToolStripMenuItem1.Text = "Arkiv";
            // 
            // avslutaToolStripMenuExit
            // 
            this.avslutaToolStripMenuExit.Name = "avslutaToolStripMenuExit";
            this.avslutaToolStripMenuExit.Size = new System.Drawing.Size(113, 22);
            this.avslutaToolStripMenuExit.Text = "Avsluta";
            this.avslutaToolStripMenuExit.Click += new System.EventHandler(this.avslutaToolStripMenuExit_Click);
            // 
            // omToolStripMenuItem1
            // 
            this.omToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.omMediabiblioteketToolStripMenuAbout});
            this.omToolStripMenuItem1.Name = "omToolStripMenuItem1";
            this.omToolStripMenuItem1.Size = new System.Drawing.Size(39, 20);
            this.omToolStripMenuItem1.Text = "Om";
            // 
            // omMediabiblioteketToolStripMenuAbout
            // 
            this.omMediabiblioteketToolStripMenuAbout.Name = "omMediabiblioteketToolStripMenuAbout";
            this.omMediabiblioteketToolStripMenuAbout.Size = new System.Drawing.Size(186, 22);
            this.omMediabiblioteketToolStripMenuAbout.Text = "Om Mediabiblioteket";
            this.omMediabiblioteketToolStripMenuAbout.Click += new System.EventHandler(this.omMediabiblioteketToolStripMenuAbout_Click);
            // 
            // arkivToolStripMenuItem
            // 
            this.arkivToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.avslutaToolStripMenuItem});
            this.arkivToolStripMenuItem.Name = "arkivToolStripMenuItem";
            this.arkivToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.arkivToolStripMenuItem.Text = "Arkiv";
            // 
            // avslutaToolStripMenuItem
            // 
            this.avslutaToolStripMenuItem.Name = "avslutaToolStripMenuItem";
            this.avslutaToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.avslutaToolStripMenuItem.Text = "Avsluta";
            // 
            // omToolStripMenuItem
            // 
            this.omToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.omMediabiblioteketToolStripMenuItem});
            this.omToolStripMenuItem.Name = "omToolStripMenuItem";
            this.omToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.omToolStripMenuItem.Text = "Om";
            // 
            // omMediabiblioteketToolStripMenuItem
            // 
            this.omMediabiblioteketToolStripMenuItem.Name = "omMediabiblioteketToolStripMenuItem";
            this.omMediabiblioteketToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.omMediabiblioteketToolStripMenuItem.Text = "Om Mediabiblioteket";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxSearch.Location = new System.Drawing.Point(731, 71);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(126, 20);
            this.textBoxSearch.TabIndex = 8;
            this.textBoxSearch.MouseHover += new System.EventHandler(this.textBoxSearch_MouseHover);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearch.Location = new System.Drawing.Point(863, 71);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(51, 21);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Sök";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSearch.AutoSize = true;
            this.lblSearch.Image = ((System.Drawing.Image)(resources.GetObject("lblSearch.Image")));
            this.lblSearch.Location = new System.Drawing.Point(728, 55);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(81, 13);
            this.lblSearch.TabIndex = 10;
            this.lblSearch.Text = "Sök efter artikel";
            // 
            // lblSearchResult
            // 
            this.lblSearchResult.AutoSize = true;
            this.lblSearchResult.Image = ((System.Drawing.Image)(resources.GetObject("lblSearchResult.Image")));
            this.lblSearchResult.Location = new System.Drawing.Point(737, 113);
            this.lblSearchResult.Name = "lblSearchResult";
            this.lblSearchResult.Size = new System.Drawing.Size(0, 13);
            this.lblSearchResult.TabIndex = 11;
            // 
            // myPictureBox
            // 
            this.myPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.myPictureBox.Location = new System.Drawing.Point(19, 302);
            this.myPictureBox.Name = "myPictureBox";
            this.myPictureBox.Size = new System.Drawing.Size(943, 195);
            this.myPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.myPictureBox.TabIndex = 12;
            this.myPictureBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(996, 504);
            this.Controls.Add(this.myPictureBox);
            this.Controls.Add(this.lblSearchResult);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.lblMyLoans);
            this.Controls.Add(this.btnLogon);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnLoan);
            this.Controls.Add(this.listBoxChooseLoan);
            this.Controls.Add(this.lblLoan);
            this.Controls.Add(this.listBoxChosenLoan);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxChosenLoan;
        private System.Windows.Forms.Label lblLoan;
        private System.Windows.Forms.ListBox listBoxChooseLoan;
        private System.Windows.Forms.Button btnLoan;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnLogon;
        private System.Windows.Forms.Label lblMyLoans;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arkivToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avslutaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem omToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem omMediabiblioteketToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblSearchResult;
        private System.Windows.Forms.PictureBox myPictureBox;
        private System.Windows.Forms.ToolTip toolTipSearch;
        private System.Windows.Forms.ToolStripMenuItem arkivToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem avslutaToolStripMenuExit;
        private System.Windows.Forms.ToolStripMenuItem omToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem omMediabiblioteketToolStripMenuAbout;
    }
}

