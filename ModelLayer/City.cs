using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
    public class City : ICity
    {
        # region Propiedades de la interfaz IReservation
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        #endregion
    }
}
