using System;

namespace BookApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the book title: ");
            string titleText = Console.ReadLine();

            Console.Write("Enter the author's name: ");
            string authorName = Console.ReadLine();

            Console.Write("Enter the book content: ");
            string contentText = Console.ReadLine();

            Book myBook = new Book(titleText, authorName, contentText);

            Console.WriteLine("\nBook information:\n");
            myBook.Show();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
