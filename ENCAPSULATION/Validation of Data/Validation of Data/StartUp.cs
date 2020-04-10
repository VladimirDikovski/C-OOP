using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonsInfo
{
   public class StartUp
    {
       public static void Main(string[] args)
        {
            List<Person> Persons = new List<Person>();
            int nPersons = int.Parse(Console.ReadLine());
            ReadArguments(nPersons,Persons);
            decimal procent = decimal.Parse(Console.ReadLine());
            Persons.ForEach(x => x.IncreaseSalary(procent));
            PrintResult(Persons);
        }

        private static void PrintResult(List<Person> persons)
        {
            foreach (var item in persons)
            {
                Console.WriteLine(item);
            }
        }

        private static void ReadArguments(int nPersons,List<Person>Persons)
        {
            for (int i = 0; i < nPersons; i++)
            {
                string[] argumens = Console.ReadLine().Split(" ");
                string firstname = argumens[0];
                string lastname = argumens[1];
                int age = int.Parse(argumens[2]);
                decimal salary = decimal.Parse(argumens[3]);
                try
                {
                    Person person = AddNewPerson(firstname, lastname, age, salary);
                    Persons.Add(person);
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private static Person AddNewPerson(string firstname, string lastname, int age, decimal salary)
        {
            return new Person(firstname, lastname, age, salary);
        }
    }
}
