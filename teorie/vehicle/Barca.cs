using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teorie.vehicle
{
    public class Barca : Vehicle
    {
        private int _weight;
        private string _category;
        private string _registrationCountry;

        // Constructori

        public Barca(int id, int year, string make, string model, string color, int weight, string category, string registrationCountry) : base(id, year, make, model, color)
        {
            _weight = weight;
            _category = category;
            _registrationCountry = registrationCountry;
        }

        // Accesori

        public int Weight
        {
            get { return _weight; }
            set
            {
                _weight = value;
            }
        }

        public string Category
        {
            get { return _category; }
            set
            {
                _category = value;
            }
        }

        public string RegistrationCountry
        {
            get { return _registrationCountry; }
            set
            {
                _registrationCountry = value;
            }
        }

        // Metode

        public string Description()
        {
            string desc = base.Description();

            desc += "Weight : " + _weight + "\n";
            desc += "Category : " + _category + "\n";
            desc += "Registration Country : " + _registrationCountry + "\n";

            return desc;
        }
    }
}
