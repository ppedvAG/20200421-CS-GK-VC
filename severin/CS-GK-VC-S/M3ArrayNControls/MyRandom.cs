using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3ArrayNControls
{
	class MyRandom // hier wird keine Static verwendet
	{
		public static void ZeigeRandom() // kann für eine TAN liste verwendet werden es wird eine wilkührliche zahl verwendet
		{
			Random random = new Random();
			Console.WriteLine($"Zufallszahl: {random.Next(5)}"); // liefert eine Zufallszahl zwischen 0 und 4 // 5 nicht mehr
		}
	}
}
