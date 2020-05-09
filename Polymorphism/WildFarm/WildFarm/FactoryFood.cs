using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    using Foods;
    public class FactoryFood
    {
        public Food GetFood(string[] argh)
        {
            Food NewFood = null;
            string foodType = argh[0];
            int quantity = int.Parse(argh[1]);
            if (foodType == "Vegetable")
            {
                NewFood = new Vegetable(quantity);
            }
            else if (foodType == "Fruit")
            {
                NewFood = new Fruit(quantity);
            }
            else if (foodType == "Meat")
            {
                NewFood = new Meat(quantity);
            }
            else if (foodType == "Seeds")
            {
                NewFood = new Seeds(quantity);
            }
            return NewFood;
        }

    }
}
