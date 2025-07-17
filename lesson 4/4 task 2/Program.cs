using System;

namespace Task_2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter file name (e.g., document.txt):");
            string name = Console.ReadLine();

            Console.WriteLine("Enter file format (xml, txt, doc):");
            string format = Console.ReadLine().ToLower();

            AbstractHandler handler;

            switch (format)
            {
                case "xml":
                    handler = new XMLHandler(name);
                    break;
                case "txt":
                    handler = new TXTHandler(name);
                    break;
                case "doc":
                    handler = new DOCHandler(name);
                    break;
                default:
                    Console.WriteLine("Unsupported file format.");
                    return;
            }

            handler.Open();
            handler.Create();
            handler.Change();
            handler.Save();
        }
    }
}
