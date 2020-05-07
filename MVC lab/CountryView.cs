using System;
using System.Collections.Generic;
using System.Text;

namespace MVC_lab
{
    class CountryView
    {
       public Country DisplayCountry { get; set; }

        //Country c;

        public CountryView(Country c)
        {
            DisplayCountry = c;
        }

        public void Display()
        {
            string colors = string.Join(", ", DisplayCountry.Colors);
            Console.Write($"The country {DisplayCountry.Name} is located on {DisplayCountry.Continent} and its colors are ");

            foreach (string color in DisplayCountry.Colors)
            {
                Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), color);
                Console.Write(color + " ");
            }
            Console.ResetColor();
            Console.WriteLine();
        }
    }
}
