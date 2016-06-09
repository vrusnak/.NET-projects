/// <summary>
/// Shark.cs
/// Created:  Viktor Rusnak, 2015-02-06
/// Revised:  
/// Purpose:  Common class for all sharks.
/// </summary>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4_lvl2
{
    /// <summary>
    /// The class handles the common features and characteristics of all shark. Inherits the Marine class.
    /// </summary>
    [Serializable]
    class Shark : Marine
    {
        private string typeOfShark;
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
            fs.AddFoodScheduleItem("Larger species of fish.");
            return fs;
        }

        /// <summary>
        /// Returns the species of this animal.
        /// </summary>
        public override string GetSpecies()
        {
            return "Shark";
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
            return TypeOfShark;
        }

        /// <summary>
        /// Default constructor for the Shark class.
        /// </summary>
        public Shark() { }

        /// <summary>
        /// Property TypeOfShark. Gets or sets the type of the shark.
        /// </summary>
        public string TypeOfShark
        {
            get { return typeOfShark; }
            set { this.typeOfShark = value; }
        }

        /// <summary>
        /// Returns a string representation of the shark characteristics.
        /// </summary>
        public override string ToString()
        {
            return base.ToString() + "The type of this shark is " + TypeOfShark;
        }
    }
}
