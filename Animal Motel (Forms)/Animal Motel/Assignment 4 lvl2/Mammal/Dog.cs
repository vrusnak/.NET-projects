/// <summary>
/// Dog.cs
/// Created:  Viktor Rusnak, 2015-02-06
/// Revised:  
/// Purpose:  Common class for all dogs.
/// </summary>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4_lvl2
{
    /// <summary>
    /// The class handles the common features and characteristics of all dogs. Inherits the Mammal class.
    /// </summary>
    [Serializable]
    class Dog : Mammal
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
            fs.AddFoodScheduleItem("1. Morning: Bones and one glas of milk.");
            fs.AddFoodScheduleItem("2. Lunch: Dogfood and water.");
            fs.AddFoodScheduleItem("3. 3 PM: Sweets!");
            fs.AddFoodScheduleItem("4. Evenings: Rest from the kitchen.");
            return fs;
        }

        /// <summary>
        /// Returns the species of this animal.
        /// </summary>
        public override string GetSpecies()
        {
            return "Dog";
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
        /// Default constructor for the Dog class.
        /// </summary>
        public Dog() { }

        /// <summary>
        /// Property LengthOfTail. Gets or sets the length of the dags tail.
        /// </summary>
        public double LengthOfTail
        {
            get { return lengthOfTail; }
            set { this.lengthOfTail = value; }
        }

        /// <summary>
        /// Returns a string representation of the dog characteristics.
        /// </summary>
        public override string ToString()
        {
            return base.ToString() + "The dog has a " + LengthOfTail + " cm long tail.";
        }
    }
}
