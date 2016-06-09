/// <summary>
/// RecipeManager.cs
/// Created:  Viktor Rusnak, 2014-10-28
/// Revised:  
/// Purpose:  To create a new array to store all the recipies in.
/// </summary>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    /// <summary>
    /// This class creates a new recipe array to store all recipies in. 
    /// It also handles any changes that will be needed to a specific recipe.
    /// </summary>
    class RecipeManager
    {
        private Recipe[] recipeList;

        /// <summary>
        /// Constructor RecipeManager. Takes one parameter maxNumOfElements and creates the recipe array.
        /// </summary>
        public RecipeManager(int maxNumOfElements)
        {
            recipeList = new Recipe[maxNumOfElements];
        }

        /// <summary>
        /// Returns true if a new recipe was added successfully into the recipe array, otherwise false.
        /// </summary>
        public bool AddRecipe(string name, FoodCategory.FoodType category, string description, string[] ingredients)
        {
            int index = FindVacantPosition();
            if (index >= 0)
            {
                Recipe recipe = new Recipe(ingredients.Length);
                recipe.Name = name;
                recipe.Description = description;
                recipe.Category = category;
                recipe.Ingredients = ingredients;
                recipeList[index] = recipe;
                return true;
            }
            return false;
        }

        private int FindVacantPosition()
        {
            for (int i = 0; i < recipeList.Length; i++)
            {
                if (recipeList[i] == null)
                    return i;
            }
            return -1;
        }

        private bool CheckRecipe(Recipe newRecipe)
        {
            if (newRecipe != null)
                return true;
            return false;
        }

        private bool CheckIndex(int index)
        {
            if (recipeList[index] != null)
                return true;
            return false;
        }

        /// <summary>
        /// Returns a recipe with the current index.
        /// </summary>
        public Recipe GetRecipeAt(int index)
        {
            if (CheckIndex(index))
                return recipeList[index];
            else
                return null;
        }

        /// <summary>
        /// Returns the current number of recipies in the recipes array.
        /// </summary>
        public int GetCurrentNumOfRecipies()
        {
            int count = 0;
            for (int i = 0; i < recipeList.Length; i++)
            {
                if (recipeList[i] != null)
                    count++;
            }
            return count;
        }

        /// <summary>
        /// Returns true if the current recipe was deleted successfully'
        /// </summary>
        public bool DeleteRecipe(int index)
        {
            if (CheckIndex(index))
            {
                recipeList[index] = null;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Shifts all the elements above the current index one step and deletes the old position.
        /// </summary>
        public void ShiftArray(int index)
        {
            for (int i = index; i < recipeList.Length - 1; i++)
            {
                recipeList[i] = recipeList[i + 1];
                DeleteRecipe(i + 1);
            }
        }

        private void TemporaryNewArray(int maxNumOfElements)
        {
            Recipe[] recipeListTempArray = new Recipe[maxNumOfElements];

            for (int i = 0; i < recipeList.Length; i++)
            {
                if (CheckIndex(i))
                    recipeListTempArray[i] = GetRecipeAt(i);
            }
            recipeList = recipeListTempArray;
        }

        /// <summary>
        /// Returns a string array representing all the recipes in as a string.
        /// </summary>
        public string[] RecipeListToString(int maxNumOfElements)
        {
            TemporaryNewArray(maxNumOfElements);
            string[] recipeListStringArray = new string[maxNumOfElements];

            for (int i = 0; i < recipeList.Length; i++)
            {
                if (CheckIndex(i))
                    recipeListStringArray[i] = GetRecipeAt(i).ToString();
            }
            return recipeListStringArray;
        }
    }
}
