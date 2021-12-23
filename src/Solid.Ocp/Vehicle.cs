using System;

namespace Solid.Ocp
{
    public class Vehicle
    {
        public Vehicle(string color,
            int year, 
            double engine,
            int seats,
            int doors)
        {
            Color = color;
            Year = year;
            Engine = engine;
            Seats = seats;
            Doors = doors;
        }

        public string Color { get; private set; }
        public int Year { get; private set; }
        public double Engine { get; private set; }
        public int Seats { get; private set; }
        public int Doors { get; private set; }

        public void Car()
        {
            Console.WriteLine($"Creating a car {Color}, {Year}, {Engine}, {Doors} ports and {Seats} seats");
        }

        public void Motorcycle()
        {
            Console.WriteLine($"Creating a motorcycle {Color}, {Year}, {Engine}");
        }

        public void StartVehicle()
        {
            Console.WriteLine("Starting..");
        }
    }
}