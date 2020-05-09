using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Foods;

namespace WildFarm.Animals
{
    public class Hen : Bird
    {
        public Hen(string name, double weight, double wingsize) : base(name, weight, wingsize)
        {
        }

        public override void EatingFood(Food foodType)
        {
           this.Weight+=foodType.Quantity* 0.35;
            this.FoodEaten += foodType.Quantity;
        }

        public override string ProduceSound()
        {
            return "Cluck";
        }
        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, {this.WingSize}, {this.Weight}, {this.FoodEaten}]";
        }
    }
}
