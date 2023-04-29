using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Завдання
{

    class CountryMedals
    {
        string Country;
        int Medals;
        int people;

        public CountryMedals(string Country, int medals, int people)
        {
           
            this.Country = Country;
            this.Medals = medals;
            this.people = people;
        }
        public string GetInformation()
        {
            string information;
            information = " Країна:  " +  this.Country + " Медалі:  " + this.Medals.ToString() + 
            " Учасники: " +this.people;
            return information;
        }
    }
}

