/// <summary>
/// EditIngredientForm.cs
/// Created:  Viktor Rusnak, 2014-10-28
/// Revised:  
/// Purpose:  To edit a selected ingredient.
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

namespace Assignment_5
{
    /// <summary>
    /// This class handles the task when the user wants to change a speciefic ingredient.
    /// </summary>
    public partial class EditIngredientForm : Form
    {
        /// <summary>
        /// Constructor EditIngredientForm. Takes a parameter str.
        /// </summary>
        public EditIngredientForm(string str)
        {
            InitializeComponent();
            this.Text = str;
            InitializeGUI();
        }

        private void InitializeGUI()
        {
            this.Icon = Properties.Resources.carrot;
            this.lblRequest.Text = "Write a new ingredient:\n(only the selected ingredient will be changed)";
            textBoxRequest.Text = string.Empty;
        }

        /// <summary>
        /// Returns a string with the name of the new ingredient.
        /// </summary>
        public string GetNewIngredient()
        {
            return textBoxRequest.Text;
        }
    }
}
