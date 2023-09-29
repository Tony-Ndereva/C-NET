using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_NET.Interfaces
{
    public  class Ticket/* : IEquatable<Ticket>*/
    {
        // property to store the duration of the ticket in hours
        public int DurationInHours { get; set; }
        // simple constructor
        public Ticket(int durationInHours)
        {
           this.DurationInHours = durationInHours;
        }
       public bool Equals(Ticket other)
        {
            return this.DurationInHours == other.DurationInHours;
        }
    }
}
