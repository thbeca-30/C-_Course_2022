using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StressTest
{
    //Exercise 3
    /// <summary>
    /// Extension methods for longs
    /// </summary>
    public static class Extensions
    {
        /// <summary>
        /// Extension method to convert a long to a binary string
        /// </summary>
        /// <param name="i">Long to covert</param>
        /// <returns>Binary string representation</returns>
        public static string ToBinaryString(this long i)
        {
            // Initialize some variables (use StringBuilder as we'll be modifying a string)
            long remainder = 0;
            StringBuilder binary = new StringBuilder("");

            // Convert to binary
            while (i > 0)
            {
                remainder = i % 2;
                i = i / 2;
                binary.Insert(0, remainder);
            }
            return binary.ToString();
        }
    }
}
