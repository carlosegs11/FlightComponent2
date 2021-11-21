using DataLayer;
using DataLayerEF2;
using ModelLayer;
using ServicesLayer;
using System;
using System.Collections.Generic;

namespace BusinessLogic
{

    public class ManageReservation
    {
        

        public List<IIATA> GetIataADO()
        {
            List<IIATA> iataList = DL_IATA.Instance.GetIata();
            return (iataList);
        }

        public List<FlightReservation> getApiRequest(IVivaAirParameters parameters, string urlService)
        {
            List<FlightReservation> flightReservation = Service.GetApiRequest(parameters, urlService);
            return flightReservation;
        }

        public bool SaveReservation(string departureStation, string arrivalStation, DateTime departureDate, string flightNumber, decimal price, string currency)
        {
            try
            {
                using (ReservationEntities db = new ReservationEntities())
                {
                    Reservation flightReservation = new Reservation
                    {
                        DepartureStation = departureStation,
                        ArrivalStation = arrivalStation,
                        DepartureDate = departureDate,
                        Number = flightNumber,
                        Price = price,
                        Currency = currency
                    };
                    db.Reservation.Add(flightReservation);
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                if (ex.InnerException != null)
                {
                    string error = ex.Message + ex.InnerException.ToString();
                    return false;
                }
                else
                {
                    string error = ex.Message + ex.InnerException.ToString();
                    return false;
                }
            }
        }
    }
}


