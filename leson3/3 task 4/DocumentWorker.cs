using System;

namespace Task_4
{
    class DocumentWorker
    {
        public virtual void OpenDocument()
        {
            Console.WriteLine("Document opened");
        }

        public virtual void EditDocument()
        {
            Console.WriteLine("Editing the document is available in Pro version");
        }

        public virtual void SaveDocument()
        {
            Console.WriteLine("Saving the document is available in Pro version");
        }
    }
}
