using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class Person
    {
        //static field that is related with the "class" person
        //detailed in GITHUB Lindorfer Programm
        static private int _Counter = 0;
        private int _Age;
        private string _Name;

        //properties
        
        public int Age 
        { get; set; }
        
        public Person()
        {
        }

        //name = "name"
        //age = "age"
        public Person(string name, int age)
        {
            _Name = name;
            _Age = age;
        }
        
        //name = "name"
        public Person(string name)
        {
            _Name = name;
        }

        // public and private auch bei class möglich
        public void Print()
        {
            Console.WriteLine("I am " + _Name);
            // call of the private methode
            PrintAge();

        }

        private void PrintAge()
        {
            Console.WriteLine("Age: " + _Age);
        }
    }
}
