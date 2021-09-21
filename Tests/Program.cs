using System;

namespace Tests
{
    class Program
    {
        class Furniture
        {
            public double Cost { set; get; }
            public string Manufacturer { set; get; }

            public void PrintInfo()
            {
                Console.WriteLine($"[Furniture] er lavet af {Manufacturer} og koster {Cost}");
            }
        }

        class Chair : Furniture
        {
            public int LegCount { get; set; } = 4;
            public void PrintInfo()
            {
                Console.WriteLine($"[Chair] er lavet af {Manufacturer} og koster {Cost}");
                Console.WriteLine($"Den har {LegCount} ben");
            }
        }
        class Computer : Furniture
        {
            public string GPU { get; set; }
            public void PrintInfo()
            {
                Console.WriteLine($"[Computer] er lavet af {Manufacturer} og koster {Cost}");
                Console.WriteLine($"Grafikkortet er et {GPU}");
            }
        }
        static void Main(string[] args)
        {
            Chair f = new Chair();
            f.Manufacturer = "Samsung";
            f.Cost = 150.45;
            f.LegCount = 3;
            f.PrintInfo();

            Computer c = new Computer();
            c.Manufacturer = "Dell";
            c.Cost = 6900;
            c.GPU = "RTX 3090";
            c.PrintInfo();
        }
    }
}
