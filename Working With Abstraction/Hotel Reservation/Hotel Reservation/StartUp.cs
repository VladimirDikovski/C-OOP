using System;

namespace Hotel_Reservation
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            
            string[] input = Console.ReadLine().Split(" ");
          
             decimal PricePerDay = decimal.Parse(input[0]);
             int days = int.Parse(input[1]);
             string season = input[2];        
             decimal price = 0;
            if (input.Length == 4)
            {
                 price = PriceCalculator.CalculatePrice(PricePerDay, days, Enum.Parse<Season>(season), Enum.Parse<Discount>(input[3]));
            }
            else
            {
               price = PriceCalculator.CalculatePrice(PricePerDay, days, Enum.Parse<Season>(season),Discount.NoDiscount);
            }
            Console.WriteLine($"{price:f2}");
           

        }
    }
}


