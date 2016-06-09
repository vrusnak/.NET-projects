/// <summary>
/// Insect.cs
/// Created:  Viktor Rusnak, 2015-02-06
/// Revised:  
/// Purpose:  Common class for all insect species.
/// </summary>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4_lvl2
{
    /// <summary>
    /// The class handles the common features and characteristics of all insect animals. Inherits the Animal class.
    /// </summary>
    [Serializable]
    abstract class Insect : Animal
    {
        private int nbrOfLegs;

        /// <summary>
        /// Default constructor for the Bird class.
        /// </summary>
        public Insect() { }

        /// <summary>
        /// Creates a enum for the different types of Insects.
        /// </summary>
        public enum InsectTypes
        {
            Bee,
            ButterFly
        }

        /// <summary>
        /// Property NbrOfLegs. Gets or sets the number of legs on the insect.
        /// </summary>
        public int NbrOfLegs
        {
            get { return nbrOfLegs; }
            set { this.nbrOfLegs = value; }
        }

        /// <summary>
        /// Returns a string representation of the insect characteristics.
        /// </summary>
        public override string ToString()
        {
            return base.ToString() + "This is a " + NbrOfLegs + "-legged insect. ";
        }
    }
}
