using System;
using ClassLibrary1;

namespace Programs
{
    /// <remarks>
    /// Represents a console application which provides sum of numbers entered.
    /// </remarks>
    class Sum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers to sum: ");
            string[] line = Console.ReadLine().Split(' ');

            int[] numbers = new int[line.Length];

            try
            {
                for (int i = 0; i < line.Length; i++)
                {
                    numbers[i] = int.Parse(line[i]);
                }
                Console.WriteLine("Sum: " + ArraySum.SumOfElements(numbers));
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number entered.");
            }

        }

    }
}
