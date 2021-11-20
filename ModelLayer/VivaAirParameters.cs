using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
    public class VivaAirParameters : IVivaAirParameters
    {
        public string Origin { get; set; }
        public string Destination { get; set; }
        public DateTime From { get; set; }
    }
}
