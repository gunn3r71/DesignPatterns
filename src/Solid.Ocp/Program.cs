using System;

namespace Solid.Ocp
{
    public class Program
    {
        static void Main(string[] args)
        {
            var type = TypeVehicle.Car;

            if (type is TypeVehicle.Car)
            {
                var vehicle = new Vehicle("blue", 2002, 1.8, 4, 2);
                vehicle.Car();
            }
            else
            {
                var vehicle = new Vehicle("blue", 2002, 100, 2, 0);
                vehicle.Motorcycle();
            }
        }
    }
}
