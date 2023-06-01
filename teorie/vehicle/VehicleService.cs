using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using teorie.vehicle;

namespace teorie.vehicle
{
    public class VehicleService
    {
        List<Vehicle> _list;

        // Controllers

        public VehicleService()
        {
            this.ReadList();
        }

        public VehicleService(List<Vehicle> list)
        {
            _list = list;
        }

        // Accessors

        public List<Vehicle> List
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
            _list = new List<Vehicle>();
            StreamReader sr = new StreamReader("D:\\mycode\\csharp\\mostenirea\\teorie\\teorie\\vehicle\\dataVehicle.txt");

            while (!sr.EndOfStream)
            {
                string text = sr.ReadLine();
                string type = text.Split('|')[0];

                switch (type)
                {
                    case "Masina":
                        Masina masina = new Masina(text);
                        _list.Add(masina);
                        break;
                    case "Avion":
                        Avion avion = new Avion(text);
                        _list.Add(avion);
                        break;
                    case "Barca":
                        Barca barca = new Barca(text);
                        _list.Add(barca);
                        break;
                    default:
                        break;
                }
            }
            sr.Close();
        }

        public void Afisare()
        {
            foreach(Vehicle vehicle in _list)
            {
                string desc = "";

                switch (vehicle.Type)
                {
                    case "Masina":
                        Masina masina = vehicle as Masina;
                        desc = masina.MasinaDescription();
                        break;
                    case "Avion":
                        Avion avion = vehicle as Avion;
                        desc = avion.AvionDescription();
                        break;
                    case "Barca":
                        Barca barca = vehicle as Barca;
                        desc = barca.BarcaDescription();
                        break;
                    default:
                        break;
                }

                Console.WriteLine(desc);
            }
        }
    }
}
