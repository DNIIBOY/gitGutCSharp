using System;
using System.Linq.Expressions;

namespace Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 42;
            int y = 64;

            if (x + y > 100)
            {
                Console.WriteLine("Summen er større end 100!");
            }
            else
            {
                Console.WriteLine("Summen er mindre end 100");
            }


            bool result = x + y > 100;
            if (result)
            {
                Console.WriteLine("Summen er større end 100!");
            }
            else
            {
                Console.WriteLine("Summen er mindre end 100");
            }
        }
    }
}
