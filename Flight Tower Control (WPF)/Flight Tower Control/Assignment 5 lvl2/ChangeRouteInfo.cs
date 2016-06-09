/// <summary>
/// ChangeRouteInfo.cs
/// Created:  Viktor Rusnak, 2015-04-02
/// Revised:  
/// Purpose:  To handle changes to the aircraft flight route. 
/// </summary>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5_lvl2
{
    /// <summary>
    /// Handles the changes to the aircraft flight route. 
    /// </summary>
    public class ChangeRouteInfo : EventArgs
    {
        private string flight;
        private string route;

        /// <summary>
        /// Constructor for the class. Takes two strings as parameters.
        /// </summary>
        public ChangeRouteInfo(string flight, string route)
        {
            this.flight = flight;
            this.route = route;
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
        /// Returns a string representation of the new flight route.
        /// </summary>
        public override string ToString()
        {
            string msg = Flight + " has changed its route by " + route;
            return msg;
        }
    }
}
