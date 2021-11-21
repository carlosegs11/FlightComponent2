using System.Configuration;

namespace DataLayer
{
    public class DL_Connection
    {
        public static string CN = ConfigurationManager.ConnectionStrings["myConnection"].ConnectionString;
        public static string Service = ConfigurationManager.AppSettings["URLVivaAir"];
    }
}
