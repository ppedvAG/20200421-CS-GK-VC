using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Console
{
	class DemoConsole
	{
		static void Main(string[] args)
		{
			#region 1
			Console.WriteLine("\n### WriteLine(String) ###");
			int alter = 35;
			string name = "Severin";
			Console.WriteLine("mein Text für die Konsole");
			Console.WriteLine(alter);
			Console.WriteLine(name);
			#endregion

			Console.WriteLine("\n### WriteLine(String, Objekt(arg)0, Objekt(arg)1) ###");
			Console.WriteLine("Ich heiße {0} und bin {1} Jahre alt", name, alter);

			Console.WriteLine("\n### Write(String) ###");
			Console.Write("Text ohne Zeilenumbruch");

			Console.WriteLine("\n### OutputEncoding ###");
			Console.WriteLine("\nEurozeichen: €");
			Console.OutputEncoding = Encoding.UTF8;
			Console.WriteLine("Eurozeichen: €");
			Console.WriteLine("Geben sie einen Text ein und klicken auf 'Enter':");
			
			Console.WriteLine("\n### ReadLine ###");
			string eingabe = Console.ReadLine();
			Console.WriteLine("Sie haben eingegeben: {0}", eingabe);

			Console.WriteLine("\n### ReadKey ###");
			Console.ReadKey();
		}
	}
}
