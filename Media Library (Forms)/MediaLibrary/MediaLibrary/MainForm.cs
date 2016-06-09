/// <summary>
/// MainForm.cs
/// Created:  Viktor Rusnak, 2015-01-06
/// Revised:  
/// Purpose:  Handles the user inferface.
/// </summary>
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaLibrary
{
    /// <summary>
    /// Class MainForm. Handles the user inferface.
    /// </summary>
    public partial class MainForm : Form
    {
        Member member = new Member();
        Media media = new Media();
        private MemberManager managerObj = new MemberManager();

        /// <summary>
        /// Constructor MainForm. Initializes the GUI.
        /// </summary>
        public MainForm()
        {
            //System.Threading.Thread.Sleep(3000);
            InitializeComponent();
            InitializeGUI();
            ClearUsersTextFile();
        }

        private void InitializeGUI()
        {
            string mediaFileName = Application.StartupPath + "\\Textfiles\\Media.txt";
            media.ReadMediaToArray(mediaFileName);
            AvailableLoansListBox();
            ClearSearchResults();
            this.Text = "Mediabiblioteket";
            this.Icon = Properties.Resources.library;
            myPictureBox.BackgroundImage = Properties.Resources.bild_new;
            lblLoan.Text = "Tillgängliga filmer och böcker:";
            btnLogon.Text = "Logga in";
            lblMyLoans.Visible = false;
            listBoxChosenLoan.Visible = false;
            btnLoan.Enabled = false;
            btnReturn.Enabled = false;
            StartScreen();
        }

        private void StartScreen()
        {
            if (btnLogon.Text == "Logga in")
                listBoxChosenLoan.SendToBack();
            else if (btnLogon.Text == "Logga ut")
                myPictureBox.SendToBack();
        }

        private void ClearUsersTextFile()
        {
            System.IO.File.WriteAllText(Application.StartupPath + "\\Textfiles\\Users.txt", string.Empty, Encoding.ASCII);
        }

        private void AvailableLoansListBox()
        {
            listBoxChooseLoan.Items.Clear();
            foreach (string item in media.AvailableLoans)
            {
                if (item != string.Empty && item != null)
                    listBoxChooseLoan.Items.Add(item);
            }
        }

        private void MemberLoansListBox()
        {
            listBoxChosenLoan.Items.Clear();
            foreach (string item in member.Loans)
            {
                if (item != string.Empty && item != null)
                {
                    listBoxChosenLoan.Items.Add(item);
                }
            }
        }

        private void ClearSearchResults()
        {
            textBoxSearch.Text = string.Empty;
            lblSearchResult.Text = string.Empty;
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (btnLogon.Text == "Logga in")
            {
                LogonForm logonForm = new LogonForm(member, managerObj);
                logonForm.Text = "Inloggning";
                logonForm.ShowDialog();
                if (logonForm.MemberFound())
                {
                    member = logonForm.GetCurrentMember();
                    for (int i = 0; i < member.Loans.Length; i++)
                    {
                        if (member.Loans[i] != null)
                            listBoxChosenLoan.Items.Add(member.Loans[i]);
                    }
                    this.Text = "Välkommen tillbaka " + member.Username;
                    btnLogon.Text = "Logga ut";
                    lblLoan.Text = "Följande kan du låna:";
                    lblMyLoans.Visible = true;
                    listBoxChosenLoan.Visible = true;
                    listBoxChooseLoan.SelectedIndex = -1;
                    listBoxChooseLoan.SelectionMode = SelectionMode.One;
                    ClearSearchResults();
                    StartScreen();
                }
                else
                    InitializeGUI();
            }
            else if (btnLogon.Text == "Logga ut")
            {
                member = new Member();
                this.Text = "Mediabiblioteket";
                listBoxChosenLoan.Items.Clear();
                lblLoan.Text = "Tillgängliga filmer och böcker:";
                btnLogon.Text = "Logga in";
                lblMyLoans.Visible = false;
                listBoxChosenLoan.Visible = false;
                btnLoan.Enabled = false;
                btnReturn.Enabled = false;
                ClearSearchResults();
                StartScreen();
            }
        }

        private void btnLoan_Click(object sender, EventArgs e)
        {
            if (listBoxChooseLoan.SelectedItems.Count == 1)
            {
                LoanObject();
                ClearSearchResults();
            }
            else
                MessageBox.Show("Endast en artikel kan lånas åt gången. Avmarkera ett eller flera objekt!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void listBoxChooseLoan_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxChooseLoan.SelectedItems.Count == 1)
            {
                LoanObject();
                ClearSearchResults();
            }
            else
                MessageBox.Show("Endast en artikel kan lånas åt gången. Avmarkera ett eller flera objekt!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void LoanObject()
        {
            if (btnLogon.Text == "Logga ut")
            {
                if (listBoxChooseLoan.SelectedIndex != -1)
                {
                    if (member.GetNumberOfLoans() < 10)
                    {
                        var result = MessageBox.Show("Vill du låna följande:\n\n" + listBoxChooseLoan.SelectedItem.ToString(), "Bekräftelse", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {

                            if (member.AddLoan(listBoxChooseLoan.SelectedIndex, media))
                            {
                                AvailableLoansListBox();
                                MemberLoansListBox();
                                btnLoan.Enabled = false;
                            }
                            else
                                MessageBox.Show("Välj en artikel!");
                        }
                    }
                    else
                        MessageBox.Show("Du kan inte låna fler objekt. Försök lämna tillbaka något och prova igen!");
                }
            }
            listBoxChooseLoan.SelectionMode = SelectionMode.One;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            ReturnObject();
            ClearSearchResults();
        }

        private void listBoxChosenLoan_DoubleClick(object sender, EventArgs e)
        {
            ReturnObject();
            ClearSearchResults();
        }

        private void ReturnObject()
        {
            if (listBoxChosenLoan.SelectedIndex != -1)
            {
                var result = MessageBox.Show("Vill du lämna tillbaka:\n\n" + listBoxChosenLoan.SelectedItem.ToString(), "Bekräftelse", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (member.RemoveLoan(listBoxChosenLoan.SelectedItem.ToString(), listBoxChosenLoan.SelectedIndex, media))
                    {
                        AvailableLoansListBox();
                        MemberLoansListBox();
                        btnReturn.Enabled = false;
                    }
                    else
                        MessageBox.Show("Välj en artikel!");
                }
            }
        }

        private void listBoxChooseLoan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxChooseLoan.SelectedIndex != -1)
            {
                if (CheckMarkings())
                {
                    if (btnLogon.Text == "Logga ut")
                        btnLoan.Enabled = true;
                }
                listBoxChosenLoan.SelectedIndex = -1;
                btnReturn.Enabled = false;
            }
        }

        private bool CheckMarkings()
        {
            if (listBoxChooseLoan.SelectedItems.Count == 1)
            {
                listBoxChooseLoan.SelectionMode = SelectionMode.One;
                return true;
            }
            return false;
        }

        private void listBoxChosenLoan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxChosenLoan.SelectedIndex != -1)
            {
                listBoxChooseLoan.SelectedIndex = -1;
                btnLoan.Enabled = false;
                btnReturn.Enabled = true;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchListBox();
        }

        private void SearchListBox()
        {
            if (!string.IsNullOrEmpty(textBoxSearch.Text))
            {
                listBoxChooseLoan.SelectedIndex = -1;
                for (int i = 0; i < listBoxChooseLoan.Items.Count; i++)
                {
                    if (listBoxChooseLoan.Items[i].ToString().ToLower().Contains(textBoxSearch.Text.ToLower()))
                    {
                        listBoxChooseLoan.SetSelected(i, true);
                        listBoxChooseLoan.SelectionMode = SelectionMode.MultiSimple;
                    }
                }
                if (listBoxChooseLoan.SelectedItems.Count > 1)
                {
                    listBoxChooseLoan.SelectionMode = SelectionMode.MultiSimple;
                }
                else
                    listBoxChooseLoan.SelectionMode = SelectionMode.One;

                if (listBoxChooseLoan.SelectedItems.Count > 1 || listBoxChooseLoan.SelectedItems.Count == 0)
                {
                    btnLoan.Enabled = false;
                    lblSearchResult.Text = listBoxChooseLoan.SelectedItems.Count + " artiklar hittade!";
                }
                else
                {
                    lblSearchResult.Text = listBoxChooseLoan.SelectedItems.Count + " artikel hittad!";
                }
            }
            else
                MessageBox.Show("Fältet kan inte vara tomt!");
        }

        private void textBoxSearch_MouseHover(object sender, EventArgs e)
        {
            toolTipSearch.Show("Sök efter ID eller författare/skådespelare", textBoxSearch, 3000);
        }

        private void omMediabiblioteketToolStripMenuAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Följande gräns gäller: Max 10 lån per användare", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void avslutaToolStripMenuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
