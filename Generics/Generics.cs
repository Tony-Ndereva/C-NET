using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_NET.Generics
{
    public  class Iterate
    {

        
        public static void displayElement<T>(T[] array)
        {
            foreach(var item in array)
            {
                Console.WriteLine(item + " ");
            }
        }
    }
}
