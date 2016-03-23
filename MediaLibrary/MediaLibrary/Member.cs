/// <summary>
/// Member.cs
/// Created:  Viktor Rusnak, 2015-01-06
/// Revised:  
/// Purpose:  To manage member loans.
/// </summary>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaLibrary
{
    /// <summary>
    /// Class Member. Manages the loans related to a member.
    /// </summary>
    public class Member
    {
        private Media mediaObj;
        private string[] loanArray;
        private string userID;
        private string memberUsername;
        private string memberPassword;

        /// <summary>
        /// Constructor Member. Creates a new string array.
        /// </summary>
        public Member()
        {
            this.loanArray = new string[10];
        }

        /// <summary>
        /// Property Loans. Gets and sets the string array loanArray.         
        /// </summary>
        public string[] Loans
        {
            get { return loanArray; }
            set { this.loanArray = value; }
        }

        /// <summary>
        /// Property GetNumberOfLoans(). Gets and sets the current number of loans.         
        /// </summary>
        public int GetNumberOfLoans()
        {
            int count = 0;
            foreach (string item in loanArray)
            {
                if (item != string.Empty && item != null)
                    count++;
            }
            return count;
        }

        /// <summary>
        /// Property Loans. Gets and sets the member ID.        
        /// </summary>
        public string UserID
        {
            get { return userID; }
            set { this.userID = value; }
        }

        /// <summary>
        /// Property Loans. Gets and sets the member username.      
        /// </summary>
        public string Username
        {
            get { return memberUsername; }
            set { this.memberUsername = value; }
        }

        /// <summary>
        /// Property Loans. Gets and sets the member password.         
        /// </summary>
        public string UserPassword
        {
            get { return memberPassword; }
            set { this.memberPassword = value; }
        }

        /// <summary>
        /// Adds a new loan to a member loan array.
        /// </summary>
        public bool AddLoan(int mediaIndex, Media mediaObj)
        {
            this.mediaObj = mediaObj;
            int index = FindVacantPosition();
            if (index >= 0)
            {
                loanArray[index] = mediaObj.AvailableLoans[mediaIndex];

                mediaObj.UnavailableLoans[mediaObj.FindVacantPositionUnAvailableLoans()] = mediaObj.AvailableLoans[mediaIndex];

                mediaObj.AvailableLoans[mediaIndex] = string.Empty;
                ShiftAvailableLoansArray(mediaIndex);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Removes the loan from the member loan array.
        /// </summary>
        public bool RemoveLoan(string value, int mediaIndex, Media mediaObj)
        {
            this.mediaObj = mediaObj;
            int count = 0;
            if (value != null)
            {
                loanArray[mediaIndex] = string.Empty;
                for (int i = mediaIndex; i < loanArray.Length; i++)
                {
                    if (i == (loanArray.Length - 1))
                    {
                        loanArray[i] = string.Empty;
                    }
                    else
                    {
                        loanArray[i] = loanArray[i + 1];
                        loanArray[i + 1] = string.Empty;
                    }
                }

                foreach (string item in mediaObj.UnavailableLoans)
                {
                    if (item.Equals(value))
                    {
                        mediaObj.UnavailableLoans[count] = string.Empty;
                        mediaObj.AvailableLoans[mediaObj.FindVacantPositionAvailableLoans()] = item;
                    }
                    count++;
                }
                return true;
            }
            return false;
        }

        private int FindVacantPosition()
        {
            for (int i = 0; i < loanArray.Length; i++)
            {
                if (string.IsNullOrEmpty(loanArray[i]))
                    return i;
            }
            return -1;
        }

        private void ShiftAvailableLoansArray(int index)
        {
            for (int i = index; i < mediaObj.AvailableLoans.Length; i++)
            {

                if (i == (mediaObj.AvailableLoans.Length - 1))
                {
                    mediaObj.AvailableLoans[i] = string.Empty;
                }
                else
                {
                    mediaObj.AvailableLoans[i] = mediaObj.AvailableLoans[i + 1];
                    mediaObj.AvailableLoans[i + 1] = string.Empty;
                }
            }
        }
    }
}

