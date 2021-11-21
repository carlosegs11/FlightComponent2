using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Flight : ITransport
    {
        public string FlightNumber { get; set ; }

        public string Save()
        {
            throw new NotImplementedException();
        }
    }
}
