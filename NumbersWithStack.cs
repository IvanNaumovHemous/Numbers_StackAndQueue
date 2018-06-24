using System;
using System.Collections.Generic;
using System.Linq;

namespace NumbersWithaStack
{
    class NumbersWithStack
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().Split(' ').Select(int.Parse);
            var stack = new Stack<int>(text);
            while (stack.Count > 0)
            {
                Console.Write(stack.Pop() + " ");
            }
            Console.WriteLine();
        }
    }
}
