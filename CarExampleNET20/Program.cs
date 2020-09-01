using System;
using System.Collections.Generic;

namespace CarExampleNET20
{
    class Program
    {
        static void Main(string[] args)
        {
            var demo = new Demo(new ConsoleUI());

            Class1 ccc = new Class3();
            var fuelVehicle = new FuelVehicle("ABC123", 50);
            fuelVehicle.FuelLevel = -3;
            var level = fuelVehicle.FuelLevel;

            List<IDrive> vehicles = new List<IDrive>
            {
                new FuelVehicle("ABC", 50),
                new FuelVehicle("ABD", 50),
                new FuelCar("CFD", 34),
                new Bicycle("Fsdf34")
            };

            foreach (IDrive vehicle in vehicles)
            {
                Console.WriteLine(vehicle.Drive(20));

                FuelCar fuelCar1 = vehicle as FuelCar;
                Console.WriteLine(fuelCar1?.DoSound());

                if (fuelCar1 != null)
                {
                    Console.WriteLine(fuelCar1.DoSound());
                }


                if (vehicle is FuelCar)
                {
                    FuelCar fuelCar = (FuelCar)vehicle;
                    Console.WriteLine(fuelCar.DoSound());
                }

                if(vehicle is FuelCar car)
                {
                    Console.WriteLine(car.DoSound());
                }

            }

        }
    }
}
