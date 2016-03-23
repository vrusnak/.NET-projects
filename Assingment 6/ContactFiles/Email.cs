/// <summary>
/// Email.cs
/// Created:  Viktor Rusnak, 2014-11-16
/// Revised:  
/// Purpose:  Handles the email information of a specific customer.
/// </summary>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assingment_6.ContactFiles
{
    /// <summary>
    /// This class handles the email information of a customer. 
    /// </summary>
    public class Email
    {
        private string work;
        private string personal;

        /// <summary>
        /// Default constructor Email. Calls another constructor in this class. 
        /// </summary>
        public Email() : this(string.Empty, string.Empty)
        {
        }

        /// <summary>
        /// Constructor Email. Takes two parameters workMail and personalMail.
        /// </summary>
        public Email(string workMail, string personalMail)
        {
            this.work = workMail;
            this.personal = personalMail;
        }

        /// <summary>
        /// Propertry Work. Gets and sets a work mail. 
        /// </summary>
        public string Work
        {
            get
            {
                return work;
            }
            set
            {
                this.work = value;
            }
        }

        /// <summary>
        /// Propertry Personal. Gets and sets a personal mail. 
        /// </summary>
        public string Personal
        {
            get
            {
                return personal;
            }
            set
            {
                this.personal = value;
            }
        }

        /// <summary>
        /// Propertry GetToStringItemsHeadings. Gets headings for the emails. 
        /// </summary>
        public string GetToStringItemsHeadings
        {
            get { return string.Format("{0,-20} {1, -20}", "Office Email", "Private Email"); }
        }

        /// <summary>
        /// Returns a string representation of the emails. 
        /// </summary>
        public override string ToString()
        {
            string strOut = string.Format("{0,-20} {1, -20}", work, personal);
            return strOut;
        }
    }
}
  
