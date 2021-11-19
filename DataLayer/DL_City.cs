using ModelLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class DL_City
    {
        public static DL_City _instance = null;

        private DL_City()
        {

        }

        public static DL_City Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DL_City();
                }
                return _instance;
            }
        }

        public List<City> GetCities()
        {
            List<City> cityList = new List<City>();
            using (SqlConnection oConnection = new SqlConnection(DL_Connection.CN))
            {
                SqlCommand cmd = new SqlCommand("sp_GetCities", oConnection);
                cmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    oConnection.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        cityList.Add(new City()
                        {
                            Id = Convert.ToInt32(dr["Id"]),
                            Code = dr["Code"].ToString(),
                            Name = dr["Name"].ToString()
                        });
                    }
                    dr.Close();

                    return cityList;

                }
                catch (Exception ex)
                {
                    cityList = null;
                    return cityList;
                }
            }

        }
    }
}
