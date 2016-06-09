using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6_lvl2
{
    class Sender
    {
        /// <summary>
        /// Default constructor Sender.
        /// </summary>
        public Sender() { }

        /// <summary>
        /// Gets and sets the company name of the sender.
        /// </summary>
        public string SenderCompany { get; set; }

        /// <summary>
        /// Gets and sets the street from which the invoice is sent.
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
        /// Gets and sets the phone number.
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Gets and sets the website.
        /// </summary>
        public string URL { get; set; }

        /// <summary>
        /// Prints an address.
        /// </summary>
        /// <returns>
        /// A formated string representing the sender address.
        /// </returns>
        public string GetAddress()
        {
            string str = string.Format("Address:\n{0}\n{1} {2}\n{3}", Street, City, ZipCode, Country);
            return str;
        }

        /// <summary>
        /// Prints a phone number.
        /// </summary>
        /// <returns>
        /// A formated string representing the senders phone number.
        /// </returns>
        public string GetPhone()
        {
            string str = string.Format("Phone:\n{0}", Phone);
            return str;
        }

        /// <summary>
        /// Prints a website.
        /// </summary>
        /// <returns>
        /// A formated string representing the senders website.
        /// </returns>
        public string GetWebsite()
        {
            string str = string.Format("Vist us at:\n{0}", URL);
            return str;
        }
    }
}
