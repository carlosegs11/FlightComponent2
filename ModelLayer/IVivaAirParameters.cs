using System;

namespace ModelLayer
{
    /// <summary>
    /// Contrato que deben respetar todas las clases de tipo VivaAirParameters (Injección de dependencias)
    /// </summary>
    public interface IVivaAirParameters
    {
        string Origin { get; set; }
        string Destination { get; set; }
        DateTime From { get; set; }
    }
}
