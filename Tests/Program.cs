using System;

namespace Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = { -2, -1, 0, 10 };
            int[] y = new int[4];
            y[0] = -2;
            y[1] = -1;
            y[2] = 0;
            y[3] = 10;
            Console.WriteLine(x[1]);
            Console.WriteLine(y[3]);
        }
    }
}