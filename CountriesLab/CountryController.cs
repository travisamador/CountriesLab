using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountriesLab
{
    internal class CountryController
    {
        List<Country> CountryDb { get; set; } 
        public CountryController()
        {
            CountryDb = new List<Country>() 
            {
                new Country("USA", "North America", new List<string> {"Red", "White", "Blue"}),
                new Country("Japan", "Asia", new List<string> {"Red", "White"}),
                new Country("Brazil", "South America", new List<string> {"Green", "Yellow", "Blue"}),
                new Country("Russia", "Europe & Asia", new List<string> {"White", "Blue", "Red"}),
                new Country("China", "Asia", new List<string> {"Red", "Yellow"}),
                new Country("England", "Europe", new List<string> {"Red", "White", "Blue"}),
                new Country("Spain", "Europe", new List<string> {"Red", "Yellow"}),
                new Country("Italy", "Europe", new List<string> {"Green", "White", "Red"}),
                new Country("Australia", "Australia", new List<string> {"Red", "White", "Blue"}),
                new Country("Zimbabwe", "Africa", new List<string> {"Green", "Yellow", "Red", "White", "Black"}),

            };
            
        }

        public void CountryAction(Country c)
        {
            CountryView view = new CountryView(c);
            view.Display();
        }
        public void welcomeAction()
        {
            while (true)
            {
                CountryListView listView = new CountryListView(CountryDb);
                Console.WriteLine("Hello, welcome to the country app. Please select a country from the following list");
                listView.Display();
                Console.Write("Select a country. ");
                Country country = CountryDb[Validator.Validator.GetUserNumberInt()];
                CountryAction(country);
                if(!Validator.Validator.GetContinue("Would you like to learn about another country?"))
                {
                    break;
                }
            }
        }
    }
}
