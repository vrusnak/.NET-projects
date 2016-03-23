/// <summary>
/// ContactForm.cs
/// Created:  Viktor Rusnak, 2014-11-16
/// Revised:  
/// Purpose:  Displays a form for the user to input contact information.
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
    /// This class handles the task when the user wants to manage the contact information for a customer.
    /// </summary>
    public partial class ContactForm : Form
    {
        private ContactFiles.Contact contact;
        private bool runCloseForm, inputError, keepForm, newContact, editContact;

        /// <summary>
        /// Constructor ContactForm. Initialize the form.
        /// </summary>
        public ContactForm(string title)
        {
            InitializeComponent();
            DefaultValues();
            InitializeGUI(title);
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
                if (value != null)
                {
                    this.contact = value;
                    InitializeTextBoxes();
                }
            }
        }

        /// <summary>
        /// Property NewContact. Sets a new contact.
        /// </summary>
        public bool NewContact
        {
            set { this.newContact = value; }
        }

        /// <summary>
        /// Property EditContact. Sets a new contact to be changed.
        /// </summary>
        public bool EditContact
        {
            set { this.editContact = value; }
        }

        /// <summary>
        /// Checks wether or not essential fields in the form contain a value before closing form.
        /// </summary>
        public void CheckInput()
        {
            string noFirstName = string.Empty, noLastName = string.Empty, noStreet = string.Empty,
                noCity = string.Empty, noZipcode = string.Empty, noCountry = string.Empty;
            inputError = false;

            if (string.IsNullOrEmpty(textBoxFirstName.Text))
            {
                noFirstName = lblFirstName.Text + "\n";
                inputError = true;
            }
            if (string.IsNullOrEmpty(textBoxLastName.Text))
            {
                noLastName = lblLastName.Text + "\n";
                inputError = true;
            }
            if (string.IsNullOrEmpty(textBoxStreet.Text))
            {
                noStreet = lblStreet.Text + "\n";
                inputError = true;
            }
            if (string.IsNullOrEmpty(textBoxCity.Text))
            {
                noCity = lblCity.Text + "\n";
                inputError = true;
            }
            if (string.IsNullOrEmpty(textBoxZipCode.Text))
            {
                noZipcode = lblZipCode.Text + "\n";
                inputError = true;
            }
            if (comboBoxCountry.SelectedIndex == -1)
            {
                noCountry = lblCountry.Text;
                inputError = true;
            }
            if (inputError)
            {
                MessageBox.Show("Please enter a valid:\n\n" + noFirstName + noLastName + noStreet +
                noCity + noZipcode + noCountry);
            }
        }

        private void DefaultValues()
        {
            contact = null;
            textBoxFirstName.Text = string.Empty;
            textBoxLastName.Text = string.Empty;
            textBoxHomePhone.Text = string.Empty;
            textBoxCellPhone.Text = string.Empty;
            textBoxEmailWork.Text = string.Empty;
            textBoxEmailPersonal.Text = string.Empty;
            textBoxStreet.Text = string.Empty;
            textBoxCity.Text = string.Empty;
            textBoxZipCode.Text = string.Empty;
            comboBoxCountry.SelectedIndex = -1;
        }

        private void InitializeGUI(string title)
        {
            this.Text = title;
            this.Icon = Properties.Resources.edit_icon;
            InitializeComboBox();
        }

        private void InitializeTextBoxes()
        {
            textBoxFirstName.Text = contact.FirstName;
            textBoxLastName.Text = contact.LastName;
            textBoxHomePhone.Text = contact.PhoneData.HomePhone;
            textBoxCellPhone.Text = contact.PhoneData.CellPhone;
            textBoxEmailWork.Text = contact.EmailData.Work;
            textBoxEmailPersonal.Text = contact.EmailData.Personal;
            textBoxStreet.Text = contact.AddressData.Street;
            textBoxCity.Text = contact.AddressData.City;
            textBoxZipCode.Text = contact.AddressData.ZipCode;
            comboBoxCountry.SelectedIndex = contact.AddressData.CountryIndex;
        }

        private void InitializeComboBox()
        {
            string[] countries = Enum.GetNames(typeof(Countries));
            foreach (string str in countries)
                comboBoxCountry.Items.Add(str.Replace("_", " "));
        }

        private void ReadName()
        {
            contact.FirstName = textBoxFirstName.Text;
            contact.LastName = textBoxLastName.Text;
        }

        private void ReadAddress()
        {
            contact.SetAdress(textBoxStreet.Text, textBoxCity.Text,
                textBoxZipCode.Text, (Countries)comboBoxCountry.SelectedIndex, comboBoxCountry.SelectedIndex);
        }

        private void ReadPhone()
        {
            contact.SetPhone(textBoxHomePhone.Text, textBoxCellPhone.Text);
        }

        private void ReadEmail()
        {
            contact.SetEmail(textBoxEmailWork.Text, textBoxEmailPersonal.Text);
        }

        private void ReadInput()
        {
            ReadName();
            ReadAddress();
            ReadPhone();
            ReadEmail();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            CheckInput();
            if (inputError)
                keepForm = true;
            else
            {
                if (newContact)
                {
                    keepForm = false;
                    contact = new ContactFiles.Contact();
                    ReadInput();
                    runCloseForm = false;
                }
                else if (editContact)
                {
                    keepForm = false;
                    ReadInput();
                    runCloseForm = false;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            runCloseForm = true;
            this.Close();
        }

        private void ContactForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (keepForm)
                e.Cancel = true;
            if (runCloseForm)
            {
                if (newContact)
                {
                    DialogResult dlg = MessageBox.Show("Discard all data?",
                        "Close form?".PadRight(60), MessageBoxButtons.YesNo);
                if (dlg == DialogResult.Yes)
                        e.Cancel = false;
                    else
                        e.Cancel = true;
                }
                else if(editContact)
                {
                    DialogResult dlg = MessageBox.Show("Are you sure? \n(No information will be edited)",
                        "Close form?".PadRight(60), MessageBoxButtons.YesNo);
                    if (dlg == DialogResult.Yes)
                        e.Cancel = false;
                    else
                        e.Cancel = true;
                }
            }
        }
    }
}
