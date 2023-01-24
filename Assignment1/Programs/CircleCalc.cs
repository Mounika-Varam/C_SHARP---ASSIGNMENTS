using System;
using ClassLibrary1;

namespace Programs
{
    /// <remarks>
    /// Represents a console application which provides the area and circumference of a circle.
    /// </remarks>
    internal class CircleCalc
    {
        static void Main(string[] args)
        {
            double radius, area;

            Console.Write("Enter radius of circle: ");

            try
            {
                radius = double.Parse(Console.ReadLine());

                area = Circle.CalculateAreaCircumference(radius, out double circumference);
                Console.WriteLine("Area: {0}\nCircumference: {1}", area, circumference);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid radius entered");
            }
            
        }
    }
}
