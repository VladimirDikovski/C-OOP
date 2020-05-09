using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Foods;

namespace WildFarm.Animals
{
    public class Cat : Feline
    {
        public Cat(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion, breed)
        {
        }

        public override void EatingFood(Food foodType)
        {
            if (foodType.GetType().Name == "Vegetable" || foodType.GetType().Name == "Meat")
            {
                this.Weight += foodType.Quantity*0.30;
                this.FoodEaten += foodType.Quantity;
            }
            else
            {
                Console.WriteLine($"{this.GetType().Name} does not eat {foodType.GetType().Name}!");
            }
        }

        public override string ProduceSound()
        {
            return "Meow"; 
        }
        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, {this.Breed}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
