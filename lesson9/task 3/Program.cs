using System;

namespace task3
{
    class Program
    {
        delegate int MyDelegate();
        delegate double MyDel(MyDelegate[] a);

        static void Main()
        {
            Random rnd = new Random();

            Console.Write("Enter number of elements in array: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(new string('-', 40));

            var array = new MyDelegate[n];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = () => rnd.Next(100);
            }

            MyDel average = delegate (MyDelegate[] c)
            {
                double sum = 0;
                for (int i = 0; i < c.Length; i++)
                {
                    sum += c[i]();
                }
                return sum / c.Length;
            };

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]() + " ");
            }

            Console.WriteLine("\nAverage value = {0:0.###}", average(array));

            Console.ReadKey();
        }
    }
}
