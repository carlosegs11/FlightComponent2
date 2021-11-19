using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
    public class FlightReservation : Reservation, IPlace
    {
        public string CityCode { get; set; }
        public string CityName { get; set; }
        public string FlightNumber { get; set; }
    }
}
