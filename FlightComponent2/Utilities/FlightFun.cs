using ModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FlightComponent2.Utilities
{
    public abstract class FlightFun
    {
        public static List<SelectListItem> GetCitiesView (List<City> cityList)
        {
            List<SelectListItem> cityListView = new List<SelectListItem>();

            foreach (var item in cityList)
            {
                SelectListItem itemCity = new SelectListItem();
                itemCity.Text = item.Name;
                itemCity.Value = item.Code;
                cityListView.Add(itemCity);
            }

            return cityListView;
        }
    }
}