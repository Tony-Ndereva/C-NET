using System;

namespace C_NET
{
    public class Person
    {
        public string FirstName;
        public string LastName;
        public void Introduce(string to)
        {
            string name = string.Format("Hi {0}, I am {1}", to, FirstName);
            Console.WriteLine(name);
        }
        public Person Parse(string str)
        {
            var person = new Person();
            person.FirstName = str;
            return person;
        }
    
    }
}
