using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
    public class FlightReservation : IReservation, IPlace
    {
        # region Propiedades de la interfaz IReservation
        public string Id { get; set; }
        public string ReservationNumber { get; set; }
        public string DepartureStation { get; set; }
        public string DepartureStationName { get; set; }
        public string ArrivalStation { get; set; }
        public string ArrivalStationName { get; set; }
        public DateTime DepartureDate { get; set; }
        public decimal Price { get; set; }
        public string Currency { get; set; }
        #endregion

        # region Propiedades de la interfaz Iplace
        public string CityCode { get; set; }
        public string CityName { get; set; }
        #endregion
        
        # region Propiedades propias de la clase FlightReservation
        public string FlightNumber { get; set; }
        #endregion
    }
}
