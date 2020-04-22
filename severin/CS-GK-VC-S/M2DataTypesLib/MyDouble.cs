using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypesLib
{
	public static class MyDouble // 64-Bit Gleitkommazahlen Positiv und Negativ
	{
		public static void ZeigeDouble()
		{
			string myDblAsStr1 = "4.22";
			string myDblAsStr2 = "4,22";
			Console.WriteLine($"myDblAsStr1: {myDblAsStr1}, myDblAsStr2: {myDblAsStr2}");
			Console.WriteLine($"double.Parse(myDblAsStr1): {double.Parse(myDblAsStr1)}, double.Parse(myDblAsStr2): {double.Parse(myDblAsStr2)}");
			Console.WriteLine($"double.Parse(myDblAsStr1, InvariantCulture): " +
				$"{double.Parse(myDblAsStr1, System.Globalization.CultureInfo.InvariantCulture)}, " +
				$"double.Parse(myDblAsStr2, InvariantCulture): " +
				$"{double.Parse(myDblAsStr2, System.Globalization.CultureInfo.InvariantCulture)}");
		}
	}
}
//Console.WriteLine($"{}");
// 0 ist default Wert von Double
