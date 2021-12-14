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

            for (int i = 0; i < H - 1; i++){
                Console.Write(" ");
            }
            Console.WriteLine(num);
            
            for (int i = 1; i < H-1; i+=2){
                
            }
            
        }
    }
}