using System;
using System.Collections.Generic;
using System.Linq;

namespace BirthdayCelebrationss
{
    public class Program
    {
       public static void Main(string[] args)
        {
            var list = new List<IBrithDay>();
            while (true)
            {
                string[] input = Console.ReadLine().Split(" ");
                if (input[0] == "End")
                {
                    break;
                }
                else if (input[0] == "Citizen")
                {
                    string name = input[1];
                    int age = int.Parse(input[2]);
                    string id = input[3];
                    string birday = input[4];
                    Citizen newCitizen = new Citizen(name, age, id, birday);
                    list.Add(newCitizen);
                }
                else if (input[0] == "Pet")
                {
                    string name = input[1];
                    string birday = input[2];
                    Pet newPet = new Pet(name, birday);
                    list.Add(newPet);
                }
                else if (input[0] == "Robot")
                {
                    string model = input[1];
                    string id = input[2];
                    Robot newRobot = new Robot(model, id);
                }
            }
            string data = Console.ReadLine();

            list = list.Where(x => x.BrithDay.EndsWith(data)).ToList();

            foreach (var item in list)
            {
                Console.WriteLine(item.BrithDay);
            }
        }
    }
}
