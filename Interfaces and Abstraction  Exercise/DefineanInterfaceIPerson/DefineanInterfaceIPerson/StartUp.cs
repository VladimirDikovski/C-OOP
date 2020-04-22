using System;

namespace PersonInfo
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            Citizen newCitizen = new Citizen(name, age);
            Console.WriteLine(newCitizen.Name);
            Console.WriteLine(newCitizen.Age);

        }
    }
}
