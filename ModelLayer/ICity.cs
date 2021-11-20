using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
    /// <summary>
    /// Contrato que deben respetar la clase de tipo ciudad (Injección de dependencias)
    /// </summary>
    public interface ICity
    {
        int Id { get; set; }
        string Code { get; set; }
        string Name { get; set; }
    }
}
