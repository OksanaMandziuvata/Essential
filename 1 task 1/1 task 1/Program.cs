using System;
using System.Drawing;

namespace Task_2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the first side of the rectangle");
            double side1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the second side of the rectangle");
            double side2 = Convert.ToDouble(Console.ReadLine());

            Rectangle rectangle = new Rectangle(side1, side2);
            Console.WriteLine("Perimeter = {0}, Area= {1}", rectangle.Perimeter, rectangle.Area);

            
            Console.ReadKey();
        }
    }
}
