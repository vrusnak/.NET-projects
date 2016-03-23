/// <summary>
/// MemberManager.cs
/// Created:  Viktor Rusnak, 2015-01-06
/// Revised:  
/// Purpose:  To manage members.
/// </summary>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaLibrary
{
    /// <summary>
    /// Class MemberManager. Manages all the members in an array.
    /// </summary>
    public class MemberManager
    {
        private Member[] memberList;

        /// <summary>
        /// Constructor MemberManager. Creates a new member array.
        /// </summary>
        public MemberManager()
        {
            memberList = new Member[100];
        }

        /// <summary>
        /// Property GetList. Returns an array of members.
        /// </summary>
        public Member[] GetList
        {
            get { return memberList; }
        }

        /// <summary>
        /// Returns the current number of members in the members array.
        /// </summary>
        public int GetCurrentNumOfMembers()
        {
            int count = 0;
            for (int i = 0; i < memberList.Length; i++)
            {
                if (memberList[i] != null)
                    count++;
            }
            return count;
        }

        /// <summary>
        /// Returns a member at the current index.
        /// </summary>
        public Member GetRecipeAt(int index)
        {
            if (CheckIndex(index))
                return memberList[index];
            else
                return null;
        }

        /// <summary>
        /// Adds a new member to the array. Returns true if successful.
        /// </summary>
        public bool AddNewMember(Member newMember)
        {
            int index = FindVacantPosition();
            if (newMember != null)
            {
                memberList[index] = newMember;
                return true;
            }
            return false;
        }

        private int FindVacantPosition()
        {
            for (int i = 0; i < memberList.Length; i++)
            {
                if (memberList[i] == null)
                    return i;
            }
            return -1;
        }

        private bool CheckIndex(int index)
        {
            if (memberList[index] != null)
                return true;
            return false;
        }
    }
}
