using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

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

        public Masina(string text) : base(text)
        {
            string[] data = text.Split('/');

            _horsepower = Int32.Parse(data[6]);
            _transmission = data[7];
            _drivetrain = data[8];
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

        public override string ToString()
        {
            string desc = base.ToString();

            desc += "Horsepower : " + _horsepower + "\n";
            desc += "Transmission : " + _transmission + "\n";
            desc += "Drivetrain : " + _drivetrain + "\n";

            return desc;
        }

        public override string ToSave()
        {
            string save = $"{base.ToSave()}/{_horsepower}/{_transmission}/{_drivetrain}";

            return save;
        }
    }
}
