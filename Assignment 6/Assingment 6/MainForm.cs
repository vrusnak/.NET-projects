/// <summary>
/// MainForm.cs
/// Created:  Viktor Rusnak, 2014-11-16
/// Revised:  
/// Purpose:  To manage customers.
/// </summary>
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assingment_6
{
    /// <summary>
    /// This class handles the task when the user wants to manage a new or selected customer.
    /// </summary>
    public partial class MainForm : Form
    {
        private CustomerManager customerMngr = new CustomerManager();

        /// <summary>
        /// Constructor MainForm. Initializes the application.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }

        private void InitializeGUI()
        {
            this.Text = "Customer registry".PadRight(105);
            this.Icon = Properties.Resources.Doc_Registry_icon;
            this.lblSearch.Text = "Search for a customer\n(Enter ID, first name or surname)";
            InitializeTextBoxes();
            DisableModBtns();
        }

        private void InitializeTextBoxes()
        {
            textBoxFirstName.Text = string.Empty;
            textBoxLastName.Text = string.Empty;
            textBoxHomePhone.Text = string.Empty;
            textBoxCellPhone.Text = string.Empty;
            textBoxEmailWork.Text = string.Empty;
            textBoxEmailPersonal.Text = string.Empty;
            textBoxStreet.Text = string.Empty;
            textBoxCity.Text = string.Empty;
            textBoxZipCode.Text = string.Empty;
            textBoxCountry.Text = string.Empty;
            DisableModBtns();
        }

        private void UpdateListBox()
        {
            listBoxRegistry.Items.Clear();
            for (int i = 0; i < customerMngr.Count; i++)
            {
                if (!string.IsNullOrEmpty(customerMngr.CustomerNameAndIDString(i)))
                    listBoxRegistry.Items.Add(customerMngr.CustomerNameAndIDString(i));
            }
        }

        private void UpdateGroupBox()
        {
            Customer tempCustomer = customerMngr.GetCustomer(listBoxRegistry.SelectedIndex);
            textBoxFirstName.Text = tempCustomer.ContactData.FirstName;
            textBoxLastName.Text = tempCustomer.ContactData.LastName;
            if (!string.IsNullOrEmpty(tempCustomer.ContactData.PhoneData.HomePhone))
                textBoxHomePhone.Text = tempCustomer.ContactData.PhoneData.HomePhone;
            else
                textBoxHomePhone.Text = "No data";
            if (!string.IsNullOrEmpty(tempCustomer.ContactData.PhoneData.CellPhone))
                textBoxCellPhone.Text = tempCustomer.ContactData.PhoneData.CellPhone;
            else
                textBoxCellPhone.Text = "No data";
            if (!string.IsNullOrEmpty(tempCustomer.ContactData.EmailData.Work))
                textBoxEmailWork.Text = tempCustomer.ContactData.EmailData.Work;
            else
                textBoxEmailWork.Text = "No data";
            if (!string.IsNullOrEmpty(tempCustomer.ContactData.EmailData.Personal))
                textBoxEmailPersonal.Text = tempCustomer.ContactData.EmailData.Personal;
            else
                textBoxEmailPersonal.Text = "No data";
            textBoxStreet.Text = tempCustomer.ContactData.AddressData.Street;
            textBoxCity.Text = tempCustomer.ContactData.AddressData.City;
            textBoxZipCode.Text = tempCustomer.ContactData.AddressData.ZipCode;
            textBoxCountry.Text = tempCustomer.ContactData.AddressData.Country.ToString().Replace("_", " ");
        }

        private void EnableModBtns()
        {
            btnAdd.Enabled = false;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            btnUnselect.Enabled = true;
        }

        private void DisableModBtns()
        {
            btnAdd.Enabled = true;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnUnselect.Enabled = false;
        }

        private void SearchListBox()
        {
            if (!string.IsNullOrEmpty(textBoxSearch.Text))
            {
                listBoxRegistry.SelectedIndex = -1;
                for (int i = 0; i < listBoxRegistry.Items.Count; i++)
                {
                    if (listBoxRegistry.Items[i].ToString().ToLower().Contains(textBoxSearch.Text.ToLower()))
                    {
                            listBoxRegistry.SetSelected(i, true);
                            listBoxRegistry.SelectionMode = SelectionMode.MultiSimple;
                    }
                }
                if(listBoxRegistry.SelectedItems.Count > 1)
                {
                    listBoxRegistry.SelectionMode = SelectionMode.MultiSimple;
                    InitializeTextBoxes();
                    btnAdd.Enabled = false;
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                }
                else
                    listBoxRegistry.SelectionMode = SelectionMode.One;
                lblSearchResult.Text = listBoxRegistry.SelectedItems.Count + " items found!";
            }
            else
                MessageBox.Show("Enter the ID or the name of the customer");
        }

        private void listBoxRegistry_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxRegistry.SelectedIndex >= 0 && listBoxRegistry.SelectedItems.Count == 1)
            {
                listBoxRegistry.SelectionMode = SelectionMode.One;
                UpdateGroupBox();
                EnableModBtns();
            }
            else
            {
                InitializeTextBoxes();
                DisableModBtns();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ContactForm contactForm = new ContactForm("Add New Customer".PadRight(55));
            contactForm.NewContact = true;

            if (contactForm.ShowDialog() == DialogResult.OK)
            {
                customerMngr.AddCustomer(contactForm.ContactData);
                UpdateListBox();
                listBoxRegistry.SelectionMode = SelectionMode.One;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will remove the selected contact", "Remove contact?".PadRight(60), MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (listBoxRegistry.SelectedIndex >= 0)
                {
                    customerMngr.DeleteCustomer(listBoxRegistry.SelectedIndex);
                    listBoxRegistry.Items.RemoveAt(listBoxRegistry.SelectedIndex);
                    listBoxRegistry.SelectionMode = SelectionMode.One;
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (listBoxRegistry.SelectedIndex >= 0)
            {
                ContactForm contactForm = new ContactForm("Edit Customer".PadRight(60));
                contactForm.ContactData = customerMngr.GetCustomer(listBoxRegistry.SelectedIndex).ContactData;
                contactForm.EditContact = true;

                if (contactForm.ShowDialog() == DialogResult.OK)
                {
                    customerMngr.EditCustomer(contactForm.ContactData, listBoxRegistry.SelectedIndex);
                    UpdateListBox();
                    InitializeTextBoxes();
                    listBoxRegistry.SelectionMode = SelectionMode.One;
                }
            }
        }

        private void btnUnselect_Click(object sender, EventArgs e)
        {
            if (listBoxRegistry.SelectedIndex >= 0)
            {
                listBoxRegistry.SelectedIndex = -1;
                listBoxRegistry.SelectionMode = SelectionMode.One;
                textBoxSearch.Text = string.Empty;
                lblSearchResult.Text = "";
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchListBox();
        }

        private void textBoxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                SearchListBox();
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Number of contacts limited to 1000");
        }
    }
}

