﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_NET.AbstractClasses_Members
{
    public abstract class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public abstract void Draw();
        public void Copy()
        {
            Console.WriteLine("Copy shape into clipboard");
        }
        public void Select()
        {
            Console.WriteLine("Selected the shape");
        }
        
    }
}
