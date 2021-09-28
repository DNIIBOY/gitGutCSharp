using System;

namespace Tests
{
    class Person
    {
        private int _age;
        private string _name;
        private string _hairColor;

        public Person(int age, string name, string hairColor)
        {
            _age = age;
            _name = name;
            _hairColor = hairColor;
        }
        public Person (string name) : this(-1, name, "undefined"){}

        public void PrintInfo()
        {
            Console.WriteLine($"Jeg heder {_name}, jeg er {_age} år gammel og mit hår er {_hairColor}");
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Bob");
            Person p2 = new Person(15, "Karen", "Blåt");
            p1.PrintInfo();
            p2.PrintInfo();
        }
    }
}