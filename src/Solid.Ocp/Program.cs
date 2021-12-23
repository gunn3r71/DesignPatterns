using System;
using Solid.Ocp.Vehicles;

namespace Solid.Ocp
{
    public class Program
    {
        static void Main(string[] args)
        {
            var type = TypeVehicle.Motorcycle;

            if (type is TypeVehicle.Car)
            {
                var vehicle = new Car("blue", 2002, 1.8, 4, 2);
            }
            else
            {
                var vehicle = new Motorcycle("blue", 2002, 100);
            }
        }
    }
}
