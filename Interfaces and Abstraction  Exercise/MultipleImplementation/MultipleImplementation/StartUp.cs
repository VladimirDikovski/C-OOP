using System;

namespace PersonInfo
{
   public class StartUp
    {
       public static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string id = Console.ReadLine();
            string birthday = Console.ReadLine();

            Citizen newCitizen = new Citizen(name, age, id, birthday);

            Console.WriteLine(newCitizen.Id);
            Console.WriteLine(newCitizen.Birthdate);
        }
    }
}
