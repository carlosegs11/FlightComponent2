using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
    public interface IVivaAirParameters
    {
        string Origin { get; set; }
        string Destination { get; set; }
        DateTime From { get; set; }
    }
}
