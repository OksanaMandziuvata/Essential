

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Converter converter = new Converter(41.88, 49.9, 0.54);

            Console.WriteLine("Enter amount in UAH:");
            double uah = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nConvert UAH to USD:");
            converter.ToUsd(uah);

            Console.WriteLine("Convert UAH to EUR:");
            converter.ToEur(uah);

            Console.WriteLine("Convert UAH to RUB:");
            converter.ToRub(uah);

            Console.WriteLine("\nEnter amount in USD:");
            double usd = Convert.ToDouble(Console.ReadLine());
            converter.FromUsd(usd);

            Console.WriteLine("Enter amount in EUR:");
            double eur = Convert.ToDouble(Console.ReadLine());
            converter.FromEur(eur);

            Console.WriteLine("Enter amount in RUB:");
            double rub = Convert.ToDouble(Console.ReadLine());
            converter.FromRub(rub);
        }
    }
}



            