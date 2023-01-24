using System;

namespace ClassLibrary1
{
    /// <remarks>
    /// Provides a method to find sum of integers.
    /// </remarks>
    public class ArraySum
    {
        /// <summary>
        /// Returns sum of all provided integers.
        /// </summary>
        /// <param name="nums">Input numbers</param>
        /// <returns>Sum of all the provided integers.</returns>

        public static int SumOfElements(params int[] nums)
        {
            
            int result = 0;
            foreach (var n in nums)
            {
                result += n;

            }
            return result;
        }
    }
}
