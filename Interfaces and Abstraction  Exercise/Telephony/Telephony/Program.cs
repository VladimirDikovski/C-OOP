using System;
using System.Collections.Generic;
using System.Linq;

namespace Telephony
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] phoneNumbers = Console.ReadLine().Split(" ");
            string[] sites = Console.ReadLine().Split(" ");
            Smartphone smartphone = new Smartphone();

            foreach (var item in phoneNumbers)
            {
                Console.WriteLine(smartphone.Call(item)); 
            }
            foreach (var item in sites)
            {
                Console.WriteLine(smartphone.Browse(item));
            }

        }
    }
}
