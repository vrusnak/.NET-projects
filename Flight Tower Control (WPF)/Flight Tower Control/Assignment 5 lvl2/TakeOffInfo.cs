/// <summary>
/// TakeOffInfo.cs
/// Created:  Viktor Rusnak, 2015-04-02
/// Revised:  
/// Purpose:  To handle changes to the aircraft take-off. 
/// </summary>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5_lvl2
{
    /// <summary>
    /// Handles the changes to the aircraft take-off. 
    /// </summary>
    public class TakeOffInfo : EventArgs
    {
        private string route;
        private string flight;

        /// <summary>
        /// Constructor for the class. Takes one string as parameters.
        /// </summary>
        public TakeOffInfo(string flight) 
        {
            this.flight = flight;
        }

        /// <summary>
        /// Property Flight. Gets or sets aircraft info.
        /// </summary>
        public string Flight
        {
            get { return this.flight; }
            set { this.flight = value; }
        }

        /// <summary>
        /// Returns a string representation of the flight take-off.
        /// </summary>
        public override string ToString()
        {
            string msg = Flight + " has started" + " " + DateTime.Now.ToLongTimeString();
            return msg;
        }
    }
}
