namespace PersonsInfo
{
    using System;
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Team NewTeam = new Team("SoftUni");
            int nPerson = int.Parse(Console.ReadLine());
            InputArguments(nPerson,NewTeam);
            Console.WriteLine($"First team has {NewTeam.FirstTeam.Count} players.");
            Console.WriteLine($"Reserve team has {NewTeam.ResevreTeam.Count} players.");

        }

        private static void InputArguments(int nPerson,Team NewTeam)
        {
            
            for (int i = 0; i < nPerson; i++)
            {
                string[] arguments = Console.ReadLine().Split(" ");
                string firstName = arguments[0];
                string lastName = arguments[1];
                int age = int.Parse(arguments[2]);
                decimal salary = decimal.Parse(arguments[3]);
                Person newPeron = GetPerson(firstName, lastName, age, salary);
                NewTeam.AddPlayer(newPeron);
                

            }
        }

        private static Person GetPerson(string firstName, string lastName, int age, decimal salary)
        {
            return new Person(firstName, lastName, age, salary);
        }
    }
}
