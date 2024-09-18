using EfratGrinbergTest.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfratGrinbergTest
{
    public static class streetManager
    {//מחלקה לניהול רחובות (הוספה, החזרת רשימת ררחובות לפי קוד עיר)
        private static List<street> streetList = new List<street>();
        public static void addStreet(string name,int displayOrder,int cityCode)
        {
            var city = cityManager.getCityCode(cityCode);
            if(city!=null)
            {
                streetList.Add(new street(name, displayOrder, cityCode));
            }
            else
            {
                Console.WriteLine("city code isnt exist");
            }
        }

        public static void displayStreetListByCity(int cityCode)
        {
            var cityStreetList = streetList.Where(street => street.CityCode == cityCode);
            foreach (var street in cityStreetList)
            {
                street.PrintStreetInfo();
            }
        }
    }
}
