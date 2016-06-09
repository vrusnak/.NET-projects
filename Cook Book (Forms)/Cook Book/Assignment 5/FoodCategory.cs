/// <summary>
/// FoodCategory.cs
/// Created:  Viktor Rusnak, 2014-10-28
/// Revised:  
/// Purpose:  To create an enum with different food types.
/// </summary>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    /// <summary>
    /// This class handles the enum-type FoodCategory.
    /// </summary>
    public class FoodCategory
    {
        /// <summary>
        /// An enum for different prioritys.
        /// </summary>
        public enum FoodType
        {
            Meat,
            Vegeterian,
            Fish,
            Seafood
        }
    }
}
