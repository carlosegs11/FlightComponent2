using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
    /// <summary>
    /// Herencia múltiple que en c# solo se permite a través de las Interfaces
    /// </summary>
    class CarReservation : IReservation, IPlace
    {
        # region Propiedades de la interfaz IReservation
        public string CarBrand { get; set; }
        string IReservation.Id { get; set; }
        string IReservation.ReservationNumber { get; set; }
        string IReservation.DepartureStation { get; set; }
        string IReservation.DepartureStationName { get; set; }
        string IReservation.ArrivalStation { get; set; }
        string IReservation.ArrivalStationName { get; set; }
        DateTime IReservation.DepartureDate { get; set; }
        decimal IReservation.Price { get; set; }
        string IReservation.Currency { get; set; }
        #endregion

        # region Propiedades de la interfaz Iplace
        public string CityCode { get; set; }
        public string CityName { get; set; }
        #endregion

        # region Propiedades propias de la clase FlightReservation
        public string CarId { get; set; }
        #endregion

    }
}
