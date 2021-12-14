using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Tests
{
    class Program
    {
        static void Main(string[] args){
            List<int> pos = new List<int>();
            List<int> neg = new List<int>();
            for (int i = 0; i < 10; i++){
                int input = int.Parse(Console.ReadLine());
                if (input >= 0){
                    pos.Add(input);
                }
                else{
                    neg.Add(input);
                }
            }

            Console.WriteLine($"Avg Positive: {pos.Average()}");
            Console.WriteLine($"Avg Negative: {neg.Average()}");
        }
    }
}