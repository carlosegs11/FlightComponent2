using ModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FlightComponent2.Utilities
{
    public abstract class FlightFun
    {
        public static List<SelectListItem> GetCitiesView (List<City> cityList)
        {
            List<SelectListItem> cityListView = new List<SelectListItem>();

            foreach (var item in cityList)
            {
                SelectListItem itemCity = new SelectListItem();
                itemCity.Text = item.Name;
                itemCity.Value = item.Code;
                cityListView.Add(itemCity);
            }

            return cityListView;
        }

        public static List<FlightReservation> GetResponseView (List<FlightReservation> flightReservationList, string originName, string destinationName)
        {
            List<FlightReservation> flightReservationListView = new List<FlightReservation>();
            foreach (var item in flightReservationList)
            {
                FlightReservation flightReservation = new FlightReservation();
                flightReservation.Id = item.Id;
                flightReservation.ArrivalStation = item.ArrivalStation;
                flightReservation.ArrivalStationName = originName;
                flightReservation.DepartureStation = item.DepartureStation;
                flightReservation.DepartureStationName = destinationName;
                flightReservation.FlightNumber = item.FlightNumber;
                flightReservation.DepartureDate = item.DepartureDate;
                flightReservation.Price = item.Price;


                flightReservationListView.Add(flightReservation);
            }

            return flightReservationListView;
        }
    }
}