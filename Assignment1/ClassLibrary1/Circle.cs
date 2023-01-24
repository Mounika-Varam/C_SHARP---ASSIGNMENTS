using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    /// <remarks>
    /// Provides a function to calculate area and circumference of a circle.
    /// </remarks>
    public class Circle
    {

        /// <summary>
        /// Calculates area and circumference of a circle.
        /// </summary>
        /// <param name="radius">Circle Radius</param>
        /// <param name="circumference">Circle Circumference</param>
        /// <returns>Returns area and circumference of a circle.</returns>
        public static double CalculateAreaCircumference(double radius, out double circumference)
        {
            double pi = Math.PI;
            double area = pi * radius * radius;
            circumference = 2 * pi * radius;
            return area;
        }
    }
}
