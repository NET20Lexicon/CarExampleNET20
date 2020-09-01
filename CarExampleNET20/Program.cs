using System;

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
        }
    }
}
