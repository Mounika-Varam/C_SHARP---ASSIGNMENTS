using System;

namespace Programs
{
    /// <remarks>
    /// Provides a main method which gives maximum marks among five.
    /// </remarks>
    internal class MaxMarks
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter marks of five students: ");
            
            float[] marks = new float[5];

            try
            {
                for (int i = 0; i < 5; i++)
                {
                    marks[i] = float.Parse(Console.ReadLine());
                }
                Console.WriteLine("Maximum marks: " + marks.Max());
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number entered.");
            }

        }
    }
}
