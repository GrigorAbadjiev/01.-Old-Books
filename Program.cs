using System;

namespace _01._Old_Books
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string searchedBook = Console.ReadLine();
            bool isBookFound = false;
            int booksSearched = 0;

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "No More Books")
                {
                    break;
                }
                if (input == searchedBook)
                {
                    isBookFound = true;
                    break;
                }
                booksSearched++;

            }
            if (isBookFound)
            {
                Console.WriteLine($"You checked {booksSearched} books and found it.");
            }
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {booksSearched} books.");
            }
        }
    }
}
