using System;
using System.Collections.Generic;

namespace WildFarm
{
    using Animals;
    using Foods;
    public class Program
    {        
       public static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            Animal animal = null;
          
            int counter = 0;
            while (true)
            {
                
                string[] animalArxh = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
                if (animalArxh[0] == "End")
                {
                    break;
                }
                if (counter % 2 == 0)
                {
                    FactoryAnimal newAnimal = new FactoryAnimal();
                    animal = newAnimal.GetAnimal(animalArxh);
                   Console.WriteLine(animal.ProduceSound());                   
                }
                else
                {
                    FactoryFood newFood = new FactoryFood();
                    Food food = newFood.GetFood(animalArxh);
                    animal.EatingFood(food);
                    animals.Add(animal);
                }
                
                counter++;
            }
            foreach (var item in animals)
            {
                Console.WriteLine(item);
            }

        }
    }
}
