using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Car:Vehicle
    {
        private const double AirConditionCar = 0.9;

        public override double LiterPerKilometur
        {
            get
            {
                return base.LiterPerKilometur;
            }
            protected set
            {
                base.LiterPerKilometur = value + AirConditionCar;
            }
        }
            

        public Car(double fuelquantity, double littleperkilometur)
            : base(fuelquantity, littleperkilometur)
        {

        }
       

      
    }
}
