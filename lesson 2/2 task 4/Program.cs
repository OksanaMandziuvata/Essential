using System;

namespace Task_4
{
    class Program
    {
        static void Main()
        {
            Invoice inv = new Invoice(678904, "Oksana", "Mandziuvata");
            inv.SetOrder("headphone", 2);

            inv.CalculateCost(true);  
            inv.CalculateCost(false); 

            Console.ReadKey();
        }
    }
}
