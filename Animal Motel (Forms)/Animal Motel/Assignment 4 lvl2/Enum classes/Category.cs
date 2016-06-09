/// <summary>
/// Category.cs
/// Created:  Viktor Rusnak, 2015-02-06
/// Revised:  
/// Purpose:  Enumumeration for categorytypes.
/// </summary>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4_lvl2
{
    /// <summary>
    /// Creates a enum for the different types of animal categories.
    /// </summary>
    public class Category
    {
        public enum CategoryType
        {
            Bird,
            Insect,
            Mammal,
            Marine,
            Reptile
        }
    }
}
