using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo_Library;

namespace M5ClassesConsumer
{
	class M5ClassesConsumer
	{
		static void Main(string[] args)
		{
			Detail detail = new Detail(4.2, 6.2);
			Detail.SagHalloStatic();
			detail.SagHallo();
			Console.WriteLine(detail.Breite);
			Console.WriteLine(detail.Höhe);

			Console.ReadKey();
		}
	}
}
