/// <summary>
/// FoodSchedule.cs
/// Created: Viktor Rusnak, 2015-02-21
/// Revised:  
/// Purpose: To create a list containing daily feeding requirements.
/// </summary>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4_lvl2
{
    /// <summary>
    /// The class handles the list of the feeing requirements for a specific animal species.
    /// </summary>
    public class FoodSchedule
    {
        private List<string> foodDescriptionList;

        /// <summary>
        /// Property Count. Returns the current number of items in the food schedule list.
        /// </summary>
        public int Count
        {
            get { return foodDescriptionList.Count; }
        }

        /// <summary>
        /// Constructor FoodSchedule. Creates a new list.
        /// </summary>
        public FoodSchedule() 
        {
            foodDescriptionList = new List<string>();
        }

        /// <summary>
        /// Returns true if adding an item to the food schedule list was successful, otherwise returns false.
        /// </summary>
        public bool AddFoodScheduleItem(string item)
        {
            if (item != string.Empty)
            {
                foodDescriptionList.Add(item);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Returns true if changing an item in the food schedule list was successful, otherwise returns false.
        /// </summary>
        public bool ChangeFoodScheduleItem(string item, int index)
        {
            if(item != string.Empty && ValidateIndex(index))
            {
                foodDescriptionList[index] = item;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Returns true if removing an item in the food schedule list was successful, otherwise returns false.
        /// </summary>
        public bool DeleteFoodScheduleItem(int index)
        {
            foodDescriptionList.RemoveAt(index);
            return false;
        }

        /// <summary>
        /// Returns true if current index is a valid number in the food schedule list, otherwise returns false.
        /// </summary>
        public bool ValidateIndex(int index)
        {
            if (index <= Count)
                return true;
            return false;
        }

        /// <summary>
        /// Returns the food schedule with the specified index. 
        /// </summary>
        public string GetFoodSchedule(int index)
        {
            return foodDescriptionList[index];
        }

        /// <summary>
        /// Returns the food schedule list. 
        /// </summary>
        public List<string> MyFoodSchedule()
        {
            return this.foodDescriptionList;
        }

        /// <summary>
        /// Returns a string representing that feeding is requried for the animal species.
        /// </summary>
        public string DescribeNoFeedingRequired()
        {
            return "Self-feeding. No feeding required!";
        }
    }
}
