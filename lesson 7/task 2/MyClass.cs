using System;

namespace Task_2
{
    public static class MyClass
    {
        public static void Sort(Train[] trains)
        {
            for (int i = 0; i < trains.Length; i++)
            {
                for (int q = 0; q < trains.Length; q++)
                {
                    if (trains[i].Nomer <= trains[q].Nomer)
                    {
                        Train g = trains[i];
                        trains[i] = trains[q];
                        trains[q] = g;
                    }
                }
            }
        }

        public static void Search(Train[] train, int poisk)
        {
            bool ok = false;
            for (int i = 0; i < train.Length; i++)
            {
                if (train[i].Nomer == poisk)
                {
                    Console.WriteLine("Train number: {0} Destination: {1} Departure date and time: {2} ",
                                      train[i].Nomer, train[i].Punkt, train[i].Time);
                    ok = true;
                }
            }
            if (!ok)
                Console.WriteLine("Train not found");
        }

        public static void AddingAnArray(Train[] train)
        {
            for (int i = 0; i < train.Length; i++)
            {
                Console.Write("Enter the train's destination: ");
                string punkt = Console.ReadLine();
                punkt = string.IsNullOrEmpty(punkt) ? "Destination not specified" : punkt;

                Console.Write("Enter the train number: ");
                string d = Console.ReadLine();
                int nomer = string.IsNullOrEmpty(d) ? 0 : Convert.ToInt32(d);

                Console.Write("Enter the departure date: ");
                d = Console.ReadLine();
                DateTime date = string.IsNullOrEmpty(d) ? DateTime.Now : DateTime.Parse(d);

                train[i] = new Train(punkt, nomer, date);
            }
        }

        public static void Show(Train[] train)
        {
            for (int i = 0; i < train.Length; i++)
            {
                Console.WriteLine("Train number: {0} Destination: {1} Departure date and time: {2}",
                                  train[i].Nomer, train[i].Punkt, train[i].Time);
            }
        }
    }
}
