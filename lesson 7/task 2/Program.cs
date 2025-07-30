using System;
using Task_2;

namespace Task2
{
    class Program
    {
        static void Main()
        {
            var train = new Train[2];

            MyClass.AddingAnArray(train);
            Console.WriteLine(new string('-', 50));

            Console.WriteLine("You entered the following train information:");
            Console.WriteLine(new string('-', 50));

            MyClass.Sort(train);
            MyClass.Show(train);

            Console.WriteLine(new string('-', 50));

            Console.WriteLine("Enter train number:");
            int poisk = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(new string('-', 50));
            MyClass.Search(train, poisk);

            Console.ReadKey();
        }
    }
}
