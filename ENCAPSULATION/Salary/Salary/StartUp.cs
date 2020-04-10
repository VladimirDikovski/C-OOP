using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonsInfo
{
   public  class StartUp
    {
        public static void Main(string[] args)
        {
            List<Person> Persons = new List<Person>();
            int nPersons = int.Parse(Console.ReadLine());

            ReadArguments(nPersons, Persons);

            decimal procent = decimal.Parse(Console.ReadLine());
            Persons.ForEach(x => x.IncreaseSalary(procent));
            PrintResult(Persons);

        }

        private static void PrintResult(List<Person> Persons)
        {
            foreach (var item in Persons)
            {
                Console.WriteLine(item);
            }
        }

        private static void ReadArguments(int nPersons,List<Person>Persons)
        {
           
            for (int i = 0; i < nPersons; i++)
            {
                string[] inputLine = Console.ReadLine().Split(" ");
                string firstName = inputLine[0];
                string lastName = inputLine[1];
                int age = int.Parse(inputLine[2]);
                decimal salary = decimal.Parse(inputLine[3]);
              Person NewPerson = AddMember(firstName, lastName, age, salary);
              Persons.Add(NewPerson);
            }
        }

        private static Person AddMember(string firstName, string lastName, int age, decimal salary)
        {
            return new Person(firstName, lastName, age, salary);
        }
    }
}
