/// <summary>
/// Butterfly.cs
/// Created:  Viktor Rusnak, 2015-02-06
/// Revised:  
/// Purpose:  Common class for all butterfly animals.
/// </summary>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4_lvl2
{
    /// <summary>
    /// The class handles the common features and characteristics of all butterflys. Inherits the Insect class.
    /// </summary>
    [Serializable]
    class Butterfly : Insect
    {
        private string colorOfWings;
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
            return "Butterfly";
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
            return ColorOfWings;
        }

        /// <summary>
        /// Default constructor for the Butterfly class.
        /// </summary>
        public Butterfly() { }

        /// <summary>
        /// Property ColorOfWings. Gets or sets the color of the butterflys wings.
        /// </summary>
        public string ColorOfWings
        {
            get { return colorOfWings; }
            set { this.colorOfWings = value; }
        }

        /// <summary>
        /// Returns a string representation of the butterfly characteristics.
        /// </summary>
        public override string ToString()
        {
            return base.ToString() + "The butterfly has " + ColorOfWings.ToLower() + " wings.";
        }
    }
}
