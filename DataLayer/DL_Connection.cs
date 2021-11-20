using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class DL_Connection
    {
        public static string CN = ConfigurationManager.ConnectionStrings["myConnection"].ConnectionString;
        public static string Service = ConfigurationManager.AppSettings["URLVivaAir"];
    }
}
