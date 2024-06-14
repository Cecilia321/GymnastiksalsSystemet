using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymnastiksalsSystemet
{
    internal class BookingManager
    {
        private List<Booking> bookings;
        Gruppe Gruppe { get; set; }


        public BookingManager() 
        { 
            bookings = new List<Booking>();
        }

       public void AddBooking(Booking booking)
        {
             bookings.Add(booking);
        }

        public List<Booking> collection(Gruppe gruppe) 
        {
            List<Booking> collection = new List<Booking>();
            foreach (Booking booking in collection)
            {
                if(booking.GruppeId == booking.GruppeId)
                collection.Add(booking);
            }
            return collection;
        }
    }
}
