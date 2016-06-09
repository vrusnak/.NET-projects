/// <summary>
/// Eagle.cs
/// Created:  Viktor Rusnak, 2015-02-06
/// Revised:  
/// Purpose:  Class for all eagle animals.
/// </summary>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4_lvl2
{
    /// <summary>
    /// The class handles the common features and characteristics of all eagle animals. Inherits the Bird class.
    /// </summary>
    [Serializable]
    class Eagle : Bird
    {
        private int nbrOfClaws;
        private EaterType.EaterTypes eaterType = EaterType.EaterTypes.Carnivore;

        /// <summary>
        /// Returns the eatertype of this animal.
        /// </summary>
        public override EaterType.EaterTypes GetEaterType()
        {
            return eaterType;
        }

        /// <summary>
        /// Returns the food schedule of this animal.
        /// </summary>
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
            return "Eagle";
        }

        /// <summary>
        /// Returns the category specification.
        /// </summary>
        public override string GetCategorySpecs()
        {
            return ColorOfBird;
        }

        /// <summary>
        /// Returns the animal specification.
        /// </summary>
        public override string GetAnimalSpecs()
        {
            return nbrOfClaws.ToString();
        }

        /// <summary>
        /// Default constructor for the Eagle class.
        /// </summary>
        public Eagle() { }

        /// <summary>
        /// Property NbrOfClaws. Gets or sets the number of claws.
        /// </summary>
        public int NbrOfClaws
        {
            get { return nbrOfClaws; }
            set { this.nbrOfClaws = value; }
        }

        /// <summary>
        /// Returns a string representation of the eagles characteristics.
        /// </summary>
        public override string ToString()
        {
           return base.ToString() + "The eagle has " + NbrOfClaws + " claws.";
        }
    }
}
