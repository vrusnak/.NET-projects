/// <summary>
/// IngredientsForm.cs
/// Created:  Viktor Rusnak, 2014-10-28
/// Revised:  
/// Purpose:  To add new ingredients to the recipe or to modify them.
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
    /// This class handles the task of adding ingredients to a recipe or modifying a speciefic ingredient.
    /// </summary>
    public partial class IngredientsForm : Form
    {
        private Recipe currRecipe;

        /// <summary>
        /// Constructor IngredientsForm. Takes one parameter recipe.
        /// </summary>
        public IngredientsForm(Recipe recipe)
        {
            InitializeComponent();
            this.currRecipe = recipe;

            if (string.IsNullOrEmpty(recipe.Name))
                this.Text = "No recipe name";
            else
                this.Text = recipe.Name + " - Add ingredients";

            InitializeGUI();
        }

        private void InitializeGUI()
        {
            this.Icon = Properties.Resources.carrot;
            if (currRecipe.Ingredients == null)
                currRecipe.Ingredients = new string[currRecipe.MaxNumOfIngredients];
            lblCount_IngredientsForm.Text = currRecipe.GetCurrentNumOfIngredientsArrays().ToString();
            textBoxIngredient_IngredientsForm.Text = string.Empty;
            listBoxIngredients_IngredientsForm.Items.Clear();
            AddIngredientsToListBox();
        }

        private void AddIngredientsToListBox()
        {
            for (int i = 0; i < currRecipe.Ingredients.Length; i++)
            {
                if (!string.IsNullOrEmpty(currRecipe.Ingredients[i]))
                    listBoxIngredients_IngredientsForm.Items.Add(currRecipe.Ingredients[i]);
            }
        }

        private void ReadInput()
        {
            if (!string.IsNullOrEmpty(textBoxIngredient_IngredientsForm.Text))
            {
                if (currRecipe.temporaryAddIngredient(textBoxIngredient_IngredientsForm.Text))
                    UpdateGUI();
                else
                {
                    MessageBox.Show("Ingredient limit reached!");
                    textBoxIngredient_IngredientsForm.Text = string.Empty;
                }
            }
            else
            {
                MessageBox.Show("Please type in an ingredient before you press \"Add\"!");
                textBoxIngredient_IngredientsForm.Focus();
            }
        }

        private void UpdateGUI()
        {
            listBoxIngredients_IngredientsForm.SelectedIndex = -1;
            listBoxIngredients_IngredientsForm.Items.Add(textBoxIngredient_IngredientsForm.Text);
            textBoxIngredient_IngredientsForm.Text = string.Empty;
            textBoxIngredient_IngredientsForm.Focus();
            lblCount_IngredientsForm.Text = currRecipe.GetCurrentNumOfIngredientsArrays().ToString();
            DisableModifierButtons();
        }

        private void EnableModifierButtons()
        {
            btnEdit_IngredientsForm.Enabled = true;
            btnDelete_IngredientsForm.Enabled = true;
        }

        private void DisableModifierButtons()
        {
            btnEdit_IngredientsForm.Enabled = false;
            btnDelete_IngredientsForm.Enabled = false;
        }

        private void btnAdd_IngredientsForm_Click(object sender, EventArgs e)
        {
            ReadInput();
        }

        private void btnEdit_IngredientsForm_Click(object sender, EventArgs e)
        {
            if (listBoxIngredients_IngredientsForm.SelectedIndex != -1)
            {
                EditIngredientForm dlg = new EditIngredientForm(listBoxIngredients_IngredientsForm.SelectedItem.ToString());
                DialogResult dlgResult = dlg.ShowDialog();

                if (dlgResult == DialogResult.OK)
                {
                    currRecipe.ChangeIngredientAt(listBoxIngredients_IngredientsForm.SelectedIndex, dlg.GetNewIngredient());
                    UpdateGUI();
                    InitializeGUI();
                }
            }
        }

        private void btnDelete_IngredientsForm_Click(object sender, EventArgs e)
        {
            DialogResult dlg = MessageBox.Show("The selected ingredient will be removed! Continue?",
                listBoxIngredients_IngredientsForm.SelectedItem.ToString(), MessageBoxButtons.YesNo);
            if (dlg == DialogResult.Yes)
            {
                currRecipe.DeleteIngredientAt(listBoxIngredients_IngredientsForm.SelectedIndex);
                currRecipe.ShiftArray(listBoxIngredients_IngredientsForm.SelectedIndex);
                UpdateGUI();
                InitializeGUI();
            }
        }

        private void listBoxIngredients_IngredientsForm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxIngredients_IngredientsForm.SelectedIndex >= 0)
                EnableModifierButtons();
            else
                DisableModifierButtons();
        }

        private void IngredientsForm_Load(object sender, EventArgs e)
        {
            toolTipExample.SetToolTip(textBoxIngredient_IngredientsForm, "Example: \"2dl Milk\"");
        }
    }
}
