using System;

namespace Task_2
{
    abstract class AbstractHandler
    {
        protected string fileName;

        public AbstractHandler(string fileName)
        {
            this.fileName = fileName;
        }

        public void Open()
        {
            Console.WriteLine(fileName + " opened");
        }

        public void Create()
        {
            Console.WriteLine(fileName + " created");
        }

        public void Change()
        {
            Console.WriteLine(fileName + " modified");
        }

        public abstract void Save();
    }
}
