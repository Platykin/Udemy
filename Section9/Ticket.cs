using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section9
{
    internal class Ticket : IEquatable<Ticket>
    {

        public int DurationInHours { get; set; }    

        public Ticket() 
        {
           DurationInHours = 0;
        }

        public Ticket(int durationInHours)
        {
            DurationInHours = durationInHours;
        }

        public bool Equals(Ticket? other)
        {
            return other!=null && this.DurationInHours == other.DurationInHours;
        }

    }
}
