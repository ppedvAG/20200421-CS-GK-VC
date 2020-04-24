using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M5Fuhrpark
{
    class FuhrparkApp
    {
        static void Main(string[] args)
        {
            double miles = Transport.KmZuMeilen(220);
            Console.WriteLine($"220 km zu Miles: {miles}");

            // Transport transport = new Transport(

            Flugzeug flugzeug = new Flugzeug("Boeing", 2000000, 500, 5);
            List<Passagier> pListe = new List<Passagier>();
            pListe.Add(new Passagier("Alter", 30));
            pListe.Add(new Passagier("Neuer", 20));
            pListe.Add(new Passagier("Jung", 15));
            flugzeug.Passagierliste = pListe;

            foreach (var item in flugzeug.Passagierliste)
            {
                Console.WriteLine(item.Nachname);
            }
            Console.ReadKey();
        }
    }
}
