using System;

namespace Task_3
{
    class Vehicle
    {
        readonly int xLocation;
        public int XLocation { get { return xLocation; } }

        readonly int yLocation;
        public int YLocation { get { return yLocation; } }

        readonly uint price;
        public uint Price { get { return price; } }

        readonly uint speed;
        public uint Speed { get { return speed; } }

        readonly uint year;
        public uint Year { get { return year; } }

        public Vehicle(int xLocation, int yLocation, uint price, uint speed, uint year)
        {
            this.xLocation = xLocation;
            this.yLocation = yLocation;
            this.price = price;
            this.speed = speed;
            this.year = year;
        }

        public Vehicle(uint price, uint speed, uint year)
            : this(0, 0, price, speed, year)
        {
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine("Coordinates: (" + XLocation + ", " + YLocation + ")");
            Console.WriteLine("Price: " + Price + ", Speed: " + Speed + ", Year: " + Year);
        }
    }

    class Car : Vehicle
    {
        public Car(int xLocation, int yLocation, uint price, uint speed, uint year)
            : base(xLocation, yLocation, price, speed, year)
        {
        }

        public Car(uint price, uint speed, uint year)
            : base(price, speed, year)
        {
        }

        public override void ShowInfo()
        {
            Console.WriteLine("=== Car ===");
            base.ShowInfo();
            Console.WriteLine();
        }
    }

    class Ship : Vehicle
    {
        private int passengers;
        public int Passengers
        {
            get { return passengers; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Passenger count cannot be negative.");
                }
                else
                {
                    passengers = value;
                }
            }
        }

        private string port;
        public string Port
        {
            get
            {
                if (port == null)
                {
                    return "Port is not defined";
                }
                return port;
            }
            set
            {
                if (value == null)
                {
                    Console.WriteLine("Port value is empty.");
                }
                else
                {
                    port = value;
                }
            }
        }

        public Ship(int xLocation, int yLocation, uint price, uint speed, uint year)
            : base(xLocation, yLocation, price, speed, year)
        {
        }

        public Ship(uint price, uint speed, uint year)
            : base(price, speed, year)
        {
        }

        public override void ShowInfo()
        {
            Console.WriteLine("=== Ship ===");
            base.ShowInfo();
            Console.WriteLine("Passengers: " + Passengers);
            Console.WriteLine("Port: " + Port);
            Console.WriteLine();
        }
    }

    class Plane : Vehicle
    {
        private int passengers;
        public int Passengers
        {
            get { return passengers; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Passenger count cannot be negative.");
                }
                else
                {
                    passengers = value;
                }
            }
        }

        public int Height { get; set; }

        public Plane(int xLocation, int yLocation, uint price, uint speed, uint year)
            : base(xLocation, yLocation, price, speed, year)
        {
        }

        public Plane(uint price, uint speed, uint year)
            : base(price, speed, year)
        {
        }

        public override void ShowInfo()
        {
            Console.WriteLine("=== Plane ===");
            base.ShowInfo();
            Console.WriteLine("Passengers: " + Passengers);
            Console.WriteLine("Flight height: " + Height + " m");
            Console.WriteLine();
        }
    }
}
