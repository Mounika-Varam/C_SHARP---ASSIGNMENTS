using System;

namespace ClassLibrary1
{
    /// <remarks>
    /// Provides a method to swap two numbers.
    /// </remarks>
    public class Swap
    {
        /// <summary>
        /// Swaps two numbers.
        /// </summary>
        /// <param name="number1">First number</param>
        /// <param name="number2">Second number</param>
        /// <returns>Two numbers after swapping.</returns>
        public static int Swapping(int number1, int number2, out int num2)
        {
            int temp = number1;
            int num1 = number2;
            num2 = temp;
            return num1;
        }
    }
}
