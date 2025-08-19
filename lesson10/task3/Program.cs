using System;

namespace Task_3
{
    class MyDictionary<TKey, TValue>
    {
        private TKey[] keys;
        private TValue[] values;
        private int count;

        public int Count
        {
            get { return count; }
        }

        public MyDictionary(int capacity)
        {
            keys = new TKey[capacity];
            values = new TValue[capacity];
            count = 0;
        }

        public void Add(TKey key, TValue value)
        {
            if (count < keys.Length)
            {
                keys[count] = key;
                values[count] = value;
                count++;
            }
            else
            {
                Console.WriteLine("Dictionary is full. Cannot add more items.");
            }
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < count)
                    return keys[index] + " - " + values[index];
                return "Index out of range.";
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the size of the dictionary:");
            int n = Convert.ToInt32(Console.ReadLine());

            var dictionary = new MyDictionary<string, string>(n);

            for (int i = 0; i < n; i++)
            {
                dictionary.Add("стiл", "table");
                

            }

            Console.WriteLine(new string('-', 20));

            for (int i = 0; i < dictionary.Count; i++)
            {
                Console.WriteLine(dictionary[i]);
            }

            Console.WriteLine("Second element: " + dictionary[1]);
            Console.WriteLine("Dictionary size: " + dictionary.Count);

            Console.ReadKey();
        }
    }
}
