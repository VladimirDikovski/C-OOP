namespace Animals
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            while (true)
            {
                string type = Console.ReadLine();
                if (type == "Beast!")
                {
                    break;
                }
                string[] arguments = Console.ReadLine().Split(" ");
                Animal NewAnimal = null;
                try
                {
                    NewAnimal = GetAnimal(type, arguments);
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    continue;
                }
              
                animals.Add(NewAnimal);
               
            }
            PrintResult(animals);
            
        }

        private static void PrintResult(List<Animal> animals)
        {
            foreach (var item in animals)
            {
                Console.WriteLine(item);
            }
        }

        private static Animal GetAnimal(string type, string[] arguments)
        {
            Animal NewAnimal = null;
            string name = arguments[0];
            int age = int.Parse(arguments[1]);
            string gender = string.Empty;
            if (arguments.Length == 3)
            {
                gender = arguments[2];

            }
            if (type == "Cat")
            {

                NewAnimal = new Cat(name, age, gender);
            }
            else if (type == "Dog")
            {
                NewAnimal = new Dog(name, age, gender);
            }
            else if (type == "Frog")
            {
                NewAnimal = new Frog(name, age, gender);
            }
            else if (type == "Kitten")
            {
                NewAnimal = new Kitten(name, age);
            }
            else if (type == "Tomcat")
            {
                NewAnimal = new Tomcat(name, age);
            }
            else
            {
                throw new ArgumentException("Invalid input!");
            }
            return NewAnimal;
        }

       
    }
}
