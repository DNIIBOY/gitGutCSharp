using System;
using System.Collections.Generic;

namespace Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = { 3, 2, 6, 69, 8, 78 };
            int sum = 0;
            for (int i = 0; i < x.Length; i++)
            {
                sum += x[i];
            }
            Console.WriteLine(sum + "\n");
            string[] strings = { "Hej", "Med", "Dig", "Jeg", "Spiser" };
            foreach (string str in strings)
            {
                Console.WriteLine(str);
            }

            Console.WriteLine();

            List<int> y = new List<int>();
            y.Add(69);
            y.Add(420);
            foreach (int el in y)
            {
                Console.WriteLine(el);
            }
        }
    }
}