using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel_Reservation
{
  public static class PriceCalculator
    {
       public static decimal CalculatePrice(decimal pricePerDay ,int dayNumber ,Season season ,Discount discount)
        {
            decimal result = pricePerDay * dayNumber * (int)season;
            result -= result * (int)discount/100 ;
            return result;
        }

    }
}
