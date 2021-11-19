using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
    public abstract class  Accommodation
    {
        public string IdRegistration { get; set; }
        public AccommodationType AccommodationType { get; set; }
    }
}
