using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;
using WildFarm.Foods;

namespace WildFarm.Animals
{
    public abstract class Animal
    {
        public Animal(string name ,double weight)
        {
            this.Name = name;
            this.Weight = weight;
        }
        public string Name { get; private set; }
        public double Weight { get; protected set; }

        public int FoodEaten { get; set; }

        public abstract string ProduceSound();
        public abstract void EatingFood(Food foodType);
    }
}
