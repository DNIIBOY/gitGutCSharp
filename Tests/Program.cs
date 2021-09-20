using System;
using System.Linq.Expressions;

namespace Tests
{
    class Program
    {
        class Furniture
        {
            public double cost { set; get; }
            public string manufacturer { set; get; }

            public void PrintInfo()
            {
                Console.WriteLine($"[Furniture] er lavet af {manufacturer} og koster {cost}");
            }
        }

        class Chair : Furniture
        {
            public int legCount { get; set; } = 4;
            public void PrintInfo()
            {
                Console.WriteLine($"[Chair] er lavet af {manufacturer} og koster {cost}");
                Console.WriteLine($"Den har {legCount} ben");
            }
        }
        class Computer : Furniture
        {
            public string GPU { get; set; }
            public void PrintInfo()
            {
                Console.WriteLine($"[Computer] er lavet af {manufacturer} og koster {cost}");
                Console.WriteLine($"Grafikkortet er et {GPU}");
            }
        }
        static void Main(string[] args)
        {
            Chair f = new Chair();
            f.manufacturer = "Samsung";
            f.cost = 150.45;
            f.legCount = 3;
            f.PrintInfo();

            Computer c = new Computer();
            c.manufacturer = "Dell";
            c.cost = 6900;
            c.GPU = "RTX 3090";
            c.PrintInfo();
        }
    }
}
