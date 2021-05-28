using System;
using task03;
using task2;

namespace task1
{
    internal static class Program
    {
        private static void Main()
        {
            var price = new Price("name", "shop", 0);
            Console.WriteLine(price.ToString());

            var item = new PublicClass();
            Console.WriteLine(item.ToString());
        }
    }
}