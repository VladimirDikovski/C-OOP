using System;
using System.Collections.Generic;
using System.Linq;

namespace Raiding
{
    public class Program
    {
       public  static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<BaseHero> heroes = new List<BaseHero>();
            int counter = 0;
            while (n!=counter)
            {
                string heroName = Console.ReadLine();
                string heroType = Console.ReadLine();
                FactoryHeroes faktori = new FactoryHeroes();
                BaseHero hero= faktori.CreateNewHero(heroName, heroType);
                try
                {
                    heroes.Add(hero);
                    counter++;
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }                              
            }
         
            int bosspower = int.Parse(Console.ReadLine());

            int sumPower = SumHeroesPower(heroes);

            PrintCastAbility(heroes);
            if (sumPower >= bosspower)
            {
                Console.WriteLine("Victory!");
            }
            else
            {
                Console.WriteLine("Defeat...");
            }
        }

        private static void PrintCastAbility(List<BaseHero> heroes)
        {
            foreach (var item in heroes)
            {
                Console.WriteLine(item.CastAbility());
            }
        }

        private static int SumHeroesPower(List<BaseHero> heroes)
        {
            int sumPower = 0;
            foreach (var item in heroes)
            {
                sumPower += item.Power;
            }
            return sumPower;
        }

      
    }
}
