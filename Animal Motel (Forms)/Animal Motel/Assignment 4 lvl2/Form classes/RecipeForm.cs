/// <summary>
/// RecipeForm.cs
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
    /// This class handles the communication of the program with the user when adding a new recipe. 
    /// It displays an windows form for the user. 
    /// </summary>
    public partial class RecipeForm : Form
    {
        private Recipe recipe;

        /// <summary>
        /// This constructor opens up the form.
        /// </summary>
        public RecipeForm(Recipe recipeObj)
        {
            InitializeComponent();
            this.recipe = recipeObj;
            this.Text = "Add a new recipe";
            this.Icon = Properties.Resources.recipeform;
        }

        /// <summary>
        /// Method is called when the form closes by the press of OK-button.
        /// </summary>
        private void btnOK_IngredientsForm_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxName.Text))
                recipe.Name = textBoxName.Text;
        }

        /// <summary>
        /// Method is called when an ingredient for the recipe is added.
        /// </summary>
        private void btnAdd_IngredientsForm_Click(object sender, EventArgs e)
        {
            recipe.Ingredients.Add(textBoxIngredient_IngredientsForm.Text);
            lblCount_IngredientsForm.Text = recipe.IngredientCount.ToString();
            textBoxIngredient_IngredientsForm.Text = string.Empty;
            textBoxIngredient_IngredientsForm.Focus();
            UpdateIngredients();
        }

        /// <summary>
        /// Method is called when an ingredient for the recipe need to be edited.
        /// </summary>
        private void btnEdit_IngredientsForm_Click(object sender, EventArgs e)
        {
            if (listBoxIngredients_IngredientsForm.SelectedIndex != -1)
            {
                recipe.Ingredients.ChangeAt(textBoxIngredient_IngredientsForm.Text, listBoxIngredients_IngredientsForm.SelectedIndex);
                UpdateIngredients();
                textBoxIngredient_IngredientsForm.Text = string.Empty;
                btnEdit_IngredientsForm.Enabled = false;
                btnDelete_IngredientsForm.Enabled = false;
            }
        }

        /// <summary>
        /// Method is called when an ingredient for the recipe need to be removed.
        /// </summary>
        private void btnDelete_IngredientsForm_Click(object sender, EventArgs e)
        {
            recipe.Ingredients.DeleteAt(listBoxIngredients_IngredientsForm.SelectedIndex);
            UpdateIngredients();
            btnEdit_IngredientsForm.Enabled = false;
            btnDelete_IngredientsForm.Enabled = false;
        }

        /// <summary>
        /// Adds all current ingredients in the form listbox.
        /// </summary>
        private void UpdateIngredients()
        {
            listBoxIngredients_IngredientsForm.Items.Clear();
            foreach (string item in recipe.Ingredients.ToStringArray())
                listBoxIngredients_IngredientsForm.Items.Add(item);
        }

        /// <summary>
        /// Method is being called when a change in the form listbox occurs.
        /// </summary>
        private void listBoxIngredients_IngredientsForm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxIngredients_IngredientsForm.SelectedIndex != -1)
            {
                btnEdit_IngredientsForm.Enabled = true;
                btnDelete_IngredientsForm.Enabled = true;
            }
        }
    }
}
