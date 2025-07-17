using System;

namespace Task_2
{
    class DOCHandler : AbstractHandler
    {
        public DOCHandler(string fileName)
            : base(fileName)
        {
        }

        public override void Save()
        {
            Console.WriteLine(fileName + " saved as DOC format");
        }
    }
}
