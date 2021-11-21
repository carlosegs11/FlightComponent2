﻿namespace ModelLayer
{
    /// <summary>
    /// Contrato que deben respetar todas las clases de tipo reserva (Injección de dependencias)
    /// </summary>
    public interface IPlace
    {
        string CityCode { get; set; }
        string CityName { get; set; }
    }
}
