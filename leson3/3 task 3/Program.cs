using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(0, 0, 20000, 180, 2022);

            Plane plane = new Plane(10, 20, 1000000, 900, 2020);
            plane.Passengers = 150;
            plane.Height = 12000;

            Ship ship = new Ship(30, 50, 5000000, 80, 2018);
            ship.Passengers = 300;
            ship.Port = "Odessa";

            car.ShowInfo();
            plane.ShowInfo();
            ship.ShowInfo();

            Console.ReadKey();
        }
    }
}
