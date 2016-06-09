/// <summary>
/// Dolphin.cs
/// Created:  Viktor Rusnak, 2015-02-06
/// Revised:  
/// Purpose:  Common class for all dolphins.
/// </summary>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4_lvl2
{
    /// <summary>
    /// The class handles the common features and characteristics of all dolphins. Inherits the Marine class.
    /// </summary>
    [Serializable]
    class Dolphin : Marine
    {
        private string typeOfDolphine;
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
            fs.AddFoodScheduleItem("To be fed as wanted:");
            fs.AddFoodScheduleItem("Small species of fish, cephalopods and crustaceans.");
            return fs;
        }

        /// <summary>
        /// Returns the species of this animal.
        /// </summary>
        public override string GetSpecies()
        {
            return "Dolphin";
        }

        /// <summary>
        /// Returns the category specification.
        /// </summary>
        public override string GetCategorySpecs()
        {
            return Weigth.ToString();
        }

        /// <summary>
        /// Returns the animal specification.
        /// </summary>
        public override string GetAnimalSpecs()
        {
            return TypeOfDolphin;
        }


        /// <summary>
        /// Default constructor for the Dolphin class.
        /// </summary>
        public Dolphin() { }

        /// <summary>
        /// Property TypeOfDolphin. Gets or sets the type of the dolphin.
        /// </summary>
        public string TypeOfDolphin
        {
            get { return typeOfDolphine; }
            set { this.typeOfDolphine = value; }
        }

        /// <summary>
        /// Returns a string representation of the dolphin characteristics.
        /// </summary>
        public override string ToString()
        {
            return base.ToString() + "Type of this dolphin is " + TypeOfDolphin.ToLower();
        }
    }
}
