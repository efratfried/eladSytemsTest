using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfratGrinbergTest
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Create a city");
                Console.WriteLine("2. Create a street");
                Console.WriteLine("3. Display cities");
                Console.WriteLine("4. Display streets by city code");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");

                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        CreateCity();
                        break;
                    case "2":
                        CreateStreet();
                        break;
                    case "3":
                        cityManager.displayCityListByOrder();
                        break;
                    case "4":
                        DisplayStreetsByCity();
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }

        static void CreateCity()
        {
            string name = "";
            
            while (true)
            {
                Console.Write("Enter city name: ");
                name = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(name))
                {
                    break;
                }
            }
            while (true)
            {
                Console.Write("Enter display order: ");
                if (int.TryParse(Console.ReadLine(), out int displayOrder))
                {
                    cityManager.addCity(name, displayOrder);
                    Console.WriteLine("City created successfully.");
                    break;

                }
                else
                {
                    Console.WriteLine("Invalid display order.");
                    break;
                }
            }
        }

        static void CreateStreet()
        {
            string name = "";
            while (true)
            {
                Console.Write("Enter street name: ");
                name = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(name))
                {
                    break;
                }
            }
            while (true)
            {
                Console.Write("Enter display order: ");
                if (int.TryParse(Console.ReadLine(), out int displayOrder))
                {
                    while(true)
                    {
                        Console.Write("Enter city code: ");
                        if (int.TryParse(Console.ReadLine(), out int cityCode))
                        {
                            streetManager.addStreet(name, displayOrder, cityCode);
                            Console.WriteLine("Street created successfully.");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid city code.");
                            break;
                        }
                    }
                    break;
                    
                }
                else
                {
                    Console.WriteLine("Invalid display order.");
                    break;
                }
            }
            
        }

        static void DisplayStreetsByCity()
        {
            Console.Write("Enter city code: ");
            if (int.TryParse(Console.ReadLine(), out int cityCode))
            {
                streetManager.displayStreetListByCity(cityCode);
            }
            else
            {
                Console.WriteLine("Invalid city code.");
            }
        }
    }
}
