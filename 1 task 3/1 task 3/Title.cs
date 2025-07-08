using System;

namespace BookApp
{
    public class Title
    {
        private string title;

        public Title(string title)
        {
            this.title = title;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Title: " + title);
            Console.ResetColor();
        }
    }
}
