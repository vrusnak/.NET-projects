/// <summary>
/// IAnimal.cs
/// Created:  Viktor Rusnak, 2015-02-21
/// Revised:  
/// Purpose:  Interface for animal properties.
/// </summary>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4_lvl2
{
    /// <summary>
    /// Interface which can be implemented by Animal class.
    /// </summary>
    public interface IAnimal
    {
        /// <summary>
        /// Property Name. Returns and sets the name.
        /// </summary>
        string Name
        {
            get;
            set;
        }

        /// <summary>
        /// Property AnimalGender. Returns and sets the gender of the animal.
        /// </summary>
        Gender.GenderType AnimalGender
        {
            get;
            set;
        }

        /// <summary>
        /// Property AnimalID. Returns and sets the animal id number.
        /// </summary>
        int AnimalID
        {
            get;
            set;
        }

        /// <summary>
        /// Returns the EaterType.
        /// </summary>
        EaterType.EaterTypes GetEaterType();

        /// <summary>
        /// Returns the FoodSchedule.
        /// </summary>
        FoodSchedule GetFoodSchedule();

        /// <summary>
        /// Returns a string of the animal species.
        /// </summary>
        string GetSpecies();
    }
}
