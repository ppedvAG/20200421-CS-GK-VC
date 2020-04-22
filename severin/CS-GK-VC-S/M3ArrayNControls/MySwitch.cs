using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3ArrayNControls
{
	class MySwitch
	{
		public static void ZeigeSwitch()
		{
			DateTime dateTime = new DateTime();
			// Mo - Salat
			// Di - Kartoffel
			// Mi - Pasta
			// Do - Kartoffel
			// Fr - Pilze
			// Sa, So - geschlossen

			dateTime = DateTime.Now; // Datum und Uhrzeit
			Console.WriteLine(dateTime);

			dateTime = DateTime.Today; // Nur Datum ohne Uhrzeit
			Console.WriteLine(dateTime);

			dateTime = dateTime.AddDays(1.2); // hier kann ein Tag und die Uhr Zeit addieren deshalb auch ein double
			Console.WriteLine(dateTime);
			
			switch (dateTime.DayOfWeek) // dateTime.DayOfWeek - der Tag wird ausgelesen
			{
				case DayOfWeek.Monday:
					Console.WriteLine("Heute: Salat");
					break;
				case DayOfWeek.Tuesday:
				case DayOfWeek.Thursday: // Case können auch zusammengefasst werden
					Console.WriteLine("Heute: Kartoffel");
					break;
				case DayOfWeek.Wednesday:
					Console.WriteLine("Heute: Pasta");
					break;
				case DayOfWeek.Friday:
					Console.WriteLine("Heute: Pilze");
					break;
				default:
					Console.WriteLine("Heute ist geschlossen");
					break;
			}
		}

	}
}
