/// <summary>
/// CustomerManager.cs
/// Created:  Viktor Rusnak, 2014-11-16
/// Revised:  
/// Purpose:  Creates and handles a new list of customers.
/// </summary>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment_6
{
    /// <summary>
    /// This class handles a list to manage all customers. 
    /// </summary>
    class CustomerManager
    {
        private List<Customer> customerList;
        private Customer customer;
        private int newID;

        /// <summary>
        /// Constructor CustomerManager. Creates a new list.
        /// </summary>
        public CustomerManager()
        {
            customerList = new List<Customer>();
        }

        /// <summary>
        /// Returns the number of customers in the customerlist.
        /// </summary>
        public int Count
        {
            get
            {
                return customerList.Count;
            }
        }

        /// <summary>
        /// Prepares the customer for the list. Returns true id successful.
        /// </summary>
        public bool AddCustomer(ContactFiles.Contact contact)
        {
            customer = new Customer();
            if (contact != null)
            {
                customer.ContactData = contact;
                ValidateID();
                customer.ID = newID;
                AddCustomer(customer);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Adds a new customer in the list. Returns true if successful.
        /// </summary>
        private bool AddCustomer(Customer customer)
        {
            if (customer != null)
            {
                customerList.Add(customer);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Returns a customer in the list with choosen index.
        /// </summary>
        public Customer GetCustomer(int index)
        {
            if (CheckIndex(index))
                return customerList[index];
            return null;

        }

        /// <summary>
        /// Removes a customer from the list with specified index. Returns true if successfull.
        /// </summary>
        public bool DeleteCustomer(int index)
        {
            if(CheckIndex(index))
            {
                customerList.RemoveAt(index);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Changes a customer in the list with specified index. Returns true if successfull.
        /// </summary>
        public bool EditCustomer(ContactFiles.Contact contact, int index)
        {
            if(CheckIndex(index))
            {
                customer = GetCustomer(index);
                customer.ContactData = contact;
                customerList.Insert(index, customer);
                customerList.RemoveAt(index+1);
                return true;
            }
            return false;
        }

        private bool CheckIndex(int index)
        {
            if (index >= 0 && index < customerList.Count)
                return true;
            return false;
        }

        private int GenerateID()
        {
            Random rand = new Random();
            return rand.Next(1000, 2000);
        }

        private void ValidateID()
        {
            bool check = false;
            int potentialID = GenerateID();
            if (customerList.Count.Equals(0))
                newID = GenerateID();
            else
            {
                for (int i = 0; i < customerList.Count; i++)
                {
                    if (!GetCustomer(i).ID.Equals(potentialID))
                        check = true;
                    else
                    {
                        check = false;
                        break;
                    }
                }
                if (check)
                    newID = potentialID;
                else
                    ValidateID();
            }
        }

        /// <summary>
        /// Returns a string representation of the customer with its ID.
        /// </summary>
        public string CustomerNameAndIDString(int index)
        {
            return string.Format("{0,-10}{1}", GetCustomer(index).ID.ToString(), GetCustomer(index).ContactData.FullName);
        }
    }
}
