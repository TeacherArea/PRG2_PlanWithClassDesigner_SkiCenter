using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkiCenter
{
    internal class Cabin
    {
        private int cabinId;
        private string type;
        private double pricePerNight;

        //TODO kontrollera värdena i set, returnera
        public int CabinId { get; set; }
        public string Type { get; set; }
        public double PricePerNight { get; set; }
    }
}
