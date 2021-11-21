using BusinessLogic;
using DataLayer;
using FlightComponent2.Utilities;
using ModelLayer;
using System;
using System.Collections.Generic;
using System.Web.Mvc;


namespace FlightComponent2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ManageReservation _manageReservation = new ManageReservation();
        public ActionResult Index()
        {
            // Manejo de Excepciones
            try
            {
                List<IIATA> iataList = _manageReservation.GetIataADO();
                ViewBag.iataList = FlightFun.GetIataView(iataList);
                return View();
            }
            catch (Exception ex) 
            { 
                ViewBag.MessageInfo = ex.ToString();
                // Logging personalizado
                CustomLog log = new CustomLog(@"C:\Applog\");
                log.Add(ex.ToString());
                return View("~/Views/Shared/Error.cshtml"); 
            }
        }

        [HttpPost]
        public ActionResult AvailableFlights(string originCode, string originName, string destinationCode, string destinationName, DateTime arrivaldate)
        {
            // Manejo de Excepciones
            try
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
            catch (Exception ex)
            {
                ViewBag.MessageInfo = ex.ToString();
                // Logging personalizado
                CustomLog log = new CustomLog(@"C:\Applog\");
                log.Add(ex.ToString());
                return View("~/Views/Shared/Error.cshtml");
            }
        }

        public ActionResult SaveReservation(string departureStation, string arrivalStation, DateTime departureDate, string flightNumber, decimal price, string currency)
        {
            // Manejo de Excepciones
            try
            {
                var request = _manageReservation.SaveReservation(departureStation, arrivalStation, departureDate, flightNumber, price, currency);
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
            catch (Exception ex)
            {
                ViewBag.MessageInfo = ex.ToString();
                // Logging personalizado
                CustomLog log = new CustomLog(@"C:\Applog\");
                log.Add(ex.ToString());
                return View("~/Views/Shared/Error.cshtml");
            }
        }
    }
}