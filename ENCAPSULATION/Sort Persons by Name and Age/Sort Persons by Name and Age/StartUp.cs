using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonsInfo
{
   public class StartUp
    {
       public static void Main(string[] args)
        {
            int nPerson = int.Parse(Console.ReadLine());
            List<Person> Persons = new List<Person>();
            GetMembers(nPerson,Persons);
            SortByNameAndAge(Persons);
            
        }

        private static void SortByNameAndAge(List<Person> persons)
        {
            List<Person> SortTedList = persons.OrderBy(x => x.FirstName).ThenBy(y => y.Age).ToList();
            PrintResult(SortTedList);
        }

        private static void PrintResult(List<Person> sortTedList)
        {
            foreach (var item in sortTedList)
            {
                Console.WriteLine(item);
            }
        }

        private static void GetMembers(int nPerson,List<Person>Persons)
        {
            for (int i = 0; i < nPerson; i++)
            {
                string[] input = Console.ReadLine().Split(" ");
                string firstName = input[0];
                string lastName = input[1];
                int age = int.Parse(input[2]);
                Person newPerson = new Person(firstName, lastName, age);
                Persons.Add(newPerson);
 
            }
        }

      
    }
}
