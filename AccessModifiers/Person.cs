using System;

namespace C_NET.AccessModifiers
{
    public class Person
    {
        public Person(DateTime birthdate)
        {
            this.BirthDate = birthdate;
        }
        public string Name { get; set; }
        public DateTime BirthDate { get; private set; }
        public int Age 
        {
            get
            {
                var timeSpan = DateTime.Today - BirthDate;
                var years = timeSpan.Days/365;
                return years;
            }
        }

    }
}
