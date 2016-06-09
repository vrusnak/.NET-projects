/// <summary>
/// Staff.cs
/// Created:  Viktor Rusnak, 2015-03-15
/// Revised:  
/// Purpose:  To handle a new staffmember.
/// </summary>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4_lvl2
{
    /// <summary>
    /// This class handles the communication of the program with the user. It displays an windows form for the user. 
    /// </summary>
    public class Staff
    {
        private string name;
        private IListManager<string> qualificationList;

        /// <summary>
        /// Constructor Staff. Takes no parameters. Creates a new list of qualifications.
        /// </summary>
        public Staff()
        {
            qualificationList = new ListManager<string>();
        }

        /// <summary>
        /// Returns the qualification list.
        /// </summary>
        public IListManager<string> Qualifications
        {
            get { return qualificationList; }
        }

        /// <summary>
        /// Gets and sets the name.
        /// </summary>
        public string Name
        {
            get { return name; }
            set { this.name = value; }
        }

        /// <summary>
        /// Returns a formated string of all the fields.
        /// </summary>
        public override string ToString()
        {
            string qualificationsString = string.Empty;
            foreach (string item in Qualifications.ToStringArray())
            {
                qualificationsString += item + "; ";
            }

            if (!string.IsNullOrEmpty(qualificationsString))
            {
                qualificationsString = qualificationsString.Remove(qualificationsString.Length - 2);
            }

            string strOut = string.Format("{0,-18}{1,-6}",
                Name, qualificationsString);
            return strOut;
        }
    }
}
