using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace MVC_lab
{
    class CountryController
    {

        public List<Country> CountryDb { get; set; }

        public CountryController()
        {
            CountryDb = new List<Country>();
            Country country1 = new Country
            {
                Name = "United States",
                Continent = "North America",
                Colors = new List<string> { "Red", "White", "Blue" }
            };
            CountryDb.Add(country1);

            Country country2 = new Country
            {
                Name = "France",
                Continent = "Europe",
                Colors = new List<string> { "Red", "White", "Blue" }
            };
            CountryDb.Add(country2);

            Country country3 = new Country
            {
                Name = "Peru",
                Continent = "South America",
                Colors = new List<string> { "Red", "White" }
            };
            CountryDb.Add(country3);

            Country country4 = new Country
            {
                Name = "Italy",
                Continent = "Europe",
                Colors = new List<string> { "Green", "Red", "White" }
            };
            CountryDb.Add(country4);

        }

        public void CountryAction(Country c)
        {
            CountryView cv = new CountryView(c);
            cv.Display();
        }

        
        public void WelcomeAction()
        {
            bool goOn = true;
            while (goOn)
            {
                CountryListView clv = new CountryListView(CountryDb);
                Console.WriteLine("Hello, welcome to the country app. Please select a country from the following list:");
                clv.Display();
                int number = int.Parse(Console.ReadLine());
                if (number < CountryDb.Count)
                {
                    Country output = CountryDb[number];
                    CountryAction(output);
                }
                else
                {
                    Console.WriteLine("Invalid input. Try again.");
                    continue;
                }
                goOn = KeepAsking();
            }
        }

        public static bool KeepAsking()
        {

            while (true)
            {
                Console.WriteLine("Would you like to learn about another country? y or n");
                string choice = Console.ReadLine().ToLower().Trim();
                if (choice == "y")
                {
                    return true;

                }
                else if (choice == "n")
                {
                    Console.WriteLine("Goodbye");
                    return false;
                }
                else
                {
                    Console.WriteLine("I'm sorry that was not valid input. Try again.");
                    continue;
                }
             }
        }
    }
}
