/// <summary>
/// Reptile.cs
/// Created:  Viktor Rusnak, 2015-02-06
/// Revised:  
/// Purpose:  Common class for all reptile species.
/// </summary>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4_lvl2
{
    /// <summary>
    /// The class handles the common features and characteristics of all reptile animals. Inherits the Animal class.
    /// </summary>
    [Serializable]
    abstract class Reptile : Animal
    {
        private string skin;

        /// <summary>
        /// Default constructor for the Reptile class.
        /// </summary>
        public Reptile() { }

        /// <summary>
        /// Creates a enum for the different types of reptile animals.
        /// </summary>
        public enum ReptileTypes
        {
            Crocodile,
            Lizard,
            Snake
        }

        /// <summary>
        /// Property Skin. Gets or sets the weight of the reptile animal.
        /// </summary>
        public string Skin
        {
            get { return skin; }
            set { this.skin = value; }
        }

        /// <summary>
        /// Returns a string representation of the reptile animal characteristics.
        /// </summary>
        public override string ToString()
        {
            return base.ToString() + "The skin of this reptile is " + skin.ToLower() + " ";
        }
    }
}
