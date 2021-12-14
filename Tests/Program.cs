using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Tests
{
    class Program
    {
        public void opg1(){
            
        }
        static void Main(string[] args){
            string num = Console.ReadLine();
            int H = int.Parse(Console.ReadLine());
            Console.WriteLine();
            
            for (int i = H; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(num);
                }
                Console.WriteLine();
            }
        }
    }
}