using DataLayer;
using ModelLayer;
using ServicesLayer;
using System.Collections.Generic;

namespace BusinessLogic
{
    public class ManageReservation
    {
        public List<City> GetCitiesADO()
        {
            List<City> cityList = DL_City.Instance.GetCities();

            return (cityList);
        }

        public List<FlightReservation> getApiRequest(IVivaAirParameters parameters, string urlService)
        {
            List<FlightReservation> flightReservation = Service.GetApiRequest(parameters, urlService);
            return flightReservation;
        }
    }
}


