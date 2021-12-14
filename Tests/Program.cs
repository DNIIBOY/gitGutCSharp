using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Tests
{
    class Program
    {
        static void Main(string[] args){
            for (int i = 0; i < 3; i++){
                try{
                    int user = int.Parse(Console.ReadLine());
                    int pass = int.Parse(Console.ReadLine());
                    
                    if (user == 12 && pass == 1234){
                        break;
                    }
                    else{
                        throw new FormatException();
                    }
                }
                catch (FormatException){
                    Console.WriteLine("Login Failed");
                }
            }
            Console.WriteLine("Login Successful");
        }
    }
}