using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Foods;

namespace WildFarm.Animals
{
    public class Dog : Mammal
    {
        public Dog(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
        {
        }

        public override void EatingFood(Food foodType)
        {
            if (foodType.GetType().Name == "Meat")
            {
                this.Weight += foodType.Quantity* 0.40;
                this.FoodEaten += foodType.Quantity;
            }
            else
            {
                Console.WriteLine($"{this.GetType().Name} does not eat {foodType.GetType().Name}!");
            }
        }

        public override string ProduceSound()
        {
           return "Woof!";
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
