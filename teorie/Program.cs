using teorie.vehicle;

internal class Program
{
    private static void Main(string[] args)
    {
        Avion avion = new Avion(1, 2000, "Ikarus", "C42", "White", 265, 450, "ULM");
        Masina masina = new Masina(2, 2015, "Subaru", "WRX STI", "Blue", 234, "Manual", "AWD");
        Barca barca = new Barca(3, 2008, "Source", "22", "Grey", 1400, "Speed Boat", "Albania");
        //Console.WriteLine(avion.Description());
        //Console.WriteLine("\n" + masina.Description());
        //Console.WriteLine("\n" + barca.Description());

        //orice baza poate retine referinta unei derivate!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        //baza nu are acces la fieldurile derivatei


        Vehicle vehicle = avion;//upcasting -->facem un cast de la derivata

        vehicle = masina;
        /* Avion av = (Avion)vehicle*/
        //downcasting 


        Avion av = vehicle as Avion;

        vehicle = masina;


        vehicle.Year = 1993;

        Console.WriteLine(av.Description());

        if(vehicle is Avion)
        {
            Avion at = (Avion)vehicle;
        }




    }
}