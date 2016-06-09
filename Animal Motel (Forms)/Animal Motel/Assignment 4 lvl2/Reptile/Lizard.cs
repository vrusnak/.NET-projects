/// <summary>
/// Lizard.cs
/// Created:  Viktor Rusnak, 2015-02-06
/// Revised:  
/// Purpose:  Common class for all lizards.
/// </summary>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4_lvl2
{
    /// <summary>
    /// The class handles the common features and characteristics of all lizards. Inherits the Reptile class.
    /// </summary>
    [Serializable]
    class Lizard : Reptile
    {
        private string typeOfLizard;
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
            fs.AddFoodScheduleItem("To be fed as wanted:");
            fs.AddFoodScheduleItem("Mainly insects like flies and crickets but also chameleons and geckos.");
            return fs;
        }

        /// <summary>
        /// Returns the species of this animal.
        /// </summary>
        public override string GetSpecies()
        {
            return "Lizard";
        }

        /// <summary>
        /// Returns the category specification.
        /// </summary>
        public override string GetCategorySpecs()
        {
            return Skin;
        }

        /// <summary>
        /// Returns the animal specification.
        /// </summary>
        public override string GetAnimalSpecs()
        {
            return TypeOfLizard;
        }

        /// <summary>
        /// Default constructor for the Lizard class.
        /// </summary>
        public Lizard() { }

        /// <summary>
        /// Property TypeOfLizard. Gets or sets the type of the lizard.
        /// </summary>
        public string TypeOfLizard
        {
            get { return typeOfLizard; }
            set { this.typeOfLizard = value; }
        }

        /// <summary>
        /// Returns a string representation of the lizard characteristics.
        /// </summary>
        public override string ToString()
        {
            return base.ToString() + "The type of the lizard is " + TypeOfLizard.ToLower();
        }
    }
}
