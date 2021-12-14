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
            protected string _name;
            public Person(string name)
            {
                _name = name;
            }
            public string ToString()
            {
                return $"Hello! My name is {_name}";
            }
        }

        class Student : Person
        {
            public Student(string name) : base(name){}
            
            public void study()
            {
                Console.WriteLine($"{_name} is studying");
            }
        }

        class Teacher : Person
        {
            public Teacher(string name) : base(name){}
            
            public void explain()
            {
                Console.WriteLine($"{_name} is explaining");
            }
        }
        static void Main(string[] args){
            Person[] people = new Person[3];
            people[0] = new Person("John");
            people[1] = new Student("Jack");
            people[2] = new Teacher("Jill");
        }
    }
}