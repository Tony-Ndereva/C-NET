using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace C_NET.Array
{
    public class ArrayPractise
    {
        public  static void PrintArray()
        {
            var numbers = new int[3] { 1, 2, 3 };
            foreach(var number in numbers)
            {
                Console.WriteLine(number);
            }
            var names = new string[3] { "Tony", "Trina","Stanley"};
            
        }
       
        
    }
}
