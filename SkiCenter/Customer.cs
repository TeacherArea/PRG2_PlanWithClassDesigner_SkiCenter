using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkiCenter
{
    public class Customer : Person
    {
        private int customerId;

        public int CustomerId
        {
            get { return customerId; }
            set
            {
                if (value <= 0) throw new ArgumentException("Kundnummer måste vara större än 0.");
                customerId = value;
            }
        }

        private List<Booking> bookings;

        //TODO kontrollera värdena i set, returnera
        public List<Booking> Bookings { get; set; }
        
        //TODO implementera metod
        // public Booking MakeBooking() { /* ... */ }
        public void CancelBooking() { /* ... */ }

    }
}