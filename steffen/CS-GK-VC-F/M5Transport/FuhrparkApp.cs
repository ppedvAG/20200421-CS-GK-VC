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
            Flugzeuge flugzeuge1 = new Flugzeuge("Boing", 800, 1780000, 0, 0);
            List<Passagier> pListe = new List<Passagier>();
            pListe.Add(new Passagier("Alter", 30));
            pListe.Add(new Passagier("Neuer", 20));
            pListe.Add(new Passagier("Jung", 15));
            flugzeuge1.Passagierliste = pListe;

            foreach (var item in flugzeuge1.Passagierliste)
            {
                Console.WriteLine("Nachnahme:" + item.Nachname);
                Console.WriteLine("Alter:" + item.Alter);
            }

            //flugzeuge1.Passagierliste = List<Passagier>
            Console.ReadKey();
        }
    }
}
