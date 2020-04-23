
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;

namespace FoodShortage
{
    public class Citizen:IBuyer
    {
        public Citizen(string name ,int age ,string id,string brithDay)          
        {
            this.Name = name;
            this.Age = age;
            this.id = id;
            this.BrithDay = brithDay;
        }
 
        public string Name { get; private set; }

        public int Age { get; private set; }

        public string id { get; private set; }

        public string BrithDay { get; private set; }

         public int Food { get; private set; }

        public int BuyFood()
        {
            this.Food += 10;
            return Food;
        }
    }
}
