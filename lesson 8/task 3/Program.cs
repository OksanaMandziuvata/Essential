using System;

namespace Task_3
{
    enum Post
    {
        Manager = 195,
        Developer = 200,
        Accountant = 192,
        Secretary = 192,
        Cleaner = 192
    }

    class Accountant
    {
        public bool AskForBonus(Post worker, int hours)
        {
            return hours > (int)worker;
        }
    }

    class Program
    {
        static void Main()
        {
            Console.Write("Enter the number of hours worked: ");
            int hours = Convert.ToInt32(Console.ReadLine());

            Accountant accountant = new Accountant();

            if (accountant.AskForBonus(Post.Cleaner, hours))
            {
                Console.WriteLine("Give a bonus");
            }
            else
            {
                Console.WriteLine("Do not give a bonus");
            }

            Console.ReadKey();
        }
    }
}
