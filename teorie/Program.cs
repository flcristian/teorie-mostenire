using System.Collections.Specialized;
using System.Runtime.CompilerServices;
using teorie.product;
using teorie.vehicle;

internal class Program
{
    private static void Main(string[] args)
    {
        /*Avion avion = new Avion(1, 2000, "Ikarus", "C42", "White", 265, 450, "ULM");
        Masina masina = new Masina(2, 2015, "Subaru", "WRX STI", "Blue", 234, "Manual", "AWD");
        Barca barca = new Barca(3, 2008, "Source", "22", "Grey", 1400, "Speed Boat", "Albania");
        //Console.WriteLine(avion.Description());
        //Console.WriteLine("\n" + masina.Description());
        //Console.WriteLine("\n" + barca.Description());

        //orice baza poate retine referinta unei derivate!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        //baza nu are acces la fieldurile derivatei


        Vehicle vehicle = avion;//upcasting -->facem un cast de la derivata

        vehicle = masina;
        *//* Avion av = (Avion)vehicle*//*
        //downcasting 


        Avion av = vehicle as Avion;

        vehicle = masina;

        vehicle.Year = 1993;

        Console.WriteLine(av.Description());

        if(vehicle is Avion)
        {
            Avion at = (Avion)vehicle;
        }*/

        //List<CustomObject> customObjectList = new List<CustomObject>
        //{
        //    new CustomObject { Id = 1, Name = "Object 1" },
        //    new CustomObject { Id = 2, Name = "Object 2" },
        //    new CustomObject { Id = 3, Name = "Object 3" }
        //};

        /*List<Vehicle> vehicles = new List<Vehicle>
        {
            new Masina(1,2008,"Nissan","Silvia S14","Black",214,"Manual","RWD"),
            new Masina(2,2014, "Subaru", "WRX STI", "White", 168, "Manual","AWD"),
            new Avion(3,2000,"Ikarus","C42","White",265,450,"Ultra Light"),
            new Barca(4, 2008, "Source", "22", "Grey", 1400, "Speed Boat", "Albania"),
            new Masina(2, 2015, "Subaru", "WRX STI", "Blue", 234, "Manual", "AWD")
        };

        Console.WriteLine($"Numar masini : {CountMasini(vehicles)}");
        Console.WriteLine($"Numar avioane : {CountAvioane(vehicles)}");
        Console.WriteLine($"Numar barci : {CountBarci(vehicles)}");*/

        /*VehicleService service = new VehicleService();

        service.Afisare();*/

        ProductService service = new ProductService();

        service.Afisare();
    }
}