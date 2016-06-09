/// <summary>
/// IListManager.cs
/// Created:  Viktor Rusnak, 2015-03-15
/// Revised:  
/// Purpose:  Interface for list (collection) properties.
/// </summary>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4_lvl2
{
    /// <summary>
    /// This class handles the communication of the program with the user. It displays an windows form for the user. 
    /// </summary>
    public interface IListManager<T>
    {
        /// <summary>
        /// Property Count. Returns the number of items in the list.
        /// </summary>
        int Count { get; }

        /// <summary>
        /// Returns true if an item was added successfully to the list.
        /// </summary>
        bool Add(T aType);

        /// <summary>
        /// Returns true if an item was changed successfully in the list at the index.
        /// </summary>
        bool ChangeAt(T aType, int index);

        /// <summary>
        /// Returns true if index is a valid number.
        /// </summary>
        bool CheckIndex(int index);

        /// <summary>
        /// Removes all items in the list.
        /// </summary>
        void Deletall();

        /// <summary>
        /// Returns true if an item was successfully removed from the list.
        /// </summary>
        bool DeleteAt(int index);

        /// <summary>
        /// Returns true a specific item from the list.
        /// </summary>
        T GetAt(int index);

        /// <summary>
        /// Returns the list as an array of strings.
        /// </summary>
        string[] ToStringArray();

        /// <summary>
        /// Returns the list as an list of strings.
        /// </summary>
        List<string> ToStringList();

        /// <summary>
        /// Saves a binary serialization of the data from the GUI.
        /// </summary>
        void BinarySerialize(string filePath);

        /// <summary>
        /// Opens the object to be binary deserialize.
        /// </summary>
        void BinaryDeSerialize(string filePath);

        /// <summary>
        /// Returns true if XML serialization of a file was successful.
        /// </summary>
        void XMLSerialize<T>(string filePath);

        /// <summary>
        /// Returns true if XML serialization of a file was successful.
        /// </summary>
        T XMLDeSerialize<T>(string filePath);
    }
}
