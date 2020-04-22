using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypesLib
{
	public static class MyInt
	{
		public static void ZeigeLiterals() 
		{
			int myInt1 = -3;
			int myInt2 = 0b_0000_0000_0000_0000_0000_0000_0000_1011; // Binär "0b" muss davor stehen, wird bei der Ausgabe dezimal dargestellt
			Console.WriteLine($"{myInt1}, {myInt2}");
		}
		public static void ZeigeMöglicheWerte() // zeigt den Maximal und Minimal Wert eines Int an
		{
			Console.WriteLine($"int.MaxValue: {int.MaxValue}");
			Console.WriteLine($"int.MinValue: {int.MinValue}");
		}

		public static void ZeigeParsing() // String zu Zahl Convertiert z.B. einen String in einen Int
		{
			string myStr1 = "3";
			string myStr2 = "f";
			// system.Int32
			int myInt1 = int.Parse(myStr1);
			// int myInt2 = int.Parse(myStr2);
			int myInt2; // default-Wert bei int ist 0
			bool istMöglich = int.TryParse(myStr2, out myInt2);
			Console.WriteLine($"myInt1: {myInt1}, istMöglich: {istMöglich}, myInt2: {myInt2}");
		}
		public static void ZeigeCasting() // Zahl von zahl Convertiert z.B. einen double in einen int und schneidet die Kommazahlen weg
		{
			double kommaZahl = 44.32;
			int ganzeZahl = (int)kommaZahl;
			Console.WriteLine($"ganzeZahl: {ganzeZahl}"); // 44
		}
		public static void ZeigeVergleich() // Vergleicht zwei Werte
		{
			Console.WriteLine($"5 >= 3: {5 >= 3}"); // True
		}
	}
}
// 0 ist default Wert von int
