using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teorie.vehicle
{
    public class Masina : Vehicle
    {
        private int _horsepower;
        private string _transmission;
        private string _drivetrain;

        // Constructori

        public Masina(int id, int year, string make, string model, string color, int horsepower, string transmission, string drivetrain) : base(id, year, make, model, color)
        {
            _horsepower = horsepower;
            _transmission = transmission;
            _drivetrain = drivetrain;
        }

        // Accesori

        public int Horsepower
        {
            get { return _horsepower; }
            set
            {
                _horsepower = value;
            }
        }

        public string Transmission
        {
            get { return _transmission; }
            set
            {
                _transmission = value;
            }
        }

        public string Drivetrain
        {
            get { return _drivetrain; }
            set
            {
                _drivetrain = value;
            }
        }

        // Metode

        public string Description()
        {
            string desc = base.Description();

            desc += "Horsepower : " + _horsepower + "\n";
            desc += "Transmission : " + _transmission + "\n";
            desc += "Drivetrain : " + _drivetrain + "\n";

            return desc;
        }
    }
}
