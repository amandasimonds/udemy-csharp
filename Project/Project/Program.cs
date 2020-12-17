using System;

namespace Project
{
    public class Person
    {
        public string Name;

        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, I am {1}", to, Name);
        }

        public static Person Parse(string str) //takes a string and returns a person object
        {
            var person = new Person();
            person.Name = str;

            return person;
        }
        static void Main(string[] args)
        {
            var p = Person.Parse("Bean"); //we parse the string and now we have a person object
            p.Introduce("M");
        }
    }
}
