using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace WildFarm.Animals
{
    public abstract class Bird : Animal
    {
        public Bird(string name, double weight,double wingsize) : base(name, weight)
        {
            this.WingSize = wingsize;
        }

        public double WingSize { get;private set; }
    }
}
