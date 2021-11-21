using System;

namespace ModelLayer
{
    public class VivaAirParameters : IParameters
    {
        public string Origin { get; set; }
        public string Destination { get; set; }
        public DateTime From { get; set; }
    }
}
