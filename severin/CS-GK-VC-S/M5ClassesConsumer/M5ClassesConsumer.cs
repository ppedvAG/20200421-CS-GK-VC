using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M5Classes;

namespace M5ClassesConsumer
{
	class M5ClassesConsumer
	{
		static void Main(string[] args)
		{
			Detail detail = new Detail(4.2, 6.2); // die Variable details wird Deklariert. die Klasse Detail ist eine eigen erstellte komplexer Datentyp
			Detail.SagHalloStatic();
			detail.SagHallo();
			Console.WriteLine(detail.Breite);
			Console.WriteLine(detail.Höhe);
			Console.WriteLine(detail.DefaultEinheit);

			Console.ReadKey();
		}
	}
}
