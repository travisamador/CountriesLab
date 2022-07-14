using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountriesLab
{
    internal class CountryView
    {
        public Country DisplayCountry { get; set; }

        public CountryView(Country _displayCountry)
        {
            DisplayCountry = _displayCountry;
        }

        public void Display()
        {
            Console.WriteLine($"Name: {DisplayCountry.Name}\nContinent: {DisplayCountry.Continent}\nColors:");
            foreach(string c in DisplayCountry.Colors)
            {
                if (Enum.TryParse(c, out ConsoleColor color))
                {
                    Console.ForegroundColor = color;
                    if(color == ConsoleColor.Black)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                    }
                }
                Console.WriteLine(c);
                Console.ResetColor();
            }
        }
    }
}
