/// <summary>
/// Contact.cs
/// Created:  Viktor Rusnak, 2014-11-16
/// Revised:  
/// Purpose:  Handles the contact information of a specific customer.
/// </summary>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment_6.ContactFiles
{
    /// <summary>
    /// This class handles the contact information of a customer. 
    /// </summary>
    public class Contact
    {
        private Address address;
        private Phone phone;
        private Email email;
        private string firstName;
        private string lastName;

        /// <summary>
        /// Default constructor Contact. Calls another constructor in this class. 
        /// </summary>
        public Contact() : this(string.Empty, string.Empty, null, null, null) { }

        /// <summary>
        /// Constructor Contact. Takes five parameters firstNme, lastName, adr, tel and mail.
        /// </summary>
        public Contact(string firstName, string lastName, Address adr, Phone tel, Email mail)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = new Address();
            this.phone = new Phone();
            this.email = new Email();
        }

        /// <summary>
        /// Propertry FirstName. Gets and sets the first name. 
        /// </summary>
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                this.firstName = value;
            }
        }

        /// <summary>
        /// Propertry LastName. Gets and sets the last name. 
        /// </summary>
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                this.lastName = value;
            }
        }

        /// <summary>
        /// Propertry FullName. Gets the full name. 
        /// </summary>
        public string FullName
        {
            get
            {
                return lastName + ", " + firstName;
            }
        }

        /// <summary>
        /// Propertry AddressData. Gets and sets the address. 
        /// </summary>
        public Address AddressData
        {
            get
            {
                return address;
            }
            set
            {
                this.address = value;
            }
        }

        /// <summary>
        /// Propertry PhoneData. Gets and sets the phone data. 
        /// </summary>
        public Phone PhoneData
        {
            get
            {
                return phone;
            }
            set
            {
                this.phone = value;
            }
        }

        /// <summary>
        /// Propertry EmailData. Gets and sets the email data. 
        /// </summary>
        public Email EmailData
        {
            get
            {
                return email;
            }
            set
            {
                this.email = value;
            }
        }

        /// <summary>
        /// Sets the address in the address class. 
        /// </summary>
        public void SetAdress(string street, string city, string zipcode, Countries country, int countryIndex)
        {
            address.Street = street;
            address.City = city;
            address.ZipCode = zipcode;
            address.Country = country;
            address.CountryIndex = countryIndex;
        }

        /// <summary>
        /// Sets the phones in the phone class. 
        /// </summary>
        public void SetPhone(string home, string cell)
        {
            phone.HomePhone = home;
            phone.CellPhone = cell;
        }

        /// <summary>
        /// Sets the emails in the email class. 
        /// </summary>
        public void SetEmail(string work, string personal)
        {
            email.Work = work;
            email.Personal = personal;
        }

        /// <summary>
        /// Returns a string representation of the contact information. 
        /// </summary>
        public string ToStringMessageBox()
        {
            return FullName + "\n" + address.GetAddressLabel() + "\n\nPhones:\n" + phone.HomePhone + 
                " (Home)\n" + phone.CellPhone + "(Cell)\nEmail:\n" +
                 email.Work + "(work)\n" + email.Personal + " (personal)";
        }
    }
}
