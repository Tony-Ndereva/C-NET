using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_NET.Interfaces
{
    public  class Furniture
    {
        // color of the furniture
        public string Color { get; set; }
        // material of the furniture
        public string Material { get; set; }
        // default constructor
        public Furniture()
        {
            this.Color = "White";
            this.Material = "Wood";
            
        }
        public Furniture(string color, string material)
        {
            this.Color = color;
            this.Material = material;
        }
    }
}
