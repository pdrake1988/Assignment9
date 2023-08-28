using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment9
{
    internal class EventSchedule
    {
        public Tuple<string, DateOnly, string> NewEvent(
            string name,
            DateOnly dateOnly,
            string location
        )
        {
            return Tuple.Create(name, dateOnly, location);
        }
    }
}
