using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
    public abstract class Reservation
    {
        public string Id { get; set; }
        public string ReservationNumber { get; set; }
        public string DepartureStation { get; set; }
        public string DepartureStationName { get; set; }
        public string ArrivalStation { get; set; }
        public string ArrivalStationName { get; set; }
        public DateTime DepartureDate { get; set; }
        public decimal Price { get; set; }
        public string Currency { get; set; }

        public Reservation()
        {
            Id = Guid.NewGuid().ToString();
        }

        public override string ToString()
        {
            return $"{Id},{ReservationNumber},{DepartureStation}, {DepartureStationName},{ArrivalStation}, {ArrivalStationName},{DepartureDate},{Price},{Currency}";
        }



    }
}
