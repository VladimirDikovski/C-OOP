using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Truck : Vehicle
    {
        private const double FuelTini = 0.95;
       private const double AirConditionTruck = 1.6;
        public Truck(double fuelquontity, double littleperkilometur) : base(fuelquontity, littleperkilometur)
        {

        }
        public override double LiterPerKilometur
        {
            get
            {
                return base.LiterPerKilometur;
            }
            protected set
            {
                base.LiterPerKilometur = value + AirConditionTruck;
            }
        }


        public override void RefuelTank(double litters)
        {
            
            FuelQuantity += litters* FuelTini;
        }
    }
}
