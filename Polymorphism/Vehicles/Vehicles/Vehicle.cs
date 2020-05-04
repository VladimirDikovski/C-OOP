using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
   public abstract class Vehicle
    {
        public Vehicle(double fuelquontity, double littleperkilometur)
        {
            this.FuelQuantity = fuelquontity;
            this.LiterPerKilometur = littleperkilometur;
        }

        public double FuelQuantity { get; protected set; }
        public virtual double LiterPerKilometur { get; protected set; }

        public void DrivingDistance(double distance)
        {
            double consuption = distance * LiterPerKilometur;
            if (FuelQuantity >= consuption)
            {
                FuelQuantity -= consuption;
                Console.WriteLine($"{this.GetType().Name} travelled {distance} km");
            }
            else
            {
                Console.WriteLine($"{this.GetType().Name} needs refueling");
            }
        }

        public virtual void RefuelTank(double litters)
        {
            this.FuelQuantity += litters;
        }
        
          
        
    }
}
