using System;
using System.Collections.Generic;

namespace C_NET.Lists
{
    internal class ListPractise
    {
        public static void PrintList()
        {
            var numbers = new List<int>() { 1, 2, 3, 4 };
            numbers.Add(1);
            numbers.AddRange(new int[3] { 5, 6, 7 });
            foreach (var number in numbers)
            {
                Console.WriteLine(number); 
            }


        }


    }
}
