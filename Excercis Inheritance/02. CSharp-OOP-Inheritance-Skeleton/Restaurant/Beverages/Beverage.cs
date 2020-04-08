namespace Restaurant.Beverages
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Beverage : Product
    {
        public Beverage(string name,decimal price,double mililitures)
            :base(name,price)
        {
            this.Milliliters = mililitures;
        }
     public virtual double Milliliters { get; set; }
            
    }
}
