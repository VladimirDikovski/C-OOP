using Operations;
using System;

namespace Operations
{
    public class StartUp
    {
       public  static void Main(string[] args)
        {
            MathOperations newOperation = new MathOperations();
            Console.WriteLine(newOperation.Add(2, 3));
            Console.WriteLine(newOperation.Add(3.5,3.5,3.5));
            Console.WriteLine(newOperation.Add(2.2m,2.2m,2.2m));
            
        }
    }
}
