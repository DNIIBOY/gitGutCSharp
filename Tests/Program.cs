using System;
using System.Linq.Expressions;

namespace Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = "Hello, World!";
            Console.WriteLine(x.Split('u')[0]);
        }
    }
}
