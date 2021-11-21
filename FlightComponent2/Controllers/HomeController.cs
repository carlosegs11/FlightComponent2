using BusinessLogic;
using DataLayer;
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
            List<IIATA> iataList = _manageReservation.GetIataADO();
            ViewBag.iataList = FlightFun.GetIataView(iataList);
            return View();
        }

        [HttpPost]
        public ActionResult AvailableFlights(string originCode, string originName, string destinationCode, string destinationName, DateTime arrivaldate)
        {
            
            IVivaAirParameters vivaAirParameters = new VivaAirParameters { Origin = originCode, Destination = destinationCode, From = arrivaldate };
            List<FlightReservation> flightReservationList = _manageReservation.getApiRequest(vivaAirParameters, DL_Connection.Service);

            if (flightReservationList.Count.Equals(0))
            {
                ViewBag.MessageInfo = "There aren't flights for the chosen options... try again please";
                return View("~/Views/Shared/Error.cshtml");
            }

            return PartialView(FlightFun.GetResponseView(flightReservationList, originName, destinationName));
        }

        public ActionResult SaveReservation(string departureStation, string arrivalStation, DateTime departureDate, string flightNumber, decimal price, string currency)
        {
            
            var request =_manageReservation.SaveReservation(departureStation, arrivalStation, departureDate, flightNumber, price, currency);
            if (request)
            {
                ViewBag.MessageInfo = "Successfully booked flight";
            }
            else 
            {
                ViewBag.MessageInfo = "We had trouble booking the flight. Try again...";
            }
            return View();
        }
    }
}