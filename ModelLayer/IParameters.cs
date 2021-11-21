using System;

namespace ModelLayer
{
    public interface IParameters
    {
        string Origin { get; set; }
        string Destination { get; set; }
        DateTime From { get; set; }
    }
}
