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
            var cityList = _manageReservation.GetCitiesADO();
            ViewBag.cityList = FlightFun.GetCitiesView(cityList);
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
    }
}