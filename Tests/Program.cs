using System;

namespace Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Årgang: ");
            int år = Convert.ToInt32(Console.ReadLine());

            Console.Write("Pris: ");
            int price = Convert.ToInt32(Console.ReadLine());

            Console.Write("Udbetaling: ");
            int ud = Convert.ToInt32(Console.ReadLine());

            Console.Write("Mærke: ");
            string mærk = Console.ReadLine();

            Bil car = new Bil(år, price, ud, mærk);

            if (!car.hasMoney())
            {
                Console.WriteLine("Du har ikke råd");
            }
            else if (!car.isYoung())
            {
                Console.WriteLine("Bilen er for gammel");
            }
            else
            {
                Console.WriteLine("Du må gerne købe bilen!");
            }
        }
        
        class Bil
        {
            public int årgang { get; set; }
            public int pris { get; set; }

            public int udbetaling { get; set; }
            public string mærke { get; set; }

            public Bil(int år, int price, int ud, string mærk)
            {
                årgang = år;
                pris = price;
                udbetaling = ud;
                mærke = mærk;
            }

            public bool isYoung()
            {
                return 2021 - årgang <= 10;
            }

            public bool hasMoney()
            {
                return udbetaling >= pris;
            }

        }
    }
}
