/// <summary>
/// Address.cs
/// Created:  Viktor Rusnak, 2014-11-16
/// Revised:  
/// Purpose:  Handles the address information of a specific customer.
/// </summary>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment_6.ContactFiles
{
    /// <summary>
    /// This class handles the address information of a customer. 
    /// </summary>
    public class Address
    {
        private string street;
        private string city;
        private string zipcode;
        private Countries country;
        private int countryIndex;

        /// <summary>
        /// Default constructor Address. Calls another constructor in this class. 
        /// </summary>
        public Address() : this(string.Empty, string.Empty, string.Empty) { }

        /// <summary>
        /// Constructor Address. Takes three parameters street, city and zipcode. Calls another constructor in this class.
        /// </summary>
        public Address(string street, string city, string zipcode) : this(street, city, zipcode, Countries.Sverige) { }

        /// <summary>
        /// Constructor Address. Takes four parameters street, city, zipcode and country.
        /// </summary>
        public Address(string street, string city, string zipcode, Countries country)
        {
            this.street = street;
            this.city = city;
            this.zipcode = zipcode;
            this.country = country;
        }

        /// <summary>
        /// Propertry Address. Gets and sets a street. 
        /// </summary>
        public Address(Address theOther) { }

        public string Street
        {
            get
            {
                return street;
            }
            set
            {
                this.street = value;
            }
        }

        /// <summary>
        /// Propertry City. Gets and sets a city. 
        /// </summary>
        public string City
        {
            get
            {
                return city;
            }
            set
            {
                this.city = value;
            }
        }

        /// <summary>
        /// Propertry ZipCode. Gets and sets a zipcode. 
        /// </summary>
        public string ZipCode
        {
            get
            {
                return zipcode;
            }
            set
            {
                this.zipcode = value;
            }
        }

        /// <summary>
        /// Propertry Country. Gets and sets a country. 
        /// </summary>
        public Countries Country
        {
            get
            {
                return country;
            }
            set
            {
                this.country = value;
            }
        }

        /// <summary>
        /// Propertry CountryIndex. Gets and sets an index for a specific country. 
        /// </summary>
        public int CountryIndex
        {
            get
            {
                return countryIndex;
            }
            set
            {
                this.countryIndex = value;
            }
        }

        /// <summary>
        /// Returns a string representation of the address. 
        /// </summary>
        public string GetAddressLabel()
        {
            return street + "\n" + zipcode + " " + city + "\n" + GetCountryString(); 
        }

        /// <summary>
        /// Returns a string representation of the country.
        /// </summary>
        public string GetCountryString()
        {
            string strCountry = country.ToString();
            strCountry = strCountry.Replace("_", " ");
            return strCountry;
        }

        /// <summary>
        /// Validates that the address fields are not empty upon closure of the form. Reutrns true if successful. 
        /// </summary>
        private bool Validate()
        {
            if (!string.IsNullOrEmpty(street) && !string.IsNullOrEmpty(city) && !string.IsNullOrEmpty(zipcode)
                && !string.IsNullOrEmpty(GetCountryString()))
                return true;
            return false;
        }

        /// <summary>
        /// Returns a call to the method GetAddressLabel() if validation checked. Otherwise returns an error string. 
        /// </summary>
        public override string ToString()
        {
            if (Validate())
            {
                return GetAddressLabel();
            }
            return "Error";
        }
    }
}
