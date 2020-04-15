using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PizzaCalories
{
   public  class Pizza
    {
        private string name;
        private List<Topping> toppings;
       
 
        public Pizza()
        {

        }
        public Pizza(string name ,Dough dough)
        {
            this.Name = name;
            this.Dough = dough;
           this.toppings = new List<Topping>();
        }
    
        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length>15)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }
                this.name = value;
            }
        }

        public Dough Dough { get; set; }

        public void AddToppings(Topping toping)
        {
            if (toppings.Count == 10)
            {
             throw new ArgumentException("Number of toppings should be in range [0..10].");
            }
            toppings.Add(toping);
        }  
        public override string ToString()
        {
            double result = this.Dough.CalculateCalories() + toppings.Sum(x => x.CalculateCalories());
            return $"{this.Name} - {result:f2} Calories.";
        }

    }
}
