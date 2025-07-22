using System;

namespace Task_2
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter the size of the array: ");
            int n;

            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.Write("Please enter a valid positive number: ");
            }

            MyArray myArray = new MyArray(n);

            myArray.MinMax();
            myArray.Sum();
            myArray.Average();
            myArray.Odd();

            Console.ReadKey();
        }
    }
}
