/// <summary>
/// Crocodile.cs
/// Created:  Viktor Rusnak, 2015-02-06
/// Revised:  
/// Purpose:  Common class for all crocodile animals.
/// </summary>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4_lvl2
{
    /// <summary>
    /// The class handles the common features and characteristics of all crocodiale animals. Inherits the Reptile class.
    /// </summary>
    [Serializable]
    class Crocodile : Reptile
    {
        private double weight;
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
            fs.AddFoodScheduleItem("Mainly small fish, invertebrates, reptiles, birds and mammals.");
            return fs;
        }

        /// <summary>
        /// Returns the species of this animal.
        /// </summary>
        public override string GetSpecies()
        {
            return "Crocodile";
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
            return Weight.ToString();
        }

        /// <summary>
        /// Default constructor for the Crocodile class.
        /// </summary>
        public Crocodile() { }

        /// <summary>
        /// Property Weight. Gets or sets the weight of the crocodile.
        /// </summary>
        public double Weight
        {
            get { return weight; }
            set { this.weight = value; }
        }

        /// <summary>
        /// Returns a string representation of the crocodile characteristics.
        /// </summary>
        public override string ToString()
        {
            return base.ToString() + "The crocodile weighs approximately " + Weight + " kg.";
        }
    }
}
