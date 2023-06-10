using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teorie.vehicle
{
    public class Avion : Vehicle
    {
        private int _weight;
        private int _maxWeight;
        private string _category;

        public Avion() : base("test")
        {

            Console.WriteLine("Eu sunt constructorul fara parametrii din derivata");
        }

        public Avion(int id, int year, string make, string model, string color, int weight, int maxWeight, string category) : base(id, year, make, model, color)
        {
            Weight = weight;
            MaxWeight = maxWeight;
            Category = category;
        }

        public Avion(string text) : base(text)
        {
            string[] data = text.Split('/');

            _weight = Int32.Parse(data[6]);
            _maxWeight = Int32.Parse(data[7]);
            _category = data[8];
        }

        // Cuvantul cheie base 
        // ->accesam fieldurile din baza
        // ->accesam constrcutorul bazei

        // Accesorii

        public int Weight
        {
            get { return _weight; }
            set
            {
                _weight = value;
            }
        }

        public int MaxWeight
        {
            get { return _maxWeight; }
            set
            {
                _maxWeight = value;
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

        // Metode

        public override string ToString()
        {
            string desc = base.ToString();

            desc += "Weight : " + _weight + "\n";
            desc += "MaxWeight : " + _maxWeight + "\n";
            desc += "Category : " + _category + "\n";

            return desc;
        }

        public override string ToSave()
        {
            string save = $"{base.ToSave()}/{_weight}/{_maxWeight}/{_category}";

            return save;
        }
    }
}
