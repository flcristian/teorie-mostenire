using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teorie.product
{
    public class FoodItem : Product
    {
        private int _weight;
        private string _expiryDate;
        private string _manufacturer;

        // Constructors

        public FoodItem(int id, double price, string name, string category, string information, int weight, string expiryDate, string manufacturer) : base(id, name, category, information, price, "FoodItem")
        {
            _weight = weight;
            _expiryDate = expiryDate;
            _manufacturer = manufacturer;
        }

        public FoodItem(string text) : base(text)
        {
            string[] data = text.Split('/');

            _weight = Int32.Parse(data[6]);
            _expiryDate = data[7];
            _manufacturer = data[8];
        }

        // Accessors

        public int Weight
        {
            get { return _weight; }
            set
            {
                _weight = value;
            }
        }

        public string ExpiryDate
        {
            get { return _expiryDate; }
            set
            {
                _expiryDate = value;
            }
        }

        public string Manufacturer
        {
            get { return _manufacturer; }
            set
            {
                _manufacturer = value;
            }
        }

        // Methods

        public string FoodItemDescription()
        {
            string desc = base.Description();

            desc += $"Weight : {_weight}\n";
            desc += $"Expiry Date : {_expiryDate}\n";
            desc += $"Manufacturer : {_manufacturer}\n";

            return desc;
        }

        public string ToSaveFoodItem()
        {
            string save = $"{base.Type}/{base.Id}/{base.Price}/{base.Name}/{base.Category}/{base.Information}/{_weight}/{_expiryDate}/{_manufacturer}";

            return save;
        }
    }
}
