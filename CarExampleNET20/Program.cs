using System;
using System.Collections.Generic;

namespace CarExampleNET20
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 ccc = new Class3();
            var fuelVehicle = new FuelVehicle("ABC123", 50);
            fuelVehicle.FuelLevel = -3;
            var level = fuelVehicle.FuelLevel;

            List<AbstractVehicle> vehicles = new List<AbstractVehicle>
            {
                new FuelVehicle("ABC", 50),
                new FuelVehicle("ABD", 50),
                new FuelCar("CFD", 34),
                new Bicycle("Fsdf34")
            };

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine(vehicle.Drive(20));
            }

        }
    }
}
