using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6_lvl2
{
    class Receiver
    {
        /// <summary>
        /// Default constructor Receiver.
        /// </summary>
        public Receiver() { }

        /// <summary>
        /// Gets and sets the invoice number.
        /// </summary>
        public string InvoiceNbr { get; set; }

        /// <summary>
        /// Gets and sets the invoice date.
        /// </summary>
        public string InvoiceDate { get; set; }

        /// <summary>
        /// Gets and sets the due date of the invoice.
        /// </summary>
        public string DueDate { get; set; }

        /// <summary>
        /// Gets and sets the company name of the recevier.
        /// </summary>
        public string ReceiverCompany { get; set; }

        /// <summary>
        /// Gets and sets the name of the recevier.
        /// </summary>
        public string ReceiverName { get; set; }

        /// <summary>
        /// Gets and sets the street to which the invoice is sent.
        /// </summary>
        public string Street { get; set; }

        /// <summary>
        /// Gets and sets the zipcode.
        /// </summary>
        public string ZipCode { get; set; }

        /// <summary>
        /// Gets and sets the city.
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Gets and sets the country.
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// Print the address of the receiver.
        /// </summary>
        /// <returns>
        /// A formated string representing the recevier.
        /// </returns>
        public string GetAddress()
        {
            string str = string.Format("{0}\n{1}\n{2}\n{3}\n{4}, {5}", ReceiverCompany, ReceiverName, Street, ZipCode, City, Country);
            return str;
        }
    }
}
