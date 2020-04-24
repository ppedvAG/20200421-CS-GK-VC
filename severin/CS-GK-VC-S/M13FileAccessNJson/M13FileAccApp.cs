using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M5Fuhrpark;
using M5Transport;
using Newtonsoft.Json;

namespace M13FileAccessNJson
{
	class M13FileAccApp
	{
		static void Main(string[] args)
		{
			// In eine Datei Schreiben
			// Beschreibung Schiff
			Schiff schiff = new Schiff("Dampfer", 1000000, 86478229, 30500);

			PKW pkw = new PKW("Alfa Romeo", 200, 600000, 4);
			schiff.Belade(pkw);

			// eine Json String erstellen
			string jsonString = JsonConvert.SerializeObject(schiff);

			// in Datei schreiben
			StreamWriter streamWriter = new StreamWriter("Transportmittel.json");

			// Datei wird in Json String gewandelt
			streamWriter.Write(jsonString);

			//schliessen
			streamWriter.Close();

			// In Datei lesen
			// Wird in Jason Datei gelesen
			StreamReader streamReader = new StreamReader("Transportmittel.json");

			// Lesen aus einer Datei
			var objekt = JsonConvert.DeserializeObject<Transport>(streamReader.ReadToEnd());

			// schliessen
			streamReader.Close();
			
			// 
			Console.WriteLine($"object is Transport: {objekt is Transport}");
			Console.WriteLine($"object: {objekt.BeschreibeMich()}");


			objekt.Beschleunige(5, Transport.GeschwEinheit.Kilometer);

			// Aufruf für static void Schreiben<T>(T o)
			Schreibe<Transport>(objekt);

			Console.ReadKey();
		}

		static void Schreibe<T>(T o)
		{
			StreamWriter streamWriter1 = new StreamWriter("Transportmittel.json");
			string jsonString = JsonConvert.SerializeObject(o);
			streamWriter1.Write(jsonString);
			streamWriter1.Close();
		}
	}
}
