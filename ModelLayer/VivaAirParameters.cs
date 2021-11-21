using System;

namespace ModelLayer
{
    /// <summary>
    /// Herencia de la interfaz
    /// </summary>
    public class VivaAirParameters : IVivaAirParameters
    {
        public string Origin { get; set; }
        public string Destination { get; set; }
        public DateTime From { get; set; }
    }
}
