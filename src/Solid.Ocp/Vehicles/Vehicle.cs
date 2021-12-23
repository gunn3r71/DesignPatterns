using System;
using Solid.Ocp.Vehicles;

namespace Solid.Ocp
{
    public abstract class Vehicle : IVehicle
    {
        protected Vehicle(string color,
            int year, 
            double engine)
        {
            Color = color;
            Year = year;
            Engine = engine;
        }

        public string Color { get; private set; }
        public int Year { get; private set; }
        public double Engine { get; private set; }


        public void StartVehicle()
        {
            Console.WriteLine($"Starting {GetType().Name}");
        }
    }
}