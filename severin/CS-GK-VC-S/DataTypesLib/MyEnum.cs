using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypesLib
{
	public static class MyEnum
	{
		enum Pizzagrößen
		{
			klein, mittel, groß, family
		}
		public static void ZeigeEnumerator()
		{
			Pizzagrößen pizzagrößen1 = Pizzagrößen.mittel;
			Pizzagrößen pizzagrößen2 = Pizzagrößen.family;
			Console.WriteLine($@"
- Ich habe mir eine {pizzagrößen1}-Pizza genommen.
- Und ich habe mir {pizzagrößen2}-Größe gegönnt");
		}
	}
}
