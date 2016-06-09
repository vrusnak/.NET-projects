/// <summary>
/// Marine.cs
/// Created:  Viktor Rusnak, 2015-02-06
/// Revised:  
/// Purpose:  Common class for all marine species.
/// </summary>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4_lvl2
{
    /// <summary>
    /// The class handles the common features and characteristics of all marine animals. Inherits the Animal class.
    /// </summary>
    [Serializable]
    abstract class Marine : Animal
    {
        private double weight;

        /// <summary>
        /// Default constructor for the Marine class.
        /// </summary>
        public Marine() { }

        /// <summary>
        /// Creates a enum for the different types of marine animals.
        /// </summary>
        public enum MarineTypes
        {
            Shark,
            Dolphin
        }

        /// <summary>
        /// Property Weight. Gets or sets the weight of the marine animal.
        /// </summary>
        public double Weigth
        {
            get { return weight; }
            set { this.weight = value; }
        }

        /// <summary>
        /// Returns a string representation of the marine animal characteristics.
        /// </summary>
        public override string ToString()
        {
            return base.ToString() + "This marine animal weighs approximately " + weight + " kg. ";
        }
    }
}
