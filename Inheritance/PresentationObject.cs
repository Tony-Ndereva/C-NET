﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_NET.Inheritance
{
    public class PresentationObject
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public void Copy()
        {
            Console.WriteLine("Object copied to clipboard");
        }
        public void Duplicate()
        {
            Console.WriteLine("Object was duplicated");
        }
    }
}