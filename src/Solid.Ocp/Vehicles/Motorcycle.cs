using System;

namespace Solid.Ocp.Vehicles
{
    public class Motorcycle : Vehicle
    {
        public Motorcycle(string color, 
            int year, 
            double engine) : base(color, year, engine)
        {
            ConfigureMotorcycle();
        }

        public void ConfigureMotorcycle()
        {
            Console.WriteLine("====Motorcycle====\n" +
                              $"Color: {Color}\n" +
                              $"Year: {Year}\n" +
                              $"Engine: {Engine}");
            StartVehicle();
        }
    }
}
