using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Classes!");


            // class = Bauanleitung/Typbeschreibung ---------------- instantiate ------>    objects
            // object is 
            // instantiate objects
            // string name = "Max Mustermann";
            // initiate custom object
            string name = new string("Max Mustermann");

            // initiate custom object
            Person max = new Person(name, 19);

            //person._Name = name;
            //person._Age = 19;

            // initiate custom object 
            Person peter = new Person("Peter");
            //person2._Name = "Peter Lustig";


            // use object and call methodes
            max.Print();
            peter.Print();
           

        }
    }
}
