using System;
using ClassLibrary1;

namespace Calculator
{
    /// <remarks>
    /// Represents a Calculator console application.
    /// </remarks>
    class Calci
    {
        static void Main(string[] args)
        {
            short choice;
            float num1, num2;

            // Creating an instance of ArithmeticOperations class
            ArithmeticOperations operation = new();

            Console.WriteLine("------ CALCULATOR ------");
            Console.WriteLine("1.Addition" + "\n" + "2.Substraction" + "\n" + "3.Multipication" + "\n" + "4.Division");

            try
            {

                // Taking Inputs from the user

                #region
                Console.Write("Enter Your Choice: ");
                choice = short.Parse(Console.ReadLine());
                Console.Write("Enter first number: ");
                num1 = float.Parse(Console.ReadLine());
                Console.Write("Enter second number: ");
                num2 = float.Parse(Console.ReadLine());
                #endregion

                // Performing operation based on user choice

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Addition of {0} and {1} is {2}", num1, num2, operation.Addition(num1, num2));
                        break;
                    case 2:
                        Console.WriteLine("Substraction of {0} and {1} is {2}", num1, num2, operation.Subtraction(num1, num2));
                        break;
                    case 3:
                        Console.WriteLine("Multiplication of {0} and {1} is {2}", num1, num2, operation.Multiplication(num1, num2));
                        break;
                    case 4:
                        Console.WriteLine("Division of {0} and {1} is {2}", num1, num2, operation.Division(num1, num2));
                        break;
                    default:
                        Console.WriteLine("Invalid Choice.");
                        break;
                }
 
            }

            // Handling FormatException which occurs when an user enters character or string type input in the place of numeric input.

            catch (FormatException)
            {

                Console.WriteLine("Exception Occured!!");
                Console.WriteLine("Invalid number is entered.");
            }

        }
    }
}
