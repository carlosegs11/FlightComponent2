namespace ModelLayer
{
    /// <summary>
    /// Contrato que deben respetar todas las clases de tipo reserva (Injección de dependencias)
    /// </summary>
    public interface ITransport
    {
        string IdTransport { get; set; }

        TransportType TransportType { get; set; }
    }
}
