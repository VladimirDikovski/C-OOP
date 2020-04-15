using System;
using System.Collections.Generic;
using System.Text;

namespace Shopping_Spree
{
    public class Person
    {
        private string name;
        private decimal money;
        private List<Product> bagOfProducts;


        public Person(string name, decimal money)
        {
            this.Name = name;
            this.Money = money;
            bagOfProducts = new List<Product>();
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be an empty string.");
                }

                this.name = value;
            }
        }

        public decimal Money
        {
            get
            {
                return this.money;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be a negative number.");
                }

                this.money = value;
            }
        }

        public IReadOnlyCollection<Product> BagOfProduct
        {
            get
            {
                return this.bagOfProducts.AsReadOnly();
            }
        }

      public void AddProduct(Product product)
       {
            this.bagOfProducts.Add(product);      
       }
       
    }
}
