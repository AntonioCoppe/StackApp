using System;

namespace WiredBrainCoffee.StackApp
{
    class Program
    {
        static void Main(string[] args)
        {
            StackDoubles();
            StackStrings();

            Console.ReadLine();
        }

        private static void StackDoubles()
        {
            var stack = new Stack<double>();
            stack.Push(1.2);
            stack.Push(2.8);
            stack.Push(3.0);

            double sum = 0.0;
            while (stack.Count > 0)
            {
                double item = stack.Pop();
                System.Console.WriteLine($"Item: {item}");
                sum += item;

            }
            Console.WriteLine($"Sum: {sum}");
        }
        private static void StackStrings()
        {
          var stack = new SimpleStack<string>();
            stack.push("Hello");
            stack.push("World");

            while (stack.count > 0)
            {
                var item = stack.Pop();
                System.Console.WriteLine($"Item: {item}");
            }
        }
    }
}
