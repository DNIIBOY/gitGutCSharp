using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Tests
{
    class Program
    {
        static public int countSpaces(string str)
        {
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                {
                    count++;
                }
            }
            return count;
        }
        static void Main(string[] args){
            Console.WriteLine(countSpaces(Console.ReadLine()));
        }
    }
}