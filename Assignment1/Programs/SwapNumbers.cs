using System;
using ClassLibrary1;

namespace Programs
{
    /// <remarks>
    /// Provides a console application which swaps two numbers.
    /// </remarks>
    internal class SwapNumbers
    {
        static void Main(string[] args)
        {
            Console.Write("Enter two numbers to swap: ");

            try
            {

                int number1 = int.Parse(Console.ReadLine());
                int number2 = int.Parse(Console.ReadLine());

                Console.WriteLine("After swapping \n number1 = {0} \n number2 = {1}", Swap.Swapping(number1, number2, out int num2), num2);

            }

            // Handling exception
            catch (FormatException)
            {
                Console.WriteLine("Invalid number entered.");
            }


        }
    }
}
