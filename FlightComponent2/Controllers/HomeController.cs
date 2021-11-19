using BusinessLogic;
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
            ViewBag.cityList = _manageReservation.GetCitiesADO();
            return View();
        }

        [HttpPost]
        public ActionResult _AvailableFlights(string originCode, string originName, string destinationCode, string destinationName, DateTime date)
        {
            List<FlightReservation> flightReservationListView = new List<FlightReservation>();


            List<FlightReservation> flightReservationList = _manageReservation.getApiRequest(originCode, destinationCode, date, "si");

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

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}