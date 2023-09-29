using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace C_NET.Interfaces
{
    public class Car : Vehicle
    {
        public Car(float speed,string color)
        {
            this.Speed = speed;
            this.Color = color;
            
        }

        
    }
}
