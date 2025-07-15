using System;

namespace Task_4
{
    class ProDocumentWorker : DocumentWorker
    {
        public override void EditDocument()
        {
            Console.WriteLine("Document edited");
        }

        public override void SaveDocument()
        {
            Console.WriteLine("Document saved in old format, saving in other formats is available in Expert version");
        }
    }
}
