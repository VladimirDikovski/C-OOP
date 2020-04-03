using System;

namespace Rhombus_of_Stars
{
  public class Program
    {
      public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            UperRow(n);
            DownRow(n-1);

           
            
        }
        public static void UperRow(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write('*' + " ");
                }
                Console.WriteLine();
            }

        }

        public static void DownRow(int n)
        {
            
            for (int i = 0; i < n ; i++)
            {
                for (int j = n; j > i; j--)
                {
                    Console.Write('*' + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
