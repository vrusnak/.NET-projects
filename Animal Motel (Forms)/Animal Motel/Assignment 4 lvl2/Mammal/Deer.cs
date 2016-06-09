/// <summary>
/// Deer.cs
/// Created:  Viktor Rusnak, 2015-02-06
/// Revised:  
/// Purpose:  Common class for all deer animals.
/// </summary>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4_lvl2
{
    /// <summary>
    /// The class handles the common features and characteristics of all deer animals. Inherits the Mammal class.
    /// </summary>
    [Serializable]
    class Deer : Mammal
    {
        private string typeOfDeer;
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
            return "Deer";
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
            return TypeOfDeer;
        }

        /// <summary>
        /// Default constructor for the Deer class.
        /// </summary>
        public Deer() { }

        /// <summary>
        /// Property TypeOfDeer. Gets or sets the type of the deer.
        /// </summary>
        public string TypeOfDeer
        {
            get { return typeOfDeer; }
            set { this.typeOfDeer = value; }
        }

        /// <summary>
        /// Returns a string representation of the deer characteristics.
        /// </summary>
        public override string ToString()
        {
            return base.ToString() + "The type of this deer is " + TypeOfDeer.ToLower();
        }
    }
}
