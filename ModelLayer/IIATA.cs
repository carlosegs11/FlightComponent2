namespace ModelLayer
{
    /// <summary>
    /// Contrato que deben respetar la clase de tipo ciudad (Injección de dependencias)
    /// </summary>
    public interface IIATA
    {
        string Code { get; set; }
        string Name { get; set; }
    }
}
