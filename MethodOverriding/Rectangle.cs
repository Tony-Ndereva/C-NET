﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_NET.MethodOverriding
{
    public class Rectangle: Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a rectangle!");
        }
    }
}
