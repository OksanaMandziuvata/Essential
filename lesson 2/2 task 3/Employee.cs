using System;

namespace Task_3
{
    class Employee
    {
        private readonly string surname;
        private readonly string name;
        private int experience;
        private string position;

        public string Surname
        {
            get { return surname; }
        }

        public string Name
        {
            get { return name; }
        }

        public string Position
        {
            get
            {
                if (position == null)
                    return "Unknown position";
                return position;
            }
            set
            {
                if (value != null)
                    position = value;
            }
        }

        public int Experience
        {
            get { return experience; }
            set
            {
                if (value >= 0)
                    experience = value;
            }
        }

       

        public Employee(string surname, string name)
        {
            this.surname = surname;
            this.name = name;
        }

        public double CalculateSalary()
        {
            double salaryCoefficient;

            switch (position.ToLower())
            {
                case "manager": salaryCoefficient = 300; break;
                case "programmer": salaryCoefficient = 350; break;
                case "secretary": salaryCoefficient = 200; break;
                case "cleaner": salaryCoefficient = 100; break;
                default: salaryCoefficient = 250; break;
            }

            switch (experience)
            {
                case 0: salaryCoefficient *= 1.5; break;
                case 1: salaryCoefficient *= 2; break;
                case 2: salaryCoefficient *= 2.5; break;
                default: salaryCoefficient *= 5; break;
            }

            return salaryCoefficient;
        }

        public void ShowSalary()
        {
            double salary = CalculateSalary();
            double tax = salary * 0.13;
            Console.WriteLine("Salary: " + salary + ", Income Tax: " + tax);
        }
    }
}
