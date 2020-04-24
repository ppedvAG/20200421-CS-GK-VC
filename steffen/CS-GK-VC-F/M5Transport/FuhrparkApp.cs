using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M5Transport
{
    class FuhrparkApp
    {
        static void Main(string[] args)
        {
            Transportmittel transportmittel = new Transportmittel("BMW", 250, 45000, 0);
            string Info = transportmittel.BeschreibeMich();
            Console.WriteLine($"Beschreibung: {Info}");
            double Miles = Transportmittel.KmToMiles(45);
            Console.WriteLine($"45 Km/h sind {Miles} Miles.");
            PKW pkw = new PKW("Audi", 250, 45000, 0, PKW.MyAntrieb.Front);
            string Info1 = pkw.BeschreibeMich();
            Console.WriteLine($"Beschreibung PKW: {Info1}");
            Schiffe schiffe = new Schiffe("Schiff 1", 250, 45000, 0, 3);
            string Info2 = schiffe.BeschreibeMich();
            Console.WriteLine($"Beschreibung Schiffe: {Info2}");
            Flugzeuge flugzeuge = new Flugzeuge("Flugzeug 1", 250, 45000, 0, 25000);
            string Info3 = flugzeuge.BeschreibeMich();
            Console.WriteLine($"Beschreibung Flugzeuge: {Info3}");
            Console.ReadKey();
        }
    }
}
