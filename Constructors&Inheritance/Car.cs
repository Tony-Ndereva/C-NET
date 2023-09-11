﻿using System;
using System.Runtime.InteropServices;

namespace C_NET.Constructors_Inheritance
{
    public class Car : Vehicle
    {
        public Car(string registrationNumber)
            :base(registrationNumber)
        {
            Console.WriteLine("Car is being initialized. {0}",registrationNumber);
        }
    }
}
