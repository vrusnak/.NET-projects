/// <summary>
/// Media.cs
/// Created:  Viktor Rusnak, 2015-01-06
/// Revised:  
/// Purpose:  To manage media objects.
/// </summary>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaLibrary
{
    /// <summary>
    /// Class Media. Manages the media objects.
    /// </summary>
    public class Media
    {
        string[] availableLoans = new string[100];
        string[] unavailableLoans = new string[100];

        /// <summary>
        /// Constructor Media. Creates two new string arrays. 
        /// One for all the available loans, another for the unavailable ones.
        /// </summary>
        public Media()
        {
            for (int i = 0; i < availableLoans.Length; i++)
                availableLoans[i] = string.Empty;

            for (int i = 0; i < unavailableLoans.Length; i++)
                unavailableLoans[i] = string.Empty;
        }

        /// <summary>
        /// Property AvailableLoans. Gets and sets the string array availableLoans.         
        /// </summary>
        public string[] AvailableLoans
        {
            get { return availableLoans; }
            set { this.availableLoans = value; }
        }

        /// <summary>
        /// Property unavailableLoans. Gets and sets the string array unavailableLoans.         
        /// </summary>
        public string[] UnavailableLoans
        {
            get { return unavailableLoans; }
            set { this.unavailableLoans = value; }
        }

        /// <summary>
        /// Reads a text file ans saves each line in an array.       
        /// </summary>
        public void ReadMediaToArray(string filename)
        {
            string[] lines = System.IO.File.ReadAllLines(filename, Encoding.UTF7);

            foreach (string line in lines)
            {
                string newLine = line.Replace(";", " ");
                newLine = newLine.Insert(10, ": ");
                int index = FindVacantPositionAvailableLoans();
                if (index >= 0)
                    availableLoans[index] = newLine;
            }
        }

        /// <summary>
        /// Returns a vacant position in availableLoans.        
        /// </summary>
        public int FindVacantPositionAvailableLoans()
        {
            for (int i = 0; i < availableLoans.Length; i++)
            {
                if (string.IsNullOrEmpty(availableLoans[i]))
                    return i;
            }
            return -1;
        }

        /// <summary>
        /// Returns a vacant position in the unavailableLoans.        
        /// </summary>
        public int FindVacantPositionUnAvailableLoans()
        {
            for (int i = 0; i < unavailableLoans.Length; i++)
            {
                if (string.IsNullOrEmpty(unavailableLoans[i]))
                    return i;
            }
            return -1;
        }

    }
}
