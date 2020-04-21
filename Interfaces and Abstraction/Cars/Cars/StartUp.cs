using System;

namespace Cars
{
    public class StartUp
    {
       public static void Main(string[] args)
        {
            Seat NewSeat = new Seat("Leon", "Grey");

            Tesla newTesla = new Tesla("Model 3", "Red", 2);

            Console.Write(NewSeat);
            Console.Write(newTesla);

        }
    }
}
