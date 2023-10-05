using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkiCenter
{
    public class Booking
    {
        private int bookingId;
        private BookingType bookingType;
        private DateTime date;
        private TimeSpan time;
        private int numberOfPeople;
        
        //TODO kontrollera värdena i set, returnera
        public int BookingId { get; set; }
        public BookingType BookingType { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public int NumberOfPeople { get; set; }
    }
}