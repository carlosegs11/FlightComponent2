using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
    public class HotelReservation : Reservation, IPlace
    {
        public string CityCode { get; set; }
        public string CityName { get; set; }
        public string HotelId { get; set; }
        public string HotelName { get; set; }
    }
}
