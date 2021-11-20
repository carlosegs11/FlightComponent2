using BusinessLogic;
using FlightComponent2.Utilities;
using ModelLayer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace FlightComponent2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ManageReservation _manageReservation = new ManageReservation();
        public ActionResult Index()
        {
            var cityList = _manageReservation.GetCitiesADO();
            ViewBag.cityList = FlightFun.GetCitiesView(cityList);
            return View();
        }

        [HttpPost]
        public ActionResult AvailableFlights(string originCode, string originName, string destinationCode, string destinationName, DateTime arrivaldate)
        {
            List<FlightReservation> flightReservationListView = new List<FlightReservation>();


            List<FlightReservation> flightReservationList = _manageReservation.getApiRequest(originCode, destinationCode, arrivaldate);

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

            return PartialView(flightReservationListView);
        }

        public ActionResult OtroMetodo(string cadena)
        {
            return View();
        }

        public ActionResult Flights(string originCode, string originName, string destinationCode, string destinationName, DateTime arrivaldate)
        {
            List<FlightReservation> flightReservationListView = new List<FlightReservation>();


            List<FlightReservation> flightReservationList = _manageReservation.getApiRequest(originCode, destinationCode, arrivaldate);

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

            return PartialView(flightReservationListView);
        }

    }
}