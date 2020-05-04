using System;
using System.Collections.Generic;
using System.Linq;

namespace Vehicles
{
    public class Program
    {
        public static void Main(string[] args)
        {
           
            var vehicle = new List<Vehicle>();
            string[] carInput = Console.ReadLine().Split(" ");           
            Car NewCar = GetNewCar(carInput);
            string[] truckInput = Console.ReadLine().Split(" ");
            Truck NewTruck = GetNewTruck(truckInput);           
            vehicle.Add(NewCar);
            vehicle.Add(NewTruck);            

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ");
                string operation = input[0];
                if (operation == "Drive")
                {
                    DriveModel(vehicle, input);

                }
                else if(operation=="Refuel")
                {
                    RefuelModel(vehicle, input);

                }

            }
            Console.WriteLine($"Car: {vehicle[0].FuelQuantity:f2}");
            Console.WriteLine($"Truck: {vehicle[1].FuelQuantity:f2}");
        }

        private static void RefuelModel(List<Vehicle> vehicle, string[] input)
        {
            string model = input[1];
            double litters = double.Parse(input[2]);
            if (model == "Car")
            {
                vehicle[0].RefuelTank(litters);
            }
            else if (model == "Truck")
            {
                vehicle[1].RefuelTank(litters);
            }
        }

        private static void DriveModel(List<Vehicle> vehicle, string[] input)
        {
            string model = input[1];
            double distance = double.Parse(input[2]);
            if (model == "Car")
            {
                vehicle[0].DrivingDistance(distance);
            }
            else if (model == "Truck")
            {
                vehicle[1].DrivingDistance(distance);
            }
        }

        private static Truck GetNewTruck(string[] truckInput)
        {
           
        
            double fuelQuontityTruck = double.Parse(truckInput[1]);          
            double litterPerKilometerTruck = double.Parse(truckInput[2]);                  
            return new Truck(fuelQuontityTruck, litterPerKilometerTruck);
        }

        private static Car GetNewCar(string[] carInput)
        {
           
            double fuelQuontityCar = double.Parse(carInput[1]);
            double litterPerKilometerCar = double.Parse(carInput[2]);          
            return new Car(fuelQuontityCar, litterPerKilometerCar);
        }
    }
}
