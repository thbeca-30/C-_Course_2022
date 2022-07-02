using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GaussianElimination
{
    static class Gauss
    {
        /// <summary>
        /// Number of equations (and variables) to solve for
        /// </summary>
        public const int numberOfEquations = 4;

        /// <summary>
        /// Solve simultaneous equations using Gaussian method
        /// </summary>
        /// <param name="coefficients">Coefficients from all equations</param>
        /// <param name="rhs">Constants from all equations</param>
        /// <returns>Array of solution results</returns>
        public static double[] SolveGaussian(double[,] coefficients, double[] rhs)
        {
            // TODO Exercise 5, Task 3
            // Make deep copies of the coefficients and rhs arrays

            // TODO Exercise 5, Task 3
            // Convert the equations to triangular form

            // TODO Exercise 5, Task 4
            // Perform the back substitution and return the result
 
        }

        // TODO Exercise 5, Task 2
        // Add static methods to do a deep copy of 1 and two dimensional arrays of doubles
    }
}
