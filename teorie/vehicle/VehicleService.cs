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
                string type = text.Split('/')[0];

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

        public void SaveList()
        {
            StreamWriter sw = new StreamWriter("D:\\mycode\\csharp\\mostenirea\\teorie\\teorie\\vehicle\\dataVehicle.txt");

            string toSave = "";
            foreach(Vehicle vehicle in _list)
            {
                toSave += vehicle.ToSave() + "\n";
            }
            sw.Write(toSave);

            sw.Close();
        }

        public void Afisare()
        {
            foreach(Vehicle vehicle in _list)
            {
                Console.WriteLine(vehicle);
            }
        }
    }
}
