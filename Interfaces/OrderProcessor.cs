using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_NET.Interfaces
{
    public class OrderProcessor
    {
        private readonly ShippingCalculator _ShippingCalculator;
        public OrderProcessor()
        {
            this._ShippingCalculator = new ShippingCalculator();
        }
    }
}
