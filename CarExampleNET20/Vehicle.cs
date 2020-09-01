using System;
using System.Collections.Generic;
using System.Text;

namespace CarExampleNET20
{
    class Vehicle
    {
        public string RegNo { get; set; }

        public Vehicle(string regNo)
        {
            RegNo = regNo;
        }

        public virtual string Drive(double distance) => distance > 0 ? $"Vehicle wants to drive for {distance}" : "Error";
    }

    class FuelVehicle : Vehicle
    {
        private double fuelLevel;

        public double FuelCapacity { get; }
        public double FuelLevel 
        {
            get 
            {
                return fuelLevel;
            }
            set 
            {
                double newLevel = Math.Max(0, value);
                fuelLevel = Math.Min(newLevel, FuelCapacity);
            }
        }

        public FuelVehicle(string regNo, double fuelCapacity) : base(regNo)
        {
            FuelCapacity = fuelCapacity;
        }

    }

    class FuelCar : FuelVehicle
    {
        private const double fuelConsumption = 0.5;
        public double maxDistance => FuelLevel / fuelConsumption;

        public double Milage { get; private set; }
        public FuelCar(string regNo, double fuelCapacity) : base(regNo, fuelCapacity)
        {
        }

        public override string Drive(double distance)
        {
            return base.Drive(distance);
        }
    }
}
