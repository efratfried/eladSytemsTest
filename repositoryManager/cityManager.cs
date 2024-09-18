using EfratGrinbergTest.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfratGrinbergTest
{
    public static class cityManager
    {//מחלקה לניהול ערים (הוספה, החזרת רשימת ערים לפי פרמטר, קבלת קוד עיר ע"פ פרמטר)
        private static List<city> cityList = new List<city>();
        public static void addCity(string name,int displayOrder)
        {
            cityList.Add(new city(name, displayOrder));
        }

        public static void displayCityListByOrder()
        {
            var sortedCityList = cityList.OrderBy(city => city.DisplayOrder).ToList();
            foreach (var city in sortedCityList)
            {
                city.PrintCityInfo();           
            }           

        }

        public static city getCityCode(int code)
        {
            return cityList.FirstOrDefault(city => city.Code == code);
        }

    }
}
