/// <summary>
/// Bee.cs
/// Created:  Viktor Rusnak, 2015-02-06
/// Revised:  
/// Purpose:  Common class for all bee animals.
/// </summary>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4_lvl2
{
    /// <summary>
    /// The class handles the common features and characteristics of all bee animals. Inherits the Insect class.
    /// </summary>
    [Serializable]
    class Bee : Insect
    {
        private string typeOfBee;
        private EaterType.EaterTypes eaterType = EaterType.EaterTypes.Herbivore;

        /// <summary>
        /// Returns the eatertype of this animal.
        /// </summary>
        public override EaterType.EaterTypes GetEaterType()
        {
            return eaterType;
        }

        /// <summary>
        /// Returns the food schedule of this animal.
        /// </summary>'
        public override FoodSchedule GetFoodSchedule()
        {
            FoodSchedule fs = new FoodSchedule();
            fs.AddFoodScheduleItem(fs.DescribeNoFeedingRequired());
            return fs;
        }

        /// <summary>
        /// Returns the species of this animal.
        /// </summary>
        public override string GetSpecies()
        {
            return "Bee";
        }

        /// <summary>
        /// Returns the category specification.
        /// </summary>
        public override string GetCategorySpecs()
        {
            return NbrOfLegs.ToString();
        }

        /// <summary>
        /// Returns the animal specification.
        /// </summary>
        public override string GetAnimalSpecs()
        {
            return TypeOfBee.ToString();
        }

        /// <summary>
        /// Default constructor for the Bee class.
        /// </summary>
        public Bee() { }

        /// <summary>
        /// Property TypeOfBee. Gets or sets the type of bee.
        /// </summary>
        public string TypeOfBee
        {
            get { return typeOfBee; }
            set { this.typeOfBee = value; }
        }

        /// <summary>
        /// Returns a string representation of the bee characteristics.
        /// </summary>
        public override string ToString()
        {
            return base.ToString() + "The type of this bee is " + TypeOfBee.ToLower() + ".";
        }
    }
}
