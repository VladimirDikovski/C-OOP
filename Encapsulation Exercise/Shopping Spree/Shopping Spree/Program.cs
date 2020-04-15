using System;
using System.Collections.Generic;
using System.Linq;

namespace Shopping_Spree
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                string[] personsInput = Console.ReadLine().Split(new char[] { ';', '=' }, StringSplitOptions.RemoveEmptyEntries);
                List<Person> Persons = new List<Person>();
                GetPersons(personsInput, Persons);
                string[] productInput = Console.ReadLine().Split(new char[] { ';', '=' }, StringSplitOptions.RemoveEmptyEntries);
                List<Product> Product = new List<Product>();
                GetProducts(productInput, Product);
                Dictionary<string, List<string>> GetAllProduct = new Dictionary<string, List<string>>();
                BuyingProduct(Persons, Product, GetAllProduct);          
                PrintResult(GetAllProduct);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private static void PrintResult(Dictionary<string, List<string>> getAllProduct)
        {
         
            foreach (var item in getAllProduct)
            {
             
                  Console.Write($"{item.Key} - {string.Join(", ", item.Value)}");
                  Console.WriteLine();
                          
            }
        }

        private static void BuyingProduct(List<Person> Persons, List<Product> Product, Dictionary<string, List<string>> GetAllProduct)
        {

            while (true)
            {
                string[] PersonAndProcut = Console.ReadLine().Split(" ");
                if (PersonAndProcut[0] == "END")
                {
                    break;
                }
                string person = PersonAndProcut[0];
                string procuct = PersonAndProcut[1];

                Person currentPerson = Persons.Where(x => x.Name == person).FirstOrDefault();
                Product currentProduct = Product.Where(x => x.Name == procuct).FirstOrDefault();

                CalucaltePrice(currentPerson, currentProduct, GetAllProduct);

            }

        }
        private static void CalucaltePrice(Person currentPerson, Product currentProduct, Dictionary<string, List<string>> GetAllProduct)
        {

            if (currentPerson.Money >= currentProduct.Cost)
            {

                currentPerson.Money -= currentProduct.Cost;
                currentPerson.AddProduct(currentProduct);
                InputInDictonory(currentPerson.Name, currentProduct.Name, GetAllProduct);
                Console.WriteLine($"{currentPerson.Name} bought {currentProduct.Name}");

            }
            else
            {
                Console.WriteLine($"{currentPerson.Name} can't afford {currentProduct.Name}");
                
            }

          
        }
        private static void InputInDictonory(string personName, string productName, Dictionary<string, List<string>> getAllProduct)
        {
            if (!getAllProduct.ContainsKey(personName))
            {
                getAllProduct[personName] = new List<string>();
            }
            getAllProduct[personName].Add(productName);
        }
        private static void GetProducts(string[] productInput, List<Product> Product)
        {
            for (int i = 0; i < productInput.Length; i += 2)
            {
                string nameofproduct = productInput[i];
                decimal costProduct = decimal.Parse(productInput[i + 1]);
                Product newProduct = new Product(nameofproduct, costProduct);
                Product.Add(newProduct);

            }
        }
        private static void GetPersons(string[] personsInput, List<Person> Persons)
        {

            for (int i = 0; i < personsInput.Length; i += 2)
            {
                string name = personsInput[i];
                decimal money = decimal.Parse(personsInput[i + 1]);
                Person newPerson = new Person(name, money);
                Persons.Add(newPerson);
            }
        }
    }
}
