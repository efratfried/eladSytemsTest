using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfratGrinbergTest.models
{
    public class city
    {
        public string Name { get; set; }

        public int Code { get; private set; }

        public int DisplayOrder { get; set; }
        private static int nextCode = 1;
        public city(string name, int displayOrder)
        {
            Name = name;
            DisplayOrder = displayOrder;
            Code = nextCode++;
        }

        public void PrintCityInfo()
        {
            Console.WriteLine($"City Name: {Name}, Code: {Code}, Display Order: {DisplayOrder}");
        }

    }
}
