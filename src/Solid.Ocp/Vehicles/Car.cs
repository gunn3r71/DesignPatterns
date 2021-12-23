using System;

namespace Solid.Ocp.Vehicles
{
    public class Car : Vehicle
    {
        public Car(string color,
            int year,
            double engine,
            int seats, 
            int doors) : base(color, year, engine)
        {
            Seats = seats;
            Doors = doors;

            ConfigureCar();
        }

        public int Seats { get; private set; }
        public int Doors { get; private set; }

        public void ConfigureCar()
        {
            Console.WriteLine("====Car====\n" +
                              $"Color: {Color}\n" +
                              $"Year: {Year}\n" +
                              $"Engine: {Engine}\n" +
                              $"Seats: {Seats}\n" +
                              $"Doors: {Doors}");
            StartVehicle();
        }
    }
}