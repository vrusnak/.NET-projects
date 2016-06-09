/// <summary>
/// MainForm.cs
/// Created:  Viktor Rusnak, 2015-03-15
/// Revised:  
/// Purpose:  To implement the listmanager interface and reuse code as much as possible with the help of generics.
/// </summary>

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Assignment_4_lvl2
{
    /// <summary>
    /// This class creates a new list.
    /// </summary>
    public class ListManager<T> : IListManager<T>
    {
        private List<T> list;

        /// <summary>
        /// Constructor AnimalManager. Takes no parameters. Creates a new list.
        /// </summary>
        public ListManager() 
        {
            list = new List<T>();
        }

        /// <summary>
        /// Property Count. Returns the number of items in the list.
        /// </summary>
        public int Count
        {
            get { return list.Count; }
        }

        /// <summary>
        /// Property AniList. Returns the list with animals.
        /// </summary>
        public List<T> MyList
        {
            get { return this.list; }
            set { this.list = value; }
        }

        /// <summary>
        /// Returns true if an item was added successfully to the list.
        /// </summary>
        public bool Add(T aType)
        {
            if (aType != null)
            {
                list.Add(aType);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Returns true if an item was changed successfully in the list at the index.
        /// </summary>
        public bool ChangeAt(T aType, int index)
        {
            if(aType != null)
            {
                list.RemoveAt(index);
                list.Insert(index, aType);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Returns true if index is a valid number.
        /// </summary>
        public bool CheckIndex(int index)
        {
            if (index >= 0)
                return true;
            return false;
        }

        /// <summary>
        /// Removes all items in the list.
        /// </summary>
        public void Deletall()
        {
            list.Clear();
        }

        /// <summary>
        /// Returns true if an item was successfully removed from the list.
        /// </summary>
        public bool DeleteAt(int index)
        {
            if (CheckIndex(index))
            {
                list.RemoveAt(index);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Returns true a specific item from the list.
        /// </summary>
        public T GetAt(int index)
        {
            if(CheckIndex(index))
            {
                return list.ElementAt(index);
            }
            return default(T);
        }

        /// <summary>
        /// Returns the list as an array of strings.
        /// </summary>
        public string[] ToStringArray()
        {
            string[] stringArray = new string[list.Count];
            foreach (T item in list)
            {
                stringArray[FindVacantPosition(stringArray)] = item.ToString();
            }
            return stringArray;
        }

        /// <summary>
        /// Returns the next vacant position in the array of strings.
        /// </summary>
        private int FindVacantPosition(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == null)
                    return i;
            }
            return -1;
        }

        /// <summary>
        /// Returns the list as an list of strings.
        /// </summary>
        public List<string> ToStringList()
        {
            List<string> stringList = new List<string>();
            foreach(T item in list)
                stringList.Add(item.ToString());
            return stringList;
        }

        /// <summary>
        /// Saves a binary serialization of the animal registry.
        /// </summary>
        public void BinarySerialize(string filePath)
        {
            FileStream fileObj = null;
            try
            {
                fileObj = new FileStream(filePath, FileMode.Create);
                BinaryFormatter binFormatter = new BinaryFormatter();
                binFormatter.Serialize(fileObj, list);
            }
            finally
            {
                if (fileObj != null)
                    fileObj.Close();
            }
          }

        /// <summary>
        /// Opens the object to be binary deserialized.
        /// </summary>
        public void BinaryDeSerialize(string filePath)
        {
            FileStream fileObj = null;
            try
            {                
                fileObj = new FileStream(filePath, FileMode.Open);
                BinaryFormatter binFormatter = new BinaryFormatter();
                list = (List<T>)binFormatter.Deserialize(fileObj);
            }
            finally
            {
                if (fileObj != null)
                    fileObj.Close();
            }
        }

        /// <summary>
        /// Saves an XML serialization of the recipes.
        /// </summary>
        public void XMLSerialize<T>(string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            TextWriter writer = new StreamWriter(filePath);
            try
            {
                serializer.Serialize(writer, MyList);
            }
            finally
            {
                if (writer != null)
                    writer.Close();
            }
        }

        /// <summary>
        /// Opens the object to be XML deserialized.
        /// </summary>
        public T XMLDeSerialize<T>(string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            TextReader reader = null;
            object obj = null;
            try
            {
                reader = new StreamReader(filePath);
                obj = (T)serializer.Deserialize(reader);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
            return (T)obj;
        }
    }
}
