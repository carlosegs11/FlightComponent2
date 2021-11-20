using ModelLayer;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace ServicesLayer
{
    public class Service
    {
        public static List<FlightReservation> GetApiRequest(IVivaAirParameters parameters, string urlService)
        {
            try
            {
                var jsonLineas = JsonConvert.SerializeObject(parameters);
                string responseValue = string.Empty;
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(urlService);
                request.Method = "POST";
                request.ContentType = "application/json";
                byte[] bytes = Encoding.UTF8.GetBytes(jsonLineas);


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

                var requestView = JsonConvert.DeserializeObject<List<FlightReservation>>(responseValue);
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
