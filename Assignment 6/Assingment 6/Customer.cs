/// <summary>
/// Customer.cs
/// Created:  Viktor Rusnak, 2014-11-16
/// Revised:  
/// Purpose:  Handles a specific customer.
/// </summary>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment_6
{
    /// <summary>
    /// This class handles the contactinformation of a customer. 
    /// </summary>
    class Customer
    {
        private ContactFiles.Contact contact;
        private int id;

        /// <summary>
        /// Default constructor Customer. Calls another constructor in this class. 
        /// </summary>
        public Customer() : this(null, 0) { }

        /// <summary>
        /// Constructor that takes two parameters (contact and id).
        /// </summary>
        public Customer(ContactFiles.Contact contact, int id)
        {
            this.contact = contact;
            this.id = id;
        }

        /// <summary>
        /// Property ContactData. Gets and sets a specific contact.
        /// </summary>
        public ContactFiles.Contact ContactData
        {
            get
            {
                return contact;
            }
            set
            {
                this.contact = value;
            }
        }

        /// <summary>
        /// Property ID. Gets and sets an ID.
        /// </summary>
        public int ID
        {
            get
            {
                return id;
            }
            set
            {
                this.id = value;
            }
        }

        /// <summary>
        /// Returns a string representation of the customers full name.
        /// </summary>
        public override string ToString()
        {
            return contact.FullName;
        }
    }
}
