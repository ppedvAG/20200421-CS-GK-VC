using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypesLib
{
	public static class MyString
	{
		public static void ZeigeInterpoliertesString()
		{
			string interpolStr = $"DateTime.Now: {DateTime.Now}";
			Console.WriteLine(interpolStr);
		}
		public static void ZeigeEscapes()
		{
			string myStr = "\n nach n, \t nach t"; // \n == Leerzeile \t ist ein Tab
			Console.WriteLine(myStr);
		}
		public static void ZeigeVerbatimString()
		{
			Console.WriteLine("ZeigeVerbatimString");
			string myStr = @"
nach n,		 nach t";
			// Mit @ Zeichen kann die einteilung selbst erstellt werden
			Console.WriteLine(myStr);
		}
		public static void ZeigeInterpoliertesVerbatimString()
		{
			Console.WriteLine("ZeigeInterpoliertesVerbatimString");
			string myStr = $@"
nach n,		{DateTime.Now}	 nach t";
			// Mit @ Zeichen kann die einteilung selbst erstellt werden
			Console.WriteLine(myStr);
		}
	}
} // Null ist default Wert von String
