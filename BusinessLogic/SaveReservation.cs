using DataLayerEF2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class SaveReservation 
    {
        private ISave _save;
        public SaveReservation (ISave save)
        {
            _save = save;
        }

        public void Save(string departureStation, string arrivalStation, DateTime departureDate, string flightNumber, decimal price, string currency)
        {
            _save.SaveReservation(departureStation, arrivalStation, departureDate, flightNumber, price, currency);
        }
    }
}
