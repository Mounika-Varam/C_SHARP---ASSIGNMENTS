using System;


namespace Programs
{
    /// <remarks>
    /// The Exception that is thrown when an user enters type of book which is not present.
    /// </remarks>
    /// <inheritdoc/>
    public class InvalidBookTypeException : Exception
    {
        public InvalidBookTypeException() 
        {
            Console.WriteLine("Invalid Type of Book");
        }
    }
}
