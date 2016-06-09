/// <summary>
/// Parrot.cs
/// Created:  Viktor Rusnak, 2015-02-06
/// Revised:  
/// Purpose:  Class for all parrot animals.
/// </summary>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4_lvl2
{
    /// <summary>
    /// The class handles the common features and characteristics of all parrot animals. Inherits the Bird class.
    /// </summary>
    [Serializable]
    class Parrot : Bird
    {
        private string origin;
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
            fs.AddFoodScheduleItem("To be fed three times as follows:");
            fs.AddFoodScheduleItem("1. Morning: 1/2 cup of Mung sprouts.");
            fs.AddFoodScheduleItem("2. Lunch: Fresh fruits and vegetables.");
            fs.AddFoodScheduleItem("3. Evenings: Nuts and seeds.");
            return fs;
        }

        /// <summary>
        /// Returns the species of this animal.
        /// </summary>
        public override string GetSpecies()
        {
            return "Parrot";
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
            return Origin;
        }

        /// <summary>
        /// Default constructor for the Parrot class.
        /// </summary>
        public Parrot()
        { }

        /// <summary>
        /// Property Origin. Gets or sets the origin of the parrot.
        /// </summary>
        public string Origin
        {
            get { return origin; }
            set { this.origin = value; }
        }

        /// <summary>
        /// Returns a string representation of the parrot characteristics.
        /// </summary>
        public override string ToString()
        {
           return base.ToString() + "The parrot originates from " + origin + ".";
        }
    }
}
