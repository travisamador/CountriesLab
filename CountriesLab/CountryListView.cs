using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountriesLab
{
    internal class CountryListView
    {
        public List<Country> Countries { get; set; } 

        public CountryListView(List<Country> _countries)
        {
            Countries = _countries;
        }

        public void Display()
        {
            Countries.ForEach(c => Console.WriteLine($"{Countries.IndexOf(c)}. {c.Name}"));
        }
    }
}
