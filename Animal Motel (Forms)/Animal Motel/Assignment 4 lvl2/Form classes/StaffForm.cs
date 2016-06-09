/// <summary>
/// StaffForm.cs
/// Created:  Viktor Rusnak, 2015-03-15
/// Revised:  
/// Purpose:  To handle the communication with the user through an graphical user interface.
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

namespace Assignment_4_lvl2
{
    /// <summary>
    /// This class handles the communication of the program with the user when adding a new staff member. 
    /// It displays an windows form for the user. 
    /// </summary>
    public partial class StaffForm : Form
    {
        Staff staffObj;

        /// <summary>
        /// This constructor opens up the form.
        /// </summary>
        public StaffForm(Staff staffObj)
        {
            InitializeComponent();
            this.staffObj = staffObj;
            this.Text = "Add a new staffmember";
            this.Icon = Properties.Resources.staffform;
            if (staffObj != null)
                staffObj.Qualifications.Deletall();
        }

        /// <summary>
        /// Property Staff. Returns and sets a new object of the Staff class.
        /// </summary>
        public Staff Staff
        {
            get { return staffObj; }
            set { this.staffObj = value; }
        }

        /// <summary>
        /// Method is called when a qualification for the staff member is added.
        /// </summary>
        private void btnAddQualifaication_Click(object sender, EventArgs e)
        {
            staffObj.Qualifications.Add(textBoxQualification.Text);
            textBoxQualification.Text = string.Empty;
            textBoxQualification.Focus();
            UpdateIngredients();
        }

        /// <summary>
        /// Adds all current qualifications in the form listbox.
        /// </summary>
        private void UpdateIngredients()
        {
            lbQualifications.Items.Clear();
            foreach (string item in staffObj.Qualifications.ToStringArray())
                lbQualifications.Items.Add(item);
        }

        /// <summary>
        /// Method is called when the form closes by the press of OK-button.
        /// </summary>
        private void btnOK_IngredientsForm_Click(object sender, EventArgs e)
        {
            if (staffObj.Name != string.Empty)
                staffObj.Name = textBoxEmplayeName.Text;
            else
                staffObj.Name = null;
        }
    }
}
