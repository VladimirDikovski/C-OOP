using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding
{
    public class FactoryHeroes
    {
        public  BaseHero CreateNewHero(string heroName, string heroType)
        {
            BaseHero hero;
            if (heroType == "Paladin")
            {
                hero = new Paladin(heroName);
            }
            else if (heroType == "Druid")
            {
                hero = new Druid(heroName);
            }
            else if (heroType == "Rogue")
            {
                hero = new Rogue(heroName);
            }
            else if (heroType == "Warrior")
            {
                hero = new Warrior(heroName);
            }
            else
            {
                throw new ArgumentException("Invalid hero!");
            }
            return hero;
        }
    }
}
