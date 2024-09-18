using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfratGrinbergTest.models
{
    class street
    {
        public string Name { get; set; }

        public int Code { get; private set; }

        public int DisplayOrder { get; set; }

        public int CityCode { get; set; }
        private static int nextCode = 1;
        public street(string name, int displayOrder, int cityCode)
        {
            Name = name;
            DisplayOrder = displayOrder;
            CityCode = cityCode;
            Code = nextCode++;
        }
        public void PrintStreetInfo()
        {
            Console.WriteLine($"Street Name: {Name}, Code: {Code}, Display Order: {DisplayOrder}, City Code: {CityCode}");
        }
    }
}
