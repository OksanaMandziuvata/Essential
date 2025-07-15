using System;

namespace Task_4
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter access key (pro or exp):");
            string key = Console.ReadLine();

            DocumentWorker doc;

            if (key == "pro")
            {
                doc = new ProDocumentWorker();
            }
            else if (key == "exp")
            {
                doc = new ExpertDocumentWorker();
            }
            else
            {
                doc = new DocumentWorker();
            }

            doc.OpenDocument();
            doc.EditDocument();
            doc.SaveDocument();

            Console.ReadKey();
        }
    }
}
