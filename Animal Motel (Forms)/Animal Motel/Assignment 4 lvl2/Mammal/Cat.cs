/// <summary>
/// Cat.cs
/// Created:  Viktor Rusnak, 2015-02-06
/// Revised:  
/// Purpose:  Common class for all cats.
/// </summary>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4_lvl2
{
    /// <summary>
    /// The class handles the common features and characteristics of all cat animals. Inherits the Mammal class.
    /// </summary>
    [Serializable]
    class Cat : Mammal
    {
        private double lengthOfTail;
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
            fs.AddFoodScheduleItem("To be fed four times as follows:");
            fs.AddFoodScheduleItem("1. Morning: Canned tuna.");
            fs.AddFoodScheduleItem("2. Lunch: Water.");
            fs.AddFoodScheduleItem("3. 3 PM: Cat sweets!");
            fs.AddFoodScheduleItem("4. Evenings: Canned food.");
            return fs;
        }

        /// <summary>
        /// Returns the species of this animal.
        /// </summary>
        public override string GetSpecies()
        {
            return "Cat";
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
            return LengthOfTail.ToString();
        }

        /// <summary>
        /// Default constructor for the cat class.
        /// </summary>
        public Cat() { }

        /// <summary>
        /// Property LengthOfTail. Gets or sets the length of the cats tail.
        /// </summary>
        public double LengthOfTail
        {
            get { return lengthOfTail; }
            set { this.lengthOfTail = value; }
        }

        /// <summary>
        /// Returns a string representation of the cat characteristics.
        /// </summary>
        public override string ToString()
        {
            return base.ToString() + "The cat has a " + LengthOfTail + " cm long tail.";
        }
    }
}
