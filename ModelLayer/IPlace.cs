using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
    public interface IPlace
    {
        string CityCode { get; set; }
        string CityName { get; set; }
    }
}
