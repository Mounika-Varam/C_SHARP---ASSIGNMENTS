using System;
using ClassLibrary1;

namespace Programs
{
    /// <remarks>
    /// Provides a console application to get details from user and provide details of books.
    /// </remarks>
    internal class Book
    {
        static void Main(string[] args)
        {

            BookDetails book = new();

            // Taking details from user
           
            try
            {
                Console.Write("Enter Book Id: ");
                book.bookId = int.Parse(Console.ReadLine());

                Console.Write("Enter Book Title: ");
                book.title = Console.ReadLine();

                try
                {
                    Console.Write("Enter Price of Book: ");
                    book.price = int.Parse(Console.ReadLine());

                    try
                    {
                        Console.WriteLine("1.Magazine\n2.Novel\n3.ReferenceBook\n4.Miscellaneous");
                        Console.WriteLine("Enter Type of Book: ");
                        int type = int.Parse(Console.ReadLine());
                        book.type = TypeOfBook(type);

                        Console.WriteLine("--------BOOK DETAILS--------");
                        Console.WriteLine("Book Id: " + book.bookId);
                        Console.WriteLine("Book title: " + book.title);
                        Console.WriteLine("Price of Book: " + book.price);
                        Console.WriteLine("Type of Book: " + book.type);

                    }
                    catch (InvalidBookTypeException) { }

                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid price of book.");
                }

            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid book Id");
            }

        }

        /// <summary>
        /// Coverts int to BookType.
        /// </summary>
        /// <param name="type"></param>
        /// <returns>Returns the Type of the book.</returns>
        /// <exception cref="InvalidBookTypeException"></exception>
        static BookType TypeOfBook(int type)
        {
            if (!(type == 1 || type == 2 || type == 3 || type == 4))
            {
                throw new InvalidBookTypeException();
            }

            return (BookType)type;
        }

    }
}
