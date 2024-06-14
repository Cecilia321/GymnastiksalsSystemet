using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymnastiksalsSystemet
{
    internal class Booking
    {
        public DateTime Date { get; private set; }
        public DateTime Start {  get; private set; }
        public DateTime End { get; private set; }
        public int HallId { get; set; }
        public int GruppeId { get; private set; }

        
        
        public Booking(int hallId, int gruppeId, DateTime date, DateTime start, DateTime end)
        {
            HallId = hallId;
            GruppeId = gruppeId;
            Date = date;
            Start = start;
            End = end;
            
        }

        
    }
}
