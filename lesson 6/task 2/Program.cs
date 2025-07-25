using System;


namespace Task_2
{
    class Book
    {
        public void FindNext(string str)
        {
            Console.WriteLine("String search : " + str);
        }
    }

    static class FindAndReplaceManager
    {
        static public void FindNext(string str)
        {
            Book a = new Book();
            a.FindNext(str);
        }
    }

    class Program
    {
        static void Main()
        {
            FindAndReplaceManager.FindNext("Hello");

            Console.ReadKey();
        }
    }
}
