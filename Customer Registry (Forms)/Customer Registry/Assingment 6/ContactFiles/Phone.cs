/// <summary>
/// Phone.cs
/// Created:  Viktor Rusnak, 2014-11-16
/// Revised:  
/// Purpose:  Handles the phone information of a specific customer.
/// </summary>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment_6.ContactFiles
{
    /// <summary>
    /// This class handles the phone information of a customer. 
    /// </summary>
    public class Phone
    {
        private string homePhone;
        private string cellPhone;

        /// <summary>
        /// Default constructor Phone. Calls another constructor in this class. 
        /// </summary>
        public Phone() : this(string.Empty, string.Empty) { }

        /// <summary>
        /// Constructor Phone. Takes two parameters homePhone and cellPhone.
        /// </summary>
        public Phone(string homePhone, string cellPhone)
        {
            this.homePhone = homePhone;
            this.cellPhone = cellPhone;
        }

        /// <summary>
        /// Propertry HomePhone. Gets and sets a home phone. 
        /// </summary>
        public string HomePhone
        {
            get
            {
                return homePhone;
            }
            set
            {
                this.homePhone = value;
            }
        }

        /// <summary>
        /// Propertry CellPhone. Gets and sets a cell phone. 
        /// </summary>
        public string CellPhone
        {
            get
            {
                return cellPhone;
            }
            set
            {
                this.cellPhone = value;
            }
        }

        /// <summary>
        /// Propertry GetToStringItemsHeadings. Gets headings for the phone numbers. 
        /// </summary>
        public string GetToStringItemsHeadings
        {
            get { return string.Format("{0,-20} {1, -20}", "Home Phone", "Cellular Phone"); }
        }

        /// <summary>
        /// Returns a string representation of the phone numbers. 
        /// </summary>
        public override string ToString()
        {
            string strOut = string.Format("{0,-20} {1, -20}", homePhone, cellPhone);
            return strOut;
        }
    }
}
