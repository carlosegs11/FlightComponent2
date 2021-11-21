using DataLayerEF2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class ADOSave : ISave
    {
        public void SaveReservation(string departureStation, string arrivalStation, DateTime departureDate, string flightNumber, decimal price, string currency)
        {
            // Se debería implementar el método guardar utilizando la librería de clases de ADO .Net
        }
    }
}
