using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Linq;


namespace BorderControl
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var identy = new List<IIdentifiable>();
            while (true)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (input[0] == "End")
                {
                    break;
                }
                else if (input.Length == 3)
                {
                    Citizen newCitizen = GetNewCitizen(input);
                    identy.Add(newCitizen);

                }
                else if (input.Length == 2)
                {
                    Robot newRobot = GetNewRobot(input);
                    identy.Add(newRobot);
                }
            }
            string type = Console.ReadLine();


            identy = identy.Where(x => x.id.EndsWith(type)).ToList();

            foreach (var item in identy)
            {
                Console.WriteLine(item.id);
            }

        }
   
        private static Robot GetNewRobot(string[] input)
        {
            string model = input[0];
            string id = input[1];
            return new Robot(model, id);
        }

        private static Citizen GetNewCitizen(string[] input)
        {
            string name = input[0];
            int age = int.Parse(input[1]);
            string id = input[2];
            return new Citizen(name, age, id);
        }
    }
}

