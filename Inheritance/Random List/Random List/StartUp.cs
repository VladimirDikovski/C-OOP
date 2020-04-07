namespace CustomRandomList
{
    using System;

  public class StartUp
    {
       public static void Main(string[] args)
        {
            var list = new RandomList();
            string[] input = Console.ReadLine().Split(" ");
            for (int i = 0; i < input.Length; i++)
            {
                list.Add(input[i]);
            }

            Console.WriteLine(list.RandomString());
        }
    }
}
