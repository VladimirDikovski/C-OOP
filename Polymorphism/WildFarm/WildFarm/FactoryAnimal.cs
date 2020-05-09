using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    using Animals;
    using System.Net.NetworkInformation;

    public  class FactoryAnimal
    {
        public Animal GetAnimal(string [] argx)
        {
            Animal newAnimal = null;
            string type = argx[0];
            string name = argx[1];
            double weight = double.Parse(argx[2]);
            if (type == "Cat")
            {
                string livingRegion = argx[3];
                string breed = argx[4];
                newAnimal = new Cat(name, weight, livingRegion, breed);
            }
            else if (type == "Tiger")
            {
                string livingRegion = argx[3];
                string breed = argx[4];
                newAnimal = new Tiger(name, weight, livingRegion, breed);
            }
            else if (type == "Owl")
            {
                double wingsize = double.Parse(argx[3]);
                newAnimal = new Owl(name, weight, wingsize);
            }
            else if (type == "Hen")
            {
                double wingsize = double.Parse(argx[3]);
                newAnimal = new Hen(name, weight, wingsize);
            }
            else if (type == "Mouse")
            {
                string livingRegion = argx[3];
                newAnimal = new Mouse(name, weight, livingRegion);
            }
            else if (type == "Dog")
            {
                string livingRegion = argx[3];
                newAnimal = new Dog(name, weight, livingRegion);
            }

            return newAnimal;
        }
    }
}
