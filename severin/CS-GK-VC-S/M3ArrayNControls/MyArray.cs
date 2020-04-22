using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3ArrayNControls
{
	static class MyArray
	{
		public static void ZeigeArray()
		{
			string[] arrayOfStr = new string[3]; // jede stelle die im Array nicht definiert wird ist mit "Null" vordefiniert
			arrayOfStr[1] = "Tulpe";
			arrayOfStr[2] = "Rosen";
			Console.WriteLine($"arrayOfStr: {arrayOfStr}"); // zeigt nur den Datentyp: System String[]

			// foreach schleife:

			foreach (string item in arrayOfStr)
			{
				//if (item == "")
				//{
				//	Console.WriteLine("Leeres Element");
				//}

				if (item == "") // ist im True Zweig bei If nur eine einzelne Anweisung sind die Geschweiftenklammern optional
					Console.WriteLine("Leeres Element");
				
				Console.WriteLine(item);
			}
		}
		public static void ZeigeDoubleArray()
		{
			double[] arrOfDbl = new double[] { 4.2, 6.3, 5.4 };

			// for-Schleife

			for (int i = 0; i<arrOfDbl.Length; i++)
			{
				Console.WriteLine(arrOfDbl[i]);
			}
		}
	}
}
// Console.WriteLine($"{}");
