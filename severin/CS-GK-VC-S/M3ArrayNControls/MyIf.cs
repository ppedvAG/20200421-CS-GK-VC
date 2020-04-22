using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3ArrayNControls
{
	class MyIf
	{
		public static void ZeigeTrueBlock()
		{
			int myInt1 = 2;
			int myInt2 = 5;

			// Vergleich 1

			Console.WriteLine("\nVergleich zweier Int Variablen:");
			if (myInt1 < myInt2)
			{
				Console.WriteLine("myInt1 ist größer");
			}
			else
			{
				Console.WriteLine("myInt2 ist größer");
			}

			// geht alles nicht:

				// Vergleich 2

				Console.WriteLine("\nnull als Bedingung: - ist nicht möglich bei C#");
				//if (null)
				//{
				//	Console.WriteLine("null");
				//}

				// Vergleich 3

				Console.WriteLine("\nWert als Bedingung: - in C# nicht möglich, es werden nur Anweisungen erwartet, die bool zurückgeben");
				//if (myInt1)
				//{
				//	Console.WriteLine("myInt1");
				//}
		}
				
		public static void ZeigeTernärenOperator()
			// Eine weiter möglichkeit einer if abfrage
			// Hier können wir Werte zurückbekommen das geht im einfachen If nicht
		{
			Console.WriteLine(true ? "true" : "false");
			
			string myStr = "heute";
			Console.WriteLine(myStr == "morgen" ? "heute" : "morgen"); // es kann für jeden Datentypen 
		}
		
	}
}
