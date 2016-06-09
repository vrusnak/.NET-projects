/// <summary>
/// Bear.cs
/// Created:  Viktor Rusnak, 2015-02-06
/// Revised:  
/// Purpose:  Common class for all bear animals.
/// </summary>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4_lvl2
{
    /// <summary>
    /// The class handles the common features and characteristics of all bear. Inherits the Mammal class.
    /// </summary>
    [Serializable]
    class Bear : Mammal
    {
        private string colorOfFur;
        private EaterType.EaterTypes eaterType = EaterType.EaterTypes.Omnivorous;

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
            return "Bear";
        }

        /// <summary>
        /// Returns the category specification.
        /// </summary>
        public override string GetCategorySpecs()
        {
            return NbrOfTeeth.ToString();
        }

        /// <summary>
        /// Returns the animal specification.
        /// </summary>
        public override string GetAnimalSpecs()
        {
            return ColorOfFur;
        }

        /// <summary>
        /// Default constructor for the Bear class.
        /// </summary>
        public Bear() { }

        /// <summary>
        /// Property ColorOfFur. Gets or sets the color of the bears fur.
        /// </summary>
        public string ColorOfFur
        {
            get { return colorOfFur; }
            set { this.colorOfFur = value; }
        }

        /// <summary>
        /// Returns a string representation of the bear characteristics.
        /// </summary>
        public override string ToString()
        {
            return base.ToString() + "The bear has " + ColorOfFur.ToLower() + " fur.";
        }
    }
}
