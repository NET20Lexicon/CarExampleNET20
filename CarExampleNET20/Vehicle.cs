using System;
using System.Collections.Generic;
using System.Text;

namespace CarExampleNET20
{
    //Interface ingen implementation
    //Alltid publikt
    public interface IDrive
    {
        string Drive(double distance);

    }

    //Abstrakt klass
    //Kan innehålla vanliga metoder med implementation
    //Samt privata metoder fält och properties
    abstract class AbstractVehicle : IDrive
    {
        //Virtual gör att ärvda klasser kan skriva egna implementationer av metoden
        public virtual string Drive(double distance) =>  $"Vehicle wants to drive for {distance}";
        //Abstract metod måste implementeras i ärvda klasser
        public abstract string Turn();

    }

    class Bicycle : AbstractVehicle
    {
        public string FrameNumber { get; }
        public Bicycle(string frameNumber)
        {
            FrameNumber = frameNumber;
        }

        public override string Turn() => "Bicycle turns";

        //Overide av virtual method
        public override string Drive(double distance)
        {
            return "Bicycle starts pedaling";
        }

    }

    class Vehicle : AbstractVehicle
    {
        public string RegNo { get; set; }

        public Vehicle(string regNo)
        {
            RegNo = regNo;
        }

        public override string Turn()
        {
            return "Vehicle turns";
        }
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

        //base anrop till basklassens konstruktor i det här fallet
        public FuelCar(string regNo, double fuelCapacity) : base(regNo, fuelCapacity)
        {
        }

        public string DoSound() => "Tut tut";


        public override string Drive(double distance)
        {
            var result = new StringBuilder();
            //Anropar basklassens Drive() metod
            result.AppendLine(base.Drive(distance));

            if(distance < 0)
            {
                distance = 0;
                result.AppendLine($"Negative distance is assumed to be 0");
            }

            //FuelLevel = FuelLevel - (distance * fuelConsumption);
            FuelLevel -= distance * fuelConsumption;

            result.AppendLine($"Regno: {RegNo} drove {distance} km");

            return result.ToString();

        }
    }
}
