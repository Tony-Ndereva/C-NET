using C_NET.Array;
using C_NET.Math;
using System;
using System.Security.Cryptography.X509Certificates;

namespace C_NET
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var john = new Person();
            john.FirstName = "John";
            john.LastName = "Smith";
            john.Introduce();

            Calculator calculator = new Calculator();
            
            var result = calculator.Add(1, 2);
            Console.WriteLine(result);

            ArrayPractise.PrintArray();
        }
    }
}
