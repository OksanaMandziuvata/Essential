using System;

namespace task2
{
    class Program
    {
        delegate double MyDelegate(double a, double b);

        static void Main()
        {
            MyDelegate Add = (x, y) => x + y;
            MyDelegate Sub = (x, y) => x - y;
            MyDelegate Mul = (x, y) => x * y;
            MyDelegate Div = (x, y) =>
            {
                if (y != 0)
                    return x / y;
                else
                {
                    Console.WriteLine("Division by zero is not allowed!");
                    return 0;
                }
            };

            Console.Write("Enter the first number: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter operator (+, -, *, /): ");
            string opSymbol = Console.ReadLine();

            MyDelegate operation = null;

            switch (opSymbol)
            {
                case "+":
                    operation = Add;
                    break;
                case "-":
                    operation = Sub;
                    break;
                case "*":
                    operation = Mul;
                    break;
                case "/":
                    operation = Div;
                    break;
                default:
                    Console.WriteLine("Invalid operation symbol!");
                    break;
            }

            Console.WriteLine(new string('-', 30));
            if (operation != null)
                Console.WriteLine("Result: {0:##.###}", operation(a, b));

            Console.ReadKey();
        }
    }
}
