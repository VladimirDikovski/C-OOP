using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public abstract class Animal
    {
        public Animal(string name,string favoritFood)
        {
            this.Name = name;
            this.FavouriteFood = favoritFood;
        }
        public string Name { get; private set; }
        public string FavouriteFood  { get; private set; }


        public abstract string ExplainSelf();
    }
}
