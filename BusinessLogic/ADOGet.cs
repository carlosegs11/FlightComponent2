using DataLayer;
using ModelLayer;
using System.Collections.Generic;

namespace BusinessLogic
{
    public class ADOGet : IGet
    {
        public List<IIATA> GetIATA()
        {
            List<IIATA> iataList = DL_IATA.Instance.GetIATA();
            return iataList;
        }
    }
}
