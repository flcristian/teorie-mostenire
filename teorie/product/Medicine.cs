using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teorie.product
{
    public class Medicine : Product
    {
        private int _quantity;
        private int _dosage;
        private int _minimumAge;

        // Constructors

        public Medicine(int id, double price, string name, string category, string information, int quantity, int dosage, int minimumAge) : base(id, name, category, information, price, "FoodItem")
        {
            _quantity = quantity;
            _dosage = dosage;
            _minimumAge = minimumAge;
        }

        public Medicine(string text) : base(text)
        {
            string[] data = text.Split('/');

            _quantity = Int32.Parse(data[6]);
            _dosage = Int32.Parse(data[7]);
            _minimumAge = Int32.Parse(data[8]);
        }

        // Accessors

        public int Quantity
        {
            get { return _quantity; }
            set
            {
                _quantity = value;
            }
        }

        public int Dosage
        {
            get { return _dosage; }
            set
            {
                _dosage = value;
            }
        }

        public int MinimumAge
        {
            get { return _minimumAge; }
            set
            {
                _minimumAge = value;
            }
        }

        // Methods

        public string MedicineDescription()
        {
            string desc = base.Description();

            desc += $"Quantity : {_quantity}\n";
            desc += $"Dosage : {_dosage}\n";
            desc += $"Minimum Age : {_minimumAge}\n";

            return desc;
        }

        public string ToSaveMedicine()
        {
            string save = $"{base.Type}/{base.Id}/{base.Price}/{base.Name}/{base.Category}/{base.Information}/{_quantity}/{_dosage}/{_minimumAge}";

            return save;
        }
    }
}
