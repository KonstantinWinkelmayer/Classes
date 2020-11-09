using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Classes!");

            //class ----- instantiate -------->  objects


            //instantiate object
            //string name = "Max Mustermann"
            string name = new string("Max Mustermann");


            //create object
            Person person = new Person();
            person.Name = name;
            

            //create object
            Person person2 = new Person();
            person2.Name = "Peter";

            //use objects
            person.Print();
            person2.Print();
           
        }
    }
}
