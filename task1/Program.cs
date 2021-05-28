using System;
using task03;

namespace task1
{
    internal static class Program
    {
        private static void Main()
        {
            var price = new Price("name", "shop", 0);
            Console.WriteLine(price.GetType());
            Console.WriteLine(price.ToString());
        }
    }
}