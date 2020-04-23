using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

namespace FoodShortage
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            var listOfPeople = new List<IBuyer>();

            for (int i = 0; i < numberOfPeople; i++)
            {
                string[] input = Console.ReadLine().Split(" ");
                if (input.Length == 4)
                {
                    Citizen newcitizen = GetNewCitizen(input);
                    listOfPeople.Add(newcitizen);
                }
                else if (input.Length == 3)
                {
                   Rebel newrebel = GetNewRebel(input);
                   listOfPeople.Add(newrebel);
                }
            }

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }
                listOfPeople.Where(x => x.Name == input).ToList().ForEach(x => x.BuyFood());
            }
            int result = 0;

            foreach (var item in listOfPeople)
            {
                result += item.Food;
            }
            Console.WriteLine(result);
           
            
         
        }

        private static Rebel GetNewRebel(string[] input)
        {
            string name = input[0];
            int age = int.Parse(input[1]);
            string group = input[2];
            return new Rebel(name, age, group);
        }

        private static Citizen GetNewCitizen(string[] input)
        {
            string name = input[0];
            int age = int.Parse(input[1]);
            string id = input[2];
            string dataofbirthday = input[3];
            return new Citizen(name, age, id, dataofbirthday);
        }
    }
}
