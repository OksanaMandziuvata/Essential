using System;

namespace BookApp
{
    public class Author
    {
        private string author;

        public Author(string author)
        {
            this.author = author;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Author: " + author);
            Console.ResetColor();
        }
    }
}
