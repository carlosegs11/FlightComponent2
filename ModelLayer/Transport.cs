using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
    public abstract class Transport
    {
        public string IdRegistration { get; set; }

        public TransportType TransportType { get; set; }
    }
}
