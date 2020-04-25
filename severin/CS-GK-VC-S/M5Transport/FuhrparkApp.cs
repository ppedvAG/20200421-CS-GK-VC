using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M5Transport;

namespace M5Fuhrpark
{
	class FuhrparkApp
	{
		static void Main(string[] args)
		{			
			Transport transport = new Transport("Alfa Romeo", 200, 50000);
			Console.WriteLine($"Beschreibung: {transport.BeschreibeMich()}");

			// km/h in dMeilen umrechnen
			double miles = Transport.KmToMiles(220);
			Console.WriteLine($"220 km/h zu Miles: {miles}");

			// Beschreibung PKW
			PKW pkw = new PKW("Alfa Romeo", 200, 600000, 4);
			Console.WriteLine($"Beschreibung PKW: {pkw.BeschreibeMich()}");

			// Beschreibung Schiff
			Schiff schiff = new Schiff("Dampfer", 1000000, 86478229, 30500);
			Console.WriteLine($"Beschreibung Schiff: {schiff.BeschreibeMich()}");

			// Beschreibung Flugzeug
			Flugzeug flugzeug = new Flugzeug("Jet", 500, 645363, 30);
			Console.WriteLine($"Beschreibung Flugzeug: {flugzeug.BeschreibeMich()}");

			List<Passagier> pList = new List<Passagier>();
			pList.Add(new Passagier("Herr Alter", 30));
			pList.Add(new Passagier("Frau Neuer", 20));
			pList.Add(new Passagier("Fräulein Jung", 15));
			flugzeug.Passagierliste = pList;

			foreach (var item in flugzeug.Passagierliste)
			{
				Console.WriteLine(item.Nachname);
			}

			Console.ReadKey();
		}
	}
}
