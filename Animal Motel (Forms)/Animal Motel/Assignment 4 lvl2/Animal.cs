/// <summary>
/// Animal.cs
/// Created:  Viktor Rusnak, 2015-02-06
/// Revised:  
/// Purpose:  To create a new animal.
/// </summary>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4_lvl2
{
    /// <summary>
    /// The class handles the basic properties related to a specific animal. Implements the interfaces IAnimal and IComparable.
    /// </summary>
    [Serializable]
    public abstract class Animal : IAnimal, IComparable
    {
        private string name;
        private int age, id;
        private Gender.GenderType gender;
        private Category.CategoryType category;

        /// <summary>
        /// Deafult constructor Animal.
        /// </summary>
        public Animal()
        {
        }

        public Animal(string animal)
        {
            Name = animal;
        }

        /// <summary>
        /// Property Name. Returns or sets the animals name.
        /// </summary>
        public string Name
        {
            get { return name; }
            set { this.name = value; }
        }

        /// <summary>
        /// Property AnimalID. Returns or sets the animals ID.
        /// </summary>
        public int AnimalID
        {
            get { return id; }
            set { this.id = value; }
        }

        /// <summary>
        /// Property Age. Returns or sets the animals age.
        /// </summary>
        public int Age
        {
            get { return age; }
            set { this.age = value; }
        }

        /// <summary>
        /// Property AnimalGender. Returns or sets the animals gender.
        /// </summary>
        public Gender.GenderType AnimalGender
        {
            get { return gender; }
            set { this.gender = value; }
        }

        /// <summary>
        /// Property AnimalCategory. Returns or sets the category of the animal.
        /// </summary>
        public Category.CategoryType AnimalCategory
        {
            get { return category; }
            set { this.category = value; }
        }

        /// <summary>
        /// Property AnimalObject. Returns or sets the type of the animal.
        /// </summary>
        public string AnimalObject
        {
            get { return GetSpecies(); }
        }

        /// <summary>
        /// Returns a formated string of the animal properties.
        /// </summary>
        public override string ToString()
        {
            string strAnimalCategory = AnimalCategory.ToString();

            string strOut = String.Format(" {0, -12} {1,-12} {2, 10}, {3, 5}, {4, 8}",
                   AnimalID, Name, Age, AnimalGender, "");

            strOut = strOut.ToUpper();
            return strOut;
        }

        /// <summary>
        /// Abstract method GetEaterType(). Have to be implemented in class inheriting this class.
        /// </summary>
        public abstract EaterType.EaterTypes GetEaterType();

        /// <summary>
        /// Abstract method GetFoodSchedule(). Have to be implemented in class inheriting this class.
        /// </summary>
        public abstract FoodSchedule GetFoodSchedule();

        /// <summary>
        /// Abstract method GetSpecies(). Have to be implemented in class inheriting this class.
        /// </summary>
        public abstract string GetSpecies();

        /// <summary>
        /// Abstract method GetCategorySpecs(). Have to be implemented in class inheriting this class.
        /// </summary>
        public abstract string GetCategorySpecs();

        /// <summary>
        /// Abstract method GetAnimalSpecs(). Have to be implemented in class inheriting this class.
        /// </summary>
        public abstract string GetAnimalSpecs();

        /// <summary>
        /// Implmented method CompareTo generated from IComparable.
        /// </summary>
        public int CompareTo(Object obj)
        {
            Animal ani = (Animal)obj;
            return this.Name.CompareTo(ani.Name);
        }                 
    }
}
