using System;

namespace Task_2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the array dimensions");
            string str = Console.ReadLine();
            int u = string.IsNullOrEmpty(str) ? 0 : Convert.ToInt32(str);

            var list = new MyList<int>();

            var t = new Random();
            for (int x = 0; x < u; x++)
            {
                list.Add(t.Next(100));
            }

            Console.WriteLine("Array of elements");
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine(new string('-', 30));

            Console.WriteLine("Enter a value to search for");
            if (list.Contains(Convert.ToInt32(Console.ReadLine())))
            {
                Console.WriteLine("The value entered is contained in an array");
            }
            else
            {
                Console.WriteLine("Value not found");
            }

            Console.ReadKey();

        }
    }
}
