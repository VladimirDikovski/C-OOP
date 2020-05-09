using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Foods;

namespace WildFarm.Animals
{
    public class Mouse : Mammal
    {
        public Mouse(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
        {
        }

        public override void EatingFood(Food foodType)
        {
            if(foodType.GetType().Name=="Vegetable"|| foodType.GetType().Name== "Fruit")
            {
                this.Weight += foodType.Quantity* 0.10;
                this.FoodEaten += foodType.Quantity;
            }
            else
            {
                Console.WriteLine($"{this.GetType().Name} does not eat {foodType.GetType().Name}!");
            }
        }

        public override string ProduceSound()
        {
           return "Squeak";
        }
        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
