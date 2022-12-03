using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_1.Food
{
    // --------------------------------------------------------------------------------
    /// <summary>
    /// Describes something as an object that has fixed calories that can be queried.
    /// </summary>
    // --------------------------------------------------------------------------------
    internal interface IOwnsCalories
    {
        // ********************************************************************************
        /// <summary>
        /// Returns the calories of the Object.
        /// </summary>
        /// <returns> The calories of the Object. </returns>
        // ********************************************************************************
        int GetCalories();
    }
}