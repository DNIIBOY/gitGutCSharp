using System;
using System.Linq.Expressions;

namespace Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 4;
            int y = 3;

            string output = "x er større end y? ";
            output += x > y;
            Console.WriteLine(output);
        }
    }
}
