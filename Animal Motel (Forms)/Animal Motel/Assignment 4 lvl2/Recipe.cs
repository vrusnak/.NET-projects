/// <summary>
/// MainForm.cs
/// Created:  Viktor Rusnak, 2015-03-15
/// Revised:  
/// Purpose:  To handle a new recipe.
/// </summary>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4_lvl2
{
    /// <summary>
    /// This class handles the communication of the program with the user. It displays an windows form for the user. 
    /// </summary>
    [Serializable]
    public class Recipe : ListManager<string>
    {
        private string name;
        private ListManager<string> ingredientList;

        /// <summary>
        /// Constructor Recipe. Takes no parameters. Creates a new list of ingredients.
        /// </summary>
        public Recipe()
        {
            ingredientList = new ListManager<string>();
        }

        /// <summary>
        /// Gets and sets the name.
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

        /// <summary>
        /// Returns the ingredient list.         
        /// </summary>
        public ListManager<string> Ingredients
        {
            get
            {
                return ingredientList;
            }
            set
            {
                this.ingredientList = value;
            }
        }
       
        /// <summary>
        /// Returns the current number of ingredients in the list.
        /// </summary>
        public int IngredientCount
        {
            get
            {
                return ingredientList.Count;
            }
        }

        /// <summary>
        /// Returns a formated string of all the fields.
        /// </summary>
        public override string ToString()
        {
            string ingredientString = string.Empty;
            foreach(string item in Ingredients.ToStringArray())
            {
                ingredientString += item + "; ";
            }

            if (!string.IsNullOrEmpty(ingredientString))
            {
                ingredientString = ingredientString.Remove(ingredientString.Length - 2);
            }

            string strOut = string.Format("{0,-18}{1,-6}",
                Name, ingredientString);
            return strOut;
        }     
    }
}
