

    class Program
    {
        static void Main()
        {
            Figure figure = new Figure(new Point("A", 6, 6), new Point("B", 1, 1), new Point("C", 1, 1), new Point("C", 1, 1));

            Console.Write("{0}, P = ", figure.Type);

            figure.PerimeterCalculator();

            Console.ReadKey();

        }
    }

