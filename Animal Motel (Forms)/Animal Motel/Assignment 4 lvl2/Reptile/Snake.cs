/// <summary>
/// Snake.cs
/// Created:  Viktor Rusnak, 2015-02-06
/// Revised:  
/// Purpose:  Common class for all snakes.
/// </summary>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4_lvl2
{
    /// <summary>
    /// The class handles the common features and characteristics of all snakes. Inherits the Reptile class.
    /// </summary>
    [Serializable]
    class Snake : Reptile
    {
        private double lengthOfSnake;
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
            fs.AddFoodScheduleItem("A variety of items including termites, rodents, birds, frogs and other reptiles.");
            return fs;
        }

        /// <summary>
        /// Returns the species of this animal.
        /// </summary>
        public override string GetSpecies()
        {
            return "Snake";
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
            return LengthOfSnake.ToString();
        }

        /// <summary>
        /// Default constructor for the Snake class.
        /// </summary>
        public Snake() { }

        /// <summary>
        /// Property LengthOfSnake. Gets or sets the length of the snake.
        /// </summary>
        public double LengthOfSnake
        {
            get { return lengthOfSnake; }
            set { this.lengthOfSnake = value; }
        }

        /// <summary>
        /// Returns a string representation of the snake characteristics.
        /// </summary>
        public override string ToString()
        {
            return base.ToString() + "The snake is " + LengthOfSnake + " m long.";
        }
    }
}
