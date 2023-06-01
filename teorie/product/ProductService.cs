using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teorie.product
{
    public class ProductService
    {
        List<Product> _list;

        // Constructors

        public ProductService()
        {
            this.ReadList();
        }

        public ProductService(List<Product> list)
        {
            _list = list;
        }

        // Accessors

        public List<Product> List
        {
            get { return _list; }
            set
            {
                _list = value;
            }
        }

        // Methods

        public void ReadList()
        {
            _list = new List<Product>();
            StreamReader sr = new StreamReader("D:\\mycode\\csharp\\mostenirea\\teorie\\teorie\\product\\dataProduct.txt");

            while (!sr.EndOfStream)
            {
                string text = sr.ReadLine();
                string type = text.Split('|')[0];

                switch (type)
                {
                    case "Medicine":
                        Medicine medicine = new Medicine(text);
                        _list.Add(medicine);
                        break;
                    case "FoodItem":
                        FoodItem foodItem = new FoodItem(text);
                        _list.Add(foodItem);
                        break;
                    default:
                        break;
                }
            }
            sr.Close();
        }

        public void Afisare()
        {
            foreach(Product product in _list)
            {
                string desc = "";

                switch (product.Type)
                {
                    case "Medicine":
                        Medicine medicine = product as Medicine;
                        desc = medicine.MedicineDescription();
                        break;
                    case "FoodItem":
                        FoodItem foodItem = product as FoodItem;
                        desc = foodItem.FoodItemDescription();
                        break;
                    default:
                        break;
                }

                Console.WriteLine(desc);
            }
        }
    }
}
