namespace PizzaCalories
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Topping
    {
        private string topycType;
        private double caloris;

        private const double Meat = 1.2;
        private const double Veggies  = 0.8;
        private const double Cheese = 1.1;
        private const double Sauce = 0.9;
        private const double staticCaloriesPerGram = 2.0;

        public Topping()
        {

        }
        public Topping(string type ,double calories)
        {
            this.TopycType = type;
            this.Calories = calories;
        }

        public string TopycType
        {
            get
            {
                return this.topycType;
            }
           private set
            {
                if(value!="Meat" && value!="Veggies" && value!="Cheese" && value!= "Sauce")
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }
                this.topycType = value;
            }
        }
        public double Calories
        {
            get
            {
                return this.caloris;
            }
           private set
            {
                if(value<1 || value > 50)
                {
                    throw new ArgumentException($"{this.TopycType} weight should be in the range [1..50].");
                }
                this.caloris = value;
            }
        }
        
       public double CalculateCalories()
        {
           
            double type = TypeOfTopping(this.TopycType);
            return staticCaloriesPerGram * this.Calories * type;
        }

        static double TypeOfTopping(string type)
        {
           
            if (type== "Meat")
            {
                return Meat;
            }
            else if(type== "Veggies")
            {
                return Veggies;
            }
            else if(type== "Cheese")
            {
                return Cheese;
            }
            else 
            {
                return Sauce;
            }
        }

     
    }
}
