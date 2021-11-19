using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
    class CarReservation : Reservation, IPlace
    {
        public string CityCode { get; set; }
        public string CityName { get; set; }
        public string CarId { get; set; }
        public string CarBrand { get; set; }

    }
}
