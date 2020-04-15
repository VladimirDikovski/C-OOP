namespace PizzaCalories
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Dough
    {
        private string flourtype;
        private string baking;
        private double calories;

        private const double White = 1.5;
        private const double Wholegrain = 1.0;
        private const double Crispy = 0.9;
        private const double Chewy = 1.1;
        private const double Homemade = 1.0;
        private const double staticCalories = 2.0;


        public Dough(string flourtype, string baking,double calories)
        {
            this.FlourType = flourtype;
            this.Baking = baking;
            this.Calories = calories;
        }

        public Dough()
        {

        }

        public string FlourType
        {
            get
            {
                return this.flourtype;
            }
            private set
            {
                if(value!= "White" && value!= "Wholegrain")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                this.flourtype = value;
            }
        }

        public string Baking
        {
            get
            {
                return this.baking;
            }
           private set
            {
                if(value!= "Crispy" && value!= "Chewy" && value != "Homemade")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                this.baking = value;
            }
        }

        public double Calories
        {
            get
            {
                return this.calories;
            }
           private set
            {
                if(value<1 ||value > 200)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }
                this.calories = value;
            }
        }

        public double CalculateCalories()
        {
            double result = 0.0;
            double baking = 0.0;
            if (this.FlourType== "White")
            {
               baking = TypeBaking(this.Baking);              
                result = staticCalories * this.Calories * White * baking;
            }
            else if(this.FlourType== "Wholegrain")
            {
                baking = TypeBaking(this.Baking);
                result = staticCalories * this.Calories * Wholegrain * baking;
            }
            return result;
        }

       static double TypeBaking(string typeBaking)
        {
            if(typeBaking== "Chewy")
            {
                return Chewy;
            }
            else if(typeBaking== "Homemade")
            {
                return Homemade;
            }
            else
            {
                return Crispy;
            }

        }

    }
}
