/// <summary>
/// AddNewUserForm.cs
/// Created:  Viktor Rusnak, 2015-01-06
/// Revised:  
/// Purpose:  Handles the creation of new user interface.
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
    /// Class LogonForm. Handles the creation of new user interface.
    /// </summary>
    public partial class AddNewUserForm : Form
    {
        Member newMember = new Member();
        MemberManager managerObj;
        private bool availableMember;

        /// <summary>
        /// Constructor AddNewUserForm. Initializes the GUI.
        /// </summary>
        public AddNewUserForm(MemberManager managerObj)
        {
            this.Icon = Properties.Resources.new_user;
            InitializeComponent();
            InitializeGUI();
            this.managerObj = managerObj;
        }

        private void InitializeGUI()
        {
            textBoxNewUsername.Text = string.Empty;
            textBoxNewPassword.Text = string.Empty;
            textBoxReenterNewPassword.Text = string.Empty;
        }

        private void btnCreateNewUser_Click(object sender, EventArgs e)
        {
            availableMember = true;
            string username = textBoxNewUsername.Text;
            string password = textBoxNewPassword.Text;
            string rePassword = textBoxReenterNewPassword.Text;

            foreach (Member member in managerObj.GetList)
            {
                if (member != null)
                {
                    if (username.Equals(member.Username))
                    {
                        MessageBox.Show("Användarnamnet är upptaget!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        availableMember = false;
                    }
                }
            }

            if (availableMember)
            {
                if (password == rePassword && password != string.Empty)
                {
                    if (password.Length < 6)
                    {
                        MessageBox.Show("Lösenordet måste vara minst 6 tecken långt. Försök igen!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {

                        string userID = GenerateID().ToString();
                        string[] newUser = { userID + " Username: \"" + username + "\" | Password: \"" + password + "\"" };
                        string[] formerData = System.IO.File.ReadAllLines(Application.StartupPath + "\\Textfiles\\Users.txt", Encoding.ASCII);
                        string[] newArray = formerData.Union(newUser).ToArray();
                        System.IO.File.WriteAllLines(Application.StartupPath + "\\Textfiles\\Users.txt", newArray, Encoding.ASCII);

                        newMember.UserID = userID;
                        newMember.Username = username;
                        newMember.UserPassword = password;
                        managerObj.AddNewMember(newMember);

                        this.Close();
                    }
                }
                else if ((textBoxNewUsername.Text == string.Empty || textBoxNewPassword.Text == string.Empty || textBoxReenterNewPassword.Text == string.Empty))
                      MessageBox.Show("Fyll i alla fält ovan", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    MessageBox.Show("Lösenorden du angivit matchar inte!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    textBoxNewPassword.Text = string.Empty;
                    textBoxReenterNewPassword.Text = string.Empty;
                }
            }
        }

        private int GenerateID()
        {
            Random rand = new Random();
            int tempID = rand.Next(1000, 2000);
            return ValidateID(tempID);
        }

        private int ValidateID(int tempID)
        {
            bool ok = true;
            foreach (Member member in managerObj.GetList)
            {
                if (member != null)
                {
                    if (tempID.ToString().Equals(member.UserID))
                        ok = false;
                }
            }

            if (ok)
                return tempID;
            else
                GenerateID();
            return 0;
        }

        private void btnAbort_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
