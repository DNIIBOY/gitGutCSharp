using System;

namespace kortBroek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Indsæt tæller eller brøk: ");
            string input = Console.ReadLine();
            string[] broek = input.Split('/');
        }
    }
}
