using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Foods;

namespace WildFarm.Animals
{
    public class Owl : Bird
    {
        public Owl(string name, double weight, double wingsize) : base(name, weight, wingsize)
        {
        }

        public override void EatingFood(Food foodType)
        {

            if (foodType.GetType().Name == "Meat")
            {
                this.Weight += foodType.Quantity* 0.25;
                this.FoodEaten += foodType.Quantity;
            }
            else
            {
                Console.WriteLine($"{this.GetType().Name} does not eat {foodType.GetType().Name}!");
            }
        }

        public override string ProduceSound()
        {
            return "Hoot Hoot";
        }
        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, {this.WingSize}, {this.Weight}, {this.FoodEaten}]";
        }
    }
}
