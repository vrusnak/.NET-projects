/// <summary>
/// MainForm.cs
/// Created:  Viktor Rusnak, 2014-10-28
/// Revised:  
/// Purpose:  To start up and initialize the program
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
    /// This class handles the communication of the program. It displays an windows form for the user. 
    /// The user can then add new recipies and also modify them.
    /// </summary>
    public partial class MainForm : Form
    {
        private const int maxNumOfIngredients = 50;
        private const int maxNumOfElements = 20;
        Recipe recipeObj = new Recipe(maxNumOfIngredients);
        RecipeManager recipeManagerObj = new RecipeManager(maxNumOfElements);

        /// <summary>
        /// This constructor opens up the application.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }

        private void InitializeGUI()
        {
            this.Text = "Cook Book";
            this.Icon = Properties.Resources._19_kitchen___recipe_book_512;
            lblCount_MainForm.Text = recipeManagerObj.GetCurrentNumOfRecipies().ToString();
            InitializeComboBox();
            InitializeTextBoxes();
            UpdateListBox(maxNumOfElements);
        }

        private void InitializeComboBox()
        {
            comboBoxCategory.Items.AddRange(Enum.GetNames(typeof(FoodCategory.FoodType)));
            comboBoxCategory.SelectedIndex = 1;
        }

        private void InitializeTextBoxes()
        {
            textBoxNameOfRecipe.Text = string.Empty;
            textBoxDescription.Text = string.Empty;
        }

        private void ReadInput()
        {
            recipeObj.Name = textBoxNameOfRecipe.Text;
            recipeObj.Description = textBoxDescription.Text;
            recipeObj.Category = (FoodCategory.FoodType)comboBoxCategory.SelectedIndex;
        }

        private void UpdateGUI()
        {
            UpdateListBox(maxNumOfElements);
            lblCount_MainForm.Text = recipeManagerObj.GetCurrentNumOfRecipies().ToString();
            InitializeTextBoxes();
            comboBoxCategory.SelectedIndex = 1;
        }

        private void UpdateListBox(int maxNumOfElements)
        {
            listBoxRecipes.Items.Clear();
            for (int i = 0; i < recipeManagerObj.RecipeListToString(maxNumOfElements).Length; i++)
            {
                if (!string.IsNullOrEmpty(recipeManagerObj.RecipeListToString(maxNumOfElements)[i]))
                    listBoxRecipes.Items.Add(recipeManagerObj.RecipeListToString(maxNumOfElements)[i]);
            }
        }

        private void ResetRecipeObject()
        {
            recipeObj = new Recipe(maxNumOfIngredients);
        }

        private void EnableModifierButtons()
        {
            btnAddRecipe.Enabled = false;
            btnUnselect.Enabled = true;
            btnEdit_MainForm.Enabled = true;
            btnDelete_MainForm.Enabled = true;
        }

        private void DisableModifierButtons()
        {
            btnAddRecipe.Enabled = true;
            btnUnselect.Enabled = false;
            btnEdit_MainForm.Enabled = false;
            btnDelete_MainForm.Enabled = false;
        }

        private void btnAddRecipe_Click(object sender, EventArgs e)
        {
            ReadInput();
            if (!string.IsNullOrEmpty(recipeObj.Name))
            {
                if (recipeManagerObj.AddRecipe(recipeObj.Name, recipeObj.Category, recipeObj.Description, recipeObj.Ingredients))
                {
                    UpdateGUI();
                    ResetRecipeObject();
                    textBoxNameOfRecipe.Focus();
                }
                else
                {
                    MessageBox.Show("Recipe limit reached!");
                    textBoxNameOfRecipe.Focus();
                }
            }
            else
                MessageBox.Show("Please enter a name for your recipe!");
        }

        private void btnAddIngredients_Click(object sender, EventArgs e)
        {
            recipeObj.Name = textBoxNameOfRecipe.Text;
            IngredientsForm dlg = new IngredientsForm(recipeObj);
            DialogResult dlgResult = dlg.ShowDialog();

            if (dlgResult == DialogResult.OK)
            {
                recipeObj.AddIngredient();

                if (recipeObj.GetCurrentNumOfIngredientsArrays() <= 0)
                    MessageBox.Show("No ingredients added!");
            }
            else if (dlgResult == DialogResult.Cancel)
            {
                recipeObj.ResetTempArray();
                MessageBox.Show("No new ingredients added!");
            }
        }

        private void btnEdit_MainForm_Click(object sender, EventArgs e)
        {
            Recipe tempRecipe = recipeManagerObj.GetRecipeAt(listBoxRecipes.SelectedIndex);
            DialogResult dlg = MessageBox.Show("This will overwrite the selected recipe! Continue?",
                    tempRecipe.Name, MessageBoxButtons.YesNo);
            if (dlg == DialogResult.Yes)
            {
                tempRecipe.Name = textBoxNameOfRecipe.Text;
                tempRecipe.Category = (FoodCategory.FoodType)comboBoxCategory.SelectedIndex;
                tempRecipe.Description = textBoxDescription.Text;
                ResetRecipeObject();
                UpdateGUI();
                DisableModifierButtons();
            }
            else
                textBoxNameOfRecipe.Focus();
        }

        private void btnDelete_MainForm_Click(object sender, EventArgs e)
        {
            Recipe tempRecipe = recipeManagerObj.GetRecipeAt(listBoxRecipes.SelectedIndex);
            DialogResult dlg = MessageBox.Show("This will remove the selected recipe! Continue?",
                tempRecipe.Name, MessageBoxButtons.YesNo);
            if (dlg == DialogResult.Yes)
            {
                if (listBoxRecipes.SelectedIndex >= 0)
                {
                    recipeManagerObj.DeleteRecipe(listBoxRecipes.SelectedIndex);
                    recipeManagerObj.ShiftArray(listBoxRecipes.SelectedIndex);
                    listBoxRecipes.Items.RemoveAt(listBoxRecipes.SelectedIndex);
                    ResetRecipeObject();
                    UpdateGUI();
                    DisableModifierButtons();
                }
                else
                    textBoxNameOfRecipe.Focus();
            }
        }

        private void btnUnselect_Click(object sender, EventArgs e)
        {
            if (listBoxRecipes.SelectedIndex >= 0)
            {
                comboBoxCategory.SelectedIndex = 1;
                listBoxRecipes.SelectedIndex = -1;
                ResetRecipeObject();
            }
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Maximum number of recipes is limited to " + maxNumOfElements + ".\n" +
            "Maximum number of ingredients is limited to " + maxNumOfIngredients + ".");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBoxRecipes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxRecipes.SelectedIndex >= 0)
            {
                Recipe tempRecipe = recipeManagerObj.GetRecipeAt(listBoxRecipes.SelectedIndex);
                textBoxNameOfRecipe.Text = tempRecipe.Name;
                comboBoxCategory.SelectedIndex = tempRecipe.GetCategoryIndex();
                textBoxDescription.Text = tempRecipe.Description;
                recipeObj.Ingredients = tempRecipe.Ingredients;
                EnableModifierButtons();
            }
            else
            {
                DisableModifierButtons();
                InitializeTextBoxes();
            }
        }
    }
}
