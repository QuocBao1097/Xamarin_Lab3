using System;
using System.Collections.Generic;
using System.Text;

namespace lab3
{
    public class Country: List<City> // Đất nươc là 1 danh sách các thành phố
    {
        public string CountryName { get; set; }

        public Country(string CountryName)
        {
            this.CountryName = CountryName;
        }
       
    }
}
