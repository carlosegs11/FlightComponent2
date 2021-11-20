using DataLayer;
using ModelLayer;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class ManageReservation
    {
        public List<City> GetCitiesADO()
        {
            List<City> cityList = DL_City.Instance.GetCities();

            return (cityList);
        }


        public List<FlightReservation> getApiRequest(string codigoOrigen, string codigoDestino, DateTime arrivalDate)
        {
            try
            {
                const string urlService = "http://testapi.vivaair.com/otatest/api/values";
                string separator = "\"";
                string parameters = "{" + separator + "Origin" + separator + ":" + separator + codigoOrigen + separator + ",";
                parameters = parameters + separator + "Destination" + separator + ":" + separator + codigoDestino + separator + ",";
                parameters = parameters + separator + "From" + separator + ":" + separator + arrivalDate.ToString("yyyy-MM-dd") + separator + "}]";

                string responseValue = string.Empty;
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(urlService);
                request.Method = "POST";
                request.ContentType = "application/json";
                byte[] bytes = Encoding.UTF8.GetBytes(parameters);

                using (Stream requestStream = request.GetRequestStream())
                {
                    request.GetRequestStream().Write(bytes, 0, bytes.Length);

                    using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                    {
                        if (response.StatusCode != HttpStatusCode.OK)
                        {
                            throw new ApplicationException("Codigo Error : " + response.StatusCode);
                        }

                        using (Stream responseStream = response.GetResponseStream())
                        {
                            if (responseStream != null)
                            {
                                using (StreamReader reader = new StreamReader(responseStream))
                                {
                                    responseValue = reader.ReadToEnd();
                                }
                            }
                        }
                    }
                }

                responseValue = responseValue.Replace("\\", "");
                responseValue = responseValue.Replace("\"[", "[");
                responseValue = responseValue.Replace("]\"", "]");

                var formatoJson = responseValue;
                var requestView = JsonConvert.DeserializeObject<List<FlightReservation>>(formatoJson);
                return requestView;

            }
            catch (Exception ex)
            {
                if (ex.InnerException != null)
                {
                    string error = ex.Message + ex.InnerException.ToString();
                    return null;
                }
                else
                {
                    string error = ex.Message + ex.InnerException.ToString();
                    return null;
                }
            }
        }
    }
}


