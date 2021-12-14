using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Tests
{
    class Program
    {
        static void Main(string[] args){
            int num = int.Parse(Console.ReadLine());
            int H = int.Parse(Console.ReadLine());
            Console.WriteLine();
            
            for (int i = H; i > 0; i--)
            {
                for (int k = 0; k < H-i; k++){
                    Console.Write(" ");
                }
                for (int j = 0; j < i; j++){
                    Console.Write(num);
                }
                Console.WriteLine();
            }
        }
    }
}