using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Tests
{
    class Program
    {
        class Person
        {
            private string _name;
            public Person(string name)
            {
                _name = name;
            }
            public string ToString()
            {
                return $"Hello! My name is {_name}";
            }
        }

        static void Main(string[] args){
            Person[] people = new Person[3];
            for (int i = 0; i<3; i++)
            {
                people[i] = new Person(Console.ReadLine());
            }
            for (int i = 0; i<3; i++)
            {
                Console.WriteLine(people[i].ToString());
            }
        }
    }
}