using System;
using System.Collections.Generic;

namespace PizzaCalories
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Pizza newPizza = new Pizza();
            Dough newDoght = new Dough();
            Topping newToping = new Topping();

            string[] pizzaTokken = Console.ReadLine().Split(" ");
            string pizzaName = pizzaTokken[1];

            string[] TokenDought = Console.ReadLine().Split(" ");
            try
            {
                newDoght = GetNewDought(TokenDought);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            try
            {
                newPizza = new Pizza(pizzaName, newDoght);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
          

            while (true)
            {
                string[] toppings = Console.ReadLine().Split(" ");
                if (toppings[0] == "END")
                {
                    break;
                }
                try
                {
                    newToping = GetNewTopping(toppings);
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return;
                }              
                newPizza.AddToppings(newToping);
            }
            Console.WriteLine(newPizza);
        }
   
    
        private static Topping GetNewTopping(string[] TokenDought)
        {
            string typeTopping = TokenDought[1];
            typeTopping = ToUpperFirstSymbols(typeTopping);          
            double caloris = double.Parse(TokenDought[2]);
            return new Topping(typeTopping, caloris);
        }

        private static Dough GetNewDought(string[] TokenDought)
        {
            string typeFlour = TokenDought[1];
            string baking = TokenDought[2];
            baking = ToUpperFirstSymbols(baking);
            double caloris = double.Parse(TokenDought[3]);

            return new Dough(typeFlour, baking, caloris);
        }
        static string ToUpperFirstSymbols(string type)
        {
            return char.ToUpper(type[0]) + type.Substring(1);
        }

    }
}
