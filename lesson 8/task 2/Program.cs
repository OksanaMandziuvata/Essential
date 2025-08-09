using System;

namespace Print
{
    enum Colors
    {
        Blue = 0,
        Red = 1,
        Green = 2
    }

    static class MyClass
    {
        public static void Print(string line, int color)
        {
            switch (color)
            {
                case (int)Colors.Blue:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case (int)Colors.Green:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case (int)Colors.Red:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                default:
                    Console.WriteLine("The string you entered will be displayed in the default console color!");
                    break;
            }

            Console.WriteLine(line);
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a string:");
            string line = Console.ReadLine();

            Console.WriteLine("Choose a color: (0 - Blue, 2 - Green, 1 - Red)");
            int color = Convert.ToInt32(Console.ReadLine());

            MyClass.Print(line, color);

            Console.ReadKey();
        }
    }
}
