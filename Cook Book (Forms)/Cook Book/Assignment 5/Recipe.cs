/// <summary>
/// Recipe.cs
/// Created:  Viktor Rusnak, 2014-10-28
/// Revised:  
/// Purpose:  To create a new recipe for the user.
/// </summary>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    /// <summary>
    /// The class handles the basic properties related to a specific recipe 
    /// such as name category and description as well as the ingredient-list. 
    /// </summary>
   public class Recipe
    {
        private string[] ingredientArray;
        private string[] tempArray;
        private FoodCategory.FoodType category;
        private string description;
        private string name;

        /// <summary>
        /// Constructor Recipe. Takes one parameter maxNumOfIngredients and creates a new string array. 
        /// Also sets default values.
        /// </summary>
        public Recipe(int maxNumOfIngredients)
        {
            ingredientArray = new string[maxNumOfIngredients];
            DefaultValues();
         }

       /// <summary>
       /// Property Category. Gets and sets the field category.
       /// </summary>
        public FoodCategory.FoodType Category
        {
            get
            {
                return category;
            }
            set
            {
                this.category = value;
            }
        }

        /// <summary>
        /// Property Description. Gets and sets the field description.
        /// </summary>
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                this.description = value;
            }
        }

        /// <summary>
        /// Property Ingredients. Gets and sets the string array ingretiendArray.         
        /// </summary>
        public string[] Ingredients
        {
            get
            {
                return ingredientArray;
            }
            set
            {
                this.ingredientArray = value;
            }
        }

       /// <summary>
       /// Returns the length of the ingredient array.
       /// </summary>
        public int MaxNumOfIngredients
        {
            get
            {
                return ingredientArray.Length;
            }
        }

       /// <summary>
       /// Gets and sets the field name.
       /// </summary>
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                this.name = value;
            }
        }

        private void DefaultValues()
        {
            ResetTempArray();
            for (int i = 0; i < ingredientArray.Length; i++)
                ingredientArray[i] = string.Empty;
            name = string.Empty;
            description = string.Empty;
            category = FoodCategory.FoodType.Vegeterian;
        }

        /// <summary>
        /// Adds a new ingredient to the ingredient array.
        /// </summary>
        public bool AddIngredient()
        {
            int index = FindVacantPosition();
            if (index >= 0)
            {
                for (int i = 0; i < tempArray.Length; i++)
                {
                    index = FindVacantPosition();
                    ingredientArray[index] = tempArray[i];
                }
                ResetTempArray();
            }
            return false;
        }

        /// <summary>
        /// Adds a new ingredient to a temporary ingredient array.
        /// </summary>
        public bool temporaryAddIngredient(string value)
        {
            int index = FindVacantPositionTempArray();
            if (index >= 0)
            {
                tempArray[index] = value;
                return true;
            }
            return false;
        }

        private int FindVacantPosition()
        {
            for (int i = 0; i < ingredientArray.Length; i++)
            {
                if (string.IsNullOrEmpty(ingredientArray[i]))
                    return i;
            }
            return -1;
        }

        private int FindVacantPositionTempArray()
        {
            if (FindVacantPosition() != -1)
            {
                for (int i = FindVacantPosition(); i < tempArray.Length; i++)
                {
                    if (string.IsNullOrEmpty(tempArray[i]))
                        return i;
                }
            }
            return -1;
        }

       /// <summary>
       /// Resets the temporary ingredient array.
       /// </summary>
       public void ResetTempArray()
        {
            tempArray = new string[MaxNumOfIngredients];
        }

       /// <summary>
       /// Returns true if the parameter index is inside the ingredient array, otherwise false.
       /// </summary>
        public bool CheckIndex(int index)
        {
            if (index >= 0 && index < ingredientArray.Length)
                return true;
            return false;
          }

        /// <summary>
        /// Returns the current number of ingredients in both the ingredient and temporary arrays.
        /// </summary>
        public int GetCurrentNumOfIngredientsArrays()
        {
            int count = 0;
            for (int i = 0; i < ingredientArray.Length; i++)
                if (!string.IsNullOrEmpty(ingredientArray[i]))
                    count++;
            for (int i = 0; i < tempArray.Length; i++)
                if (!string.IsNullOrEmpty(tempArray[i]))
                    count++;
            return count;
        }

       /// <summary>
       /// Returns true if the ingredient was changed successfully, otherwise false.
       /// </summary>
        public bool ChangeIngredientAt(int index, string value)
        {
            if (CheckIndex(index))
            {
                ingredientArray[index] = value;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Returns true if the ingredient was deleted successfully, otherwise false.
        /// </summary>
        public bool DeleteIngredientAt(int index)
        {
            if (CheckIndex(index))
            {
                ingredientArray[index] = string.Empty;
                return true;
            }
            return false;
        }

       /// <summary>
       /// Returns the index of the current category selected.
       /// </summary>
       public int GetCategoryIndex()
        {
            if (category.ToString() == "Meat")
                return 0;
            else if (category.ToString() == "Vegeterian")
                return 1;
            else if (category.ToString() == "Fish")
                return 2;
            else
                return 3;
        }

       /// <summary>
       /// Shifts all the elements above the current index one step and deletes the old position.
       /// </summary>
       public void ShiftArray(int index)
       {
           for (int i = index; i < ingredientArray.Length - 1; i++)
           {
               ingredientArray[i] = ingredientArray[i + 1];
               DeleteIngredientAt(i + 1);
           }
       }

       /// <summary>
       /// Returns a formated string of all the fields.
       /// </summary>
        public override string ToString()
        {
            int numberName = Math.Min(name.Length, 15);
            int numberDescription = Math.Min(description.Length, 30);
            string strDescription = description.Substring(0, numberDescription);
            string strName = name.Substring(0, numberName);
            if (string.IsNullOrEmpty(strDescription))
                strDescription = "No description found!";
            string strOut = string.Format("{0,-18}{1,-6}{2,-12}{3,0}", 
                strName, GetCurrentNumOfIngredientsArrays(), category.ToString(), strDescription);
            return strOut;
        }
    }
}
