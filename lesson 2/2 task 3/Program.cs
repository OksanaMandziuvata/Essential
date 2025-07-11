using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Mandziuvata", "Oksana");

            employee.Position = "Programmer";
            employee.Experience = 2;

            Console.WriteLine("Employee Information:");
            Console.WriteLine("Surname: " + employee.Surname);
            Console.WriteLine("Name: " + employee.Name);
            Console.WriteLine("Position: " + employee.Position);
            Console.WriteLine("Experience: " + employee.Experience + " years");

            employee.ShowSalary();

            Console.ReadKey();
        }
    }
}
