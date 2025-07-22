using System;

namespace Task_2
{
    class MyArray
    {
        int[] array;

        
        public MyArray(int n)
        {
            array = new int[Math.Abs(n)];
            Random random = new Random();

            Console.WriteLine("Generated array:");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 40);
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

        public void MinMax()
        {
            int min = array[0];
            int max = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                max = Math.Max(max, array[i]);
                min = Math.Min(min, array[i]);
            }

            Console.WriteLine("Max = {0}; Min = {1}", max, min);
        }

        public int Sum()
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            Console.WriteLine("Sum = {0}", sum);
            return sum;
        }

        public void Average()
        {
            double average = (double)Sum() / array.Length;
            Console.WriteLine("Average = {0:F2}", average);
        }

        public void Odd()
        {
            Console.Write("Odd numbers: ");
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    Console.Write(array[i] + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
