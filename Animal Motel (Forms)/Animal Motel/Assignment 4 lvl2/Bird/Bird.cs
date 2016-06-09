/// <summary>
/// Bird.cs
/// Created:  Viktor Rusnak, 2015-02-06
/// Revised:  
/// Purpose:  Common class for all bird species.
/// </summary>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4_lvl2
{
    /// <summary>
    /// The class handles the common features and characteristics of all bird animals. Inherits the Animal class.
    /// </summary>
    [Serializable]
    abstract class Bird : Animal
    {
        private string colorOfBird;

        /// <summary>
        /// Default constructor for the Bird class.
        /// </summary>
        public Bird() { }

        /// <summary>
        /// Creates a enum for the different types of birds.
        /// </summary>
        public enum BirdTypes
        {
            Eagle,
            Parrot
        }

        /// <summary>
        /// Property ColorOfBird. Gets or sets the color of the bird.
        /// </summary>
        public string ColorOfBird
        {
            get { return colorOfBird; }
            set { this.colorOfBird = value; }
        }

        /// <summary>
        /// Returns a string representation of the birds characteristics.
        /// </summary>
        public override string ToString()
        {
            return base.ToString() + "It is a " + ColorOfBird.ToLower() + " bird. ";
        }
    }
}
