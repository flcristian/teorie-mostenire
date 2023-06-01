using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teorie.vehicle
{
    public class Vehicle
    {
        private int _id;
        private int _year;
        private string _make;
        private string _model;
        private string _color;
        private string _type;

        // Constructori
        public Vehicle()
        { 
            Console.WriteLine("Eu sunt constructorul din baza fara parametrii");         
        }

        public Vehicle(int id, int year)
        {
            Console.WriteLine("Eu sunt constructorul din baza care are doi parametri.");
            _id = id;
            _year = year;
        }

        public Vehicle(string make, string model, string color)
        {
            Console.WriteLine("Eu sunt constructorul din baza care are trei parametri.");
            _make = make;
            _model = model;
            _color = color;
        }

        public Vehicle(int id, int year, string make, string model, string color)
        {
            _id = id;
            _year = year;
            _make = make;
            _model = model;
            _color = color;
        }

        public Vehicle(string text)
        {
            string[] data = text.Split('|');
            

            _type = data[0];
            _id = Int32.Parse(data[1]);
            _year = Int32.Parse(data[2]);
            _make = data[3];
            _model = data[4];
            _color = data[5];

            
        }

        // Accesori

        public int Id
        {
            get { return _id; }
            set
            {
                _id = value;
            }
        }

        public int Year
        {
            get { return _year; }
            set
            {
                _year = value;
            }
        }

        public string Make
        {
            get { return _make; }
            set
            {
                _make = value;
            }
        }

        public string Model
        {
            get { return _model; }
            set
            {
                _model = value;
            }
        }

        public string Color
        {
            get { return _color; }
            set
            {
                _color = value;
            }
        }

        public string Type
        {
            get { return _type; }
            set
            {
                _type = value;
            }
        }

        // Metode

        public string Description()
        {
            string desc = "";

            desc += "Id : " + _id + "\n";
            desc += "Year : " + _year + "\n";
            desc += "Make : " + _make + "\n";
            desc += "Model : " + _model + "\n";
            desc += "Color : " + _color + "\n";

            return desc;
        }
    }
}
