/// <summary>
/// Mammal.cs
/// Created:  Viktor Rusnak, 2015-02-06
/// Revised:  
/// Purpose:  Common class for all mammal species.
/// </summary>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4_lvl2
{
    /// <summary>
    /// The class handles the common features and characteristics of all mammal animals. Inherits the Animal class.
    /// </summary>
    [Serializable]
    abstract class Mammal : Animal
    {
        private int nbrOfTeeth;

        /// <summary>
        /// Default constructor for the Bird class.
        /// </summary>
        public Mammal() { }

        /// <summary>
        /// Creates a enum for the different types of mammal animals.
        /// </summary>
        public enum MammalTypes
        {
            Cat,
            Dog,
            Bear,
            Deer
        }

        /// <summary>
        /// Property NbrOfTeeth. Gets or sets the number of teeth on the mammal.
        /// </summary>
        public int NbrOfTeeth
        {
            get { return nbrOfTeeth; }
            set { this.nbrOfTeeth = value; }
        }

        /// <summary>
        /// Returns a string representation of the mammal characteristics.
        /// </summary>
        public override string ToString()
        {
            return base.ToString() + "This mammal has " + NbrOfTeeth + " teeths. ";
        }
    }
}
