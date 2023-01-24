using System;


namespace ClassLibrary1
{
    /// <remarks>
    /// Provides set of Arithmetic Operations such as addition, substraction, multiplication, division.
    /// </remarks>
    public class ArithmeticOperations
    {
        /// <summary>
        /// Adds two numbers.
        /// </summary>
        /// <param name="a">First number</param>
        /// <param name="b">Second number</param>
        /// <returns>Addition of two given numbers.</returns>
        public float Addition(float a, float b)
        {
            return a + b;
        }

        /// <summary>
        /// Subtracts two numbers.
        /// </summary>
        /// <param name="a">First number</param>
        /// <param name="b">Second number</param>
        /// <returns>Subtraction of two given numbers.</returns>
        public float Subtraction(float a, float b)
        {
            return a - b;
        }

        /// <summary>
        /// Multiplies two numbers.
        /// </summary>
        /// <param name="a">First number</param>
        /// <param name="b">Second number</param>
        /// <returns>Multiplication of two given numbers.</returns>
        public float Multiplication(float a, float b)
        {
            return a * b;
        }

        /// <summary>
        /// Divides two numbers.
        /// </summary>
        /// <param name="a">First number</param>
        /// <param name="b">Second number</param>
        /// <returns>Division of two given numbers.</returns>
        public float Division(float a, float b)
        {
            
            return a / b;
            
        }

    }
}
