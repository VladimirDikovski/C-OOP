using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomStack
{
  public class StartUp
    {
       public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ");

            var stackOfString = new StackOfStrings();
            Stack<string> inputStack = new Stack<string>();

            inputStack = AddValus(inputStack, input);

            Console.WriteLine(stackOfString.IsEmpty());

            stackOfString.AddRange(inputStack);
            Console.WriteLine(stackOfString.IsEmpty());


        }

        private static Stack<string> AddValus(Stack<string> inputStack, string[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                inputStack.Push(input[i]);
            }
            return inputStack;
        }
    }
}
