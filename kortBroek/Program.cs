using System;

namespace kortBroek
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] fraction = new int[2];  // Opret array til opbevaring af tæller og nævner

            while (true)
            {
                Console.Write("Indsæt tæller eller brøk: ");
                string input = Console.ReadLine();
                string[] fractionInput = input.Split('/');

                if (fractionInput[0] == input)  // Tjek om brøk blev skrevet med "/" 
                {
                    fractionInput = new string[2];
                    fractionInput[0] = input;

                    Console.Write("Indsæt nævner: ");
                    fractionInput[1] = Console.ReadLine();
                }

                else if (fractionInput.Length != 2)
                {
                    Console.Write("Ikke gylding brøk, prøv igen");
                    Console.ReadKey();
                    continue;
                }

                try
                {
                    fraction[0] = Convert.ToInt32(fractionInput[0]);
                    fraction[1] = Convert.ToInt32(fractionInput[1]);
                }
                catch (FormatException)
                {
                    Console.Write("Ikke gylding brøk, prøv igen");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }

                int divider = findLargestShortener(fraction[0], fraction[1]);

                if (divider == -1)
                {
                    Console.WriteLine("Kan ikke forkortes...");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }

                Console.WriteLine($"{fraction[0]/divider}\n-\n{fraction[1]/divider}");
                Console.WriteLine($"Delt med {divider}");
                Console.ReadKey();
                Console.Clear();
            }

            static int findLargestShortener(int numer, int denom)
            {
                int max = -1;

                for (int i = 2; i <= Math.Min(Math.Abs(numer), Math.Abs(denom)); i++)
                {
                    if (numer % i == 0 && denom % i == 0)
                    {
                        max = i;
                    }
                }

                if (max == -1)
                {
                    return -1;
                }

                return max;
            }
        }
    }
}
