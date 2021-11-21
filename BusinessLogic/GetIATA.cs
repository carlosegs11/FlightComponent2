using ModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class GetIATA
    {
        private IGet _get;
        public GetIATA(IGet get)
        {
            _get = get;
        }

        public List<IIATA> Get()
        {
            return _get.GetIATA();
        }
    }
}
