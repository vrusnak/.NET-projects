/// <summary>
/// LogonForm.cs
/// Created:  Viktor Rusnak, 2015-01-06
/// Revised:  
/// Purpose:  Handles the user login interface.
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
    /// Class LogonForm. Handles the user login inferface.
    /// </summary>
    public partial class LogonForm : Form
    {
        private Member currMember;
        private MemberManager currManagerObj;
        private bool memberFound;

        /// <summary>
        /// Constructor LogonForm. Initializes the GUI.
        /// </summary>
        public LogonForm(Member member, MemberManager managerObj)
        {
            this.Icon = Properties.Resources.user;
            this.currMember = member;
            this.currManagerObj = managerObj;
            InitializeComponent();
            InitializeGUI();
        }

        private void InitializeGUI()
        {
            textBoxUsername.Text = string.Empty;
            textBoxPassword.Text = string.Empty;
            textBoxUsername.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            memberFound = false;

            foreach (Member member in currManagerObj.GetList)
            {
                if (member != null)
                {
                    if (username.Equals(member.Username) && password.Equals(member.UserPassword))
                    {
                        memberFound = true;
                        currMember = member;
                        this.Close();
                    }
                }
            }

            if (!username.Equals(currMember.Username) && !password.Equals(currMember.UserPassword))
            {
                MessageBox.Show("Fel användarnamn eller lösenord!", "Försök igen", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                textBoxPassword.Text = string.Empty;
            }
        }

        /// <summary>
        /// Returns the boolean value of the variable memberFound.
        /// </summary>
        public bool MemberFound()
        {
            return memberFound;
        }

        /// <summary>
        /// Returns the current member.
        /// </summary>
        public Member GetCurrentMember()
        {
            return currMember;
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            AddNewUserForm newUserForm = new AddNewUserForm(currManagerObj);
            newUserForm.Text = "Ny Användare";
            newUserForm.ShowDialog();
            InitializeGUI();
        }

        private void btnAbortLogonForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
