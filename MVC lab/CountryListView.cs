using System;
using System.Collections.Generic;
using System.Text;

namespace MVC_lab
{
    class CountryListView
    {
        
        public List<Country> Countries { get; set; }

        public CountryListView(List<Country> countries)
        {
            Countries = countries;
        }
        public void Display()
        {
            Console.WriteLine("Please pick a country from the list");
            try
            {
                for (int i = 0; i < Countries.Count; i++)
                {
                    Country c = Countries[i];
                    Console.WriteLine($"{i} : {c.Name}");
                }
            }
            catch
            {
                Console.WriteLine("Invalid input. Try again");
            }
          
        }
    }
}
