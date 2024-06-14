using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymnastiksalsSystemet
{
    internal class Booking
    {
        DateTime Date { get; set; }
        DateTime Start {  get; set; }
        DateTime End { get; set; }
        private int HallId { get; set; }
        private int Id { get; set; }

        
        public Booking(int hallId, int id)
        {
            HallId = hallId;
            Id = id;
            Date = DateTime.Now;
            Start = DateTime.Now;
            End = DateTime.Now;
        }

        public override string ToString()
        {
            return "Dato for resevation" + Date.ToString("dd:MM:yy") + "Tidspunkt for booking" + Start("HH");
        }
    }
}
